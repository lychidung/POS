using MayPOS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayPOS.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }

        public bool Update_Password(string Username, string Pass)
        {
            string query = string.Format("UPDATE dbo.tb_taikhoan SET Pass = N'{0}' WHERE Username = N'{1}'", Pass, Username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool Update_ThongTinAccount(string ten, string hinhanh, string Username)
        {
            string query = string.Format("UPDATE dbo.tb_taikhoan SET TenNV = N'{0}', Hinh = N'{1}' WHERE Username = N'{2}'", ten, hinhanh, Username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool checkDangnhap(string username, string pass)
        {
            string query = "USP_Login @userName , @pass";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new Object[] {username, pass});
            return result.Rows.Count > 0;
        }

        public List<TaiKhoan> LoadThongTinList(string username)
        {
            List<TaiKhoan> taikhoanList = new List<TaiKhoan>();
            string query = "SELECT * FROM tb_taikhoan WHERE Username =" + "'" +username + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TaiKhoan taikhoan = new TaiKhoan(item);
                taikhoanList.Add(taikhoan);
            }
            return taikhoanList;
        }

        public bool CongDiemNhanVien(string username, int diem)
        {
            string query = string.Format("UPDATE dbo.tb_taikhoan SET DiemThuong = DiemThuong + {0} WHERE Username = N'{1}'", diem, username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable LoadAccount()
        {
            string query = string.Format("select * from tb_taikhoan");

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public bool Xoa_ThongTinAccount_Admin(string username)
        {
            string query = string.Format("DELETE FROM dbo.tb_taikhoan WHERE Username = N'{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool Update_ThongTinAccount_Admin(string ten, string hinhanh, string Username, int diem, int capbac)
        {
            string query = string.Format("UPDATE dbo.tb_taikhoan SET TenNV = N'{0}', Hinh = N'{1}', DiemThuong = {3} ,Capbac = {4} WHERE Username = N'{2}'", ten, hinhanh, Username, diem, capbac);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool Them_Account(string ten, string hinhanh, string Username, int diem, string pass, int capbac)
        {
            string query = string.Format("INSERT INTO dbo.tb_taikhoan (Username, TenNV, Pass, Capbac, Hinh, Diemthuong) VALUES (N'{0}', N'{1}', N'{2}', {3}, N'{4}', {5})", Username, ten, pass, capbac, hinhanh, diem);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
