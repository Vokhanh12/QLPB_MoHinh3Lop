using QLPB.DAO;
using QLPB.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPB.BUS
{
    class PhongBanBUS
    {

        public static DataTable TTPhongBan()
        {
            DataTable dt = new DataTable();
            dt = PhongBanDAO.TTPhong();
            return dt;
        }

        public static void Them_PhongBan(PhongBanDTO pb)
        {
            try
            {
                PhongBanDAO.Them_PhongBan(pb);
            }
            catch (Exception)
            {
                MessageBox.Show("Them phong ban khong thanh cong");
            }
        }

        public static void Xoa_PhongBan(PhongBanDTO pb)
        {
            try
            {
                PhongBanDAO.Xoa_PhongBan(pb);
            }
            catch (Exception)
            {
                MessageBox.Show("Xoa phong ban khong thanh cong");
            }

        }

        public static void CapNhat_PhongBan(PhongBanDTO pb)
        {
            try
            {
                PhongBanDAO.CapNhap_PhongBan(pb);
            }
            catch (Exception)
            {
                MessageBox.Show("Cap nhat phong ban khong thanh cong");
            }

        }


    }
}
