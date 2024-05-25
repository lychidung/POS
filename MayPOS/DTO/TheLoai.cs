using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayPOS.DTO
{
    public class TheLoai
    {
        public TheLoai(int iD_theloaimon, string tentheloai, string hinhtheloai)
        {
            this.ID_theloaimon = iD_theloaimon;
            this.Tentheloai = tentheloai;
            this.Hinhtheloai = hinhtheloai;
        }

        public TheLoai(DataRow row)
        {
            this.ID_theloaimon = (int)row["ID_theloaimon"];
            this.Tentheloai = row["Tentheloai"].ToString();
            this.Hinhtheloai = row["Hinhtheloai"].ToString();
        }

        private int iD_theloaimon;
        private string tentheloai;
        private string hinhtheloai;

        public int ID_theloaimon { get => iD_theloaimon; set => iD_theloaimon = value; }
        public string Tentheloai { get => tentheloai; set => tentheloai = value; }
        public string Hinhtheloai { get => hinhtheloai; set => hinhtheloai = value; }
    }

    

}
