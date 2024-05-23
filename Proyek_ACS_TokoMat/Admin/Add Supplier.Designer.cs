
namespace Proyek_ACS_TokoMat.Admin
{
    partial class Add_Supplier
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
            this.telepon_Supplier = new System.Windows.Forms.TextBox();
            this.alamat_Supplier = new System.Windows.Forms.TextBox();
            this.nama_Supplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.email_Supplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(27, 27);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(165, 29);
            this.Title.TabIndex = 44;
            this.Title.Text = "Add Supplier";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 71);
            this.button2.TabIndex = 43;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 80);
            this.button1.TabIndex = 42;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // telepon_Supplier
            // 
            this.telepon_Supplier.Location = new System.Drawing.Point(165, 190);
            this.telepon_Supplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.telepon_Supplier.Name = "telepon_Supplier";
            this.telepon_Supplier.Size = new System.Drawing.Size(180, 26);
            this.telepon_Supplier.TabIndex = 41;
            // 
            // alamat_Supplier
            // 
            this.alamat_Supplier.Location = new System.Drawing.Point(165, 145);
            this.alamat_Supplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.alamat_Supplier.Name = "alamat_Supplier";
            this.alamat_Supplier.Size = new System.Drawing.Size(180, 26);
            this.alamat_Supplier.TabIndex = 40;
            // 
            // nama_Supplier
            // 
            this.nama_Supplier.Location = new System.Drawing.Point(165, 104);
            this.nama_Supplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nama_Supplier.Name = "nama_Supplier";
            this.nama_Supplier.Size = new System.Drawing.Size(180, 26);
            this.nama_Supplier.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Telepon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Alamat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nama";
            // 
            // email_Supplier
            // 
            this.email_Supplier.Location = new System.Drawing.Point(165, 239);
            this.email_Supplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email_Supplier.Name = "email_Supplier";
            this.email_Supplier.Size = new System.Drawing.Size(180, 26);
            this.email_Supplier.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Email";
            // 
            // Add_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 343);
            this.Controls.Add(this.email_Supplier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.telepon_Supplier);
            this.Controls.Add(this.alamat_Supplier);
            this.Controls.Add(this.nama_Supplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Supplier";
            this.Text = "Add_Supplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox telepon_Supplier;
        private System.Windows.Forms.TextBox alamat_Supplier;
        private System.Windows.Forms.TextBox nama_Supplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email_Supplier;
        private System.Windows.Forms.Label label4;
    }
}