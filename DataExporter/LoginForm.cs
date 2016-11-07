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
        MainForm mf = new MainForm();
        Configuration config = ConfigurationManager.OpenExeConfiguration(System.Windows.Forms.Application.ExecutablePath);
        public LoginForm()
        {
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
                //String sql = "select a.[group],b.tipe from tUser as a INNER JOIN tGroup as b on a.username = '" + txt_user.Text + "' AND a.password like '" + kunci.Substring(0, kunci.Length - 5) + "%' and a.[group] = b.name";
                String sql = "SELECT c.name,c.tipe from tUser as a INNER JOIN tUserGroup as b ON a.username = b.username AND a.username = '" + txt_user.Text + "' AND a.password like '" + kunci.Substring(0, kunci.Length - 5) + "%' INNER JOIN tGroup as c ON b.[group] = c.name;Select @@ROWCOUNT";
                //Console.WriteLine(sql);
                DataSet ds = MsSQL.dgsql(sql);
                if (ds.Tables[0].Rows[0][1].ToString() == "1")
                {
                    auth.authID = ds.Tables[0].Rows[0][0].ToString();
                    FormAdmin fr = new FormAdmin();
                    this.Hide();
                    fr.ShowDialog();
                    this.Close();
                }

                if (ds.Tables[0].Rows[0][1].ToString() == "1")
                {
                    MainForm fr = new MainForm();
                    this.Hide();
                    fr.ShowDialog();
                    this.Close();
                }
            }


        }
    }
}
