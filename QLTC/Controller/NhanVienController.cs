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
    class NhanVienController
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        string fileName = @".\Data\QLTC.xml";
        public NhanVienController()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }
        public void them(NhanVienModel nv)
        {
            XmlElement nhanvien = doc.CreateElement("NhanVien");

            XmlElement maNV = doc.CreateElement("MaNV");
            maNV.InnerText = nv.MaNV;
            nhanvien.AppendChild(maNV);

            XmlElement hoTenNV = doc.CreateElement("HoTenNV");
            hoTenNV.InnerText = nv.HoTenNV;
            nhanvien.AppendChild(hoTenNV);

            XmlElement gt = doc.CreateElement("GioiTinh");
            gt.InnerText = nv.SDT;
            nhanvien.AppendChild(gt);

            XmlElement sdt = doc.CreateElement("SDT");
            sdt.InnerText = nv.SDT;
            nhanvien.AppendChild(sdt);

            XmlElement email = doc.CreateElement("Email");
            email.InnerText = nv.Email;
            nhanvien.AppendChild(email);

            XmlElement chucVu = doc.CreateElement("ChucVu");
            chucVu.InnerText = nv.SDT;
            nhanvien.AppendChild(chucVu);

            root.AppendChild(nhanvien);
            doc.Save(fileName);
        }

        public void sua(NhanVienModel nv)
        {
            XmlNode nhanviencu = root.SelectSingleNode("NhanVien[MaNV = '" + nv.MaNV + "']");
            if (nhanviencu != null)
            {
                XmlNode nhanvienmoi = doc.CreateElement("NhanVien");

                XmlElement maNV = doc.CreateElement("MaNV");
                maNV.InnerText = nv.MaNV;
                nhanvienmoi.AppendChild(maNV);

                XmlElement hoTenNV = doc.CreateElement("HoTenNV");
                hoTenNV.InnerText = nv.HoTenNV;
                nhanvienmoi.AppendChild(hoTenNV);

                XmlElement gt = doc.CreateElement("GioiTinh");
                gt.InnerText = nv.SDT;
                nhanvienmoi.AppendChild(gt);

                XmlElement sdt = doc.CreateElement("SDT");
                sdt.InnerText = nv.SDT;
                nhanvienmoi.AppendChild(sdt);

                XmlElement email = doc.CreateElement("Email");
                email.InnerText = nv.Email;
                nhanvienmoi.AppendChild(email);

                XmlElement chucVu = doc.CreateElement("ChucVu");
                chucVu.InnerText = nv.ChucVu;
                nhanvienmoi.AppendChild(chucVu);

                root.ReplaceChild(nhanvienmoi, nhanviencu);
                doc.Save(fileName);
            }
        }

        public void xoa(NhanVienModel nv)
        {
            XmlNode nhanvien = root.SelectSingleNode("NhanVien[MaNV = '" + nv.MaNV + "']");
            if (nhanvien != null)
            {
                root.RemoveChild(nhanvien);
                doc.Save(fileName);
            }
        }
        public void timkiem(NhanVienModel nv, DataGridView dgv)
        {
            XmlNode nhanvien = root.SelectSingleNode("NhanVien[MaNV = '" + nv.MaNV + "']");
            if (nhanvien != null)
            {
                dgv.Rows.Clear();
                dgv.ColumnCount = 6;
                dgv.Rows.Add();
                XmlNode maNV = nhanvien.SelectSingleNode("MaNV");
                dgv.Rows[0].Cells[0].Value = maNV.InnerText;

                XmlNode hoTenNV = nhanvien.SelectSingleNode("HoTenNV");
                dgv.Rows[0].Cells[1].Value = hoTenNV.InnerText;

                XmlNode gt = nhanvien.SelectSingleNode("GioiTinh");
                dgv.Rows[0].Cells[2].Value =gt.InnerText;

                XmlNode sdt = nhanvien.SelectSingleNode("SDT");
                dgv.Rows[0].Cells[3].Value = sdt.InnerText;

                XmlNode email = nhanvien.SelectSingleNode("Email");
                dgv.Rows[0].Cells[4].Value = email.InnerText;

                XmlNode chucVu = nhanvien.SelectSingleNode("ChucVu");
                dgv.Rows[0].Cells[5].Value = chucVu.InnerText;

            }
        }

        public void hienthi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 6;
            int i = 0;
            XmlNodeList ds = root.SelectNodes("NhanVien");
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = item.SelectSingleNode("MaNV").InnerText;
                dgv.Rows[i].Cells[1].Value = item.SelectSingleNode("HoTenNV").InnerText;
                dgv.Rows[i].Cells[2].Value = item.SelectSingleNode("GioiTinh").InnerText;
                dgv.Rows[i].Cells[3].Value = item.SelectSingleNode("SDT").InnerText;
                dgv.Rows[i].Cells[4].Value = item.SelectSingleNode("Email").InnerText;
                dgv.Rows[i].Cells[5].Value = item.SelectSingleNode("ChucVu").InnerText;
                i++;
            }
        }
    }
}
