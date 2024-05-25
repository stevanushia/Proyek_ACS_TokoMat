using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_ACS_TokoMat
{
    public partial class FormLogin : Form
    {
        DB db;

        string username;
        string password;
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new DB("", "");
            DB.openConnection();
            DB.closeConnection();
        }

        void Login()
        {
            username = textBox1.Text;
            password = textBox2.Text;

            bool login = DB.setLogged(username, password);

            if (login)
            {
                //FormDashboard f = new FormDashboard(this);
                //f.Show();
                this.Hide();

                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
