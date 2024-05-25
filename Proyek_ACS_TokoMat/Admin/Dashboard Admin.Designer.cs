
namespace Proyek_ACS_TokoMat
{
    partial class DashboardAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLaporanPenjualan = new System.Windows.Forms.Button();
            this.btnLaporanPembelian = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(580, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterSupplierToolStripMenuItem,
            this.masterUserToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // masterSupplierToolStripMenuItem
            // 
            this.masterSupplierToolStripMenuItem.Name = "masterSupplierToolStripMenuItem";
            this.masterSupplierToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.masterSupplierToolStripMenuItem.Text = "Master Supplier";
            // 
            // masterUserToolStripMenuItem
            // 
            this.masterUserToolStripMenuItem.Name = "masterUserToolStripMenuItem";
            this.masterUserToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.masterUserToolStripMenuItem.Text = "Master User";
            // 
            // btnLaporanPenjualan
            // 
            this.btnLaporanPenjualan.Location = new System.Drawing.Point(23, 45);
            this.btnLaporanPenjualan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLaporanPenjualan.Name = "btnLaporanPenjualan";
            this.btnLaporanPenjualan.Size = new System.Drawing.Size(251, 79);
            this.btnLaporanPenjualan.TabIndex = 1;
            this.btnLaporanPenjualan.Text = "Laporan Penjualan ";
            this.btnLaporanPenjualan.UseVisualStyleBackColor = true;
            this.btnLaporanPenjualan.Click += new System.EventHandler(this.btnLaporanPenjualan_Click);
            // 
            // btnLaporanPembelian
            // 
            this.btnLaporanPembelian.Location = new System.Drawing.Point(302, 45);
            this.btnLaporanPembelian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLaporanPembelian.Name = "btnLaporanPembelian";
            this.btnLaporanPembelian.Size = new System.Drawing.Size(251, 79);
            this.btnLaporanPembelian.TabIndex = 2;
            this.btnLaporanPembelian.Text = "Laporan Pembelian";
            this.btnLaporanPembelian.UseVisualStyleBackColor = true;
            this.btnLaporanPembelian.Click += new System.EventHandler(this.btnLaporanPembelian_Click);
            // 
            // DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 330);
            this.Controls.Add(this.btnLaporanPembelian);
            this.Controls.Add(this.btnLaporanPenjualan);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashboardAdmin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterSupplierToolStripMenuItem;
        private System.Windows.Forms.Button btnLaporanPenjualan;
        private System.Windows.Forms.Button btnLaporanPembelian;
        private System.Windows.Forms.ToolStripMenuItem masterUserToolStripMenuItem;
    }
}