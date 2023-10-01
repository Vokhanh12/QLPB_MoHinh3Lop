using QLPB.DAO;
using QLPB.DTO;
using QLPB.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPB.GUI
{
    public partial class phongGUI : Form
    {

        public phongGUI()
        {
            InitializeComponent();
        }

        private void loadlvPhongPhan()
        {
            DataTable dt = new DataTable();
            dt = PhongBanDAO.TTPhong();
            int Sonv = dt.Rows.Count;
            for (int i = 0; i < Sonv; i++)
            {
                lvPhongBan.Items.Add(dt.Rows[i][0].ToString());
                lvPhongBan.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
            }
        }

        private void phongGUI_Load(object sender, EventArgs e)
        {
            loadlvPhongPhan();
        }

        private void lvPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {

            PhongBanDTO pb = new PhongBanDTO();
            pb.maphong = tbMaPhong.Text;
            pb.tenphong = tbTenPhong.Text;

            PhongBanBUS.Them_PhongBan(pb);

            lvPhongBan.Items.Clear();

            string[] row = { pb.maphong, pb.maphong };
            var listViewItem = new ListViewItem(row);

            lvPhongBan.Items.Add(listViewItem);

            lvPhongBan.Items.Clear();
            loadlvPhongPhan();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            PhongBanDTO pb = new PhongBanDTO();

            pb.maphong = tbMaPhong.Text;
            PhongBanBUS.Xoa_PhongBan(pb);

            lvPhongBan.Items.Clear();
            loadlvPhongPhan();

        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            PhongBanDTO pb = new PhongBanDTO();
            pb.maphong = tbMaPhong.Text;
            pb.tenphong = tbTenPhong.Text;

            PhongBanBUS.CapNhat_PhongBan(pb);


            lvPhongBan.Items.Clear();
            loadlvPhongPhan();


        }
    }

     
    }
