namespace QlyKho
{
    partial class FormMain
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
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.dataGridViewmain = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sắpXếpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sốLượngTăngDầnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sốLượngGiảmDầnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmain)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(899, 6);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(54, 33);
            this.buttonTimKiem.TabIndex = 2;
            this.buttonTimKiem.Text = "Tìm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            //this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(755, 12);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(138, 22);
            this.textBoxTimKiem.TabIndex = 1;
            // 
            // dataGridViewmain
            // 
            this.dataGridViewmain.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmain.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewmain.Name = "dataGridViewmain";
            this.dataGridViewmain.RowTemplate.Height = 24;
            this.dataGridViewmain.Size = new System.Drawing.Size(941, 347);
            this.dataGridViewmain.TabIndex = 12;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.sắpXếpToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(1, -1);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(174, 31);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(84, 27);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // sắpXếpToolStripMenuItem1
            // 
            this.sắpXếpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sốLượngTăngDầnToolStripMenuItem1,
            this.sốLượngGiảmDầnToolStripMenuItem1});
            this.sắpXếpToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sắpXếpToolStripMenuItem1.Name = "sắpXếpToolStripMenuItem1";
            this.sắpXếpToolStripMenuItem1.Size = new System.Drawing.Size(82, 27);
            this.sắpXếpToolStripMenuItem1.Text = "Sắp xếp";
            // 
            // sốLượngTăngDầnToolStripMenuItem1
            // 
            this.sốLượngTăngDầnToolStripMenuItem1.Name = "sốLượngTăngDầnToolStripMenuItem1";
            this.sốLượngTăngDầnToolStripMenuItem1.Size = new System.Drawing.Size(231, 28);
            this.sốLượngTăngDầnToolStripMenuItem1.Text = "Số lượng tăng dần";
            // 
            // sốLượngGiảmDầnToolStripMenuItem1
            // 
            this.sốLượngGiảmDầnToolStripMenuItem1.Name = "sốLượngGiảmDầnToolStripMenuItem1";
            this.sốLượngGiảmDầnToolStripMenuItem1.Size = new System.Drawing.Size(231, 28);
            this.sốLượngGiảmDầnToolStripMenuItem1.Text = "Số lượng giảm dần";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(963, 408);
            this.Controls.Add(this.dataGridViewmain);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho nguyên liệu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmain)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewmain;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem sắpXếpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sốLượngTăngDầnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sốLượngGiảmDầnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
    }
}

