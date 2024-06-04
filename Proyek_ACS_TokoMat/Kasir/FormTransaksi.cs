using Proyek_ACS_TokoMat.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_ACS_TokoMat.Kasir
{
    public partial class FormTransaksi : Form
    {
        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            reset();
        }

        void reset()
        {
            labelTransId.Text = "Trans ID : " + DB.generateId("HTRANS");
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            txtID.Text = "";
            txtNama.Text = "";
            txtHarga.Text = "";
            txtSubTotal.Text = "";

            txtTotal.Text = "";
            numBayar.Value = 0;
            txtKembalian.Text = "0";

            btnSave.Enabled = true;

            dataGridView1.Columns["Remove"].Visible = true;
            dataGridView1.Columns["Id"].Visible = true;

            updateHtrans();
        }

        async Task check()
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.DefaultCellStyle.BackColor = Color.Lime;
                await Task.Delay(90);
            }
            dataGridView1.Columns["Remove"].Visible = false;
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
        public void setBarang(string id)
        {
            this.txtID.Text = id;
            this.txtNama.Text = DB.getScalar($"SELECT NAMA FROM BARANG WHERE ID = '{id}'");
            this.txtHarga.Text = DB.getScalar($"SELECT HARGAJUAL FROM BARANG WHERE ID = '{id}'");
            numQty.Value = 0;
            txtSubTotal.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Cari_Barang s = new Cari_Barang(this, "BARANG");
            s.ShowDialog();
        }

        void cetakNota(string htrans)
        {
            //FormNota f = new FormNota(htrans);
            //f.Show();
        }

        private void numBayar_ValueChanged(object sender, EventArgs e)
        {
            updateHtrans();
        }

        

        private void btnInput_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text != "" && numQty.Value > 0)
            {
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.Cells["ID"].Value.ToString() == txtID.Text)
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
                this.dataGridView1.Rows.Add(txtID.Text, txtNama.Text, txtHarga.Text, numQty.Value, txtSubTotal.Text);
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Remove")
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                updateHtrans();
            }
        }

        private void numBayar_KeyUp(object sender, KeyEventArgs e)
        {
            updateHtrans();
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

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Keranjang Kosong");
                return;
            }

            if (numBayar.Value < Int32.Parse(txtTotal.Text))
            {
                MessageBox.Show("Pembayaran tidak cukup");
                return;
            }

            DB.openConnection();
            SqlTransaction transaction = DB.conn.BeginTransaction();
            try
            {
                string idHtrans = DB.generateIdTr("HTRANS", transaction);
                int total_bill = Int32.Parse(txtTotal.Text);
                int total_paid = (int)numBayar.Value;
                string employee = DB.getScalarTr($"SELECT ID FROM USERS WHERE NAMA = '{DB.logged.Field<string>("NAMA")}'", transaction);
                DateTime now = DateTime.Now;

                DB.execTr($"INSERT INTO HTRANS VALUES('{employee}','{now}',{total_bill},{total_paid});", transaction);

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string newid = DB.generateIdTr("DTRANS", transaction);
                    DataGridViewRow row = dataGridView1.Rows[i];
                    string barang = row.Cells["Id"].Value.ToString();
                    int qty = Int32.Parse(row.Cells["Qty"].Value.ToString());
                    int subtotal = Int32.Parse(row.Cells["Subtotal"].Value.ToString());

                    DB.execTr($"INSERT INTO DTRANS VALUES('{idHtrans}','{barang}',{qty},{subtotal})", transaction);
                    DB.execTr($"UPDATE BARANG SET QTY = QTY - {qty} WHERE ID = '{barang}'", transaction);
                }

                transaction.Commit();

                btnSave.Enabled = false;
                check();
                cetakNota(idHtrans);
                reset();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Gagal insert data transaction");
                transaction.Rollback();
            }
        }
    }
}
