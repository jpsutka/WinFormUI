using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class WinFormsUI : Form
    {
        public WinFormsUI()
        {
            InitializeComponent();
        }

        bool sidebarExpanded = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                sidebar.Width -= 15;
                if (sidebar.Width <= 70) 
                { 
                    sidebarExpanded = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 15;
                if (sidebar.Width >= 211)
                {
                    sidebarExpanded = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
    }
}
