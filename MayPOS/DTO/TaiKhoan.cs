using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayPOS.DTO
{
    public class TaiKhoan
    {
        public TaiKhoan(string tennv,int capbac,string hinh,int diemthuong)
        {
            this.Tennv = tennv;
            this.Capbac = capbac;      
            this.Hinh = hinh;
            this.Diemthuong = diemthuong;
        }

        public TaiKhoan(DataRow row)
        {
            this.Tennv = row["TenNV"].ToString();
            this.Capbac = (int)row["Capbac"];
            this.Hinh = row["Hinh"].ToString();
            this.Diemthuong = (int)row["DiemThuong"];
        }

        private string tennv;
        private int capbac;
        private string hinh;
        private int diemthuong;

        public string Tennv { get => tennv; set => tennv = value; }
        public int Capbac { get => capbac; set => capbac = value; }
        public string Hinh { get => hinh; set => hinh = value; }
        public int Diemthuong { get => diemthuong; set => diemthuong = value; }
    }
}
