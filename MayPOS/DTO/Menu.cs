    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Security.Principal;
    using System.Text;
    using System.Threading.Tasks;

namespace MayPOS.DTO
    {
    //ID_monan INT IDENTITY PRIMARY KEY,
    //Tenmonan NVARCHAR(100) NOT NULL,
    //ID_theloaimon INT,
    //Gia FLOAT NOT NULL DEFAULT 0,
    //Mota NVARCHAR(100) NOT NULL,
    //Hinhmonan NVARCHAR(100) NOT NULL,
public class Menu
{
        public Menu(int iD_monan, string tenmonan, int iD_theloaimon, string gia, string mota, string hinhmonan)
        {
            this.ID_monan = iD_monan;
            this.Tenmonan = tenmonan;
            this.ID_theloaimon = iD_theloaimon;
            this.Gia = gia;
            this.Mota = mota;
            this.Hinhmonan = hinhmonan;
        }

        public Menu(DataRow row)
        {
            this.ID_monan = (int)row["ID_monan"];
            this.Tenmonan = row["Tenmonan"].ToString();
            this.ID_theloaimon = (int)row["ID_theloaimon"];
            this.Gia = row["Gia"].ToString();
            this.Mota = row["Mota"].ToString();
            this.Hinhmonan = row["Hinhmonan"].ToString();
        }

        private int iD_monan;
        private string tenmonan;

        public int ID_monan
        {
            get { return iD_monan; }
            set { iD_monan = value; }
        }

        public string Tenmonan
        {
            get { return tenmonan; }
            set { tenmonan = value; }
        }

        public int ID_theloaimon { get => iD_theloaimon; set => iD_theloaimon = value; }
        public string Gia { get => gia; set => gia = value; }
        public string Mota { get => mota; set => mota = value; }
        public string Hinhmonan { get => hinhmonan; set => hinhmonan = value; }

        private int iD_theloaimon;
        private string gia;
        private string mota;
        private string hinhmonan;

    }
}
