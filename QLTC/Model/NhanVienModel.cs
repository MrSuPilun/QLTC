using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTC.Model
{
    class NhanVienModel
    {
        private string _MaNV;
        private string _HoTenNV;
        private string _GioiTinh;
        private string _SDT;
        private string _Email;
        private string _ChucVu;

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string HoTenNV { get => _HoTenNV; set => _HoTenNV = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string ChucVu { get => _ChucVu; set => _ChucVu = value; }
    }
}
