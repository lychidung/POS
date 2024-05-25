using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayPOS.DTO
{
    public class TheLoaiMon
    {
        public TheLoaiMon(int id_theloaimon, string tentheloai)
        {
            this.Id_Theloaimon = id_theloaimon;
            this.Tentheloai = tentheloai;
        }

        public TheLoaiMon(DataRow row)
        {
            this.Id_Theloaimon = (int)row["ID_theloaimon"];
            this.Tentheloai = row["Tentheloai"].ToString();
        }

        private int id_Theloaimon;

        public int Id_Theloaimon
        {
            get { return id_Theloaimon; }
            set { id_Theloaimon = value; } 
        }

        private string tentheloai;

        public string Tentheloai
        {
            get { return tentheloai; }
            set { tentheloai = value; }
        }
    }
}
