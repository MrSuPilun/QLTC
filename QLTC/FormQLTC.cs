using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTC
{
    public partial class FormQLTC : Form
    {
        public FormQLTC()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormKhachHang formKH = new FormKhachHang();
            formKH.Show();
        }       

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormSanPham formSP = new FormSanPham();
            formSP.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormNhanVien formNV = new FormNhanVien();
            formNV.Show();
        }
    }
}
