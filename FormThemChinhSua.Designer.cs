namespace QlyKho
{
    partial class FormThemChinhSua
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
            this.labelMaNL = new System.Windows.Forms.Label();
            this.labelTenNL = new System.Windows.Forms.Label();
            this.labelDonVi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMaNL
            // 
            this.labelMaNL.AutoSize = true;
            this.labelMaNL.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNL.Location = new System.Drawing.Point(12, 70);
            this.labelMaNL.Name = "labelMaNL";
            this.labelMaNL.Size = new System.Drawing.Size(121, 23);
            this.labelMaNL.TabIndex = 0;
            this.labelMaNL.Text = "Mã nguyên liệu";
            // 
            // labelTenNL
            // 
            this.labelTenNL.AutoSize = true;
            this.labelTenNL.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNL.Location = new System.Drawing.Point(12, 35);
            this.labelTenNL.Name = "labelTenNL";
            this.labelTenNL.Size = new System.Drawing.Size(126, 23);
            this.labelTenNL.TabIndex = 1;
            this.labelTenNL.Text = "Tên nguyên liệu";
            this.labelTenNL.Click += new System.EventHandler(this.labelTenNL_Click);
            // 
            // labelDonVi
            // 
            this.labelDonVi.AutoSize = true;
            this.labelDonVi.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonVi.Location = new System.Drawing.Point(12, 108);
            this.labelDonVi.Name = "labelDonVi";
            this.labelDonVi.Size = new System.Drawing.Size(57, 23);
            this.labelDonVi.TabIndex = 2;
            this.labelDonVi.Text = "Đơn vị";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(178, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 22);
            this.textBox3.TabIndex = 5;
            // 
            // buttonLuu
            // 
            this.buttonLuu.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Location = new System.Drawing.Point(178, 160);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(75, 31);
            this.buttonLuu.TabIndex = 6;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            // 
            // FormThemChinhSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 223);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelDonVi);
            this.Controls.Add(this.labelTenNL);
            this.Controls.Add(this.labelMaNL);
            this.Name = "FormThemChinhSua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa";
            this.Load += new System.EventHandler(this.FormThemChinhSua_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaNL;
        private System.Windows.Forms.Label labelTenNL;
        private System.Windows.Forms.Label labelDonVi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonLuu;
    }
}