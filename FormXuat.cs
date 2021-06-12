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
    public partial class FormXuat : Form
    {
        public FormXuat()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            FormXuatThem xuatthem = new FormXuatThem();
            xuatthem.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
