using System;
using System.Data;
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
            initDBConn();
        }

        private void initDBConn()
        {
            MsSQL.setpar(config.AppSettings.Settings["dbserver"].Value, config.AppSettings.Settings["dbinit"].Value, enc2.DecryptStringAES(config.AppSettings.Settings["dbuser"].Value, "roniGanteng"), enc2.DecryptStringAES(config.AppSettings.Settings["dbpass"].Value, "roniGanteng"), config.AppSettings.Settings["dbport"].Value);
            MsSQL.setconnection();            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                //initDBConn();
                String kunci = enc.encstr(txt_user.Text + txt_pass.Text);
                String[] hostname = bantu.GetLocalIPAddress();
                String sql = "EXEC LogIn @name = '" + txt_user.Text + "',@pass = '" + kunci.Substring(0, kunci.Length - 5) + "%',@ip = '" +hostname[0]+ "',@hostn = '" + hostname[1] + "'";
                Console.WriteLine(sql);
                DataSet ds = MsSQL.dgsql(sql);
                if (bantu.cekError(ds))
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    { 
                        auth.authID = txt_user.Text;
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
                    }
                    else
                    {
                        notification.Error("Can Not LogIn", "Wrong Username or PassWord");
                    }
                }
            }


        }        
    }
}
