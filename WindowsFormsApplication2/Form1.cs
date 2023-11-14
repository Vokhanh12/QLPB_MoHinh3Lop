using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.DAO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadLv1()
        {
            DataTable dt = ChamCong.dataNhanVien();

            int count = dt.Rows.Count;

            for(int i = 0; i < count; i++)
            {
                listView1.Items.Add(dt.Rows[i][0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
            }
            


        }

        private void loadLv2()
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadLv1();
         
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        



        }

        private void listView1_Click(object sender, EventArgs e)
        {
            DataTable dt = ChamCong.dataNhanVienByMaNV(listView1.SelectedItems[0].Text);
            MessageBox.Show(listView1.SelectedItems[0].Text.Trim());

            tbMaNhanVIen.Text = dt.Rows[0][0].ToString();
            tbHoTen.Text = dt.Rows[0][1].ToString();

            if (dt.Rows[0][2].ToString().Trim() == "0")
                cbGioiTinh.Text = "Nam";
            else cbGioiTinh.Text = "Nu";
        }
    }
}
