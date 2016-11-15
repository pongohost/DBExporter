using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Plibs;
using ClosedXML.Excel;
using DotLiquid;
using WeifenLuo.WinFormsUI.Docking;
using MetroFramework.Controls;

namespace DataExporter
{
    public partial class DataExport : DockContent
    {
        public Configuration config = ConfigurationManager.OpenExeConfiguration(System.Windows.Forms.Application.ExecutablePath);
        String namaModul = "Data Export";
        String[] nett = bantu.GetLocalIPAddress();
        String mainsql="";
        DataTable dTable,dGridTable;
        public DataExport()
        {
            InitializeComponent();           
            Shown +=new EventHandler(MainForm_Load);
        }

        private void MainForm_Load(object sender, EventArgs e)
        { 
            MsSQL.setpar(config.AppSettings.Settings["dbserver"].Value, config.AppSettings.Settings["dbinit"].Value, enc2.DecryptStringAES(config.AppSettings.Settings["dbuser"].Value, "roniGanteng"), enc2.DecryptStringAES(config.AppSettings.Settings["dbpass"].Value, "roniGanteng"));
            MsSQL.setconnection();
            loadcomboquery();
        }

        private void dBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDBconf(this);
        }

        private void showLogin(Form parent)
        {
            LoginForm frm = new LoginForm();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void showDBconf(Form parent)
        {
            DBConf frm = new DBConf();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loadcomboquery();
        }

        private void loadcomboquery()
        {
            String sql = "EXEC getListQuery '"+auth.authID+"'";
            DataSet ds = MsSQL.dgsql(sql);
            bantu.addComboItem(cb_query2, ds);
        }
                
        private void cb_query_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clearlayout();
            String sql = "SELECT jenis,label,nilai,nama from tParameter where parent_id = '" + cb_query2.SelectedValue.ToString()+"'";
            DataSet ds = MsSQL.dgsql(sql);
            int lbl = 0;
            dTable = ds.Tables[0];
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    MetroLabel a = new MetroLabel();
                    //Label a = new Label();
                    //a = new Label();
                    a.Name = "label" + lbl;
                    a.Text = row[1].ToString() + " :";
                    a.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    a.Size = new System.Drawing.Size(130, 20);
                    flow_holder.Controls.Add(a);
                    if (row[0].ToString() == "TextBox")
                    {
                        MetroTextBox b = new MetroTextBox();
                        //TextBox b = new TextBox();
                        b.Name = row[3].ToString();
                        b.Size = new System.Drawing.Size(240, 26);
                        flow_holder.Controls.Add(b);
                    }
                    if (row[0].ToString() == "DropDown")
                    {
                        MetroComboBox b = new MetroComboBox();
                        //ComboBox b = new ComboBox();
                        b.Name = row[3].ToString();
                        b.Size = new System.Drawing.Size(240, 26);
                        b.DropDownHeight = 250;
                        String sqlcb = row[2].ToString();
                        if (sqlcb.Contains("sql="))
                        {
                            sqlcb = sqlcb.Replace("sql=", "");
                            DataSet ds2 = MsSQL.dgsql(sqlcb);
                            bantu.addComboItem(b, ds2);
                        }
                        else if (sqlcb.Contains("list="))
                        {
                            sqlcb = sqlcb.Replace("list=", "");
                            String[] isi = sqlcb.Split('|');
                            for (int i = 0; i < isi.Length; i++)
                            {
                                b.Items.Add(isi[i]);
                            }
                        }
                        flow_holder.Controls.Add(b);
                    }
                    lbl++;
                }
            }

        }

        private void clearlayout()
        {
            if (dTable != null)
            {
                int i = 0;
                foreach (DataRow row in dTable.Rows)
                {
                    if (row[0].ToString() == "TextBox")
                    {
                        ((MetroTextBox)flow_holder.Controls[row[3].ToString()]).Dispose();
                    }
                    if (row[0].ToString() == "DropDown")
                    {
                        ((MetroComboBox)flow_holder.Controls[row[3].ToString()]).Dispose();
                    }
                    ((MetroLabel)flow_holder.Controls["label" + i]).Dispose(); 
                    i++;
                }
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            string s="";
            Dictionary<string, string> filter = new Dictionary<string, string>();
            foreach (DataRow row in dTable.Rows)
            {
                if (row[0].ToString() == "TextBox")
                {
                    s = ((MetroTextBox)flow_holder.Controls[row[3].ToString()]).Text;
                }
                if (row[0].ToString() == "DropDown")
                {
                    s = ((MetroComboBox)flow_holder.Controls[row[3].ToString()]).Text;
                }
                filter.Add(row[3].ToString(), s);
                //Console.WriteLine(s);
            }
            String sql = "SELECT query from tQuery where id = '" + cb_query2.SelectedValue.ToString() + "'";
            DataSet ds = MsSQL.dgsql(sql);
            MsSQL.insertLog(auth.authID, namaModul, "Load Report = '" + cb_query2.Text + "' Query = " + sql, nett[0], nett[1], auth.LogId);
            //Console.WriteLine(ds.Tables[0].Rows[0][0].ToString());
            Template template = Template.Parse(ds.Tables[0].Rows[0][0].ToString());
            Dictionary<string, object> filterdict = filter.ToDictionary(kvp => kvp.Key, kvp => (object)kvp.Value);
            String sqlready = template.Render(Hash.FromDictionary(filterdict));
            DataSet ds2 = MsSQL.dgsql(sqlready);

            dGridTable = ds2.Tables[0];
            gv_data.DataSource = dGridTable;
            gv_data.Refresh();
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            //var path = System.Windows.Forms.Application.ExecutablePath + "HelloWorld.xlsx";
            MsSQL.insertLog(auth.authID, namaModul, "Export Excel = '" + cb_query2.Text + "' ", nett[0], nett[1], auth.LogId);
            String filePath = saveFileDialog.FileName;
            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(dGridTable);
            wb.SaveAs(filePath);
        }

    }
}
