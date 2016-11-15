using System;
using System.Windows.Forms;
using System.Configuration;
using Plibs;

namespace DataExporter
{
    public partial class DBConf : Form
    {
        DataExport mf = new DataExport();
        
        public DBConf()
        {
            InitializeComponent();
            Load += new EventHandler(load_dbconf);
        }

        private void load_dbconf(object sender, EventArgs e)
        {
            in_setdbserver.Text = mf.config.AppSettings.Settings["dbserver"].Value;
            in_setdbport.Text = mf.config.AppSettings.Settings["dbport"].Value;
            in_setdb.Text = mf.config.AppSettings.Settings["dbinit"].Value;
            in_setdbuser.Text = enc2.DecryptStringAES(mf.config.AppSettings.Settings["dbuser"].Value, "roniGanteng");
            in_setdbpass.Text = enc2.DecryptStringAES(mf.config.AppSettings.Settings["dbpass"].Value, "roniGanteng");
        }
        private void btn_setdbsave_Click(object sender, EventArgs e)
        {
            mf.config.AppSettings.Settings["dbserver"].Value = in_setdbserver.Text.ToString();
            mf.config.AppSettings.Settings["dbinit"].Value = in_setdb.Text.ToString();
            mf.config.AppSettings.Settings["dbport"].Value = in_setdbport.Text.ToString();
            mf.config.AppSettings.Settings["dbuser"].Value = enc2.EncryptStringAES(in_setdbuser.Text.ToString(), "roniGanteng");
            mf.config.AppSettings.Settings["dbpass"].Value = enc2.EncryptStringAES(in_setdbpass.Text.ToString(), "roniGanteng");
            mf.config.Save(ConfigurationSaveMode.Modified);
            MessageBox.Show(this, "Configuration Saved", "Save Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_sqltest_Click(object sender, EventArgs e)
        {
            MsSQL.tescon(in_setdbserver.Text, in_setdb.Text, in_setdbuser.Text, in_setdbpass.Text);
        }
    }
}
