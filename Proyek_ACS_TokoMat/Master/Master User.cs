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
    public partial class Master_User : Form
    {
        public Master_User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add_User au = new Add_User();
            //au.ShowDialog();
        }

        private void Master_User_Load(object sender, EventArgs e)
        {
            reset();
            textBoxId.Enabled = false;
        }
        void reset()
        {
            DataTable detail = DB.get($"SELECT ID, NAMA, PASSWORD, ROLE, STATUS FROM USERS WHERE NAMA LIKE '%{searchBar.Text}%'  ORDER BY ID DESC;");
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = detail;
            dgvUsers.Columns["PASSWORD"].Visible = false;
            textBoxId.Text = DB.generateId("USERS");
            textBoxNama.Text = "";
            textBoxPass.Text = "";
            comboBoxRole.SelectedIndex = 0;
            rbAktif.Checked = false;
            rbNonAktif.Checked = false;

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnInput.Enabled = true;
            btnClear.Enabled = true;

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow sel = dgvUsers.Rows[e.RowIndex];

            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnInput.Enabled = false;
            btnClear.Enabled = true;

            textBoxId.Text = sel.Cells["ID"].Value.ToString();
            textBoxNama.Text = sel.Cells["NAMA"].Value.ToString();
            textBoxPass.Text = sel.Cells["PASSWORD"].Value.ToString();

            string role = sel.Cells["ROLE"].Value.ToString();
            string status = sel.Cells["STATUS"].Value.ToString();
            comboBoxRole.SelectedIndex = comboBoxRole.Items.IndexOf(role);
            foreach (RadioButton rb in this.Controls.OfType<RadioButton>())
            {
                if (rb.Text == status) rb.Checked = true; else rb.Checked = false;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text;
            DB.exec($"DELETE FROM USERS WHERE ID = '{id}';");
            reset();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text;
            string username = textBoxNama.Text;
            string password = textBoxPass.Text;
            bool role = comboBoxRole.SelectedIndex > -1;
            bool status = rbAktif.Checked || rbNonAktif.Checked;

            if (id != "" && username != "" && password != "" && role && status)
            {
                if (DB.getScalar($"SELECT NAMA FROM USERS WHERE ID = '{id}'") != username)
                {
                    if (DB.cekNamaKembar("USERS", username))
                    {
                        MessageBox.Show($"Nama {username} sudah dipakai");
                        return;
                    }
                }

                string selectedRole = comboBoxRole.Text;
                string selectedStatus = "";
                foreach (RadioButton rb in this.Controls.OfType<RadioButton>())
                {
                    if (rb.Checked) selectedStatus = rb.Text;
                }
                DB.exec($"UPDATE USERS SET NAMA = '{username}', PASSWORD = '{password}', ROLE = '{selectedRole}', STATUS = '{selectedStatus}' WHERE ID = '{id}';");
                MessageBox.Show("Berhasil mengupdate " + username);
                reset();
            }
            else MessageBox.Show("Terdapat field kosong");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void searchBar_KeyUp(object sender, KeyEventArgs e)
        {
            reset();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string username = textBoxNama.Text;
            string password = textBoxPass.Text;
            bool role = comboBoxRole.SelectedIndex > -1;
            bool status = rbAktif.Checked || rbNonAktif.Checked;

            if (username != "" && password != "" && role && status)
            {

                if (DB.cekNamaKembar("USERS", username))
                {
                    MessageBox.Show($"Nama {username} sudah dipakai");
                    return;
                }

                string selectedRole = comboBoxRole.Text;
                string selectedStatus = "";
                foreach (RadioButton rb in this.Controls.OfType<RadioButton>())
                {
                    if (rb.Checked) selectedStatus = rb.Text;
                }

                DB.exec($"INSERT INTO USERS VALUES('{username}','{password}','{selectedStatus}','{selectedRole}');");
                MessageBox.Show("Berhasil menginput " + username);
                reset();
            }
            else MessageBox.Show("Terdapat field kosong");
        }
    }
}
