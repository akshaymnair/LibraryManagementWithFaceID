﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class issued : Form
    {
        public issued()
        {
            InitializeComponent();
        }

        private void issued_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uckLibMgrDataSet2.Issues' table. You can move, or remove it, as needed.
            this.issuesTableAdapter.Fill(this.uckLibMgrDataSet2.Issues);

        }
    }
}
