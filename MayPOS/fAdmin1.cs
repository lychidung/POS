using MayPOS.DAO;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Globalization;
using System.ComponentModel;

namespace MayPOS
{
    public partial class fAdmin : Form
    {
        DataTable hoadonDataTable = new DataTable();
        DataTable nhanvienDataTable = new DataTable();

        public fAdmin()
        {
            InitializeComponent();

            // Khởi tạo cấu trúc DataTable cho hoadonDataTable
            hoadonDataTable.Columns.Add("STT", typeof(int));
            hoadonDataTable.Columns.Add("ID_hoadon", typeof(int));
            hoadonDataTable.Columns.Add("MonAn", typeof(string));
            hoadonDataTable.Columns.Add("DonGia", typeof(int));
            hoadonDataTable.Columns.Add("Ngaylapdon", typeof(DateTime));
            //hoadonDataTable.Columns.Add("Thoigianlapdon", typeof(TimeSpan));
            hoadonDataTable.Columns.Add("TongTien", typeof(int));
            hoadonDataTable.Columns.Add("TenNV", typeof(string));

            // Khởi tạo cấu trúc DataTable cho nhanvienDataTable
            nhanvienDataTable.Columns.Add("STT", typeof(int));
            nhanvienDataTable.Columns.Add("TenNV", typeof(string));
            nhanvienDataTable.Columns.Add("Capbac", typeof(int));
            nhanvienDataTable.Columns.Add("Username", typeof(string));
            nhanvienDataTable.Columns.Add("Diemthuong", typeof(int));



            // Load dữ liệu vào DataTable
            LoadDataToDataTable();

            // Gán hoadonDataTable làm nguồn dữ liệu cho hoadonGridView
            hoadonGridView.DataSource = hoadonDataTable;

            // Gán nhanvienDataTable làm nguồn dữ liệu cho nhanvienGridView
            nhanvienGridView.DataSource = nhanvienDataTable;

            // Thiết lập số thứ tự cho từng dòng trong DataGridView
            SetRowNumber();

            // Lấy ngày hiện tại
            string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            //DateTime today = DateTime.Now.Date;

            // Tính và hiển thị tổng doanh thu
            int totalRevenue = CalculateTotalRevenue(date);
            Box_doanhthu.Text = totalRevenue.ToString() + "đ";
        }

        private void LoadDataToDataTable()
        {
            
            DataTable result = HoaDon.Instance.LoadDataToDataTable_HD();

            int stt = 1;

            if (result != null && result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    int id_hd = Convert.ToInt32(row["ID_hoadon"]);
                    string monan = row["Tenmonan"].ToString();
                    int dongia = Convert.ToInt32(row["Gia"]);
                    DateTime ngaylapdon = Convert.ToDateTime(row["Ngaylapdon"]);
                    //TimeSpan thoigianlapdon = TimeSpanConverter()
                    //DateTime thoigianlapdon = Convert.ToDateTime(row["Ngaylapdon"]);
                    int tongtien = Convert.ToInt32(row["TongTien"]);
                    string tenNV = row["TenNV"].ToString();
                    int capbac = Convert.ToInt32(row["Capbac"]);
                    string username = row["Username"].ToString();
                    int diemthuong = Convert.ToInt32(row["DiemThuong"]);

                    // Thêm dữ liệu vào hoadonDataTable
                    hoadonDataTable.Rows.Add(stt, id_hd, monan, dongia, ngaylapdon, tongtien, tenNV);

                    // Thêm dữ liệu vào nhanvienDataTable
                    if (capbac == 0) // Chỉ thêm dữ liệu của nhân viên
                    {
                        nhanvienDataTable.Rows.Add(stt, tenNV, capbac, username, diemthuong);
                    }

                    stt++;
                }
            }
        }

