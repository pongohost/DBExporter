
using System;
using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace DataExporter
{
    public partial class FormAdmin : Form
    {

        nav_menu navmenu = null;
        LoginForm fr = null;
        public FormAdmin()
        {
            InitializeComponent();
            //nav_menu navmenu = new nav_menu(this);
            fr = new LoginForm(this);
            navmenu = new nav_menu(this);
            navmenu.Show(dockPanel1, DockState.DockLeftAutoHide);
        }

        public void ChangeAdmin()
        {
            navmenu.menuAdmin();
        }

        public void ChangeUser()
        {
            navmenu.menuUser();
        }

        public void form_on_Load(object sender, EventArgs e)
        {            
            fr.ShowDialog();
        }        

        public void ShowLogIn()
        {
            fr.StartPosition = FormStartPosition.CenterScreen;            
            fr.ShowDialog();
        }

        public void ClearDock()
        {
            for(int i= dockPanel1.Contents.Count - 1; i>0 ; i--)
            {
                if (!dockPanel1.Contents[i].DockHandler.TabText.Equals("MENU"))
                    dockPanel1.Contents[i].DockHandler.Close();
            }
        }
    }
}
