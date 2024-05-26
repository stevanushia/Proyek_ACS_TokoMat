﻿using Proyek_ACS_TokoMat.Admin;
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
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            string displayNama = DB.logged["NAMA"].ToString();
            txtWelcome.Text = "Welcome, " + displayNama;
        }

        private void masterUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master_User f = new Master_User();
            f.Show();
        }
    }
}