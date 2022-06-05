using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTC.Model
{
    class KhachHangModel
    {
        private string _MaKH;
        private string _HoTenKH;
        private string _SDT;
        private string _Dchi;
        private string _Email;
        private string _TenDN;
        private string _MKhau;

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string HoTenKH { get => _HoTenKH; set => _HoTenKH = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string Dchi { get => _Dchi; set => _Dchi = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string TenDN { get => _TenDN; set => _TenDN = value; }
        public string MKhau { get => _MKhau; set => _MKhau = value; }
    }
}
