using _020101102.DAO;
using _020101102.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _020101102
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            loadLV();

            loadTV();

            loadcb();
        }

        private void loadcb()
        {
            DataTable dt = new DataTable();
            dt = QuanLySinhVienDAO.get_dslh();

            List<string> dsLop = new List<string>();

            int Sovn = dt.Rows.Count;
            for(int i = 0;i< Sovn; i++)
            {
                dsLop.Add(""+dt.Rows[i][0].ToString());
            }

            cbLopHoc.DataSource = dsLop;
        }

        private void loadLV()
        {
            DataTable dt = new DataTable();

            dt = QuanLySinhVienDAO.TTQLSV();

            int Sonv = dt.Rows.Count;

            for (int i = 0; i < Sonv; i++)
            {
                lvSinhVien.Items.Add(dt.Rows[i][0].ToString());
                lvSinhVien.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                lvSinhVien.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lvSinhVien.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                lvSinhVien.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
                lvSinhVien.Items[i].SubItems.Add(dt.Rows[i][5].ToString());
                lvSinhVien.Items[i].SubItems.Add(dt.Rows[i][6].ToString());
            }
        }

        private void loadTV()
        {
            TreeNode rootNode1 = new TreeNode("DH CNTT K20");
            DataTable dt1 = new DataTable();
            dt1 = QuanLySinhVienDAO.getTenSVByTenKhoa("L001");

            TreeNode rootNode2 = new TreeNode("DH CNTT K21");
            DataTable dt2 = new DataTable();
            dt2 = QuanLySinhVienDAO.getTenSVByTenKhoa("L002");

            TreeNode rootNode3 = new TreeNode("DH CNTT K22");
            DataTable dt3 = new DataTable();
            dt3 = QuanLySinhVienDAO.getTenSVByTenKhoa("L003");

            TreeNode rootNode4 = new TreeNode("DH Luật khóa 2022");
            DataTable dt4 = new DataTable();
            dt4 = QuanLySinhVienDAO.getTenSVByTenKhoa("L004");

            TreeNode rootNode5 = new TreeNode("DH Du lịch khóa 2023");
            DataTable dt5 = new DataTable();
            dt5 = QuanLySinhVienDAO.getTenSVByTenKhoa("L005");


            treeView1.Nodes.Add(rootNode1);
            treeView1.Nodes.Add(rootNode2);
            treeView1.Nodes.Add(rootNode3);
            treeView1.Nodes.Add(rootNode4);
            treeView1.Nodes.Add(rootNode5);





            int Sonv1 = dt1.Rows.Count;

            for (int i = 0; i < Sonv1; i++)
            {
                TreeNode childNode = new TreeNode(dt1.Rows[i][0].ToString());
                rootNode1.Nodes.Add(childNode);
            }

            int Sonv2 = dt2.Rows.Count;

            for (int i = 0; i < Sonv2; i++)
            {
                TreeNode childNode = new TreeNode(dt2.Rows[i][0].ToString());
                rootNode2.Nodes.Add(childNode);
            }

            int Sonv3 = dt3.Rows.Count;

            for (int i = 0; i < Sonv3; i++)
            {
                TreeNode childNode = new TreeNode(dt3.Rows[i][0].ToString());
                rootNode3.Nodes.Add(childNode);
            }

            int Sonv4 = dt4.Rows.Count;

            for (int i = 0; i < Sonv4; i++)
            {
                TreeNode childNode = new TreeNode(dt4.Rows[i][0].ToString());
                rootNode4.Nodes.Add(childNode);
            }

            int Sonv5 = dt5.Rows.Count;

            for (int i = 0; i < Sonv5; i++)
            {
                TreeNode childNode = new TreeNode(dt5.Rows[i][0].ToString());
                rootNode5.Nodes.Add(childNode);
            }

        



        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                string nodeName = e.Node.Text;
                MessageBox.Show($"childnode: {nodeName}");

                DataTable dt = new DataTable();
                dt = QuanLySinhVienDAO.getInfoSVByName(nodeName);

                tbMaSV.Text = dt.Rows[0][0].ToString();
                tbTenSV.Text = dt.Rows[0][1].ToString();
                tbSDT.Text = dt.Rows[0][5].ToString();
                tbDiaChi.Text = dt.Rows[0][4].ToString();
                cbLopHoc.Text = e.Node.Parent.ToString();
                DateTime parsedDateTime = DateTime.Parse(dt.Rows[0][3].ToString());
                dtNgaySinh.Value = parsedDateTime;

                if(dt.Rows[0][2].ToString().Trim() == "True")
                {
                    rbNam.Checked = true;
                    rbNu.Checked = false;
                }
                else
                {
                    rbNu.Checked = true;
                    rbNam.Checked = false;
                }


            }
            else
            {
                string rootNodeName = e.Node.Text;
                MessageBox.Show($"rootnode: {rootNodeName}");
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = QuanLySinhVienDAO.getCountSV();


            tbMaSV.Text = "SV0" + (int.Parse(dt.Rows[0][0].ToString()) + 1).ToString();

        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            string gioitinh = rbNam.Checked ? "Nam" : "Nữ";  // Use meaningful values for gender

            SinhVienDTO csv = new SinhVienDTO();

            QuanLySinhVienDAO.insertSinhVien(csv);



        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            string gioitinh = rbNam.Checked ? "Nam" : "Nữ";  // Use meaningful values for gender
            SinhVienDTO csv = new SinhVienDTO();

            QuanLySinhVienDAO.updateSV(csv,cbLopHoc.Text);

        }
    }
}
