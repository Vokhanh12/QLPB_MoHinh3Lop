using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.DAO
{
    class KetNoiCSDL
    {
        private static SqlConnection cnn = new SqlConnection();

        public static void MoKetNoi()
        {
            try
            {
                string sqlcon = @"Data Source=192.168.0.113,15432;Initial Catalog=QLCHAMCONG;User ID=sa;Password=Aa@123456789";
                cnn.ConnectionString = sqlcon;

                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ket noi khong thanh cong");
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
