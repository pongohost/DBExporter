using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plibs;
using WeifenLuo.WinFormsUI.Docking;

namespace DataExporter
{
    public partial class roleForm : DockContent
    {
        public Configuration config = ConfigurationManager.OpenExeConfiguration(System.Windows.Forms.Application.ExecutablePath);
        int urut = 1;
        String[] listParam = new String[20];
        public roleForm()
        {
            InitializeComponent();
        }

        private void roleForm_Load(object sender, EventArgs e)
        {
            MsSQL.setpar(config.AppSettings.Settings["dbserver"].Value, config.AppSettings.Settings["dbinit"].Value, enc2.DecryptStringAES(config.AppSettings.Settings["dbuser"].Value, "roniGanteng"), enc2.DecryptStringAES(config.AppSettings.Settings["dbpass"].Value, "roniGanteng"));
            MsSQL.setconnection();
            loadgridquerylist();
        }
        private void loadgridquerylist()
        {
            String sql = "Select name from tGroup";
            DataSet ds = MsSQL.dgsql(sql);

            DataTable dGridTable = ds.Tables[0];
            dgv_role.DataSource = dGridTable;
            dgv_role.Refresh();

            String sql2 = "Select title from tQuery";
            DataSet ds2 = MsSQL.dgsql(sql2);

            DataTable dGridTable2 = ds2.Tables[0];
            dgv_gQuery.DataSource = dGridTable2;
            dgv_gQuery.Refresh();
        }

        private void dgv_querylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine(dgv_querylist.SelectedCells[0].Value);
            String sql1 = "SELECT * FROM tGroup where name = '" + dgv_role.SelectedCells[0].Value + "'";
            DataSet ds = MsSQL.dgsql(sql1);
            //MessageBox.Show(ds.Tables[0].Rows[0][2].ToString());
            in_groupname.Text = ds.Tables[0].Rows[0][1].ToString();
            in_groupnote.Text = ds.Tables[0].Rows[0][2].ToString();
            if (ds.Tables[0].Rows[0][4].ToString().Equals("True"))
                cb_group.Checked = true;
            else
                cb_group.Checked = false;
            String sql2 = "SELECT modul FROM tPermission WHERE \"group\" = '" + ds.Tables[0].Rows[0][1].ToString() + "'";
            DataSet ds2 = MsSQL.dgsql(sql2);
            flowgroup.Controls.Clear();
            addPermTitle();
            foreach (DataRow row in ds2.Tables[0].Rows)
            {
                addPermList(row[0].ToString());
            }
        } 
        
        private void dgv_gQuery_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addPermList(dgv_gQuery.SelectedCells[0].Value.ToString());
        }

        private void addPermList(String item)
        {
            listParam[urut] = item;
            Label a = new Label()
            {
                Margin = new System.Windows.Forms.Padding(0),
                Name = "item"+urut,
                Size = new System.Drawing.Size(190, 30),
                Text = item,
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
            };
            Button btn = new Button()
            {
                BackColor = System.Drawing.SystemColors.ButtonFace,
                BackgroundImage = global::DataExporter.Properties.Resources.delete,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center,
                Margin = new System.Windows.Forms.Padding(0),
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                ForeColor = System.Drawing.SystemColors.ButtonFace,
                Name = "btn_delete" + urut,
                Size = new System.Drawing.Size(100, 30)
            };
            btn.Click += new EventHandler(btn_del);
            flowgroup.Controls.Add(a);
            flowgroup.Controls.Add(btn);
            urut++;
        }

        private void btn_del(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            String idx = btn.Name.Replace("btn_delete", "");
            ((Label)flowgroup.Controls["item" + idx]).Dispose();
            ((Button)flowgroup.Controls["btn_delete" + idx]).Dispose();
        }

        private void addPermTitle()
        {
            Label a = new Label()
            {
                BackColor = System.Drawing.SystemColors.ButtonShadow,
                Margin = new System.Windows.Forms.Padding(0),
                Name = "titelnama",
                Size = new System.Drawing.Size(190, 30),
                Text = "Modul Name",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            };
            Label b = new Label()
            {
                BackColor = System.Drawing.SystemColors.ButtonShadow,
                Margin = new System.Windows.Forms.Padding(0),
                Name = "titelaction",
                Size = new System.Drawing.Size(100, 30),
                Text = "Action",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            };
            flowgroup.Controls.Add(a);
            flowgroup.Controls.Add(b);
        }

    }
}
