using Guna.UI2.WinForms;
using MayPOS.DAO;
using MayPOS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayPOS
{
    public partial class UC_theloai_admin : UserControl
    {
        public UC_theloai_admin()
        {
            InitializeComponent();
            LoadTheLoai();
        }

        private void guna2HtmlToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void UC_theloai_admin_Load(object sender, EventArgs e)
        {

        }

        public void LoadTheLoai()
        {
            FlowLayerTheLoai.Controls.Clear();
            List<TheLoai_Admin> theloai = TheLoaiDAO.Instance.LoadTheLoaiList_admin();
            foreach (TheLoai_Admin item in theloai)
            {
                UC_theloai_admin_sub uC_Theloai = new UC_theloai_admin_sub(item.SoLuongLoai, item.ID_theloaimon, item.GiaCaoNhat, item.GiaThapNhat, item.Hinhbanner, item.Tentheloai);
                FlowLayerTheLoai.Controls.Add(uC_Theloai);
                Panel cardPanel = uC_Theloai.PanelAllLoaiClick;
                Label cardPanel1 = uC_Theloai.TenLoaiClick;
                Label cardPanel2 = uC_Theloai.ThongkemonClick;
                Label cardPanel3 = uC_Theloai.ThongkegiaClick;
                PictureBox cardPanel4 = uC_Theloai.HinhLoaiClick;
                Panel cardPanel5 = uC_Theloai.PanelAllLoai1Click;

                cardPanel.Click += Click;
                cardPanel1.Click += Click;
                cardPanel2.Click += Click;
                cardPanel3.Click += Click;
                cardPanel4.Click += Click;
                cardPanel5.Click += Click;

                void Click(object sender, EventArgs e)
                {
                    FormCollection fc = Application.OpenForms;

                    foreach (Form frm in fc)
                    {
                        //iterate through
                        if (frm.Name == "fAdminMain")
                        {
                            fAdminMain f = (fAdminMain)frm;
                            Guna2Panel fr = f.GetPanel();
                            UC_ThucDonMain uc = new UC_ThucDonMain(item.ID_theloaimon);
                            fr.Controls.Clear();
                            fr.Controls.Add(uc);
                        }
                    }
                }
            }
        }

        private void AddLoai_Click(object sender, EventArgs e)
        {
            ThemDanhMuc themdanhmuc = new ThemDanhMuc();
            themdanhmuc.ShowDialog();
        }
    }
}
