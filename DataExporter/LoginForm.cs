using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Plibs;

namespace DataExporter
{
    public partial class LoginForm : Form
    {
        //MainForm mf = new MainForm();
        public FormAdmin fa = null;
        Configuration config = ConfigurationManager.OpenExeConfiguration(System.Windows.Forms.Application.ExecutablePath);
        public LoginForm()
        {
            InitializeComponent();
            Shown += new EventHandler(LoginForm_Load);
        }

        public LoginForm(Form dari)
        {
            fa = dari as FormAdmin;
            InitializeComponent();
            Shown += new EventHandler(LoginForm_Load);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            MsSQL.setpar(config.AppSettings.Settings["dbserver"].Value, config.AppSettings.Settings["dbinit"].Value, enc2.DecryptStringAES(config.AppSettings.Settings["dbuser"].Value, "roniGanteng"), enc2.DecryptStringAES(config.AppSettings.Settings["dbpass"].Value, "roniGanteng"));
            MsSQL.setconnection();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //MessageBox.Show( bantu.GetLocalIPAddress());
            //MessageBox.Show(auth.authID);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.AutoSize = true;
            DBConf frm = new DBConf();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_user.Text.Length >= 2 && txt_pass.Text.Length >= 2)
            {
                String kunci = enc.encstr(txt_user.Text + txt_pass.Text);
                String[] hostname = bantu.GetLocalIPAddress();
                String sql = "EXEC LogIn @name = '" + txt_user.Text + "',@pass = '" + kunci.Substring(0, kunci.Length - 5) + "%',@ip = '" +hostname[0]+ "',@hostn = '" + hostname[1] + "'";
                Console.WriteLine(sql);
                DataSet ds = MsSQL.dgsql(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //auth.authID = ds.Tables[0].Rows[0][0].ToString();
                    auth.authID = txt_user.Text;
                    //auth.AuthName = txt_user.Text;
                    auth.LogId = Convert.ToInt32(ds.Tables[1].Rows[0][0].ToString());

                    if (ds.Tables[0].Rows[0][1].ToString() == "1")
                    {       
                        fa.ChangeAdmin();
                        this.Close();
                    }

                    if (ds.Tables[0].Rows[0][1].ToString() == "2")
                    {
                        fa.ChangeUser();
                        this.Close();
                    }
                } else
                {
                    notification.Error("Can Not LogIn", "Wrong Username or PassWord");
                }
            }


        }
    }
}
