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
using MayPOS.DAO;
using MayPOS.DTO;
using static MayPOS.Login;

namespace MayPOS
{
    public partial class UserSetting : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        private string path1 = "", path2 = "", defaultpath = GlobalDirection.PathLinkGlobal + "\\avatar\\", newPicture = "";
        void LoadThongTin(string username, string name, string level, string avatar, int diemthuong)
        {
            txt_UserName.Text = username;
            txt_Fullname.Text = name;
            txt_Levels.Text = level;
            txt_Avatar.Text = avatar;
            numeric_Points.Value = diemthuong;
        }

        void LayThongTin()
        {
            openFileDialog.Filter = "|*.jpg;*.png;*.img";
            List<TaiKhoan> taikhoan = AccountDAO.Instance.LoadThongTinList(GlobalUsername.UsernameGlobal);
            foreach (TaiKhoan item in taikhoan)
            {
                string capbac;
                if (item.Capbac == 0)
                    capbac = "Nhân Viên";
                else
                    capbac = "Quản Lý";
                LoadThongTin(GlobalUsername.UsernameGlobal, item.Tennv, capbac, item.Hinh, item.Diemthuong);
            }
        }

        private void UserSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void UserSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void button_SaveChange_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_ChangePass_Click(object sender, EventArgs e)
        {
            
        }

        private void button_SaveChange_Click_1(object sender, EventArgs e)
        {
            string ten = txt_Fullname.Text;
            string hinh = txt_Avatar.Text;
            if (!ten.Equals(""))
            {
                if (AccountDAO.Instance.Update_ThongTinAccount(ten, hinh, GlobalUsername.UsernameGlobal))
                {
                    if (!path1.Equals("") && !path2.Equals(""))
                    {
                        try
                        {
                            File.Copy(path1, path2, true);
                        }
                        catch { }
                    }
                    path1 = "";
                    path2 = "";
                    MessageBox.Show("CẬP NHẬT THÔNG TIN THÀNH CÔNG");
                }
                else
                    MessageBox.Show("LỖI CẬP NHẬT THÔNG TIN", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("TÊN KHÔNG ĐƯỢC ĐỂ TRỐNG!!!");
        }

        private void button_ChangePass_Click_1(object sender, EventArgs e)
        {
            fChangePass fChangePass = new fChangePass();
            fChangePass.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                newPicture = openFileDialog.SafeFileName;
                path1 = openFileDialog.FileName;
                path2 = defaultpath + newPicture;
                txt_Avatar.Text = newPicture;
            }
        }

        public UserSetting()
        {
            InitializeComponent();
            LayThongTin();
        }

        private void label_Settings_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
