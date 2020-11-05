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
namespace ChatBox_v3
{
    public partial class Login : Form
    {       
        public Login()
        {
            InitializeComponent();
        }     
        
        private void button2_Click(object sender, EventArgs e)
        {            
            StreamReader sr = new StreamReader("taikhoan.txt");
            string tk = sr.ReadLine();
            string mk=sr.ReadLine();
            int count = 0;
            while(mk!=null)
            {                 
                if (taikhoan.Text == tk && matkhau.Text == mk)
                {
                    StreamWriter sr1 = new StreamWriter("tkdangnhap.txt");
                    sr1.WriteLine(tk);
                    sr1.Close();                  
                    Client cl = new Client();
                    cl.Show();
                    this.Hide();
                    count++;
                }
                tk = sr.ReadLine();
                mk = sr.ReadLine();               
            }
            if(count==0)
            {
                MessageBox.Show("Lỗi", "Thông báo");
                matkhau.Text = "";
            }                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.Show();
        }


    }
}
