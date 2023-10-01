using QLPB.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPB.DAO
{
    class PhongBanDAO
    {
        public static DataTable TTPhong()
        {
            string sql = "SELECT * FROM PhongBan";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }

        public static void Them_PhongBan(PhongBanDTO pb)
        {
            string sql = "INSERT INTO PhongBan([MaPhong],[TenPhong]) VALUES ('"+pb.maphong+"','"+pb.tenphong+"')";
            KetNoiCSDL.ThucThiTryVan(sql);



        }


        public static void Xoa_PhongBan(PhongBanDTO pb)
        {
            string sql = "DELETE FROM PhongBan WHERE MaPhong ='" + pb.tenphong+"' ";
            KetNoiCSDL.ThucThiTryVan(sql);
        }


        public static void CapNhap_PhongBan(PhongBanDTO pb)
        {
            string sql = "UPDATE PhongBan set TenPhong = N'"+ pb.tenphong + "' WHERE MaPhong ='" + pb.maphong +"' ";
            KetNoiCSDL.ThucThiTryVan(sql);

        }


    }
}
