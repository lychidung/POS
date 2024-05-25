using System;
using MayPOS.DAO;
using MayPOS.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MayPOS.fManagerMain;

namespace MayPOS
{
    public partial class UC_Dashboard : UserControl
    {
        private int tongDoanhThu;
        private int soDonHang;

        int month = (int)DateTime.Now.Month;
        int year = (int)DateTime.Now.Year;

        void LoadDashboard()
        {
            List<Dashboard> dt = DashboardDAO.Instance.LoadDashboard(month, year);
            foreach (Dashboard dash in dt)
            {
                tongDoanhThu = dash.TongDoanhThu;
                soDonHang = dash.SoDonHang;
            }
            LoadDuLieu();
            LoadTop5();
        }

        void LoadDuLieu()
        {
            textBox1.Text = tongDoanhThu.ToString("0,0") + " đ";
            textBox2.Text = soDonHang.ToString();
        }

        void LoadTop5()
        {
            DataTable dt = DashboardDAO.Instance.GetTop5(month, year);
            dataGridView1.DataSource = dt;
        }

        public UC_Dashboard()
        {
            InitializeComponent();
            CustomMonth();
            LoadDashboard();
            LoadThue();
        }

        void LoadThue()
        {
            numeric_Thue.Value = GlobalRate.Rate;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int selectedMonth = dateTimePicker1.Value.Month;
            month = selectedMonth;
            int selectedYear = dateTimePicker1.Value.Year;
            year = selectedYear;
            LoadDashboard();
            //LoadTop5();
        }

        void CustomMonth()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/yyyy";
            dateTimePicker1.ShowUpDown = true;
            DateTime newDateValue = new DateTime(year, month, 1);
            dateTimePicker1.Value = newDateValue;
        }

        private void btn_Save_thue_Click(object sender, EventArgs e)
        {
            string query = string.Format("UPDATE dbo.tb_thue SET Thue = {0}", numeric_Thue.Value);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
            {
                GlobalRate.Rate = (int)numeric_Thue.Value;
                MessageBox.Show("THAY ĐỔI THUẾ THÀNH CÔNG");
            }
        }
    }
}