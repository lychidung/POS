using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MayPOS.DAO
{
    public class HoaDon
    {
        private static HoaDon instance;
        public static HoaDon Instance
        {
            get { if (instance == null) instance = new HoaDon(); return instance; }
            private set { instance = value; }
        }
        private HoaDon() { }
        public DataTable LoadDataToDataTable_HD()
        {
            string query = @"SELECT hd.ID_hoadon, td.Tenmonan, td.Gia, hd.Ngaylapdon, hd.Thoigianlapdon,
                SUM(ct.Dongia * ct.Soluong) AS TongTien, tk.TenNV, tk.Capbac, tk.Username, tk.DiemThuong 
                FROM tb_hoadon hd 
                INNER JOIN tb_chitiethoadon ct ON hd.ID_hoadon = ct.ID_hoadon 
                INNER JOIN tb_thucdon td ON ct.ID_monan = td.ID_monan 
                INNER JOIN tb_taikhoan tk ON ct.Username = tk.Username 
                GROUP BY hd.ID_hoadon, td.Tenmonan, td.Gia, hd.Ngaylapdon, hd.Thoigianlapdon, tk.TenNV, tk.Capbac, tk.Username, tk.DiemThuong";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable TongDoanhThu(string daySelected)
        {
            string query = string.Format(@"SELECT SUM(Soluong*Dongia) TONGDT
                                        FROM tb_hoadon
                                        JOIN tb_chitiethoadon ON tb_hoadon.ID_hoadon = tb_chitiethoadon.ID_hoadon
                                        WHERE Ngaylapdon = '{0}'", daySelected);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }

        public DataTable LoadDataHoaDonDate(string day)
        {
            string query = string.Format(@"SELECT hd.ID_hoadon, hd.Ngaylapdon, hd.Thoigianlapdon,
                            SUM(ct.Dongia * ct.Soluong) AS TongTien, tk.TenNV, tk.Capbac, tk.Username, tk.DiemThuong 
                            FROM tb_hoadon hd 
                            INNER JOIN tb_chitiethoadon ct ON hd.ID_hoadon = ct.ID_hoadon 
                            INNER JOIN tb_taikhoan tk ON ct.Username = tk.Username 
                            WHERE hd.Ngaylapdon = '{0}'
                            GROUP BY hd.ID_hoadon, hd.Ngaylapdon, hd.Thoigianlapdon, tk.TenNV, tk.Capbac, tk.Username, tk.DiemThuong", day);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable LoadDataNhanVien()
        {
            string query = "SELECT tb_taikhoan.TenNV, tb_taikhoan.Capbac, tb_taikhoan.Username, SUM(tb_chitiethoadon.Soluong*tb_chitiethoadon.Dongia) AS TongTien, CAST(ROUND(SUM(tb_chitiethoadon.Soluong * tb_chitiethoadon.Dongia * 0.00001), 0) AS INT) AS DiemThuong FROM tb_taikhoan JOIN tb_chitiethoadon ON tb_taikhoan.Username = tb_chitiethoadon.Username GROUP BY tb_taikhoan.TenNV, tb_taikhoan.Capbac, tb_taikhoan.Username";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable Insert_HoaDon()
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string time = DateTime.Now.ToString("HH:mm:ss");
            string query = string.Format("INSERT INTO tb_hoadon (Ngaylapdon, Thoigianlapdon) OUTPUT inserted.ID_hoadon VALUES('{0}', '{1}');", date, time);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }

        public bool Insert_ChiTietHoaDon(int ID_hoadon, int ID_monan, int Soluong, int Dongia, string Username)
        {
            string query = string.Format("INSERT INTO tb_chitiethoadon (ID_hoadon, ID_monan, Soluong, Dongia, Username) VALUES ({0}, {1}, {2}, {3}, N'{4}')", ID_hoadon, ID_monan, Soluong, Dongia, Username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        
    }
}
