﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;

namespace Final_Project_Vispro
{
    public partial class FrmStruk : Form
    {
        public FrmStruk()
        {
            InitializeComponent();
        }

        private void FrmStruk_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = crystalReport22;
            crystalReportViewer1.Refresh();

        }
    }
}
