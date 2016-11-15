using System;
using System.Data;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Plibs;
using System.Configuration;

namespace DataExporter
{    
    public partial class UserManagement : DockContent
    {
        int urut = 1;
        String[] listParam = new String[20];
        public Configuration config = ConfigurationManager.OpenExeConfiguration(System.Windows.Forms.Application.ExecutablePath);
        String namaModul = "User Management";
        String[] nett = bantu.GetLocalIPAddress();
        public UserManagement()
        {
            InitializeComponent();
            Shown += new EventHandler(UserManagement_Load);
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            MsSQL.setpar(config.AppSettings.Settings["dbserver"].Value, config.AppSettings.Settings["dbinit"].Value, enc2.DecryptStringAES(config.AppSettings.Settings["dbuser"].Value, "roniGanteng"), enc2.DecryptStringAES(config.AppSettings.Settings["dbpass"].Value, "roniGanteng"));
            MsSQL.setconnection();
            loadgridUserlist();

            String sql = "Select name from tGroup where tipe =2";
            DataSet ds = MsSQL.dgsql(sql);

            DataTable dGridTable = ds.Tables[0];
            dgv_permission.DataSource = dGridTable;
            dgv_permission.Refresh();

            //addUserTitle();
        }

        private void loadgridUserlist()
        {
            String sql = "Select username from tUser where isActive = 1";
            DataSet ds = MsSQL.dgsql(sql);

            DataTable dGridTable = ds.Tables[0];
            dgv_user.DataSource = dGridTable;
            dgv_user.Refresh();
        }

        private void dgv_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            in_user_name.Text = dgv_user.SelectedCells[0].Value.ToString();
            in_user_name.Enabled = false;
            in_user_pass.Text = "";
            String sql2 = "SELECT \"group\" FROM tUserGroup WHERE username = '" + dgv_user.SelectedCells[0].Value.ToString() + "'";
            DataSet ds2 = MsSQL.dgsql(sql2);
            flow_user.Controls.Clear();
            bantu.clrSingleEmptyArray(listParam);
            addUserTitle();
            foreach (DataRow row in ds2.Tables[0].Rows)
            {
                addUserflow(row[0].ToString());
            }
        }

        private void addUserTitle()
        {
            Label a = new Label()
            {
                BackColor = System.Drawing.SystemColors.ButtonShadow,
                Margin = new System.Windows.Forms.Padding(0),
                Name = "titelnama",
                Size = new System.Drawing.Size(295, 30),
                Text = "Permission",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            };
            Label b = new Label()
            {
                BackColor = System.Drawing.SystemColors.ButtonShadow,
                Margin = new System.Windows.Forms.Padding(0),
                Name = "titelnama",
                Size = new System.Drawing.Size(35, 30),
                Text = "Act",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            };
            flow_user.Controls.Add(a);
            flow_user.Controls.Add(b);
        }

        public void addUserflow(String nilai)
        {
            if (bantu.addSingleEmptyArray(listParam, nilai, "Input Gagal", "Data Sudah Ada") == true)
            {
                Label a = new Label()
                {
                    Margin = new System.Windows.Forms.Padding(0),
                    Name = "jenis" + urut,
                    Size = new System.Drawing.Size(290, 20),
                    Text = nilai,
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                };
                Button btn = new Button()
                {
                    BackColor = System.Drawing.SystemColors.ButtonFace,
                    BackgroundImage = global::DataExporter.Properties.Resources.delete,
                    BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                    ForeColor = System.Drawing.SystemColors.ButtonFace,
                    Margin = new System.Windows.Forms.Padding(0),
                    Name = "btn_delete" + urut,
                    Size = new System.Drawing.Size(35, 30)
                };
                btn.Click += new EventHandler(btn_del);
                flow_user.Controls.Add(a);
                flow_user.Controls.Add(btn);
                urut++;
            }
        }

        private void btn_del(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            String idx = btn.Name.Replace("btn_delete", "");
            String isi = ((Label)flow_user.Controls["jenis" + idx]).Text;
            ((Label)flow_user.Controls["jenis" + idx]).Dispose();
            ((Button)flow_user.Controls["btn_delete" + idx]).Dispose();
            bantu.delSingleEmptyArray(listParam, isi, "Hapus Gagal", "Data Tidak Ditemukan");
        }

        private void dgv_permission_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addUserflow(dgv_permission.SelectedCells[0].Value.ToString());
        }

        private void btn_user_save_Click(object sender, EventArgs e)
        {
            String newparam = "";
            Boolean separator = false;
            for (int i = 0; i < listParam.Length; i++)
            {
                if (listParam[i] != null)
                {
                    if (separator == true)
                        newparam = "|" + newparam;
                    newparam = listParam[i] + newparam;
                    separator = true;
                }
            }
            String kunci;
            if (in_user_pass.Text.Length > 0)
            {
                kunci = enc.encstr(in_user_name.Text + in_user_pass.Text);
            } else
            {
                kunci = "";
            }            
            String sql = "EXEC insertUser @name = '" + in_user_name.Text + "', @pass = '" + kunci + "', @perm = '" + newparam + "'";
            Console.WriteLine(sql);
            MsSQL.kuerisql(sql, "Simpan Permission", "Simpan Data Berhasil");
            MsSQL.insertLog(auth.authID, namaModul, "Menyimpan data SQL = " + sql, nett[0], nett[1], auth.LogId);
            loadgridUserlist();
        }

        private void btn_usr_clear_Click(object sender, EventArgs e)
        {
            in_user_name.Text = "";
            in_user_name.Enabled = true;
            in_user_pass.Text = "";
            flow_user.Controls.Clear();
            addUserTitle();
            bantu.clrSingleEmptyArray(listParam);
        }

        private void btn_usr_del_Click(object sender, EventArgs e)
        {
            if (in_user_name.Text.Length > 0)
            {
                String sql = "DELETE from tUser WHERE username = '" + in_user_name.Text + "'";
                MsSQL.kuerisql(sql, "Hapus User", "Hapus User Berhasil");
                MsSQL.insertLog(auth.authID, namaModul, "Menghapus data SQL = " + sql, nett[0], nett[1], auth.LogId);
                loadgridUserlist();
            }
        }
    }
}
