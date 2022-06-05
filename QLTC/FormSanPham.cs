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
    public partial class FormSanPham : Form
    {
        SanPhamController spC = new SanPhamController();
        SanPhamModel spM = new SanPhamModel();
        NhaCungCapController nccC = new NhaCungCapController();
        NhomSPController nhomspC = new NhomSPController();
        public FormSanPham()
        {            
            InitializeComponent();
            nccC.LoadCppNCC(cbbNCC);
            nhomspC.LoadCppNhomSP(cbbNSP);
        }
                
        private void btnLoadFile_Click(object sender, EventArgs e)
        {            
            spC.hienthi(dgv);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbMaSP.Text.Trim() != "")
            {
                spM.MaSP = tbMaSP.Text;
                spM.TenSP = tbTenSP.Text;
                spM.SoLuong = int.Parse(tbSL.Text);
                spM.DonGia = int.Parse(tbDG.Text);
                spM.MaNhomSP = cbbNSP.Text;
                spM.MaNCC = cbbNCC.Text;
                spM.TinhTrang = cbbTinhTrang.Text;
                spC.them(spM);
                spC.hienthi(dgv);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tbMaSP.Text.Trim() != "")
            {
                spM.MaSP = tbMaSP.Text;
                spM.TenSP = tbTenSP.Text;
                spM.SoLuong = int.Parse(tbSL.Text);
                spM.DonGia = int.Parse(tbDG.Text);
                spM.MaNhomSP = cbbNSP.Text;
                spM.MaNCC = cbbNCC.Text;
                spM.TinhTrang = cbbTinhTrang.Text;
                spC.sua(spM);
                spC.hienthi(dgv);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv.Rows[index];
           /* if(selectedRow != null)
            {*/
                tbMaSP.Text = selectedRow.Cells[0].Value.ToString();
                tbTenSP.Text = selectedRow.Cells[1].Value.ToString();
                tbSL.Text = selectedRow.Cells[2].Value.ToString();
                tbDG.Text = selectedRow.Cells[3].Value.ToString();
                cbbNSP.Text = selectedRow.Cells[4].Value.ToString();
                cbbNCC.Text = selectedRow.Cells[5].Value.ToString();
                cbbTinhTrang.Text = selectedRow.Cells[6].Value.ToString();
            /*}   */        
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbMaSP.Text.Trim() != "")
            {
                spM.MaSP = tbMaSP.Text;
                spC.xoa(spM);
                spC.hienthi(dgv);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (tbMaSP.Text.Trim() != "")
            {
                spM.MaSP = tbMaSP.Text;
                spC.timkiem(spM, dgv);                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbMaSP.Text = "";
            tbTenSP.Text = "";
            tbSL.Text = "";
            tbDG.Text = "";
            if(cbbNSP.Items.Count > -1)
                cbbNSP.SelectedIndex = 0;
            if (cbbNCC.Items.Count > -1)
                cbbNCC.SelectedIndex = 0;
            if (cbbTinhTrang.Items.Count > -1)
                cbbTinhTrang.SelectedIndex = 0;
        }
    }
}
