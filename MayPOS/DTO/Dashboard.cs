using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayPOS.DTO
{
    public class Dashboard
    {
        public Dashboard(int TongDoanhThu, int SoDonHang)
        {
            this.TongDoanhThu = TongDoanhThu;
            this.SoDonHang = SoDonHang;
        }

        public Dashboard(DataRow row)
        {
            this.TongDoanhThu = Convert.ToInt32(row["TongDoanhThu"]);
            this.SoDonHang = Convert.ToInt32(row["SoDonHang"]);
        }

        private int tongDoanhThu;
        public int TongDoanhThu
        {
            get { return tongDoanhThu; }
            set { tongDoanhThu = value; }
        }

        private int soDonHang;
        public int SoDonHang
        {
            get { return soDonHang; }
            set { soDonHang = value; }
        }

        // Các thuộc tính mới từ câu truy vấn thứ hai
        public string TenMonAn { get; set; }
        public int TongSoLuong { get; set; }

        // Constructor từ câu truy vấn thứ hai
        public Dashboard(string tenMonAn, int tongSoLuong)
        {
            TenMonAn = tenMonAn;
            TongSoLuong = tongSoLuong;
        }

        // Phương thức để lấy dữ liệu từ DataRow của câu truy vấn thứ hai
        public static Dashboard FromDataRow(DataRow row)
        {
            string tenMonAn = row["Tenmonan"].ToString();
            int tongSoLuong = Convert.ToInt32(row["TongSoLuong"]);
            return new Dashboard(tenMonAn, tongSoLuong);
        }
    }
}