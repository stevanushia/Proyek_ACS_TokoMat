
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
            this.searchBar = new System.Windows.Forms.TextBox();
            this.btnCcari = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(634, 32);
            this.searchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(234, 26);
            this.searchBar.TabIndex = 30;
            // 
            // btnCcari
            // 
            this.btnCcari.Location = new System.Drawing.Point(879, 29);
            this.btnCcari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCcari.Name = "btnCcari";
            this.btnCcari.Size = new System.Drawing.Size(112, 35);
            this.btnCcari.TabIndex = 29;
            this.btnCcari.Text = "Cari Barang";
            this.btnCcari.UseVisualStyleBackColor = true;
            this.btnCcari.Click += new System.EventHandler(this.btnCcari_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(22, 29);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(151, 29);
            this.Title.TabIndex = 28;
            this.Title.Text = "Cari Barang";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(29, 509);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(152, 49);
            this.btnBatal.TabIndex = 27;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // dgvBarang
            // 
            this.dgvBarang.AllowUserToAddRows = false;
            this.dgvBarang.AllowUserToDeleteRows = false;
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Location = new System.Drawing.Point(29, 78);
            this.dgvBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.ReadOnly = true;
            this.dgvBarang.RowHeadersWidth = 62;
            this.dgvBarang.Size = new System.Drawing.Size(963, 412);
            this.dgvBarang.TabIndex = 25;
            this.dgvBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarang_CellContentClick);
            this.dgvBarang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarang_CellDoubleClick);
            // 
            // Cari_Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 594);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.btnCcari);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.dgvBarang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cari_Barang";
            this.Text = "Cari_Barang";
            this.Load += new System.EventHandler(this.Cari_Barang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button btnCcari;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.DataGridView dgvBarang;
    }
}