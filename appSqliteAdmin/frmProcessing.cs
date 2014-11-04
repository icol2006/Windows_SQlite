using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSqliteAdmin
{
    public partial class frmProcessing : Form
    {
        public frmProcessing()
        {
            InitializeComponent();
            
        }

        private void frmProcessing_FormClosing(object sender, FormClosingEventArgs e)
        {
            

       /*    DialogResult dr = MessageBox.Show("Do you want close the process", "Title", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                
            }*/ 
        }


    }
}
