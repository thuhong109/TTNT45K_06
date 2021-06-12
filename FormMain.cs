using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyKho
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhap nhap = new FormNhap();
            nhap.MdiParent = this;
            nhap.Show();
        }

        private void xuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormXuat xuat = new FormXuat();
            xuat.MdiParent = this;
            xuat.Show();
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChinhSua sua = new FormChinhSua();
            sua.MdiParent = this;
            sua.Show();
        }
    }
}
