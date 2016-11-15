using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace DataExporter
{
    public partial class nav_menu : DockContent
    {
        public FormAdmin mf = null;
        public nav_menu()
        {
            InitializeComponent();
        }

       
        public void menuAdmin()
        {
            fl_nav.Controls.SetChildIndex(btn_out, 0);
            fl_nav.Controls.SetChildIndex(btn_export, 0);
            fl_nav.Controls.SetChildIndex(btn_log, 0);
            fl_nav.Controls.SetChildIndex(btn_role, 0);
            fl_nav.Controls.SetChildIndex(btn_user, 0);
            fl_nav.Controls.SetChildIndex(btn_query, 0);
            btn_query.Visible = true;
            btn_role.Visible = true;
            btn_user.Visible = true;
            btn_log.Visible = true;
            btn_export.Visible = true;
        }

        public void menuUser()
        {
            fl_nav.Controls.SetChildIndex(btn_export, 0);
            fl_nav.Controls.SetChildIndex(btn_out, 1);
            btn_query.Visible = false;
            btn_role.Visible = false;
            btn_user.Visible = false;
            btn_log.Visible = false;
            btn_export.Visible = true;
        }


        public void form_onShow(object sender, EventArgs e)
        {
            Console.WriteLine("hadir");
        }
        public nav_menu(Form dari)
        {
            mf = dari as FormAdmin;
            InitializeComponent();
        }

       
        private void btn_query_Click(object sender, EventArgs e)
        {
            QueryManagement qm = new QueryManagement();
            qm.Show(this.mf.dockPanel1);
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            UserManagement um = new UserManagement();
            um.Show(this.mf.dockPanel1);
        }

        private void btn_role_Click(object sender, EventArgs e)
        {
            roleForm um = new roleForm();
            um.Show(this.mf.dockPanel1);
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            logViewer um = new logViewer();
            um.Show(this.mf.dockPanel1);
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            mf.ClearDock();
            mf.ShowLogIn();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DataExport um = new DataExport();
            um.Show(this.mf.dockPanel1);
        }
    }
}
