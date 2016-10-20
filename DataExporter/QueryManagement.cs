using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Plibs;
using System.Configuration;

namespace DataExporter
{
    public partial class QueryManagement : DockContent
    {
        int urut=1;
        LinkedList<String> linklist = new LinkedList<String>();
        public Configuration config = ConfigurationManager.OpenExeConfiguration(System.Windows.Forms.Application.ExecutablePath);
        public QueryManagement()
        {
            InitializeComponent();
            Shown += new EventHandler(QueryManagement_Load);

        }
        private void QueryManagement_Load(object sender, EventArgs e)
        {
            MsSQL.setpar(config.AppSettings.Settings["dbserver"].Value, config.AppSettings.Settings["dbinit"].Value, enc2.DecryptStringAES(config.AppSettings.Settings["dbuser"].Value, "roniGanteng"), enc2.DecryptStringAES(config.AppSettings.Settings["dbpass"].Value, "roniGanteng"));
            MsSQL.setconnection();
            loadgridquerylist();
        }
        private void loadgridquerylist()
        {
            String sql = "Select title from tQuery";
            DataSet ds = MsSQL.dgsql(sql);

            DataTable dGridTable = ds.Tables[0];
            dgv_querylist.DataSource = dGridTable;
            dgv_querylist.Refresh();
        }

        private void btn_addparam_Click(object sender, EventArgs e)
        {
            addparamflow(cb_paramtype.Text,"","","");
        }

        public void addparamflow(String jenis, String nilai, String label, String nama)
        {
            Label a = new Label()
            {
                Name = "jenis"+urut,
                Size = new System.Drawing.Size(100, 20),
                Text = jenis,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            TextBox b = new TextBox()
            {
                Size = new System.Drawing.Size(160, 26),
                Text = nilai,
                Name = "isi" + urut
            };
            TextBox c = new TextBox()
            {
                Size = new System.Drawing.Size(100, 26),
                Text = nilai,
                Name = "lbl" + urut
            };
            TextBox d = new TextBox()
            {
                Size = new System.Drawing.Size(100, 26),
                Text = nilai,
                Name = "act" + urut
            };
            Button btn = new Button()
            {
                BackColor = System.Drawing.SystemColors.ButtonFace,
                BackgroundImage = global::DataExporter.Properties.Resources.delete,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center,
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                ForeColor = System.Drawing.SystemColors.ButtonFace,
                Name = "btn_delete" + urut,
                Size = new System.Drawing.Size(30, 30)
            };
            btn.Click += new EventHandler(btn_del);
            flowparam.Controls.Add(a);
            flowparam.Controls.Add(b);
            flowparam.Controls.Add(c);
            flowparam.Controls.Add(d);
            flowparam.Controls.Add(btn);
            urut++;

        }        

        private void btn_del(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            String idx = btn.Name.Replace("btn_delete", "");
            ((Label)flowparam.Controls["jenis" + idx]).Dispose();
            ((TextBox)flowparam.Controls["isi" + idx]).Dispose();
            ((TextBox)flowparam.Controls["lbl" + idx]).Dispose();
            ((TextBox)flowparam.Controls["act" + idx]).Dispose();
            ((Button)flowparam.Controls["btn_delete" + idx]).Dispose();
        }

        private void dgv_querylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine(dgv_querylist.SelectedCells[0].Value);
            String sql1 = "SELECT * FROM tQuery where title = '" + dgv_querylist.SelectedCells[0].Value + "'";
            DataSet ds = MsSQL.dgsql(sql1);
            //MessageBox.Show(ds.Tables[0].Rows[0][2].ToString());
            in_query_title.Text = ds.Tables[0].Rows[0][3].ToString();
            in_query.Text = ds.Tables[0].Rows[0][1].ToString();
            if (ds.Tables[0].Rows[0][2].ToString().Equals("True"))
                cb_query.Checked = true;
            else
                cb_query.Checked = false;
            String sql2 = "SELECT * FROM tParameter WHERE parent_id = '" + ds.Tables[0].Rows[0][0].ToString() + "'";
            DataSet ds2 = MsSQL.dgsql(sql2);
            flowparam.Controls.Clear();
            foreach (DataRow row in ds2.Tables[0].Rows)
            {
                addparamflow(row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());                
            }
        }        
    }
}
