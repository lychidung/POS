using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayPOS.DTO
{
    public class TheLoai_Admin
    {
        public TheLoai_Admin(int iD_theloaimon, string tentheloai, string Hinhbanner)
        {
            this.ID_theloaimon = iD_theloaimon;
            this.Tentheloai = tentheloai;
            this.Hinhbanner = Hinhbanner;
        }

        public TheLoai_Admin(DataRow row)
        {
            this.ID_theloaimon = (int)row["ID_theloaimon"];
            this.Tentheloai = row["Tentheloai"].ToString();
            this.Hinhbanner = row["Hinhbanner"].ToString();
            this.SoLuongLoai = (int)row["SoLuongLoai"];
            this.giacaonhat = row["GiaCaoNhat"].ToString();
            this.giathapnhat = row["GiaThapNhat"].ToString();
        }

        private int iD_theloaimon;
        private string tentheloai;
        private string hinhbanner;

        private int soluongloai;
        private string giacaonhat;
        private string giathapnhat;
        public int SoLuongLoai { get => soluongloai; set => soluongloai = value; }
        public string GiaCaoNhat { get => giacaonhat; set => giacaonhat = value; }
        public string GiaThapNhat { get => giathapnhat; set => giathapnhat = value; }





        public int ID_theloaimon { get => iD_theloaimon; set => iD_theloaimon = value; }
        public string Tentheloai { get => tentheloai; set => tentheloai = value; }
        public string Hinhbanner { get => hinhbanner; set => hinhbanner = value; }
    }

}
