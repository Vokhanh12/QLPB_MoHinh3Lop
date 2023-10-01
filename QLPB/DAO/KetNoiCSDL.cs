using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPB.DAO
{
    class KetNoiCSDL
    {
        private static SqlConnection cnn = new SqlConnection();

        public static void MoKetNoi()
        {
            try
            {
                string sqlcon = @"Data Source=M25\SQLEXPRESS;Initial Catalog=QLNV28_09;Integrated Security=True";
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
