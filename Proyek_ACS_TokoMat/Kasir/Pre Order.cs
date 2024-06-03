using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Proyek_ACS_TokoMat.User;

namespace Proyek_ACS_TokoMat.User
{
    public partial class Pre_Order : Form
    {
        public Pre_Order()
        {
            InitializeComponent();
        }

        public void reset()
        {
            txtNomorNota.Text = DB.generateId("HTRANS");
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            txtNomorNota.Enabled = false;
            txtNama.Enabled = false;
            txtKodeBarang.Enabled = false;
            txtHarga.Enabled = false;
            txtNama.Text = "";
            txtHarga.Text = "";
            txtSubTotal.Text = "";

            cbStatus.Items.Clear();
            cbStatus.Items.Add("Pending");
            cbStatus.Items.Add("Arrived");
            cbStatus.Items.Add("Finished");
            cbStatus.SelectedIndex = 0;
        }
        public void setBarang(string id)
        {
            this.txtKodeBarang.Text = id;
            this.txtNama.Text = DB.getScalar($"SELECT NAMA FROM BARANG WHERE ID = '{id}'");
            this.txtHarga.Text = DB.getScalar($"SELECT HARGABELI FROM BARANG WHERE ID = '{id}'");
            numQty.Value = 1;
            //txtSubTotal.Text = "";
            if (txtHarga.Text != "")
            {
                int qty = (int)numQty.Value;
                int harga = Int32.Parse(txtHarga.Text);
                int value = qty * harga;
                txtSubTotal.Text = value.ToString();
                updateHtrans();
            }
            btnUpdate.Enabled = false;
            cbStatus.Enabled = false;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cari_Barang f = new Cari_Barang(this, "BARANG");
            f.Show();
        }

        private void Pre_Order_Load(object sender, EventArgs e)
        {
            reset();
        }


        void updateHtrans()
        {
            int total = 0;
            int bayar = 0;
            int kembalian = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Int32.Parse(row.Cells["Subtotal"].Value.ToString());
            }
            txtTotal.Text = total.ToString();

