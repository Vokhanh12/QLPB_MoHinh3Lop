using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.DAO
{
    class ChamCong
    {
        public static DataTable dataNhanVien()
        {
            string sql = "SELECT * FROM NhanVien";
            return KetNoiCSDL.DocDuLieu(sql);
        }

        public static DataTable dataNhanVienByMaNV(string MaNV)
        {
            string sql = "SELECT * FROM NhanVien nv " +
                $"WHERE nv.MaNV = '{MaNV}'";
            return KetNoiCSDL.DocDuLieu(sql);
        }
    }
}
