using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTC.Model;
using QLTC.Controller;

namespace QLTC
{
    public partial class FormKhachHang : Form
    {
        KhachHangController khC = new KhachHangController();
        KhachHangModel khM = new KhachHangModel();
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            khC.hienthi(dgv);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbMaKH.Text.Trim() != "")
            {
                khM.MaKH = tbMaKH.Text;
                khM.HoTenKH = tbHTKH.Text;
                khM.SDT = tbSDT.Text;
                khM.Email = tbEmail.Text;
                khM.Dchi = tbDChi.Text;
                khC.them(khM);
                khC.hienthi(dgv);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbMaKH.Text = "";
            tbHTKH.Text = "";
            tbSDT.Text = "";
            tbEmail.Text = "";
            tbDChi.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbMaKH.Text.Trim() != "")
            {
                khM.MaKH = tbMaKH.Text;
                khC.xoa(khM);
                khC.hienthi(dgv);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (tbMaKH.Text.Trim() != "")
            {
                khM.MaKH = tbMaKH.Text;
                khC.timkiem(khM, dgv);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(tbMaKH.Text.Trim() != "")
            {
                khM.MaKH = tbMaKH.Text;
                khM.HoTenKH = tbHTKH.Text;
                khM.SDT = tbSDT.Text;
                khM.Email = tbEmail.Text;
                khM.Dchi = tbDChi.Text;
                khC.sua(khM);
                khC.hienthi(dgv);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv.Rows[index];
            tbMaKH.Text = selectedRow.Cells[0].Value.ToString();
            tbHTKH.Text = selectedRow.Cells[1].Value.ToString();
            tbSDT.Text = selectedRow.Cells[2].Value.ToString();
            tbEmail.Text = selectedRow.Cells[3].Value.ToString();
            tbDChi.Text = selectedRow.Cells[4].Value.ToString();           
        }
    }
}
