using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _020101102.DAO
{
    class KetNoiCSDL
    {
        private static SqlConnection cnn = new SqlConnection();

        public static void MoKetNoi()
        {
            try
            {
                string sqlcon = @"Data Source=192.168.2.22,15432;Initial Catalog=qlsinhvien;Persist Security Info=True;User ID=sa;Password=Aa@123456789";
                cnn.ConnectionString = sqlcon;

                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ket noi khong thanh cong");
                MessageBox.Show(""+ex);
            }


        }

        public static void DongKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        public static DataTable DocDuLieu(string sql)
        {
            MoKetNoi();
            SqlCommand cd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DongKetNoi();
            return dt;

        }

        public static void ThucThiTryVan(string sql)
        {
            MoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }



    }
}
