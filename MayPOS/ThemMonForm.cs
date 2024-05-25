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

namespace MayPOS
{
    public partial class ThemMonForm : Form
    {
        public ThemMonForm()
        {
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

        private void buttonThemMon_Click(object sender, EventArgs e)
        {
            string tenmonan = textBoxTenMonAn.Text;
            int theloaimon = (comboBoxTheLoaiMonThem.SelectedItem as TheLoaiMon).Id_Theloaimon;
            float gia = (float) numericGiaThem.Value;
            string hinhanh = textBoxHinhAnh.Text;
            string mota = textBoxMoTa.Text;
            if (!tenmonan.Equals(""))
            {
                if (ThucDonDAO.Instance.Them_ThucDon(tenmonan, theloaimon, gia, mota, hinhanh))
                {
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
    }
}
