using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020101102.DTO
{
    class MonHocDTO
    {
        private string _maMH;
        private string _tenMH;
        private string _soTC;

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

        public string TenMH
        {
            get
            {
                return _tenMH;
            }

            set
            {
                _tenMH = value;
            }
        }

        public string SoTC
        {
            get
            {
                return _soTC;
            }

            set
            {
                _soTC = value;
            }
        }
    }
}