            if (numBayar.Value > 0)
            {
                bayar = (int)numBayar.Value;
                kembalian = bayar - total;
                txtKembalian.Text = kembalian.ToString();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtKodeBarang.Text != "" && numQty.Value > 0)
            {
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.Cells["ID"].Value.ToString() == txtKodeBarang.Text)
                    {
                        int qty = (int)numQty.Value;
                        int rqty = Int32.Parse(r.Cells["Qty"].Value.ToString());
                        int value = qty + rqty;
                        int harga = Int32.Parse(r.Cells["Harga"].Value.ToString());
                        r.Cells["Qty"].Value = value;
                        r.Cells["Subtotal"].Value = value * harga;
                        updateHtrans();
                        return;
                    }
                }
                this.dataGridView1.Rows.Add(txtKodeBarang.Text, txtNama.Text, txtHarga.Text, numQty.Value, txtSubTotal.Text);
                updateHtrans();
            }
        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            if (txtHarga.Text != "")
            {
                int qty = (int)numQty.Value;
                int harga = Int32.Parse(txtHarga.Text);
                int value = qty * harga;
                txtSubTotal.Text = value.ToString();
                updateHtrans();
            }
        }

        private void numQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtHarga.Text != "")
            {
                int qty = (int)numQty.Value;
                int harga = Int32.Parse(txtHarga.Text);
                int value = qty * harga;
                txtSubTotal.Text = value.ToString();
                updateHtrans();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Remove")
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                updateHtrans();
            }
        }

        private void numBayar_ValueChanged(object sender, EventArgs e)
        {
            updateHtrans();
        }

        private void numBayar_KeyUp(object sender, KeyEventArgs e)
        {
            updateHtrans();
        }

        public void setSupplier(string supplier)
        {
            
            textBoxSupplier.Text = DB.getScalar($"SELECT NAMA FROM SUPPLIER WHERE ID = '{supplier}'");
            btnUpdate.Enabled = false;
            cbStatus.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Keranjang Kosong");
                return;
            }

            DB.openConnection();
            SqlTransaction transaction = DB.conn.BeginTransaction();
            try
            {
                string idHPO = DB.generateIdTr("HPO", transaction);
                int total_bill = Int32.Parse(txtTotal.Text);
                int total_paid = (int)numBayar.Value;
                string status = cbStatus.Items[cbStatus.SelectedIndex].ToString();
                string supplier = DB.getScalarTr($"SELECT ID FROM SUPPLIER WHERE NAMA = '{textBoxSupplier.Text}'", transaction);
                string employee = DB.getScalarTr($"SELECT ID FROM USERS WHERE NAMA = '{DB.logged.Field<string>("NAMA")}'", transaction);
                DateTime now = DateTime.Now;
                string insertHPOQuery = $"INSERT INTO HPO (supplier, UserID, date_ordered, date_arrived, total_bill, total_paid, status) VALUES ({supplier}, {employee}, '{now}', '{now}', {total_bill}, {total_paid}, '{status}')";
                Console.WriteLine(insertHPOQuery);  
                DB.execTr(insertHPOQuery, transaction);

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    //string newid = DB.generateIdTr("DPO", transaction);
                    DataGridViewRow row = dataGridView1.Rows[i];
                    string barang = row.Cells["Id"].Value.ToString();
                    int qty = Int32.Parse(row.Cells["Qty"].Value.ToString());
                    int subtotal = Int32.Parse(row.Cells["Subtotal"].Value.ToString());

                    DB.execTr($"INSERT INTO DPO (hpo, barang, qty, subtotal) VALUES('{idHPO}','{barang}','{qty}','{subtotal}')", transaction);
                }

                transaction.Commit();
                reset();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Gagal insert data transaction");
                transaction.Rollback();
            }
        }

        private void btnSelSupplier_Click(object sender, EventArgs e)
        {
            Cari_Barang f = new Cari_Barang(this, "SUPPLIER");
            f.Show();
        }

        private void btnSelHpo_Click(object sender, EventArgs e)
        {
            Cari_Barang s = new Cari_Barang(this,"");
            s.Show();
        }

        public void setHpo(string hpo)
        {
            reset();
            txtKodeBarang.Text = hpo;
            textBoxSupplier.Text = DB.getScalar($"SELECT SUPPLIER FROM HPO WHERE ID = '{hpo}'");
            txtNamaSupplier.Text = DB.getScalar($"SELECT NAMA FROM SUPPLIER WHERE ID = '{textBoxSupplier.Text}'");
            btnSelSupplier.Enabled = false;
            btnSelBarang.Enabled = false;

            DataTable detail = DB.get($"SELECT * FROM DPO WHERE HPO = '{hpo}'  ORDER BY ID DESC;");
            foreach (DataRow dr in detail.Rows)
            {
                string idBarang = dr.Field<string>("BARANG");
                string namaBarang = DB.getScalar($"SELECT NAMA FROM BARANG WHERE ID = '{idBarang}';");
                int hargaBarang = Int32.Parse(DB.getScalar($"SELECT HBELI FROM BARANG WHERE ID = '{idBarang}';"));
                int qty = dr.Field<int>("QTY");
                int subtotal = dr.Field<int>("SUBTOTAL");
                dataGridView1.Rows.Add(idBarang, namaBarang, hargaBarang, qty, subtotal);
            }
            dataGridView1.Columns["Remove"].Visible = false;

            txtTotal.Text = DB.getScalar($"SELECT TOTAL_BILL FROM HPO WHERE ID = '{hpo}'");
            numBayar.Maximum = 9999999999;
            numBayar.Value = Int32.Parse(DB.getScalar($"SELECT TOTAL_PAID FROM HPO WHERE ID = '{hpo}'"));
            cbStatus.SelectedIndex = cbStatus.Items.IndexOf(DB.getScalar($"SELECT STATUS FROM HPO WHERE ID = '{hpo}'"));
            //panel1.Enabled = true;
            numQty.Enabled = false;
            btnSave.Enabled = false;

        }
    }
}
