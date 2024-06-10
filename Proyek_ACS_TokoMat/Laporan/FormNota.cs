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

namespace Proyek_ACS_TokoMat.Laporan
{
    public partial class FormNota : Form
    {
        int idn;
        public FormNota(int id)
        {
            InitializeComponent();
            idn = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrystalReport1 nt = new CrystalReport1();
            nt.SetParameterValue("Invoice", idn);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = nt;
        }
    }
}
