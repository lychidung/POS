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

namespace MayPOS
{
    public partial class BillCash : Form
    {
        string id;
        private double getRate = 0;

        public BillCash(int ID)
        {
            InitializeComponent();
            txtID.Text = "# " + ID.ToString();
            
            ShowBill(ID);
        }

        void ShowBill(int ID)
        {
            id = ID.ToString();
            // Tạo các cột cho DataGridView (nếu chưa tạo trong designer)
            guna2DataGridView1.Columns.Add("TenMonAnColumn", "Món Ăn");
            guna2DataGridView1.Columns.Add("SoLuongColumn", "Số Lượng");
            guna2DataGridView1.Columns.Add("DonGiaColumn", "Đơn Giá");
            guna2DataGridView1.Columns.Add("Thành tiền", "Thành Tiền");

            // Truy vấn SQL để lấy thông tin chi tiết các món ăn trong đơn hàng
            string query = $"SELECT td.Tenmonan, td.Gia AS [DonGiaGoc], ct.Dongia, ct.Soluong, hd.ID_hoadon, hd.Ngaylapdon, hd.Thoigianlapdon FROM tb_chitiethoadon ct INNER JOIN tb_thucdon td ON ct.ID_monan = td.ID_monan INNER JOIN tb_hoadon hd ON hd.ID_hoadon = ct.ID_hoadon WHERE ct.ID_hoadon = {ID}";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            double tongtien = 0; // Khởi tạo tổng tiền

            if (result != null && result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    string tenMonAn = row["Tenmonan"].ToString();
                    int dongiaGoc = Convert.ToInt32(row["DonGiaGoc"]);
                    int donGia = Convert.ToInt32(row["Dongia"]);
                    int soLuong = Convert.ToInt32(row["Soluong"]);

                    int thanhTien = dongiaGoc * soLuong; // Tính thành tiền cho món ăn
                    tongtien += thanhTien;
                    guna2DataGridView1.Rows.Add(tenMonAn, soLuong, dongiaGoc, thanhTien);
                    
                }
            }

            if (result.Rows.Count > 0)
            {
                string ngay = result.Rows[0]["ngaylapdon"].ToString();
                string thoigian = result.Rows[0]["Thoigianlapdon"].ToString();
                DateTime dateTime = DateTime.Parse(ngay);
                string ngayLapDonFormatted = dateTime.ToString("dd/MM/yyyy");
                txtDate.Text = thoigian + " " +ngayLapDonFormatted;
            }

            string queryThue = $"SELECT * FROM tb_thue";
            DataTable resultThue = DataProvider.Instance.ExecuteQuery(queryThue);

            if (resultThue.Rows.Count > 0)
            {
                double thue =(int)resultThue.Rows[0]["Thue"];
                txtTax.Text = "Total (TAX "+ thue.ToString() +"%):";
                txtTong.Text = ((tongtien * (thue / 100)) + tongtien).ToString("N0") + "đ";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo tệp PDF mới
                string savePath = GlobalDirection.PathLinkGlobal + "\\InvoiceLog\\hoadon-" + id + ".PDF"; // Đường dẫn lưu tệp PDF
                FileStream fs = new FileStream(savePath, FileMode.Create);
                iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Tạo ảnh chụp của form hiện tại
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(this.Width, this.Height);
                this.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, this.Width, this.Height-60));
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
    }
}
