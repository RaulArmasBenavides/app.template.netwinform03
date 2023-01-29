﻿using admSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAdo03.View
{
    public partial class MDImenu : Form
    {
        public MDImenu()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoView p = new ProductoView();
            p.MdiParent = this;
            p.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textSharpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prim p = new Prim();
            p.MdiParent = this;
            p.Show();
        }
    }
}
