
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
            this.button1 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.DataUser = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataUser)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1221, 62);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add User";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(1102, 6);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(132, 42);
            this.BtnBack.TabIndex = 14;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // DataUser
            // 
            this.DataUser.AllowUserToAddRows = false;
            this.DataUser.AllowUserToDeleteRows = false;
            this.DataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataUser.Location = new System.Drawing.Point(12, 69);
            this.DataUser.Name = "DataUser";
            this.DataUser.ReadOnly = true;
            this.DataUser.RowHeadersWidth = 62;
            this.DataUser.RowTemplate.Height = 28;
            this.DataUser.Size = new System.Drawing.Size(1221, 332);
            this.DataUser.TabIndex = 13;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 17);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(154, 29);
            this.Title.TabIndex = 12;
            this.Title.Text = "Master User";
            // 
            // Master_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.DataUser);
            this.Controls.Add(this.Title);
            this.Name = "Master_User";
            this.Text = "Master_User";
            ((System.ComponentModel.ISupportInitialize)(this.DataUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.DataGridView DataUser;
        private System.Windows.Forms.Label Title;
    }
}