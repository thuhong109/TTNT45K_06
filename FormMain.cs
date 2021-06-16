using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QlyKho
{
    public partial class FormMain : Form
    {
        string sCon = 
        @"Data Source=.\SqlExpress;Initial Catalog=QUANLIKHONGUYENLIEU;Integrated Security=True";
        
        public FormMain()
        {
            InitializeComponent();
        }

      

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        #region kết nối sql
        private void FormMain_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi");
            }
            string sQuery = "select * from NGUYENLIEU inner join BANGTONKHO on NGUYENLIEU.MANGUYENLIEU = BANGTONKHO.MANGUYENLIEU";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "bangtonkho");

            dataGridViewmain.DataSource = ds.Tables["bangtonkho"];

            con.Close();

        }
        #endregion
        
        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLy qly = new FormQuanLy();
            this.Hide();
            qly.ShowDialog();
            this.Show();
        }
        
        // tìm kiếm
        //List<TENNGUYENLIEU> SearchTENNGUYENLIEUByName(string name)
        //{
        //    List<TENNGUYENLIEU> listTen = new List<TENNGUYENLIEU>();

        //    return listTen;
        //}
        //private void buttonTimKiem_Click(object sender, EventArgs e)
        //{
        //    SearchTENNGUYENLIEUByName(textBoxTimKiem.Text);
        //}

        

        
        
    }
}
