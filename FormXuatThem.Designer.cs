namespace QlyKho
{
    partial class FormXuatThem
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
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.textBoxMaNL = new System.Windows.Forms.TextBox();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDonGia = new System.Windows.Forms.Label();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMaNL
            // 
            this.labelMaNL.AutoSize = true;
            this.labelMaNL.Location = new System.Drawing.Point(12, 66);
            this.labelMaNL.Name = "labelMaNL";
            this.labelMaNL.Size = new System.Drawing.Size(104, 17);
            this.labelMaNL.TabIndex = 0;
            this.labelMaNL.Text = "Mã nguyên liệu";
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Location = new System.Drawing.Point(12, 106);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(64, 17);
            this.labelSoLuong.TabIndex = 1;
            this.labelSoLuong.Text = "Số lượng";
            // 
            // buttonLuu
            // 
            this.buttonLuu.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Location = new System.Drawing.Point(58, 199);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(75, 35);
            this.buttonLuu.TabIndex = 2;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            // 
            // textBoxMaNL
            // 
            this.textBoxMaNL.Location = new System.Drawing.Point(158, 66);
            this.textBoxMaNL.Name = "textBoxMaNL";
            this.textBoxMaNL.Size = new System.Drawing.Size(144, 22);
            this.textBoxMaNL.TabIndex = 3;
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(158, 106);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(144, 22);
            this.textBoxSoLuong.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // labelDonGia
            // 
            this.labelDonGia.AutoSize = true;
            this.labelDonGia.Location = new System.Drawing.Point(15, 141);
            this.labelDonGia.Name = "labelDonGia";
            this.labelDonGia.Size = new System.Drawing.Size(57, 17);
            this.labelDonGia.TabIndex = 6;
            this.labelDonGia.Text = "Đơn giá";
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.Location = new System.Drawing.Point(158, 141);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.Size = new System.Drawing.Size(144, 22);
            this.textBoxDonGia.TabIndex = 7;
            // 
            // buttonHuy
            // 
            this.buttonHuy.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Location = new System.Drawing.Point(201, 199);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(75, 35);
            this.buttonHuy.TabIndex = 8;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = true;
            // 
            // FormXuatThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 262);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.textBoxDonGia);
            this.Controls.Add(this.labelDonGia);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxSoLuong);
            this.Controls.Add(this.textBoxMaNL);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.labelSoLuong);
            this.Controls.Add(this.labelMaNL);
            this.Name = "FormXuatThem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất Kho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaNL;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.TextBox textBoxMaNL;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDonGia;
        private System.Windows.Forms.TextBox textBoxDonGia;
        private System.Windows.Forms.Button buttonHuy;
    }
}