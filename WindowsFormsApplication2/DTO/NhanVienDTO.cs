using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.DTO
{
    class NhanVienDTO
    {
        private string _maNV;
        private string _hoTen;
        private string _phai;
        private string _hsLuong;
        private DateTime _NgaySinh;
        private string _noiSinh;

        public string MaNV
        {
            get
            {
                return _maNV;
            }

            set
            {
                _maNV = value;
            }
        }

        public string HoTen
        {
            get
            {
                return _hoTen;
            }

            set
            {
                _hoTen = value;
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

        public string HsLuong
        {
            get
            {
                return _hsLuong;
            }

            set
            {
                _hsLuong = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return _NgaySinh;
            }

            set
            {
                _NgaySinh = value;
            }
        }

        public string NoiSinh
        {
            get
            {
                return _noiSinh;
            }

            set
            {
                _noiSinh = value;
            }
        }
    }
}
