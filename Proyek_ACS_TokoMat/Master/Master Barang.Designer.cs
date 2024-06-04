
namespace Proyek_ACS_TokoMat.Admin
{
    partial class Master_Barang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.numBeli = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numHarga = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numBeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 70;
            this.label3.Text = "Search Bar : ";
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(163, 24);
            this.searchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(1013, 26);
            this.searchBar.TabIndex = 69;
            this.searchBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchBar_KeyUp);
            // 
            // numBeli
            // 
            this.numBeli.Location = new System.Drawing.Point(123, 600);
            this.numBeli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numBeli.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numBeli.Name = "numBeli";
            this.numBeli.Size = new System.Drawing.Size(224, 26);
            this.numBeli.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 605);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Harga Beli : ";
            // 
            // numHarga
            // 
            this.numHarga.Location = new System.Drawing.Point(123, 560);
            this.numHarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numHarga.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numHarga.Name = "numHarga";
            this.numHarga.Size = new System.Drawing.Size(224, 26);
            this.numHarga.TabIndex = 64;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(694, 611);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(146, 59);
            this.btnClear.TabIndex = 63;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(371, 526);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 62;
            this.label12.Text = "Status :";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.cbStatus.Location = new System.Drawing.Point(470, 522);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(208, 28);
            this.cbStatus.TabIndex = 61;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(848, 611);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 59);
            this.btnUpdate.TabIndex = 58;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 645);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 20);
            this.label16.TabIndex = 57;
            this.label16.Text = "Qty : ";
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(123, 642);
            this.numQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numQty.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(94, 26);
            this.numQty.TabIndex = 56;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 565);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 20);
            this.label17.TabIndex = 55;
            this.label17.Text = "Harga Jual : ";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(123, 520);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(221, 26);
            this.textBoxNama.TabIndex = 54;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 525);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 20);
            this.label18.TabIndex = 53;
            this.label18.Text = "Nama :";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(123, 480);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(148, 26);
            this.textBoxId.TabIndex = 52;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 485);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 20);
            this.label19.TabIndex = 51;
            this.label19.Text = "ID :";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(1018, 611);
            this.btnInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(161, 59);
            this.btnInput.TabIndex = 50;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // dgvBarang
            // 
            this.dgvBarang.AllowUserToAddRows = false;
            this.dgvBarang.AllowUserToDeleteRows = false;
            this.dgvBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Location = new System.Drawing.Point(15, 64);
            this.dgvBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.ReadOnly = true;
            this.dgvBarang.RowHeadersWidth = 51;
            this.dgvBarang.Size = new System.Drawing.Size(1164, 389);
            this.dgvBarang.TabIndex = 49;
            this.dgvBarang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarang_CellDoubleClick);
            // 
            // Master_Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 698);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.numBeli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numHarga);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.dgvBarang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Master_Barang";
            this.Text = "Master_Barang";
            this.Load += new System.EventHandler(this.Master_Barang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchBar;
        public System.Windows.Forms.NumericUpDown numBeli;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown numHarga;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.DataGridView dgvBarang;
    }
}