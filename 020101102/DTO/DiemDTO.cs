using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020101102.DTO
{
    class DiemDTO
    {
        private string _maSV;
        private string _maMH;
        private string _maThi;
        private string _diem;

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

        public string MaMH
        {
            get
            {
                return _maMH;
            }

            set
            {
                _maMH = value;
            }
        }

        public string MaThi
        {
            get
            {
                return _maThi;
            }

            set
            {
                _maThi = value;
            }
        }

        public string Diem
        {
            get
            {
                return _diem;
            }

            set
            {
                _diem = value;
            }
        }
    }
}
