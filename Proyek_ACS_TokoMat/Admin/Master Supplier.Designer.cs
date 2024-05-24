
namespace Proyek_ACS_TokoMat.Admin
{
    partial class Form1
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
            this.dataSupplier = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1221, 58);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add Supplier";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(1111, 19);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(132, 42);
            this.BtnBack.TabIndex = 14;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // dataSupplier
            // 
            this.dataSupplier.AllowUserToAddRows = false;
            this.dataSupplier.AllowUserToDeleteRows = false;
            this.dataSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSupplier.Location = new System.Drawing.Point(21, 71);
            this.dataSupplier.Name = "dataSupplier";
            this.dataSupplier.ReadOnly = true;
            this.dataSupplier.RowHeadersWidth = 62;
            this.dataSupplier.RowTemplate.Height = 28;
            this.dataSupplier.Size = new System.Drawing.Size(1221, 343);
            this.dataSupplier.TabIndex = 13;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(21, 19);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(198, 29);
            this.Title.TabIndex = 12;
            this.Title.Text = "Master Supplier";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.dataSupplier);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.DataGridView dataSupplier;
        private System.Windows.Forms.Label Title;
    }
}