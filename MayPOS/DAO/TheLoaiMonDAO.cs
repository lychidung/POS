using MayPOS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayPOS.DAO
{
    public class TheLoaiMonDAO
    {
        private static TheLoaiMonDAO instance;
        public static TheLoaiMonDAO Instance
        {
            get { if (instance == null) instance = new TheLoaiMonDAO(); return instance; }
            private set { instance = value; }
        }
        private TheLoaiMonDAO() { }

        public List<TheLoaiMon> LoadTheLoaiMon()
        {
            List<TheLoaiMon> list = new List<TheLoaiMon>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_TheLoaiMon");

            foreach (DataRow row in data.Rows) 
            {
                TheLoaiMon theLoaiMon = new TheLoaiMon(row);
                list.Add(theLoaiMon);
            }

            return list;
        }

        public TheLoaiMon Lay_TheLoaiMon(int id)
        {
            TheLoaiMon theLoaiMon = null;

            string query = "SELECT * FROM tb_theloaimon WHERE ID_theloaimon = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows) 
            {
                theLoaiMon = new TheLoaiMon(row);
                return theLoaiMon;
            }

            return theLoaiMon;
        }
    }
}
