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
    public partial class FormAdmin : Form
    {        
        public FormAdmin()
        {
            InitializeComponent();
            nav_menu navmenu = new nav_menu(this);
            navmenu.Show(dockPanel1, DockState.DockLeftAutoHide);
        }
    }
}
