using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MayPOS.Login;

namespace MayPOS
{
    public partial class UC_theloai : UserControl
    {
        public UC_theloai(String tentheloai, string hinhtheloai)
        {
            InitializeComponent();
            TenLoai.Text = tentheloai;
            try
            {
                HinhLoai.Image = Image.FromFile(GlobalDirection.PathLinkGlobal + "\\icon-theloai-mon\\" + hinhtheloai + "");
            }
            catch { }
        }

        public Panel CardpanelClick
        {
            get { return PanelLoai; }
        }

        public Label TenLoaiClick
        {
            get { return TenLoai; }
        }

        public PictureBox HinhLoaiClick
        {
            get { return HinhLoai; }
        }
    }
}
