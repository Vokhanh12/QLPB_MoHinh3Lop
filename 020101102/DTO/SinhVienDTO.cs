using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020101102.DTO
{
    class SinhVienDTO
    {
        private string _maSV;
        private string _tenSV;
        private string _phai;
        private string _ngaySinh;
        private string _diaChi;
        private string _dienThoai;
        private string _maLop;

        public string MaSV
        {
            get
            {
                return _maSV;
            }

            set
            {
                _maSV = value;
            }
        }

        public string TenSV
        {
            get
            {
                return _tenSV;
            }

            set
            {
                _tenSV = value;
            }
        }

        public string Phai
        {
            get
            {
                return _phai;
            }

            set
            {
                _phai = value;
            }
        }

        public string NgaySinh
        {
            get
            {
                return _ngaySinh;
            }

            set
            {
                _ngaySinh = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _diaChi;
            }

            set
            {
                _diaChi = value;
            }
        }

        public string DienThoai
        {
            get
            {
                return _dienThoai;
            }

            set
            {
                _dienThoai = value;
            }
        }

        public string MaLop
        {
            get
            {
                return _maLop;
            }

            set
            {
                _maLop = value;
            }
        }
    }
}
