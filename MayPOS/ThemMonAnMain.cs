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
using System.Windows.Forms;
using static MayPOS.Login;

namespace MayPOS
{
    public partial class ThemMonAnMain : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        private string path1 = "", path2 = "", defaultpath = GlobalDirection.PathLinkGlobal + "\\images\\", newPicture = "";
        public ThemMonAnMain()
        {
            openFileDialog.Filter = "|*.jpg;*.png;*.img";
            InitializeComponent();
            LoadTheLoaiThucDon(comboBoxTheLoaiMonThem);
        }

        void LoadTheLoaiThucDon(ComboBox cb)
        {
            cb.DataSource = TheLoaiMonDAO.Instance.LoadTheLoaiMon();
            cb.DisplayMember = "Tentheloai";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ThemMonForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void buttonThemMon_Click_1(object sender, EventArgs e)
        {
            string tenmonan = textBoxTenMonAn.Text;
            int theloaimon = (comboBoxTheLoaiMonThem.SelectedItem as TheLoaiMon).Id_Theloaimon;
            float gia = (float)numericGiaThem.Value;
            string hinhanh = textBoxHinhAnh.Text;
            string mota = textBoxMoTa.Text;
            if (!tenmonan.Equals(""))
            {
                if (ThucDonDAO.Instance.Them_ThucDon(tenmonan, theloaimon, gia, mota, hinhanh))
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
                    MessageBox.Show("THÊM MÓN THÀNH CÔNG!");
                }
                else
                {
                    MessageBox.Show("THÊM KHÔNG THÀNH CÔNG!");
                }
            }
            else
            {
                MessageBox.Show("TÊN MÓN ĂN CHƯA CÓ!");
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
