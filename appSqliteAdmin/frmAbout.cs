using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSqliteManagerPro
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            label4.BackColor = Color.Transparent;
        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            string target = linkLabel1.Text;
            System.Diagnostics.Process.Start(target);
        }
    }
}
