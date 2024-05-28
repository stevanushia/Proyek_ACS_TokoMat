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
    public partial class FormMasterBarang : Form
    {
        public FormMasterBarang()
        {
            InitializeComponent();
        }

        private void FormMasterBarang_Load(object sender, EventArgs e)
        {
            reset();
        }
        void reset()
        {
            //if (DB.logged.Field<string>("ROLE") == "Admin") numQty.Enabled = true;
            DataTable detail = DB.get($"SELECT * FROM products WHERE NAMA LIKE '%{searchBar.Text}%' ORDER BY ID DESC;");
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

            //DataTable kategori = DB.get($"SELECT NAMA FROM KATEGORI;");
            //cbKategori.Items.Clear();
            //foreach (DataRow r in kategori.Rows)
            //{
            //    cbKategori.Items.Add(r["NAMA"].ToString());
            //    cbKategori.SelectedIndex = kategori.Rows.IndexOf(r);
            //}

            btnUpdate.Enabled = false;
            btnClear.Enabled = true;
            btnInput.Enabled = true;

            numQty.Value = 0;
            numHarga.Value = 0;
            numBeli.Value = 0;

            textBoxNama.Text = "";

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
            //string kategori = DB.getScalar($"SELECT ID FROM KATEGORI WHERE NAMA = '{cbKategori.Text

            if (nama != "" && harga > 0 && hbeli > 0 )
            {
                if (DB.cekNamaKembar("BARANG", nama))
                {
                    MessageBox.Show($"Nama {nama} sudah dipakai");
                    return;
                }

                DB.exec($"INSERT INTO BARANG VALUES('{id}','{nama}','{harga}', '{hbeli}', '{qty}')");
                reset();
            }
            else MessageBox.Show("Ada field kosong");
        }
    }
}
