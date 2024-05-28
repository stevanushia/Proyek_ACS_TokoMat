
namespace Proyek_ACS_TokoMat
{
    partial class Dashboard_User
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
            this.btnPembelian = new System.Windows.Forms.Button();
            this.btnPenjualan = new System.Windows.Forms.Button();
            this.btnRetur = new System.Windows.Forms.Button();
            this.btnPreOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPembelian
            // 
            this.btnPembelian.Location = new System.Drawing.Point(308, 29);
            this.btnPembelian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPembelian.Name = "btnPembelian";
            this.btnPembelian.Size = new System.Drawing.Size(251, 79);
            this.btnPembelian.TabIndex = 4;
            this.btnPembelian.Text = "Pembelian";
            this.btnPembelian.UseVisualStyleBackColor = true;
            // 
            // btnPenjualan
            // 
            this.btnPenjualan.Location = new System.Drawing.Point(34, 29);
            this.btnPenjualan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPenjualan.Name = "btnPenjualan";
            this.btnPenjualan.Size = new System.Drawing.Size(251, 79);
            this.btnPenjualan.TabIndex = 3;
            this.btnPenjualan.Text = "Penjualan ";
            this.btnPenjualan.UseVisualStyleBackColor = true;
            this.btnPenjualan.Click += new System.EventHandler(this.btnPenjualan_Click);
            // 
            // btnRetur
            // 
            this.btnRetur.Location = new System.Drawing.Point(34, 122);
            this.btnRetur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetur.Name = "btnRetur";
            this.btnRetur.Size = new System.Drawing.Size(251, 79);
            this.btnRetur.TabIndex = 5;
            this.btnRetur.Text = "Retur";
            this.btnRetur.UseVisualStyleBackColor = true;
            // 
            // btnPreOrder
            // 
            this.btnPreOrder.Location = new System.Drawing.Point(308, 122);
            this.btnPreOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreOrder.Name = "btnPreOrder";
            this.btnPreOrder.Size = new System.Drawing.Size(251, 79);
            this.btnPreOrder.TabIndex = 6;
            this.btnPreOrder.Text = "Pre Order";
            this.btnPreOrder.UseVisualStyleBackColor = true;
            // 
            // Dashboard_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 360);
            this.Controls.Add(this.btnPreOrder);
            this.Controls.Add(this.btnRetur);
            this.Controls.Add(this.btnPembelian);
            this.Controls.Add(this.btnPenjualan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard_User";
            this.Text = "Dashboard_User";
            this.Load += new System.EventHandler(this.Dashboard_User_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPembelian;
        private System.Windows.Forms.Button btnPenjualan;
        private System.Windows.Forms.Button btnRetur;
        private System.Windows.Forms.Button btnPreOrder;
    }
}