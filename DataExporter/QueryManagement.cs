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
        String[] listParam = new String[20];
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
            addParamTitle();
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

        private void addParamTitle()
        {
            Label a = new Label()
            {
                BackColor = System.Drawing.SystemColors.ButtonShadow,
                Margin = new System.Windows.Forms.Padding(0),
                Name = "titelnama",
                Size = new System.Drawing.Size(110, 30),
                Text = "Type",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            };
            Label b = new Label()
            {
                BackColor = System.Drawing.SystemColors.ButtonShadow,
                Margin = new System.Windows.Forms.Padding(0),
                Name = "titelnama",
                Size = new System.Drawing.Size(160, 30),
                Text = "Initial Value",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            };
            Label c = new Label()
            {
                BackColor = System.Drawing.SystemColors.ButtonShadow,
                Margin = new System.Windows.Forms.Padding(0),
                Name = "titelnama",
                Size = new System.Drawing.Size(115, 30),
                Text = "Label",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            };
            Label d = new Label()
            {
                BackColor = System.Drawing.SystemColors.ButtonShadow,
                Margin = new System.Windows.Forms.Padding(0),
                Name = "titelnama",
                Size = new System.Drawing.Size(115, 30),
                Text = "Param Name",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            };
            Label e = new Label()
            {
                BackColor = System.Drawing.SystemColors.ButtonShadow,
                Margin = new System.Windows.Forms.Padding(0),
                Name = "titelnama",
                Size = new System.Drawing.Size(33, 30),
                Text = "Act",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            };
            flowparam.Controls.Add(a);
            flowparam.Controls.Add(b);
            flowparam.Controls.Add(c);
            flowparam.Controls.Add(d);
            flowparam.Controls.Add(e);
        }

        public void addparamflow(String jenis, String nilai, String label, String nama)
        {
            bantu.addSingleEmptyArray(listParam, urut.ToString(), "Input Gagal", "Data Sudah Ada");
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
                Text = label,
                Name = "lbl" + urut
            };
            TextBox d = new TextBox()
            {
                Size = new System.Drawing.Size(100, 26),
                Text = nama,
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
            bantu.delSingleEmptyArray(listParam, idx, "Hapus Gagal", "Data Tidak Ditemukan");
        }

        private void dgv_querylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine(dgv_querylist.SelectedCells[0].Value);
            String sql1 = "SELECT * FROM tQuery where title = '" + dgv_querylist.SelectedCells[0].Value + "'";
            DataSet ds = MsSQL.dgsql(sql1);
            //MessageBox.Show(ds.Tables[0].Rows[0][2].ToString());
            in_query_title.Text = ds.Tables[0].Rows[0][3].ToString();
            in_query.Text = ds.Tables[0].Rows[0][1].ToString();
            query_id.Text = ds.Tables[0].Rows[0][0].ToString();
            if (ds.Tables[0].Rows[0][2].ToString().Equals("True"))
                cb_query.Checked = true;
            else
                cb_query.Checked = false;
            String sql2 = "SELECT * FROM tParameter WHERE parent_id = '" + ds.Tables[0].Rows[0][0].ToString() + "'";
            DataSet ds2 = MsSQL.dgsql(sql2);
            flowparam.Controls.Clear();
            bantu.clrSingleEmptyArray(listParam);
            addParamTitle();
            foreach (DataRow row in ds2.Tables[0].Rows)
            {
                addparamflow(row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());                
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String newparam = "";
            Boolean separator = false;
            for (int i = 0; i < listParam.Length; i++)
            {
                if (listParam[i] != null)
                {
                    String isi = "";
                    if (separator == true)
                        newparam = "{|" + newparam;
                    
                    isi = ((Label)flowparam.Controls["jenis" + listParam[i]]).Text.ToString();
                    isi = isi + "|}"+((TextBox)flowparam.Controls["isi" + listParam[i]]).Text.ToString();
                    isi = isi + "|}" + ((TextBox)flowparam.Controls["lbl" + listParam[i]]).Text.ToString();
                    isi = isi + "|}" + ((TextBox)flowparam.Controls["act" + listParam[i]]).Text.ToString();

                    newparam = isi + newparam;
                    separator = true;
                }
            }
            //MessageBox.Show(cb_group.Checked);
            String idx = "";
            if (query_id.Text != "id")
                idx = ", @id =" + query_id.Text;
            //Console.WriteLine("EXEC insertQuery @query = '" + in_query.Text + "', @aktif = " + cb_query.Checked + ", @titel = '" + in_query_title.Text + "', @param = '" + newparam + "'" + idx);
            MsSQL.kuerisql("EXEC insertQuery @query = '" + in_query.Text + "', @aktif = " + cb_query.Checked + ", @titel = '" + in_query_title.Text + "', @param = '" + newparam + "'" + idx, "Simpan Permission", "Simpan Data Berhasil");
            loadgridquerylist();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            in_query_title.Text = "";
            in_query.Text = "";
            query_id.Text = "id";
            flowparam.Controls.Clear();
            bantu.clrSingleEmptyArray(listParam);
            addParamTitle();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (query_id.Text != "id")
            {
                MsSQL.kuerisql("DELETE from tQuery WHERE id = '" + query_id.Text + "'", "Hapus Group", "Hapus Data Berhasil");
                loadgridquerylist();
            }
        }
    }
}
