using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_ACS_TokoMat.User
{
    public partial class Pembelian_Barang : Form
    {
        public Pembelian_Barang()
        {
            InitializeComponent();
        }

        public void setBarang(string id)
        {
            this.txtKodeBarang.Text = id;
            this.txtNama.Text = DB.getScalar($"SELECT NAMA FROM BARANG WHERE ID = '{id}'");
            this.txtHarga.Text = DB.getScalar($"SELECT HARGA FROM BARANG WHERE ID = '{id}'");
            numQty.Value = 0;
            //txtSubTotal.Text = "";
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
