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
    public partial class MasterSuppliers : Form
    {
        public MasterSuppliers()
        {
            InitializeComponent();
        }

        void reset()
        {
            DataTable detail = DB.get($"SELECT * FROM SUPPLIER WHERE NAMA LIKE '%{searchBar.Text}%' ORDER BY ID DESC;");
            dgvSup.DataSource = null;
            dgvSup.DataSource = detail;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = true;
            btnInput.Enabled = true;

            textBoxNama.Text = "";
            textBoxKontak.Text = "";

            rbAktif.Checked = false;
            rbNonAktif.Checked = false;

            textBoxId.Text = DB.generateId("SUPPLIER");
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
        }

        private void dgvSup_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void searchBar_KeyUp(object sender, KeyEventArgs e)
        {
            reset();
        }

        private void dgvSup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnInput_Click_1(object sender, EventArgs e)
        {
            string id = textBoxId.Text;
            string nama = textBoxNama.Text;
            string kontak = textBoxKontak.Text;
            bool status = rbAktif.Checked || rbNonAktif.Checked;

            if ( nama != "" && kontak != "" && status)
            {
                if (DB.cekNamaKembar("SUPPLIER", nama))
                {
                    MessageBox.Show($"Nama {nama} sudah dipakai");
                    return;
                }

                string selectedStatus = "";
                foreach (RadioButton rb in this.Controls.OfType<RadioButton>())
                {
                    if (rb.Checked) selectedStatus = rb.Text;
                }

                DB.exec($"INSERT INTO SUPPLIER VALUES('{nama}','{kontak}','{selectedStatus}');");
                MessageBox.Show("Berhasil menginput " + nama);
                reset();
            }
            else MessageBox.Show("Terdapat field kosong");
        }

        private void MasterSuppliers_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void dgvSup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSup_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnInput.Enabled = false;

            DataGridViewRow sel = dgvSup.Rows[e.RowIndex];
            textBoxId.Text = sel.Cells["ID"].Value.ToString();
            textBoxNama.Text = sel.Cells["NAMA"].Value.ToString();
            textBoxKontak.Text = sel.Cells["KONTAK"].Value.ToString();

            string status = sel.Cells["STATUS"].Value.ToString();
            foreach (RadioButton rb in this.Controls.OfType<RadioButton>())
            {
                if (rb.Text == status) rb.Checked = true; else rb.Checked = false;
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string id = textBoxId.Text;
            DB.exec($"DELETE FROM SUPPLIER WHERE ID = '{id}';");
            reset();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            string id = textBoxId.Text;
            string nama = textBoxNama.Text;
            string kontak = textBoxKontak.Text;
            bool status = rbAktif.Checked || rbNonAktif.Checked;

            if (id != "" && nama != "" && kontak != "" && status)
            {

                if (DB.getScalar($"SELECT NAMA FROM SUPPLIER WHERE ID = '{id}'") != nama)
                {
                    if (DB.cekNamaKembar("SUPPLIER", nama))
                    {
                        MessageBox.Show($"Nama {nama} sudah dipakai");
                        return;
                    }
                }

                string selectedStatus = "";
                foreach (RadioButton rb in this.Controls.OfType<RadioButton>())
                {
                    if (rb.Checked) selectedStatus = rb.Text;
                }
                DB.exec($"UPDATE SUPPLIER SET NAMA = '{nama}', kontak = '{kontak}', STATUS = '{selectedStatus}' WHERE ID = '{id}';");
                MessageBox.Show("Berhasil mengupdate " + nama);
                reset();
            }
            else MessageBox.Show("Terdapat field kosong");
        }

        private void searchBar_KeyUp_1(object sender, KeyEventArgs e)
        {
            reset();
        }
    }
}
