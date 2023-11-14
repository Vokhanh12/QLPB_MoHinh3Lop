using _020101102.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _020101102.GUI;

namespace _020101102
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static DataTable ThongTinReport()
        {
            string sql = "select p.MaPhong, TenPhong, MaNV, HoTen, NgaySinh, DiaChi From PhongBan p, " +
            "NhanVien nv where p.MaPhong = nv.MaPhong ";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = ThongTinReport();
            CrystalReport1NEW cry = new CrystalReport1NEW();
            cry.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cry;
    }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
