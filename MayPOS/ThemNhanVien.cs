using MayPOS.DAO;
using MayPOS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static MayPOS.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MayPOS
{
    
    public partial class ThemNhanVien : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        private string path1 = "", path2 = "", defaultpath = GlobalDirection.PathLinkGlobal + "\\avatar\\", newPicture = "";
        public ThemNhanVien()
        {
            openFileDialog.Filter = "|*.jpg;*.png;*.img";
            InitializeComponent();
            btnXoa.Visible = false;
            btnCapNhat.Visible = false;
        }
        public ThemNhanVien(string tennv, string username, int capBac, int diemthuong, string hinhanh)
        {
            openFileDialog.Filter = "|*.jpg;*.png;*.img";
            InitializeComponent();
            textBoxUsername.ReadOnly = true;
            textBoxUsername.Text = username;
            textBoxHoTen.Text = tennv;
            comboBoxCapBac.SelectedIndex = capBac;
            numericDiemThuong.Value = diemthuong;
            textBoxHinhAnh.Text = hinhanh;
            tuychinh_chitiet();
        }

        void tuychinh_chitiet()
        {
            btnTaoTK.Visible = false;
            panel1.Visible = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = textBoxUsername.Text;

            try
            {
                AccountDAO.Instance.Xoa_ThongTinAccount_Admin(id);
                MessageBox.Show("XÓA THÀNH CÔNG TÀI KHOẢN: "+id);
                this.Close();
            }
            catch
            {
                MessageBox.Show("XÓA KHÔNG THÀNH CÔNG");
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string tennv = textBoxHoTen.Text;
            string hinhnv = textBoxHinhAnh.Text;
            int diem = (int)numericDiemThuong.Value;

            int capbac = comboBoxCapBac.SelectedIndex;
            if (!username.Equals(""))
            {
                if (AccountDAO.Instance.Update_ThongTinAccount_Admin(tennv, hinhnv, username, diem, capbac))
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
                    MessageBox.Show("TẠO TÀI KHOẢN THÀNH CÔNG!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("TẠO KHÔNG THÀNH CÔNG!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP USERNAME!");
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string pass = textBoxPass.Text;
            string tennv = textBoxHoTen.Text;
            string hinhnv = textBoxHinhAnh.Text;
            int diem =(int)numericDiemThuong.Value;

            int capbac = comboBoxCapBac.SelectedIndex;
            if (!username.Equals(""))
            {
                if (AccountDAO.Instance.Them_Account(tennv, hinhnv, username, diem, pass, capbac))
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
                    MessageBox.Show("TẠO TÀI KHOẢN THÀNH CÔNG!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("TẠO KHÔNG THÀNH CÔNG!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP USERNAME!");
            }
        }

        private void button_chonAnh_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                newPicture = openFileDialog.SafeFileName;
                path1 = openFileDialog.FileName;
                path2 = defaultpath + newPicture;
                textBoxHinhAnh.Text = newPicture;
            }
        }
    }
}
