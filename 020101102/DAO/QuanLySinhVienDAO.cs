using _020101102.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _020101102.DAO
{
    class QuanLySinhVienDAO
    {

       public static DataTable get_dslh()
        {
            string sql = "SELECT TenLop FROM LOP";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
       public static DataTable TTQLSV()
        {
            string sql = "SELECT sv.MaSV,sv.TenSV,sv.Phai,sv.NgaySinh,sv.DiaChi,sv.DiaChi,d.Diem,mh.TenMH "
                       + "FROM SINHVIEN sv "
                       + "JOIN DIEM d ON sv.MaSV = d.MaSV "
                       + "JOIN MONHOC mh ON d.MaMH = mh.MaMH; ";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;


        }

        public static DataTable ThongTinReport()
        {
            string sql = "select p.MaPhong, TenPhong, MaNV, HoTen, NgaySinh, DiaChi From PhongBan p, "+
            "NhanVien nv where p.MaPhong = nv.MaPhong ";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }

       

        public static void updateSV(SinhVienDTO sv,string malop)
        {
            try {

                string sql = "UPDATE SINHVIEN " +
    "SET " +
        $"TenSV = '{sv.TenSV}', " +
        $"Phai = '{sv.Phai}', " +
        $"NgaySinh = '{sv.NgaySinh}', " +
        $"DiaChi = '{sv.DiaChi}', " +
        $"DienThoai = '{sv.DienThoai}', " +
    "WHERE " +
        $"MaSV = '{sv.MaSV}'; ";

                KetNoiCSDL.DocDuLieu(sql);
                MessageBox.Show("Cap nhat thanh công");

            }catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }

            

        }

        public static void deleteSV()
        {

        }



        public static void insertSinhVien(SinhVienDTO sv)
        {
            try {
                MessageBox.Show("Them thanh cong");
            } catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            
        }
        public static DataTable getCountSV()
        {
            string sql = "SELECT COUNT(*) AS TotalCount FROM SINHVIEN;";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }

        public static DataTable getTenSVByTenKhoa(string TenKhoa)
        {



            string sql = "SELECT sv.TenSV " +
          "FROM SINHVIEN sv " +
          "JOIN LOP l ON sv.MaLop = l.MaLop " +
          $"where sv.MaLop = '{TenKhoa}'";

            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;

        }


        public static DataTable getInfoSVByName(string name)
        {
            string sql = "SELECT * FROM SINHVIEN " +
$"WHERE TenSV = N'{name}'";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;

        }



    }
}
