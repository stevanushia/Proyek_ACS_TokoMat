﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyek_ACS_TokoMat.Laporan;

namespace Proyek_ACS_TokoMat.Admin
{
    public partial class Laporan_Penjualan : Form
    {
        public Laporan_Penjualan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cRPenjualan nt = new cRPenjualan();
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = nt;
        }
    }
}
