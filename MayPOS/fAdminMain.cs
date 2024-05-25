using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace MayPOS
{
    public partial class fAdminMain : Form
    {
        private UserControl currentPanel;

        public fAdminMain()
        {
            InitializeComponent();
            currentPanel = new UC_Dashboard();
            AddPanelMainForm(currentPanel);
        }

        public Guna2Panel GetPanel()
        {
            return PanelMain;
        }

        private void AddPanelMainForm(UserControl panel)
        {
            panel.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(panel);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            currentPanel = new UC_theloai_admin();
            AddPanelMainForm(currentPanel);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            currentPanel = new UC_ThucDonMain();
            AddPanelMainForm(currentPanel);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            currentPanel = new UC_hoadon();
            AddPanelMainForm(currentPanel);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            currentPanel = new UC_Dashboard();
            AddPanelMainForm(currentPanel);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            currentPanel = new UC_taikhoan();
            AddPanelMainForm(currentPanel);
        }
    }
}
