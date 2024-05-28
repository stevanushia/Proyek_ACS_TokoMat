using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_ACS_TokoMat.Admin
{
    public partial class Master_Barang : Form
    {
        public Master_Barang()
        {
            InitializeComponent();
        }

        private void Master_Barang_Load(object sender, EventArgs e)
        {
            reset();
        }

        void reset()
        {
            DataTable detail = DB.get($"SELECT * FROM BARANG WHERE NAMA LIKE '%{searchBar.Text}%' ORDER BY ID DESC;");
            dgvBarang.DataSource = null;
            dgvBarang.DataSource = detail;

            foreach (DataGridViewRow r in dgvBarang.Rows)
            {
                if ((int)r.Cells["QTY"].Value <= 0)
                {
                    r.DefaultCellStyle.ForeColor = Color.Red;
                    string id = r.Cells["QTY"].Value.ToString();
                }
            }

            btnUpdate.Enabled = false;
            btnClear.Enabled = true;
            btnInput.Enabled = true;

            numQty.Value = 0;
            numHarga.Value = 0;
            numBeli.Value = 0;

            textBoxNama.Text = "";

            cbStatus.SelectedIndex = 0;

            textBoxId.Text = DB.generateId("BARANG");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text;
            string nama = textBoxNama.Text;
            int harga = (int)numHarga.Value;
            int hbeli = (int)numBeli.Value;
            int qty = (int)numQty.Value;
            string status = cbStatus.Text;

            if (nama != "" && harga > 0 && hbeli > 0 && cbStatus.SelectedIndex > -1)
            {
                if (DB.cekNamaKembar("BARANG", nama))
                {
                    MessageBox.Show($"Nama {nama} sudah dipakai");
                    return;
                }

                DB.exec($"INSERT INTO BARANG VALUES('{id}','{nama}','{qty}','{harga}', '{hbeli}' ,'{status}')");
                reset();
            }
            else MessageBox.Show("Ada field kosong");
        }
    }
}
