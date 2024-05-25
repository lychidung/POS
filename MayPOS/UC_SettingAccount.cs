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
    public partial class UC_inforAccount : UserControl
    {
        public UC_inforAccount()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "fManagerMain")
                {
                    frm.Close();
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UserSetting userSetting = new UserSetting();
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "fManagerMain")
                {
                    frm.Close();
                }
            }
            userSetting.ShowDialog();
        }
    }
}
