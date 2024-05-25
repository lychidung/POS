using MayPOS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayPOS.DAO
{
    public class TheLoaiDAO
    {
        private static TheLoaiDAO instance;

        public static TheLoaiDAO Instance
        {
            get { if (instance == null) instance = new TheLoaiDAO(); return TheLoaiDAO.instance; }
            set { TheLoaiDAO.instance = value; }
        }

        private TheLoaiDAO() { }

        public List<TheLoai> LoadTheLoaiList()
        {
            List<TheLoai> theloaiList = new List<TheLoai>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTheLoaiList");
            foreach (DataRow item in data.Rows)
            {
                TheLoai theloai = new TheLoai(item);
                theloaiList.Add(theloai);
            }

            return theloaiList;
        
        }

        public List<TheLoai_Admin> LoadTheLoaiList_admin()
        {
            List<TheLoai_Admin> theloaiList = new List<TheLoai_Admin>();
            string query = "SELECT COUNT(tb_thucdon.ID_theloaimon) AS SoLuongLoai, MAX(tb_theloaimon.ID_theloaimon) AS ID_theloaimon, COALESCE(MAX(Gia),0) AS GiaCaoNhat, COALESCE(MIN(Gia),0) AS GiaThapNhat, Hinhbanner, Tentheloai FROM tb_theloaimon LEFT JOIN tb_thucdon ON tb_thucdon.ID_theloaimon = tb_theloaimon.ID_theloaimon GROUP BY tb_thucdon.ID_theloaimon, Hinhbanner, Tentheloai;";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TheLoai_Admin theloai = new TheLoai_Admin(item);
                theloaiList.Add(theloai);
            }
            return theloaiList;
        }

        public bool Update_Theloai(int id, string ten, string icon, string hinh)
        {
            string query = string.Format("UPDATE dbo.tb_theloaimon SET Tentheloai = N'{0}', Hinhtheloai = N'{1}', Hinhbanner = N'{2}' WHERE ID_theloaimon = {3}",ten,icon,hinh,id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool Add_Theloai(string ten, string icon, string hinh)
        {
            string query = string.Format("INSERT INTO dbo.tb_theloaimon(Tentheloai,Hinhtheloai,Hinhbanner) VALUES (N'{0}',N'{1}',N'{2}')", ten, icon, hinh);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool Delete_Theloai(int id)
        {
            string query = string.Format("DELETE FROM dbo.tb_theloaimon WHERE ID_theloaimon = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
