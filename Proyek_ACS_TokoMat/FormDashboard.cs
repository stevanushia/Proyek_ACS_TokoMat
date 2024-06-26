﻿using Proyek_ACS_TokoMat.Admin;
using Proyek_ACS_TokoMat.Kasir;
using Proyek_ACS_TokoMat.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_ACS_TokoMat
{
    public partial class FormDashboard : Form
    {
        FormLogin l;
        public FormDashboard(FormLogin l)
        {
            InitializeComponent();
            this.l = l;
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            string displayNama = DB.logged["NAMA"].ToString();
            txtWelcome.Text = "Welcome, " + displayNama;
        }

        private void masterUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master_User f = new Master_User();
            f.ShowDialog();
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void masterStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master_Barang f = new Master_Barang();
            f.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            l.Show();
            this.Close();
        }

        private void masterSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterSuppliers f = new MasterSuppliers();
                f.ShowDialog();
        }

        private void preOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pre_Order f = new Pre_Order();
            f.ShowDialog();
        }

        private void transaksiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTransaksi f = new FormTransaksi();
            f.ShowDialog();
        }
        private void laporanPembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Laporan_Pembelian lp = new Laporan_Pembelian();
            lp.ShowDialog();
        }

        private void laporanPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Laporan_Penjualan lp = new Laporan_Penjualan();
            lp.ShowDialog();
        }
    }
}
