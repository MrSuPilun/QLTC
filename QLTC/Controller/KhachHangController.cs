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
    class KhachHangController
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        string fileName = @".\Data\QLTC.xml";
        public KhachHangController()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }
        public void them(KhachHangModel kh)
        {
            XmlElement khachhang = doc.CreateElement("KhachHang");

            XmlElement maKH = doc.CreateElement("MaKH");
            maKH.InnerText = kh.MaKH;
            khachhang.AppendChild(maKH);

            XmlElement hoTenKH = doc.CreateElement("HoTenKH");
            hoTenKH.InnerText = kh.HoTenKH;
            khachhang.AppendChild(hoTenKH);

            XmlElement sdt = doc.CreateElement("SDT");
            sdt.InnerText = kh.SDT;
            khachhang.AppendChild(sdt);

            XmlElement email = doc.CreateElement("Email");
            email.InnerText = kh.Email;
            khachhang.AppendChild(email);

            XmlElement dchi = doc.CreateElement("Dchi");
            dchi.InnerText = kh.Dchi;
            khachhang.AppendChild(dchi);

            root.AppendChild(khachhang);
            doc.Save(fileName);
        }

        public void sua(KhachHangModel kh)
        {
            XmlNode khachhangcu = root.SelectSingleNode("KhachHang[MaKH = '" + kh.MaKH + "']");
            if (khachhangcu != null)
            {
                XmlNode khachhangmoi = doc.CreateElement("KhachHang");

                XmlElement maKH = doc.CreateElement("MaKH");
                maKH.InnerText = kh.MaKH;
                khachhangmoi.AppendChild(maKH);

                XmlElement hoTenKH = doc.CreateElement("HoTenKH");
                hoTenKH.InnerText = kh.HoTenKH;
                khachhangmoi.AppendChild(hoTenKH);

                XmlElement sdt = doc.CreateElement("SDT");
                sdt.InnerText = kh.SDT;
                khachhangmoi.AppendChild(sdt);

                XmlElement email = doc.CreateElement("Email");
                email.InnerText = kh.Email;
                khachhangmoi.AppendChild(email);

                XmlElement dchi = doc.CreateElement("Dchi");
                dchi.InnerText = kh.Dchi;
                khachhangmoi.AppendChild(dchi);

                root.ReplaceChild(khachhangmoi, khachhangcu);
                doc.Save(fileName);
            }
        }

        public void xoa(KhachHangModel kh)
        {
            XmlNode khachhang = root.SelectSingleNode("KhachHang[MaKH = '" + kh.MaKH + "']");
            if (khachhang != null)
            {
                root.RemoveChild(khachhang);
                doc.Save(fileName);
            }
        }
        public void timkiem(KhachHangModel kh, DataGridView dgv)
        {
            XmlNode khachhang = root.SelectSingleNode("KhachHang[MaKH = '" + kh.MaKH + "']");
            if (khachhang != null)
            {
                dgv.Rows.Clear();
                dgv.ColumnCount = 5;
                dgv.Rows.Add();
                XmlNode maKH = khachhang.SelectSingleNode("MaKH");
                dgv.Rows[0].Cells[0].Value = maKH.InnerText;

                XmlNode hoTenKH = khachhang.SelectSingleNode("HoTenKH");
                dgv.Rows[0].Cells[1].Value = hoTenKH.InnerText;

                XmlNode sdt = khachhang.SelectSingleNode("SDT");
                dgv.Rows[0].Cells[2].Value = sdt.InnerText;

                XmlNode email = khachhang.SelectSingleNode("Email");
                dgv.Rows[0].Cells[3].Value = email.InnerText;

                XmlNode dchi = khachhang.SelectSingleNode("Dchi");
                dgv.Rows[0].Cells[4].Value = dchi.InnerText;
            }
        }

        public void hienthi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 5;
            int i = 0;
            XmlNodeList ds = root.SelectNodes("KhachHang");
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = item.SelectSingleNode("MaKH").InnerText;
                dgv.Rows[i].Cells[1].Value = item.SelectSingleNode("HoTenKH").InnerText;
                dgv.Rows[i].Cells[2].Value = item.SelectSingleNode("SDT").InnerText;
                dgv.Rows[i].Cells[3].Value = item.SelectSingleNode("Email").InnerText;
                dgv.Rows[i].Cells[4].Value = item.SelectSingleNode("Dchi").InnerText;
                i++;
            }
        }
    }
}
