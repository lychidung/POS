using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayPOS.DTO
{
    public class ThucDon
    {
        public ThucDon(int id_monan, string tenmonan, int id_theloaimon, double gia, string mota, string hinhmonan)
        {
            this.ID_monan = id_monan;
            this.Tenmonan = tenmonan;
            this.ID_theloaimon = id_theloaimon;
            this.Gia = gia;
            this.Mota = mota;
            this.Hinhmonan = hinhmonan;
        }

        public ThucDon(DataRow row)
        {
            this.ID_monan = (int)row["ID"];
            this.Tenmonan = row["Tên Món Ăn"].ToString();
            this.ID_theloaimon = (int)row["ID Thể Loại"];
            this.Gia = (double)row["Đơn Giá"];
            this.Mota = row["Mô Tả"].ToString();
            this.Hinhmonan = row["Hình Ảnh"].ToString();
        }

        private int id_monan;

        public int ID_monan
        {
            get { return id_monan; }
            set { id_monan = value; }
        }

        private string tenmonan;

        public string Tenmonan
        {
            get { return tenmonan; }
            set { tenmonan = value; }
        }

        private int id_theloaimon;

        public int ID_theloaimon
        {
            get { return id_theloaimon; }
            set { id_theloaimon = value; }
        }

        private double gia;

        public double Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        private string mota;

        public string Mota
        {
            get { return mota; }
            set { mota = value; }
        }

        private string hinhmonan;

        public string Hinhmonan
        {
            get { return hinhmonan; }
            set { hinhmonan = value; }
        }
    }
}
