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
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMaNL = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelMaNL
            // 
            this.labelMaNL.AutoSize = true;
            this.labelMaNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNL.Location = new System.Drawing.Point(12, 66);
            this.labelMaNL.Name = "labelMaNL";
            this.labelMaNL.Size = new System.Drawing.Size(121, 20);
            this.labelMaNL.TabIndex = 0;
            this.labelMaNL.Text = "Mã nguyên liệu";
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuong.Location = new System.Drawing.Point(12, 106);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(74, 20);
            this.labelSoLuong.TabIndex = 1;
            this.labelSoLuong.Text = "Số lượng";
            // 
            // buttonLuu
            // 
            this.buttonLuu.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Location = new System.Drawing.Point(142, 161);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(75, 35);
            this.buttonLuu.TabIndex = 2;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
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
            // comboBoxMaNL
            // 
            this.comboBoxMaNL.FormattingEnabled = true;
            this.comboBoxMaNL.Location = new System.Drawing.Point(158, 66);
            this.comboBoxMaNL.Name = "comboBoxMaNL";
            this.comboBoxMaNL.Size = new System.Drawing.Size(144, 24);
            this.comboBoxMaNL.TabIndex = 9;
            // 
            // FormXuatThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 229);
            this.Controls.Add(this.comboBoxMaNL);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxSoLuong);
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
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxMaNL;
    }
}