﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintCheckInCheckOut
{
    public partial class License : Form
    {
        public License()
        {
            InitializeComponent();
        }

        private void License_Load(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                this.Dispose();

                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
