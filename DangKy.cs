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

namespace ChatBox_v3
{
    public partial class DangKy : Form
    {
        string tk1 = "hoangtrongbinh";
        
        string tk2 = "nguyenduylinh";
        
        string tk3 = "lethihuyen";
        
        string tk4 = "admin";
        
        public DangKy()
        {
            InitializeComponent();
        }

        private void bkiemtra_Click(object sender, EventArgs e)
        {
            if(taikhoan.Text==""||matkhau.Text=="")
                MessageBox.Show("Xin nhập đủ thông tin", "Thông báo");
            else if (taikhoan.Text!=tk1&& taikhoan.Text != tk2 && taikhoan.Text != tk3 && taikhoan.Text != tk4)
            {
                MessageBox.Show("Tài khoản OK", "Thông báo");
            }
            else
                MessageBox.Show("Tài khoản đã có người dùng", "Thông báo");
        }

        private void bdangky_Click(object sender, EventArgs e)
        {
            if(taikhoan.Text!=""&&matkhau.Text!=""&&admitmk.Text!=""&&matkhau.Text==admitmk.Text)
            {
                StreamWriter sr = new StreamWriter("taikhoan.txt",true);
                sr.WriteLine(taikhoan.Text);
                sr.WriteLine(matkhau.Text);
                sr.Close();
                MessageBox.Show("Đăng ký thành công", "Thông báo");
                this.Hide();
            }
            else if(matkhau.Text!=""&& matkhau.Text!=admitmk.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng", "Thông báo");
                admitmk.Text = "";
                matkhau.Text = "";
            }
        }
    }
}
