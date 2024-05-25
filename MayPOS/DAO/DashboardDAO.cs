using MayPOS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace MayPOS.DAO
{
    public class DashboardDAO
    {
        private static DashboardDAO instance;
        public static DashboardDAO Instance
        {
            get { if (instance == null) instance = new DashboardDAO(); return instance; }
            private set { instance = value; }
        }
        private DashboardDAO() { }

        public List<Dashboard> LoadDashboard(int month, int year)
        {
            List<Dashboard> list = new List<Dashboard>();
            string query = string.Format("SELECT COALESCE(SUM(ISNULL(dbo.tb_chitiethoadon.Dongia, 0) * ISNULL(dbo.tb_chitiethoadon.Soluong, 0)), 0) AS TongDoanhThu,\r\n       COUNT(DISTINCT dbo.tb_hoadon.ID_hoadon) AS SoDonHang\r\nFROM dbo.tb_chitiethoadon\r\nJOIN dbo.tb_hoadon ON dbo.tb_chitiethoadon.ID_hoadon = dbo.tb_hoadon.ID_hoadon\r\nWHERE MONTH(dbo.tb_hoadon.Ngaylapdon) = {0} AND YEAR(dbo.tb_hoadon.Ngaylapdon) = {1}", month, year);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Dashboard dashBoard = new Dashboard(row);
                list.Add(dashBoard);
            }

            return list;
        }

        public DataTable GetTop5(int month, int year)
        {
            string query = string.Format("SELECT TOP 5 tb_thucdon.Tenmonan AS [Tên món ăn], SUM(tb_chitiethoadon.Soluong) AS [Tổng số lượng]\r\nFROM tb_thucdon\r\nINNER JOIN tb_chitiethoadon ON tb_thucdon.ID_monan = tb_chitiethoadon.ID_monan\r\nINNER JOIN tb_hoadon ON tb_chitiethoadon.ID_hoadon = tb_hoadon.ID_hoadon\r\nWHERE MONTH(dbo.tb_hoadon.Ngaylapdon) = {0} AND YEAR(dbo.tb_hoadon.Ngaylapdon) = {1}\r\nGROUP BY tb_thucdon.Tenmonan, tb_thucdon.ID_monan\r\nORDER BY [Tổng số lượng] DESC", month, year);
            DataTable gettop5 = DataProvider.Instance.ExecuteQuery(query);
            return gettop5;
        }

    }
}
