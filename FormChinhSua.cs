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
    public partial class FormChinhSua : Form
    {
        public FormChinhSua()
        {
            InitializeComponent();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            FormThemChinhSua f = new FormThemChinhSua();
            f.Show();
        }
    }
}
