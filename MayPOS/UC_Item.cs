using Guna.UI2.WinForms;
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
    public partial class UC_Item : UserControl
    {
        private int Thutuchon, ID_mon, Dongia;
        public UC_Item(int ID, string ten, int gia, string hinh, int thutuchon)
        {
            InitializeComponent();
            this.ID_mon = ID;
            this.Thutuchon = thutuchon;
            this.Dongia = gia;
            Tenmonchon.Text = ten;
            Giachon.Text = gia.ToString();
            try
            {
                Hinhchon.Image = Image.FromFile(GlobalDirection.PathLinkGlobal + "\\images\\" + hinh + "");
            }
            catch
            {
                return;
            }
        }

        public int LayDonGia()
        {
            return Dongia;
        }

        public int LayID_Mon()
        {
            return ID_mon;
        }

        public int LayThuTu()
        {
            return Thutuchon;
        }

        public Guna2NumericUpDown SoLuongMonClick
        {
            get { return SoLuongMon; }
        }

    }
}
