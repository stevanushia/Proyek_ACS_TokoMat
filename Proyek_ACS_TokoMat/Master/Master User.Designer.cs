
namespace Proyek_ACS_TokoMat.Admin
{
    partial class Master_User
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.rbNonAktif = new System.Windows.Forms.RadioButton();
            this.rbAktif = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(690, 11);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(117, 34);
            this.BtnBack.TabIndex = 14;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(19, 129);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 28;
            this.dgvUsers.Size = new System.Drawing.Size(767, 266);
            this.dgvUsers.TabIndex = 13;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            this.dgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellDoubleClick);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(11, 14);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(129, 25);
            this.Title.TabIndex = 12;
            this.Title.Text = "Master User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Search Bar : ";
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(146, 66);
            this.searchBar.Margin = new System.Windows.Forms.Padding(4);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(661, 22);
            this.searchBar.TabIndex = 62;
            this.searchBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchBar_KeyUp);
            // 
            // rbNonAktif
            // 
            this.rbNonAktif.AutoSize = true;
            this.rbNonAktif.Location = new System.Drawing.Point(167, 559);
            this.rbNonAktif.Margin = new System.Windows.Forms.Padding(4);
            this.rbNonAktif.Name = "rbNonAktif";
            this.rbNonAktif.Size = new System.Drawing.Size(74, 20);
            this.rbNonAktif.TabIndex = 76;
            this.rbNonAktif.TabStop = true;
            this.rbNonAktif.Text = "nonaktif";
            this.rbNonAktif.UseVisualStyleBackColor = true;
            // 
            // rbAktif
            // 
            this.rbAktif.AutoSize = true;
            this.rbAktif.Location = new System.Drawing.Point(98, 559);
            this.rbAktif.Margin = new System.Windows.Forms.Padding(4);
            this.rbAktif.Name = "rbAktif";
            this.rbAktif.Size = new System.Drawing.Size(52, 20);
            this.rbAktif.TabIndex = 75;
            this.rbAktif.TabStop = true;
            this.rbAktif.Text = "aktif";
            this.rbAktif.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(679, 490);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 28);
            this.btnClear.TabIndex = 74;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(20, 561);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 16);
            this.label26.TabIndex = 73;
            this.label26.Text = "Status : ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(20, 529);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 16);
            this.label25.TabIndex = 72;
            this.label25.Text = "Role : ";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "admin",
            "kasir"});
            this.comboBoxRole.Location = new System.Drawing.Point(98, 525);
            this.comboBoxRole.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(197, 24);
            this.comboBoxRole.TabIndex = 71;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(679, 458);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 28);
            this.btnUpdate.TabIndex = 69;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(98, 493);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(197, 22);
            this.textBoxPass.TabIndex = 68;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(20, 497);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 16);
            this.label27.TabIndex = 67;
            this.label27.Text = "Password : ";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(98, 461);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(197, 22);
            this.textBoxNama.TabIndex = 66;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(20, 465);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(50, 16);
            this.label28.TabIndex = 65;
            this.label28.Text = "Nama :";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(679, 554);
            this.btnInput.Margin = new System.Windows.Forms.Padding(4);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(107, 28);
            this.btnInput.TabIndex = 64;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(98, 426);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(132, 22);
            this.textBoxId.TabIndex = 78;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(20, 430);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(26, 16);
            this.label29.TabIndex = 77;
            this.label29.Text = "ID :";
            // 
            // Master_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 611);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.rbNonAktif);
            this.Controls.Add(this.rbAktif);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Master_User";
            this.Text = "Master_User";
            this.Load += new System.EventHandler(this.Master_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.RadioButton rbNonAktif;
        private System.Windows.Forms.RadioButton rbAktif;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label29;
    }
}