
namespace Proyek_ACS_TokoMat.Admin
{
    partial class MasterSuppliers
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
            this.rbNonAktif = new System.Windows.Forms.RadioButton();
            this.rbAktif = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvSup = new System.Windows.Forms.DataGridView();
            this.textBoxKontak = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSup)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 75;
            this.label3.Text = "Search Bar : ";
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(171, 29);
            this.searchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(822, 26);
            this.searchBar.TabIndex = 74;
            this.searchBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchBar_KeyUp_1);
            // 
            // rbNonAktif
            // 
            this.rbNonAktif.AutoSize = true;
            this.rbNonAktif.Location = new System.Drawing.Point(205, 589);
            this.rbNonAktif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbNonAktif.Name = "rbNonAktif";
            this.rbNonAktif.Size = new System.Drawing.Size(100, 24);
            this.rbNonAktif.TabIndex = 73;
            this.rbNonAktif.TabStop = true;
            this.rbNonAktif.Text = "Non-Aktif";
            this.rbNonAktif.UseVisualStyleBackColor = true;
            // 
            // rbAktif
            // 
            this.rbAktif.AutoSize = true;
            this.rbAktif.Location = new System.Drawing.Point(127, 589);
            this.rbAktif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbAktif.Name = "rbAktif";
            this.rbAktif.Size = new System.Drawing.Size(66, 24);
            this.rbAktif.TabIndex = 72;
            this.rbAktif.TabStop = true;
            this.rbAktif.Text = "Aktif";
            this.rbAktif.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(875, 545);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 71;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(40, 592);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(68, 20);
            this.label26.TabIndex = 70;
            this.label26.Text = "Status : ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(875, 465);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.TabIndex = 69;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(875, 505);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // dgvSup
            // 
            this.dgvSup.AllowUserToAddRows = false;
            this.dgvSup.AllowUserToDeleteRows = false;
            this.dgvSup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSup.Location = new System.Drawing.Point(29, 85);
            this.dgvSup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSup.Name = "dgvSup";
            this.dgvSup.ReadOnly = true;
            this.dgvSup.RowHeadersWidth = 51;
            this.dgvSup.Size = new System.Drawing.Size(966, 366);
            this.dgvSup.TabIndex = 60;
            this.dgvSup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSup_CellContentClick);
            this.dgvSup.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSup_CellDoubleClick_1);
            // 
            // textBoxKontak
            // 
            this.textBoxKontak.Location = new System.Drawing.Point(127, 549);
            this.textBoxKontak.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxKontak.Name = "textBoxKontak";
            this.textBoxKontak.Size = new System.Drawing.Size(222, 26);
            this.textBoxKontak.TabIndex = 67;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(40, 554);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(67, 20);
            this.label27.TabIndex = 66;
            this.label27.Text = "Kontak :";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(127, 509);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(222, 26);
            this.textBoxNama.TabIndex = 65;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(40, 514);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(59, 20);
            this.label28.TabIndex = 64;
            this.label28.Text = "Nama :";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(127, 469);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(148, 26);
            this.textBoxId.TabIndex = 63;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(40, 474);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(34, 20);
            this.label29.TabIndex = 62;
            this.label29.Text = "ID :";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(875, 625);
            this.btnInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(120, 35);
            this.btnInput.TabIndex = 61;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click_1);
            // 
            // MasterSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 766);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.rbNonAktif);
            this.Controls.Add(this.rbAktif);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvSup);
            this.Controls.Add(this.textBoxKontak);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.btnInput);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MasterSuppliers";
            this.Text = "Master Supplier";
            this.Load += new System.EventHandler(this.MasterSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.RadioButton rbNonAktif;
        private System.Windows.Forms.RadioButton rbAktif;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvSup;
        private System.Windows.Forms.TextBox textBoxKontak;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnInput;
    }
}