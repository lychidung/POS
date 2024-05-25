using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MayPOS.DTO;

namespace MayPOS.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> LoadMenuList()
        {
            List<Menu> menuList = new List<Menu>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetMenuList");

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                menuList.Add(menu);
            }

            return menuList;
        }

        public List<Menu> LoadMenuListTheoID(int id)
        {
            List<Menu> menuList = new List<Menu>();
            string query = "SELECT * FROM tb_thucdon WHERE ID_theloaimon = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                menuList.Add(menu);
            }

            return menuList;
        }

        public List<Menu> SearchMenu(string ten)
        {
            List<Menu> menuList = new List<Menu>();
            string query = string.Format("SELECT * FROM dbo.tb_thucdon WHERE dbo.fuConvertToUnsign1(Tenmonan) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", ten);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                menuList.Add(menu);
            }

            return menuList;
        }
    }
}
