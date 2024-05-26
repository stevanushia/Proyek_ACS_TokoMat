﻿namespace Proyek_ACS_TokoMat
{
    partial class FormDashboard
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
            this.masterStokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPembelianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterStokToolStripMenuItem,
            this.masterSupplierToolStripMenuItem,
            this.masterUserToolStripMenuItem});
            this.masterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // masterStokToolStripMenuItem
            // 
            this.masterStokToolStripMenuItem.Name = "masterStokToolStripMenuItem";
            this.masterStokToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.masterStokToolStripMenuItem.Text = "Master Barang";
            // 
            // masterSupplierToolStripMenuItem
            // 
            this.masterSupplierToolStripMenuItem.Name = "masterSupplierToolStripMenuItem";
            this.masterSupplierToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.masterSupplierToolStripMenuItem.Text = "Master Supplier";
            // 
            // masterUserToolStripMenuItem
            // 
            this.masterUserToolStripMenuItem.Name = "masterUserToolStripMenuItem";
            this.masterUserToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.masterUserToolStripMenuItem.Text = "Master User";
            this.masterUserToolStripMenuItem.Click += new System.EventHandler(this.masterUserToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laporanPembelianToolStripMenuItem,
            this.laporanPenjualanToolStripMenuItem});
            this.laporanToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // laporanPembelianToolStripMenuItem
            // 
            this.laporanPembelianToolStripMenuItem.Name = "laporanPembelianToolStripMenuItem";
            this.laporanPembelianToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.laporanPembelianToolStripMenuItem.Text = "Laporan Pembelian";
            // 
            // laporanPenjualanToolStripMenuItem
            // 
            this.laporanPenjualanToolStripMenuItem.Name = "laporanPenjualanToolStripMenuItem";
            this.laporanPenjualanToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.laporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan";
            // 
            // txtWelcome
            // 
            this.txtWelcome.AutoSize = true;
            this.txtWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.Location = new System.Drawing.Point(12, 45);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(282, 52);
            this.txtWelcome.TabIndex = 1;
            this.txtWelcome.Text = "WELCOME, ";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtWelcome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterStokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanPembelianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanPenjualanToolStripMenuItem;
        private System.Windows.Forms.Label txtWelcome;
    }
}