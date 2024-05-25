using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace MayPOS
{
    public partial class Calculator : Form
    {
        public Calculator(double TongChinh)
        {
            InitializeComponent();
            numericThanhToan.Value = (decimal)TongChinh;
        }

        private void numericThua_ValueChanged(object sender, EventArgs e)
        {
        }



        private void btnCalcu_Click(object sender, EventArgs e)
        {
            int tien1 = (int)numericThanhToan.Value;
            int tien2 = (int)numericNhan.Value;
            int tienthua = tien2 - tien1;
            if (tienthua >= 0)
                numericThua.Value = tienthua;
            else
                numericThua.Value = 0;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if ((int)numericNhan.Value >= (int)numericThanhToan.Value && (int)numericThanhToan.Value > 0)
            {
                FormCollection fc = Application.OpenForms;

                foreach (Form frm in fc)
                {
                    //iterate through
                    if (frm.Name == "fManagerMain")
                    {
                        fManagerMain fr = (fManagerMain)frm;
                        fr.LoadHoaDon(true);
                        break;
                    }
                }
                this.Close();
            }
        }
    }
}
