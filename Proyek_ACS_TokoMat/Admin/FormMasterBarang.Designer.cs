namespace Proyek_ACS_TokoMat.Admin
{
    partial class FormMasterBarang
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
            this.label3.Location = new System.Drawing.Point(14, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Search Bar : ";
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(145, 12);
            this.searchBar.Margin = new System.Windows.Forms.Padding(4);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(901, 22);
            this.searchBar.TabIndex = 69;
            // 
            // numBeli
            // 
            this.numBeli.Location = new System.Drawing.Point(109, 473);
            this.numBeli.Margin = new System.Windows.Forms.Padding(4);
            this.numBeli.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numBeli.Name = "numBeli";
            this.numBeli.Size = new System.Drawing.Size(199, 22);
            this.numBeli.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 477);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "Harga Beli : ";
            // 
            // numHarga
            // 
            this.numHarga.Location = new System.Drawing.Point(109, 441);
            this.numHarga.Margin = new System.Windows.Forms.Padding(4);
            this.numHarga.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numHarga.Name = "numHarga";
            this.numHarga.Size = new System.Drawing.Size(199, 22);
            this.numHarga.TabIndex = 64;
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(208, 503);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 63;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(754, 482);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 47);
            this.btnUpdate.TabIndex = 58;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 509);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 16);
            this.label16.TabIndex = 57;
            this.label16.Text = "Qty : ";
            // 
            // numQty
            // 
            this.numQty.Enabled = false;
            this.numQty.Location = new System.Drawing.Point(109, 507);
            this.numQty.Margin = new System.Windows.Forms.Padding(4);
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
            this.numQty.Size = new System.Drawing.Size(84, 22);
            this.numQty.TabIndex = 56;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 445);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 16);
            this.label17.TabIndex = 55;
            this.label17.Text = "Harga Jual : ";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(109, 409);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(197, 22);
            this.textBoxNama.TabIndex = 54;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 413);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 16);
            this.label18.TabIndex = 53;
            this.label18.Text = "Nama :";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(109, 377);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(132, 22);
            this.textBoxId.TabIndex = 52;
            this.textBoxId.Text = "autogenerate";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 381);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 16);
            this.label19.TabIndex = 51;
            this.label19.Text = "ID :";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(905, 482);
            this.btnInput.Margin = new System.Windows.Forms.Padding(4);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(143, 47);
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
            this.dgvBarang.Location = new System.Drawing.Point(13, 44);
            this.dgvBarang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.ReadOnly = true;
            this.dgvBarang.RowHeadersWidth = 51;
            this.dgvBarang.Size = new System.Drawing.Size(1035, 311);
            this.dgvBarang.TabIndex = 49;
            // 
            // FormMasterBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 564);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.numBeli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numHarga);
            this.Controls.Add(this.btnClear);
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
            this.Name = "FormMasterBarang";
            this.Text = "FormMasterBarang";
            this.Load += new System.EventHandler(this.FormMasterBarang_Load);
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