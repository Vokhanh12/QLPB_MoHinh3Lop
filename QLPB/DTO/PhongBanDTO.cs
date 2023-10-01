using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPB.DTO
{
    class PhongBanDTO
    {
        private string _maphong;
        private string _tenphong;

        public string maphong
        {
            get
            {
                return _tenphong;
            }
            set
            {
                _tenphong = value;
            }

        }

        public string tenphong
        {
            get { return _tenphong; }
            set
            {
                _tenphong = value;
            }
        }


        public PhongBanDTO()
        {
            _maphong = "";
            _tenphong = "";
        }

        public PhongBanDTO(string maPhong,string tenPhonng)
        {
            _maphong = maPhong;
            _tenphong = tenphong;
        }


    }
}
