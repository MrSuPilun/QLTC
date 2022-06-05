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
    public partial class FormNhanVien : Form
    {
        NhanVienController nvC = new NhanVienController();
        NhanVienModel nvM = new NhanVienModel();
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbMaNV.Text = "";
            tbHTNV.Text = "";
            tbSDT.Text = "";
            tbEmail.Text = "";
            tbChucVu.Text = "";
            if (cbbGT.Items.Count > -1)
                cbbGT.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbMaNV.Text.Trim() != "")
            {
                nvM.MaNV = tbMaNV.Text;
                nvM.HoTenNV = tbHTNV.Text;
                nvM.GioiTinh = cbbGT.Text;
                nvM.SDT = tbSDT.Text;
                nvM.Email = tbEmail.Text;
                nvM.ChucVu = tbChucVu.Text;
                nvC.them(nvM);
                nvC.hienthi(dgv);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tbMaNV.Text.Trim() != "")
            {
                nvM.MaNV = tbMaNV.Text;
                nvM.HoTenNV = tbHTNV.Text;
                nvM.GioiTinh = cbbGT.Text;
                nvM.SDT = tbSDT.Text;
                nvM.Email = tbEmail.Text;
                nvM.ChucVu = tbChucVu.Text;
                nvC.sua(nvM);
                nvC.hienthi(dgv);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbMaNV.Text.Trim() != "")
            {
                nvM.MaNV = tbMaNV.Text;
                nvC.xoa(nvM);
                nvC.hienthi(dgv);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (tbMaNV.Text.Trim() != "")
            {
                nvM.MaNV = tbMaNV.Text;
                nvC.timkiem(nvM, dgv);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            nvC.hienthi(dgv);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv.Rows[index];
            tbMaNV.Text = selectedRow.Cells[0].Value.ToString();
            tbHTNV.Text = selectedRow.Cells[1].Value.ToString();
            cbbGT.Text = selectedRow.Cells[2].Value.ToString();
            tbSDT.Text = selectedRow.Cells[3].Value.ToString();
            tbEmail.Text = selectedRow.Cells[4].Value.ToString();
            tbChucVu.Text = selectedRow.Cells[5].Value.ToString();
        }
    }
}
