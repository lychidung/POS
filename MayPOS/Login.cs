using MayPOS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayPOS
{
    public partial class Login : Form
    {

        public class GlobalDirection
        {
            //public static string PathLinkGlobal = Directory.GetCurrentDirectory();
            public static string PathLinkGlobal = "C:\\Do Hoa May Tinh\\MayPOS";

        }
        public class GlobalUsername
        {
            public static string UsernameGlobal;
        }


        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        bool checkDangnhap(string username, string pass)
        {
            return AccountDAO.Instance.checkDangnhap(username, pass);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Environment.Exit(1);
            }
        }

        private void btnLogin_Click_2(object sender, EventArgs e)
        {
            string username = textUsername.Text;

            string pass = textPass.Text;
            if (checkDangnhap(username, pass))
            {
                GlobalUsername.UsernameGlobal = textUsername.Text;
                fManagerMain fmanagermain = new fManagerMain();
                this.Hide();
                fmanagermain.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu vui lòng nhập lại !!");
            }
        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}