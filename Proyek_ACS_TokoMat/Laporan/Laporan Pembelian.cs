using System;
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
    public partial class Laporan_Pembelian : Form
    {
        public Laporan_Pembelian()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            cRPembelian nt= new cRPembelian();
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = nt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
