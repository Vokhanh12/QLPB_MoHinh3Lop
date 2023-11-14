using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020101102.DTO
{
    class KhoaDTO
    {
        private string _maKhoa;
        private string _tenKhoa;

        public string MaKhoa
        {
            get
            {
                return _maKhoa;
            }

            set
            {
                _maKhoa = value;
            }
        }

        public string TenKhoa
        {
            get
            {
                return _tenKhoa;
            }

            set
            {
                _tenKhoa = value;
            }
        }
    }
}
