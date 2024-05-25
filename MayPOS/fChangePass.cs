using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MayPOS.DAO;
using MayPOS.DTO;
using static MayPOS.Login;

namespace MayPOS
{
    public partial class fChangePass : Form
    {
        public fChangePass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string oldPass = txt_OldPass.Text;
            string newPass = txt_NewPass.Text;
            string againPass = txt_AgainPass.Text;
            if (AccountDAO.Instance.checkDangnhap(GlobalUsername.UsernameGlobal, oldPass))
            {
                if (!newPass.Equals("") && newPass.Length > 3)
                {
                    if (newPass.Equals(againPass))
                    {
                        if (AccountDAO.Instance.Update_Password(GlobalUsername.UsernameGlobal, newPass))
                        {
                            if (MessageBox.Show("THAY ĐỔI MẬT KHẨU THÀNH CÔNG", "Thông Báo", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                        else
                            MessageBox.Show("LỖI THAY ĐỔI MẬT KHẨU");
                    }
                    else
                        MessageBox.Show("MẬT KHẨU NHẬP LẠI KHÔNG ĐÚNG");
                }
                else
                    MessageBox.Show("MẬT KHẨU KHÔNG ĐƯỢC ĐỂ TRỐNG VÀ PHẢI LỚN HƠN 3 KÝ TỰ");
            }
            else
                MessageBox.Show("MẬT KHẨU CŨ KHÔNG ĐÚNG");
        }
    }
}
