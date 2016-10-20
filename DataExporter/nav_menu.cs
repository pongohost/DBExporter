using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
