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
    class NhaCungCapController
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        string fileName = @".\Data\QLTC.xml";

        public NhaCungCapController()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public void LoadCppNCC(ComboBox cbb)
        {
            XmlNodeList ds = root.SelectNodes("NhaCungCap");
            foreach (XmlNode item in ds)
            {
                cbb.Items.Add(item.SelectSingleNode("MaNCC").InnerText);                
            }
        }
    }
}
