using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);

            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);

            decimal dKQ = dSo1 + dSo2;

            txtKetQua.Text = dKQ.ToString();

        }

        private void btTru_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);

            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);

            decimal dKQ = dSo1 - dSo2;

            txtKetQua.Text = dKQ.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);

            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);

            decimal dKQ = dSo1 / dSo2;

            txtKetQua.Text = dKQ.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);

            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);

            decimal dKQ = dSo1 * dSo2;

            txtKetQua.Text = dKQ.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
