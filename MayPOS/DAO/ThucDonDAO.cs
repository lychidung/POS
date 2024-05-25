using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MayPOS.DTO;

namespace MayPOS.DAO
{
    public class ThucDonDAO
    {
        private static ThucDonDAO instance;
        public static ThucDonDAO Instance
        {
            get { if (instance == null) instance = new ThucDonDAO(); return instance; }
            private set { instance = value; }
        }
        private ThucDonDAO() { }

        public DataTable LoadThucDon()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_ThucDon");
        }

        public DataTable LoadThucDonTheoLoai(int id)
        {
            string query = string.Format("SELECT ID_monan AS [ID], Tenmonan AS [Tên Món Ăn], ID_theloaimon AS [ID Thể Loại], Gia AS [Đơn Giá], Mota AS [Mô Tả], Hinhmonan AS [Hình Ảnh] FROM dbo.tb_thucdon WHERE ID_theloaimon = {0}", id);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchThucDon(string ten)
        {
            string query = string.Format("SELECT ID_monan AS [ID], Tenmonan AS [Tên Món Ăn], ID_theloaimon AS [ID Thể Loại], Gia AS [Đơn Giá], Mota AS [Mô Tả], Hinhmonan AS [Hình Ảnh] FROM dbo.tb_thucdon WHERE dbo.fuConvertToUnsign1(Tenmonan) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", ten);

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchThucDonTheoLoai(string ten, int id_loai)
        {
            string query = string.Format("SELECT ID_monan AS [ID], Tenmonan AS [Tên Món Ăn], ID_theloaimon AS [ID Thể Loại], Gia AS [Đơn Giá], Mota AS [Mô Tả], Hinhmonan AS [Hình Ảnh] FROM dbo.tb_thucdon WHERE dbo.fuConvertToUnsign1(Tenmonan) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' AND ID_theloaimon = {1}", ten, id_loai);

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool Them_ThucDon(string tenmonan, int id_theloaimon, float gia, string mota, string hinhmonan)
        {
            string query = string.Format("INSERT INTO dbo.tb_thucdon (Tenmonan, ID_theloaimon, Gia, Mota, Hinhmonan) VALUES (N'{0}', {1}, {2}, N'{3}', N'{4}')", tenmonan, id_theloaimon, gia, mota, hinhmonan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool Update_ThucDon(int id_monan, string tenmonan, int id_theloaimon, float gia, string mota, string hinhmonan)
        {
            string query = string.Format("UPDATE dbo.tb_thucdon SET Tenmonan = N'{0}', ID_theloaimon = {1}, Gia = {2}, MoTa = N'{3}', Hinhmonan = N'{4}' WHERE ID_monan = {5}", tenmonan, id_theloaimon, gia, mota, hinhmonan, id_monan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool Xoa_ThucDon(int id_monan)
        {
            string query = string.Format("DELETE dbo.tb_thucdon WHERE ID_monan = N'{0}'", id_monan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
