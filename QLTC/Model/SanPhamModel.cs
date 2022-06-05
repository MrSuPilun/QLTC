using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTC.Model
{
    class SanPhamModel
    {
        private string _MaSP;
        private string _TenSP;
        private int _SoLuong;
        private int _DonGia;
        private string _MaNCC;
        private string _MaNhomSP;
        private string _TinhTrang;

        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public string TenSP { get => _TenSP; set => _TenSP = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public int DonGia { get => _DonGia; set => _DonGia = value; }
        public string MaNCC { get => _MaNCC; set => _MaNCC = value; }
        public string MaNhomSP { get => _MaNhomSP; set => _MaNhomSP = value; }
        public string TinhTrang { get => _TinhTrang; set => _TinhTrang = value; }
    }
}