        private void SetRowNumber()
        {
            foreach (DataGridViewRow row in hoadonGridView.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        // Thêm tham số cho phương thức tính tổng tiền các hóa đơn trong ngày
        private int CalculateTotalRevenue(string selectedDate)
        {
            // Lấy ngày bắt đầu và kết thúc của ngày được chọn
            //DateTime startDate = selectedDate.Date;
            //DateTime endDate = startDate.AddDays(1);
            string startDate = selectedDate;

            // Truy vấn SQL để tính tổng tiền các hóa đơn trong ngày
            MessageBox.Show(startDate.ToString());
            DataTable result = HoaDon.Instance.TongDoanhThu(startDate);

            if (result == null)
            {
                foreach (DataRow row in result.Rows)
                {
                    if (result != null)
                    {
                        return Convert.ToInt32(row[0]);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            return 0; 
        }

        private void Day_Start_ValueChanged(object sender, EventArgs e)
        {
            // Lấy ngày hiện tại và cập nhật ngày bắt đầu từ DateTimePicker
            DateTime today = DateTime.Now.Date;
            DateTime selectedDate = new DateTime(Day_Start.Value.Year, Day_Start.Value.Month, Day_Start.Value.Day);

            // Tính và hiển thị tổng doanh thu của ngày được chọn
            //int totalRevenue = CalculateTotalRevenue(selectedDate);
            //Box_doanhthu.Text = totalRevenue.ToString() + "đ";
        }


        private void btn_chitiet_hoadon_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn hay không
            if (hoadonGridView.SelectedRows.Count > 0)
            {
                // Lấy chỉ số dòng được chọn
                int selectedRowIndex = hoadonGridView.SelectedRows[0].Index;

                // Kiểm tra xem dòng được chọn có phải là dòng trống hay không
                if (selectedRowIndex != hoadonGridView.Rows.Count - 1)
                {
                    // Lấy thông tin chi tiết hóa đơn từ dòng được chọn trong DataGridView
                    int id_donhang = Convert.ToInt32(hoadonGridView.Rows[selectedRowIndex].Cells["ID_hoadon"].Value);
                    string monan = hoadonGridView.Rows[selectedRowIndex].Cells["MonAn"].Value.ToString();
                    int dongia = Convert.ToInt32(hoadonGridView.Rows[selectedRowIndex].Cells["DonGia"].Value);
                    string ngaylapdon = hoadonGridView.Rows[selectedRowIndex].Cells["Ngaylapdon"].Value.ToString();
                    string tenNV = hoadonGridView.Rows[selectedRowIndex].Cells["TenNV"].Value.ToString();

                    // Truy vấn SQL để lấy thông tin chi tiết các món ăn trong đơn hàng
                    string query = $"SELECT td.Tenmonan, ct.Dongia, ct.Soluong FROM tb_chitiethoadon ct INNER JOIN tb_thucdon td ON ct.ID_monan = td.ID_monan WHERE ct.ID_hoadon = {id_donhang}";
                    DataTable result = DataProvider.Instance.ExecuteQuery(query);

                    // Xây dựng chuỗi thông tin chi tiết hóa đơn
                    StringBuilder invoiceBuilder = new StringBuilder();
                    invoiceBuilder.AppendLine("Thông tin chi tiết hóa đơn");
                    invoiceBuilder.AppendLine("-------------------------------------");
                    invoiceBuilder.AppendLine($"Mã đơn hàng: {id_donhang}");
                    invoiceBuilder.AppendLine($"Ngày lập đơn: {ngaylapdon}");
                    invoiceBuilder.AppendLine($"Nhân viên: {tenNV}");
                    invoiceBuilder.AppendLine("\r\nDanh sách món ăn:");

                    int tongtien = 0; // Khởi tạo tổng tiền

                    if (result != null && result.Rows.Count > 0)
                    {
                        foreach (DataRow row in result.Rows)
                        {
                            string tenMonAn = row["Tenmonan"].ToString();
                            int donGia = Convert.ToInt32(row["Dongia"]);
                            int soLuong = Convert.ToInt32(row["Soluong"]);

                            int thanhTien = donGia * soLuong; // Tính thành tiền cho món ăn

                            invoiceBuilder.AppendLine($"- Món ăn: {tenMonAn}\r\n   +Đơn giá: {donGia}đ\r\n   +Số lượng: {soLuong}");

                            tongtien += thanhTien; // Cộng vào tổng tiền
                        }
                    }
                    invoiceBuilder.AppendLine("-------------------------------------");
                    invoiceBuilder.AppendLine($"\r\nTổng tiền: {tongtien}đ");

                    string invoiceText = invoiceBuilder.ToString();

                    // Truyền chi tiết hóa đơn vào ô TextBox
                    Box_chitiet_hoadon.Text = invoiceText;
                }
                else
                {
                    // Hiển thị thông báo khi chọn vào dòng trống
                    Box_chitiet_hoadon.Text = "Không có hóa đơn";
                }
            }
        }
    }
}