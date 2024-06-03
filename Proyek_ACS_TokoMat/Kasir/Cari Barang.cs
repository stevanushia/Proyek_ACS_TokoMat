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
    public partial class Cari_Barang : Form
    {

        string table;
        Form f;
        public Cari_Barang(Form Formasal, string table)
        {
            InitializeComponent();
            this.table = table;
            this.f = Formasal;
        }

        private void Cari_Barang_Load(object sender, EventArgs e)
        {
            reset();
        }

        void reset()
        {
            DataTable detail = DB.get($"SELECT * FROM {table} WHERE STATUS != 'Finished' ORDER BY ID DESC;");

            if (table != "HPO")
            {
                detail = DB.get($"SELECT * FROM {table} WHERE NAMA LIKE'%{searchBar.Text}%' AND (STATUS = 'Aktif' OR STATUS = 'AVAILABLE')  ORDER BY ID DESC;");
            }

            dgvBarang.DataSource = null;
            dgvBarang.DataSource = detail;
            dgvBarang.Columns["id"].Visible = false;
        }

        private void btnCcari_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBarang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow sel = dgvBarang.Rows[e.RowIndex];
            if (f is Pembelian_Barang)
            {
                Pembelian_Barang f = (Pembelian_Barang)this.f;
                if (table == "BARANG")
                {
                    f.setBarang(sel.Cells["ID"].Value.ToString());
                }
                
            }
            else if (f is Penjualan_Barang)
            {
                Penjualan_Barang f = (Penjualan_Barang)this.f;
                if (table == "BARANG")
                {
                    f.setBarang(sel.Cells["ID"].Value.ToString());

                }
            }
            else if (f is Pre_Order )
            {
                Pre_Order f = (Pre_Order)this.f;
                if (table == "BARANG")
                {
                    f.setBarang(sel.Cells["ID"].Value.ToString());
                }
                if (table == "SUPPLIER")
                {
                    f.setSupplier(sel.Cells["ID"].Value.ToString());
                }
            }
            this.Close();
        }

        private void dgvBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
