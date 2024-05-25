using iTextSharp.text.pdf;
using MayPOS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MayPOS.Login;
using static MayPOS.fManagerMain;

namespace MayPOS
{
    public partial class Bill : Form
    {
        string id;
        private double getRate = 0;
        public Bill(int id_donhang, string ngaylapdon, string tenNV, int tong, int tongGoc, string thoigianlapdon)
        {
            InitializeComponent();
            getRate = Math.Round(((double)tong/(double)tongGoc) - 1, 2, MidpointRounding.ToEven) * 100;
            TenNV.Text = tenNV;
            MaHoaDon.Text = "#Bill: " + id_donhang;
            NgayLapDon.Text = "Ngày thanh toán: " + thoigianlapdon + " " +ngaylapdon+ "";
            TongTien.Text = "Tổng tiền(Thuế " + getRate + "%): "+ tong.ToString("0,0") +"đ";
            LoadMonAnBill(id_donhang);
            id = id_donhang.ToString();
        }

        void LoadMonAnBill(int id_donhang)
        {
            // Tạo các cột cho DataGridView (nếu chưa tạo trong designer)
            HoaDonView.Columns.Add("TenMonAnColumn", "Tên Món Ăn");
            HoaDonView.Columns.Add("DonGiaColumn", "Đơn Giá");
            HoaDonView.Columns.Add("SoLuongColumn", "Số Lượng");
            HoaDonView.Columns.Add("Thành tiền", "Tổng Tiền(Thuế " + getRate + "%)");

            // Truy vấn SQL để lấy thông tin chi tiết các món ăn trong đơn hàng
            string query = $"SELECT td.Tenmonan, td.Gia AS [DonGiaGoc], ct.Dongia, ct.Soluong FROM tb_chitiethoadon ct INNER JOIN tb_thucdon td ON ct.ID_monan = td.ID_monan WHERE ct.ID_hoadon = {id_donhang}";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            
            if (result != null && result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    string tenMonAn = row["Tenmonan"].ToString();
                    int dongiaGoc = Convert.ToInt32(row["DonGiaGoc"]);
                    int donGia = Convert.ToInt32(row["Dongia"]);
                    int soLuong = Convert.ToInt32(row["Soluong"]);

                    int thanhTien = donGia * soLuong; // Tính thành tiền cho món ăn

                    HoaDonView.Rows.Add(tenMonAn, dongiaGoc, soLuong, thanhTien);
                }
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo tệp PDF mới
                string savePath =  GlobalDirection.PathLinkGlobal + "\\BillLog\\hoadon-" + id+".PDF"; // Đường dẫn lưu tệp PDF
                FileStream fs = new FileStream(savePath, FileMode.Create);
                iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Tạo ảnh chụp của form hiện tại
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(this.Width, this.Height);
                this.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, this.Width, this.Height));
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(bitmap, System.Drawing.Imaging.ImageFormat.Jpeg);

                // Cài đặt kích thước ảnh trong tài liệu PDF
                img.ScaleToFit(iTextSharp.text.PageSize.A4.Width, iTextSharp.text.PageSize.A4.Height);
                img.Alignment = iTextSharp.text.Element.ALIGN_CENTER;

                // Thêm ảnh vào tài liệu PDF và đóng tài liệu
                doc.Add(img);
                doc.Close();

                // Mở tệp PDF sau khi tạo xong
                System.Diagnostics.Process.Start(savePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tạo PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
