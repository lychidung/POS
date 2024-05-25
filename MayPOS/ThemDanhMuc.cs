using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MayPOS.DAO;
using static MayPOS.Login;

namespace MayPOS
{
    public partial class ThemDanhMuc : Form
    {
        private int id;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        private string path1 = "", path2 = "", defaultpath = GlobalDirection.PathLinkGlobal + "\\icon-theloai-mon\\", newPicture1 = "", newPicture2 = "";
        public ThemDanhMuc()
        {
            openFileDialog.Filter = "|*.jpg;*.png;*.img";
            InitializeComponent();
        }

        public ThemDanhMuc(int id_danhmuc ,string tenDanhMuc, string iconDanhMuc, string hinhDanhMuc)
        {
            openFileDialog.Filter = "|*.jpg;*.png;*.img";
            InitializeComponent();
            Unlock_Settings();
            LoadTheLoaiSelect(id_danhmuc,tenDanhMuc,iconDanhMuc,hinhDanhMuc);
        }

        void Unlock_Settings()
        {
            button_Them.Visible = false;
            guna2Button1.Visible = true;
            guna2Button2.Visible = true;
        }

        void LoadTheLoaiSelect(int id_danhmuc, string tenDanhMuc, string iconDanhMuc, string hinhDanhMuc)
        {
            id = id_danhmuc;
            textBoxTenLoai.Text = tenDanhMuc;
            textBoxHinhLoai.Text = iconDanhMuc;
            textBoxHinhAnh.Text = hinhDanhMuc;
        }

        private void button_chonAnhIcon_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                newPicture1 = openFileDialog.SafeFileName;
                path1 = openFileDialog.FileName;
                path2 = defaultpath + newPicture1;
                textBoxHinhLoai.Text = newPicture1;
            }
        }

        private void ThemDanhMuc_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "fAdminMain")
                {
                    fAdminMain f = (fAdminMain)frm;
                    Guna2Panel fr = f.GetPanel();
                    foreach (System.Windows.Forms.Control ctrl in fr.Controls)
                    {
                        if (ctrl.Name == "UC_theloai_admin")
                        {
                            UC_theloai_admin uc = (UC_theloai_admin)ctrl;
                            uc.LoadTheLoai();
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void button_chonAnh_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                newPicture2 = openFileDialog.SafeFileName;
                path1 = openFileDialog.FileName;
                path2 = defaultpath + newPicture2;
                textBoxHinhAnh.Text = newPicture2;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string ten = textBoxTenLoai.Text;
            string icon = textBoxHinhLoai.Text;
            string hinh = textBoxHinhAnh.Text;
            if (!ten.Equals(""))
            {
                if (TheLoaiDAO.Instance.Update_Theloai(id, ten, icon, hinh))
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
                    MessageBox.Show("CẬP NHẬT DANH MỤC THÀNH CÔNG");
                }
                else
                    MessageBox.Show("LỖI CẬP NHẬT DANH MỤC");
            }
            else
                MessageBox.Show("TÊN DANH MỤC KHÔNG ĐƯỢC ĐỂ TRỐNG");
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            string ten = textBoxTenLoai.Text;
            string icon = textBoxHinhLoai.Text;
            string hinh = textBoxHinhAnh.Text;
            if (!ten.Equals(""))
            {
                if (TheLoaiDAO.Instance.Add_Theloai(ten, icon, hinh))
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
                    MessageBox.Show("THÊM DANH MỤC THÀNH CÔNG");
                }
                else
                    MessageBox.Show("LỖI THÊM DANH MỤC");
            }
            else
                MessageBox.Show("TÊN DANH MỤC KHÔNG ĐƯỢC ĐỂ TRỐNG");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (TheLoaiDAO.Instance.Delete_Theloai(id))
            {
                MessageBox.Show("XÓA DANH MỤC THÀNH CÔNG");
            }
            else
                MessageBox.Show("LỖI XÓA DANH MỤC");
        }
    }
}
