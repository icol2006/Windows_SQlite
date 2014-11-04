#region Copyright & License Information
﻿/*
 * Copyright 2014 Maykol Alvarado P
 * This file is part of windows sqlite which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation. For more information,
 * see COPYING.
 */
﻿#endregion

﻿using System;
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
