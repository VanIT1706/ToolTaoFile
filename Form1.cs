using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace slide22._1_tạo_thư_mục_và_file_hàng_loạt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath;
            }
            else
                MessageBox.Show("Bạn chưa chọn đường dẫn","Thông báo");
        }

        private void btnTaoFile_Click(object sender, EventArgs e)
        {
            if (txtPath.Text != "")
            {
                //check thư mục có tồn tại hay không, nếu không thì báo lỗi
                string path = txtPath.Text;
                if (Directory.Exists(path)){
                    //duyệt for để tao file hàng loạt
                    for(int i = 1; i <= int.Parse(txtSoLuong.Text) ; i++)
                    {
                        string PathCreate = path + @"\fileTest " + i + ".txt";
                        FileInfo f = new FileInfo(PathCreate);
                        f.Create();
                    }
                    MessageBox.Show("Đã tạo thành công");

                } else
                    MessageBox.Show("Đường dẫn không tồn tại");

            } else
                MessageBox.Show("Bạn chưa chọn đường dẫn", "Thông báo");
        }

        private void btnTaoThuMuc_Click(object sender, EventArgs e)
        {
            if (txtPath.Text != "")
            {
                if (Directory.Exists(txtPath.Text))
                {
                    for(int i = 1; i <= int.Parse(txtSoLuong.Text); i++)
                    {
                        string directoryCreate = txtPath.Text + @"\New Folder " + i;
                        DirectoryInfo d = new DirectoryInfo(directoryCreate);
                        d.Create();
                    }
                    MessageBox.Show("Tạo thư mục thành công");
                }
                else
                    MessageBox.Show("Đường dẫn không tồn tại");
            }
            else
                MessageBox.Show("bạn chưa nhập đường dẫn");
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thong báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
