using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using QLTC.Model;

namespace QLTC.Controller
{
    class SanPhamController
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        string fileName = @".\Data\QLTC.xml";
        public SanPhamController()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }
        public void them(SanPhamModel sp)
        {
            XmlElement sanpham = doc.CreateElement("SanPham");

            XmlElement maSP = doc.CreateElement("MaSP");
            maSP.InnerText = sp.MaSP;
            sanpham.AppendChild(maSP);

            XmlElement tenSP = doc.CreateElement("TenSP");
            tenSP.InnerText = sp.TenSP;
            sanpham.AppendChild(tenSP);

            XmlElement soLuong = doc.CreateElement("SoLuong");
            soLuong.InnerText = sp.SoLuong.ToString();
            sanpham.AppendChild(soLuong);

            XmlElement donGia = doc.CreateElement("DonGia");
            donGia.InnerText = sp.DonGia.ToString();
            sanpham.AppendChild(donGia);

            XmlElement maNhomSP = doc.CreateElement("MaNhomSP");
            maNhomSP.InnerText = sp.MaNhomSP;
            sanpham.AppendChild(maNhomSP);

            XmlElement maNCC = doc.CreateElement("MaNCC");
            maNCC.InnerText = sp.MaNCC;
            sanpham.AppendChild(maNCC);

            XmlElement tinhTrang = doc.CreateElement("TinhTrang");
            tinhTrang.InnerText = sp.TinhTrang;
            sanpham.AppendChild(tinhTrang);

            root.AppendChild(sanpham);
            doc.Save(fileName);
        }

        public void sua(SanPhamModel sp)
        {
            XmlNode sanphamcu = root.SelectSingleNode("SanPham[MaSP = '" + sp.MaSP + "']");
            if(sanphamcu != null)
            {
                XmlNode sanphammoi = doc.CreateElement("SanPham");

                XmlElement maSP = doc.CreateElement("MaSP");
                maSP.InnerText = sp.MaSP;
                sanphammoi.AppendChild(maSP);

                XmlElement tenSP = doc.CreateElement("TenSP");
                tenSP.InnerText = sp.TenSP;
                sanphammoi.AppendChild(tenSP);

                XmlElement soLuong = doc.CreateElement("SoLuong");
                soLuong.InnerText = sp.SoLuong.ToString();
                sanphammoi.AppendChild(soLuong);

                XmlElement donGia = doc.CreateElement("DonGia");
                donGia.InnerText = sp.DonGia.ToString();
                sanphammoi.AppendChild(donGia);

                XmlElement maNhomSP = doc.CreateElement("MaNhomSP");
                maNhomSP.InnerText = sp.MaNhomSP;
                sanphammoi.AppendChild(maNhomSP);

                XmlElement maNCC = doc.CreateElement("MaNCC");
                maNCC.InnerText = sp.MaNCC;
                sanphammoi.AppendChild(maNCC);

                XmlElement tinhTrang = doc.CreateElement("TinhTrang");
                tinhTrang.InnerText = sp.TinhTrang;
                sanphammoi.AppendChild(tinhTrang);

                root.ReplaceChild(sanphammoi, sanphamcu);
                doc.Save(fileName);
            }
        }

        public void xoa(SanPhamModel sp)
        {
            XmlNode sanpham = root.SelectSingleNode("SanPham[MaSP = '" + sp.MaSP + "']");
            if (sanpham != null)
            {
                root.RemoveChild(sanpham);
                doc.Save(fileName);
            }
        }
        public void timkiem(SanPhamModel sp, DataGridView dgv)
        {
            XmlNode sanpham = root.SelectSingleNode("SanPham[MaSP = '" + sp.MaSP + "']");
            if (sanpham != null)
            {
                dgv.Rows.Clear();
                dgv.ColumnCount = 7;
                dgv.Rows.Add();
                XmlNode maSP = sanpham.SelectSingleNode("MaSP");
                dgv.Rows[0].Cells[0].Value = maSP.InnerText;

                XmlNode tenSP = sanpham.SelectSingleNode("TenSP");
                dgv.Rows[0].Cells[1].Value = tenSP.InnerText;

                XmlNode soLuong = sanpham.SelectSingleNode("SoLuong");
                dgv.Rows[0].Cells[2].Value = soLuong.InnerText;

                XmlNode donGia = sanpham.SelectSingleNode("DonGia");
                dgv.Rows[0].Cells[3].Value = donGia.InnerText;

                XmlNode maNhomSP = sanpham.SelectSingleNode("MaNhomSP");
                dgv.Rows[0].Cells[4].Value = maNhomSP.InnerText;

                XmlNode maNCC = sanpham.SelectSingleNode("MaNCC");
                dgv.Rows[0].Cells[5].Value = maNCC.InnerText;

                XmlNode trangThai = sanpham.SelectSingleNode("TinhTrang");
                dgv.Rows[0].Cells[6].Value = trangThai.InnerText;             
            }
        }

        public void hienthi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 7;
            int i = 0;
            XmlNodeList ds = root.SelectNodes("SanPham");
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = item.SelectSingleNode("MaSP").InnerText;
                dgv.Rows[i].Cells[1].Value = item.SelectSingleNode("TenSP").InnerText;
                dgv.Rows[i].Cells[2].Value = item.SelectSingleNode("SoLuong").InnerText;
                dgv.Rows[i].Cells[3].Value = item.SelectSingleNode("DonGia").InnerText;
                dgv.Rows[i].Cells[4].Value = item.SelectSingleNode("MaNhomSP").InnerText;
                dgv.Rows[i].Cells[5].Value = item.SelectSingleNode("MaNCC").InnerText;
                dgv.Rows[i].Cells[6].Value = item.SelectSingleNode("TinhTrang").InnerText;
                i++;
            }
        }
    }
}
