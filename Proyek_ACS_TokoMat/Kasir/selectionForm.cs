using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_ACS_TokoMat.Kasir
{

    public partial class selectionForm : Form
    {
        string table;
        Form po;
        public selectionForm(Form po)
        {
            InitializeComponent();
            this.table = table;
            this.po = po;
        }

        private void selectionForm_Load(object sender, EventArgs e)
        {
            labelTable.Text = table;
            reset();
        }
        void reset()
        {
            DataTable detail = DB.get($"SELECT * FROM hpo WHERE STATUS != 'Finished' ORDER BY ID DESC;");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = detail;
            dataGridView1.Columns["id"].Visible = false;
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            reset();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow sel = dataGridView1.Rows[e.RowIndex];
            //if (po is FormPo)
            //{
            //    FormPo f = (FormPo)this.po;
            //    if (table == "BARANG")
            //    {
            //        f.setBarang(sel.Cells["ID"].Value.ToString());
            //    }
            //    if (table == "SUPPLIER")
            //    {
            //        f.setSupplier(sel.Cells["ID"].Value.ToString());
            //    }
            //    if (table == "HPO")
            //    {
            //        f.setHpo(sel.Cells["ID"].Value.ToString());
            //    }
            //}
            //else if (po is FormTransaksi)
            //{
            //    FormTransaksi f = (FormTransaksi)this.po;
            //    if (table == "MEMBER")
            //    {
            //        f.setMember(sel.Cells["ID"].Value.ToString());
            //    }
            //    else if (table == "BARANG")
            //    {
            //        f.setBarang(sel.Cells["ID"].Value.ToString());
            //    }

            //}
            //else if (po is FormPenjualanBarang)
            //{
            //    FormPenjualanBarang f = (FormPenjualanBarang)this.po;
            //    if (table == "BARANG")
            //    {
            //        f.setBarang(sel.Cells["ID"].Value.ToString());
            //    }
            //}


            //this.Close();
        }
    }
}
