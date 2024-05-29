
namespace Proyek_ACS_TokoMat.User
{
    partial class Pembelian_Barang
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
            this.textStok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblQTY = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListBarang = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomorNota = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBeli = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.SuspendLayout();
            // 
            // textStok
            // 
            this.textStok.Location = new System.Drawing.Point(150, 271);
            this.textStok.Name = "textStok";
            this.textStok.ReadOnly = true;
            this.textStok.Size = new System.Drawing.Size(217, 26);
            this.textStok.TabIndex = 167;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 166;
            this.label4.Text = "Stok Barang : ";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(857, 467);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(18, 20);
            this.lblGrandTotal.TabIndex = 165;
            this.lblGrandTotal.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(734, 468);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 20);
            this.label20.TabIndex = 164;
            this.label20.Text = "Grand Total : ";
            // 
            // lblQTY
            // 
            this.lblQTY.AutoSize = true;
            this.lblQTY.Location = new System.Drawing.Point(856, 439);
            this.lblQTY.Name = "lblQTY";
            this.lblQTY.Size = new System.Drawing.Size(18, 20);
            this.lblQTY.TabIndex = 163;
            this.lblQTY.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(749, 439);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 20);
            this.label16.TabIndex = 162;
            this.label16.Text = "Total QTY:";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(215, 511);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(154, 49);
            this.btnTambah.TabIndex = 161;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(455, 488);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 49);
            this.btnClear.TabIndex = 160;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 159;
            this.label2.Text = "List Barang";
            // 
            // dgvListBarang
            // 
            this.dgvListBarang.AllowUserToAddRows = false;
            this.dgvListBarang.AllowUserToDeleteRows = false;
            this.dgvListBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBarang.Location = new System.Drawing.Point(455, 131);
            this.dgvListBarang.Name = "dgvListBarang";
            this.dgvListBarang.ReadOnly = true;
            this.dgvListBarang.RowHeadersVisible = false;
            this.dgvListBarang.RowHeadersWidth = 51;
            this.dgvListBarang.RowTemplate.Height = 24;
            this.dgvListBarang.Size = new System.Drawing.Size(522, 263);
            this.dgvListBarang.TabIndex = 158;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 157;
            this.label3.Text = "Nomor Nota : ";
            // 
            // txtNomorNota
            // 
            this.txtNomorNota.Location = new System.Drawing.Point(758, 91);
            this.txtNomorNota.Name = "txtNomorNota";
            this.txtNomorNota.ReadOnly = true;
            this.txtNomorNota.Size = new System.Drawing.Size(217, 26);
            this.txtNomorNota.TabIndex = 156;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(38, 511);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 49);
            this.btnCancel.TabIndex = 154;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnBeli
            // 
            this.btnBeli.Location = new System.Drawing.Point(455, 421);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(154, 49);
            this.btnBeli.TabIndex = 155;
            this.btnBeli.Text = "Beli";
            this.btnBeli.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(845, 25);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(132, 42);
            this.BtnBack.TabIndex = 153;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 152;
            this.label1.Text = "Supplier :";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(149, 330);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(217, 26);
            this.txtSupplier.TabIndex = 151;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 150;
            this.label10.Text = "Harga Barang : ";
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(150, 211);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.ReadOnly = true;
            this.txtHarga.Size = new System.Drawing.Size(217, 26);
            this.txtHarga.TabIndex = 149;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 148;
            this.label9.Text = "Nama Barang : ";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(149, 151);
            this.txtNama.Name = "txtNama";
            this.txtNama.ReadOnly = true;
            this.txtNama.Size = new System.Drawing.Size(217, 26);
            this.txtNama.TabIndex = 147;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 146;
            this.label8.Text = "Kode Barang : ";
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.Location = new System.Drawing.Point(149, 95);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.ReadOnly = true;
            this.txtKodeBarang.Size = new System.Drawing.Size(217, 26);
            this.txtKodeBarang.TabIndex = 145;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 31);
            this.button2.TabIndex = 144;
            this.button2.Text = "Cari";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(149, 456);
            this.numQty.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(219, 26);
            this.numQty.TabIndex = 143;
            this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 142;
            this.label5.Text = "Qty : ";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(26, 28);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(228, 29);
            this.Title.TabIndex = 141;
            this.Title.Text = "Pembelian Barang";
            // 
            // Pembelian_Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 598);
            this.Controls.Add(this.textStok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblQTY);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvListBarang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomorNota);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBeli);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKodeBarang);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Title);
            this.Name = "Pembelian_Barang";
            this.Text = "Pembelian_Barang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblQTY;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomorNota;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Title;
    }
}