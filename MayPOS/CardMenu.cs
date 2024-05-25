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
    public partial class CardMenu : UserControl
    {
        public CardMenu(string ten, string gia, string hinhmonan)
        {
            InitializeComponent();
            Tenmonan.Text = ten;
            Giamonan.Text = gia;
            try
            {
                Anhmonan.Image = Image.FromFile(GlobalDirection.PathLinkGlobal + "\\images\\" + hinhmonan + "");

            }
            catch { }
        }


        public string tenmon { get; set; }
        public string giamon { get; set; }

        public Panel CardpanelClick
        {
            get { return PanelCard; } 
        }

        public Label TenmonanClick
        {
            get { return Tenmonan; }
        }

        public Label GiamonanClick
        {
            get { return Giamonan; }
        }

        public PictureBox AnhmonanClick
        {
            get { return Anhmonan; }   
        }
    }
}
