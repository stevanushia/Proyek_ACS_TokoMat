﻿
namespace Proyek_ACS_TokoMat.User
{
    partial class Cari_Barang
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
            this.textInvc = new System.Windows.Forms.TextBox();
            this.btnCcari = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.btnPembelian = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPenjualan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textInvc
            // 
            this.textInvc.Location = new System.Drawing.Point(564, 26);
            this.textInvc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textInvc.Name = "textInvc";
            this.textInvc.Size = new System.Drawing.Size(208, 22);
            this.textInvc.TabIndex = 30;
            // 
            // btnCcari
            // 
            this.btnCcari.Location = new System.Drawing.Point(781, 23);
            this.btnCcari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCcari.Name = "btnCcari";
            this.btnCcari.Size = new System.Drawing.Size(100, 28);
            this.btnCcari.TabIndex = 29;
            this.btnCcari.Text = "Cari Barang";
            this.btnCcari.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(20, 23);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(127, 25);
            this.Title.TabIndex = 28;
            this.Title.Text = "Cari Barang";
            // 
            // btnPembelian
            // 
            this.btnPembelian.Location = new System.Drawing.Point(746, 407);
            this.btnPembelian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPembelian.Name = "btnPembelian";
            this.btnPembelian.Size = new System.Drawing.Size(135, 39);
            this.btnPembelian.TabIndex = 26;
            this.btnPembelian.Text = "Pembelian";
            this.btnPembelian.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(26, 407);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(135, 39);
            this.btnBatal.TabIndex = 27;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(856, 330);
            this.dataGridView1.TabIndex = 25;
            // 
            // btnPenjualan
            // 
            this.btnPenjualan.Location = new System.Drawing.Point(605, 407);
            this.btnPenjualan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPenjualan.Name = "btnPenjualan";
            this.btnPenjualan.Size = new System.Drawing.Size(135, 39);
            this.btnPenjualan.TabIndex = 31;
            this.btnPenjualan.Text = "Penjualan";
            this.btnPenjualan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 407);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 39);
            this.button1.TabIndex = 32;
            this.button1.Text = "Pre Order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Cari_Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPenjualan);
            this.Controls.Add(this.textInvc);
            this.Controls.Add(this.btnCcari);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.btnPembelian);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cari_Barang";
            this.Text = "Cari_Barang";
            this.Load += new System.EventHandler(this.Cari_Barang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInvc;
        private System.Windows.Forms.Button btnCcari;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnPembelian;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPenjualan;
        private System.Windows.Forms.Button button1;
    }
}