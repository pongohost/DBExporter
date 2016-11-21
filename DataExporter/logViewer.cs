using System;
using System.Configuration;
using WeifenLuo.WinFormsUI.Docking;
using Plibs;
using System.Data;

namespace DataExporter
{
    public partial class logViewer : DockContent
    {
        public Configuration config = ConfigurationManager.OpenExeConfiguration(System.Windows.Forms.Application.ExecutablePath);
        String namaModul = "Log Viewer";
        String[] nett = bantu.GetLocalIPAddress();
        //ObjectListView ListView;
        public logViewer()
        {
            InitializeComponent();
        }

        public void logViewer_load(object sender, EventArgs e)
        {
            cb_limit.SelectedIndex = 0;
            //MsSQL.setpar(config.AppSettings.Settings["dbserver"].Value, config.AppSettings.Settings["dbinit"].Value, enc2.DecryptStringAES(config.AppSettings.Settings["dbuser"].Value, "roniGanteng"), enc2.DecryptStringAES(config.AppSettings.Settings["dbpass"].Value, "roniGanteng"));
            //MsSQL.setconnection();
            loadgridLoglist("",1,cb_limit.SelectedItem.ToString());
        }

        private void loadgridLoglist(String cari,int bawah=0, String atas="0")
        {
            //String sql = "SELECT [Date] as Date,[identity],Modul,Message,ip,hostname from appLog";
            if (atas.Equals("All"))
            {
                bawah = 0;
                atas = "1";
            }
            int atasint = int.Parse(atas);
            String sql = "EXEC SearchDB '%"+cari+ "%',dbo, appLog,'[Date],[identity],ip,hostname,Message'," + bawah+","+atas;
            DataSet ds = MsSQL.dgsql(sql);
            MsSQL.insertLog(auth.authID, namaModul, "Mencari Log = " + sql, nett[0], nett[1], auth.LogId);

            if (ds.Tables[0].Rows.Count > 0)
            {
                this.dgv_log.DataSource = ds;
                this.dgv_log.DataMember = "Table";
                this.dgv_log.Columns[ds.Tables[0].Columns.Count - 1].Visible = false;
                this.dgv_log.Columns[ds.Tables[0].Columns.Count - 2].Visible = false;
                this.dgv_log.Columns[ds.Tables[0].Columns.Count - 3].Visible = false;
                this.dgv_log.Refresh();

                txt_total.Text = ds.Tables[0].Rows[0][ds.Tables[0].Columns.Count - 2].ToString();
                txt_now.Text = ds.Tables[0].Rows[0][ds.Tables[0].Columns.Count - 1].ToString();
            } else
            {
                this.dgv_log.DataSource = null;
                this.dgv_log.Refresh();
                txt_total.Text = "0";
                txt_now.Text = "0";
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            loadgridLoglist(txt_search.Text, 1, cb_limit.SelectedItem.ToString());
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            loadgridLoglist(txt_search.Text, 1, cb_limit.SelectedItem.ToString());
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (int.Parse(txt_now.Text.ToString()) < int.Parse(txt_total.Text.ToString()))
            {
                int next = int.Parse(txt_now.Text.ToString()) * int.Parse(cb_limit.SelectedItem.ToString());
                int nextEnd = next + int.Parse(cb_limit.SelectedItem.ToString());
                loadgridLoglist(txt_search.Text, next + 1, nextEnd.ToString());
            }
            
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (int.Parse(txt_now.Text.ToString()) > 1)
            {
                int Prev = (int.Parse(txt_now.Text.ToString()) - 2) * int.Parse(cb_limit.SelectedItem.ToString());
                if (Prev <= 0)
                    Prev = 1;
                int PrevEnd = Prev + int.Parse(cb_limit.SelectedItem.ToString());
                loadgridLoglist(txt_search.Text, Prev, PrevEnd.ToString());
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            int last = (int.Parse(txt_total.Text.ToString())-1) * int.Parse(cb_limit.SelectedItem.ToString());
            int lastEnd = last + int.Parse(cb_limit.SelectedItem.ToString());
            loadgridLoglist(txt_search.Text, last, lastEnd.ToString());
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            loadgridLoglist(txt_search.Text, 1, cb_limit.SelectedItem.ToString());
        }

       
    }
}
