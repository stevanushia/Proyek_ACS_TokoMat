
namespace Proyek_ACS_TokoMat.Admin
{
    partial class Add_User
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
            this.Title = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.role_User = new System.Windows.Forms.ComboBox();
            this.password_User = new System.Windows.Forms.TextBox();
            this.username_User = new System.Windows.Forms.TextBox();
            this.nama_User = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(28, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(121, 29);
            this.Title.TabIndex = 35;
            this.Title.Text = "Add User";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 71);
            this.button2.TabIndex = 34;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 80);
            this.button1.TabIndex = 33;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // role_User
            // 
            this.role_User.FormattingEnabled = true;
            this.role_User.Items.AddRange(new object[] {
            "Admin\t",
            "User"});
            this.role_User.Location = new System.Drawing.Point(142, 214);
            this.role_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.role_User.Name = "role_User";
            this.role_User.Size = new System.Drawing.Size(180, 28);
            this.role_User.TabIndex = 32;
            // 
            // password_User
            // 
            this.password_User.Location = new System.Drawing.Point(142, 171);
            this.password_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password_User.Name = "password_User";
            this.password_User.Size = new System.Drawing.Size(180, 26);
            this.password_User.TabIndex = 31;
            // 
            // username_User
            // 
            this.username_User.Location = new System.Drawing.Point(142, 126);
            this.username_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.username_User.Name = "username_User";
            this.username_User.Size = new System.Drawing.Size(180, 26);
            this.username_User.TabIndex = 30;
            // 
            // nama_User
            // 
            this.nama_User.Location = new System.Drawing.Point(142, 85);
            this.nama_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nama_User.Name = "nama_User";
            this.nama_User.Size = new System.Drawing.Size(180, 26);
            this.nama_User.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Pasword";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nama";
            // 
            // Add_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 339);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.role_User);
            this.Controls.Add(this.password_User);
            this.Controls.Add(this.username_User);
            this.Controls.Add(this.nama_User);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_User";
            this.Text = "Add_User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox role_User;
        private System.Windows.Forms.TextBox password_User;
        private System.Windows.Forms.TextBox username_User;
        private System.Windows.Forms.TextBox nama_User;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}