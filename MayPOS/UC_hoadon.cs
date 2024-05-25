using MayPOS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayPOS
{
    public partial class UC_hoadon : UserControl
    {
        DataTable hoadonDataTable = new DataTable();
        DataTable nhanvienDataTable = new DataTable();
        BindingSource thucDons = new BindingSource();
        private bool getCheck = true;
        // Lấy ngày hiện tại
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        public UC_hoadon()
        {

            InitializeComponent();
            // Khởi tạo cấu trúc DataTable cho hoadonDataTable
            hoadonDataTable.Columns.Add("STT", typeof(int));
            hoadonDataTable.Columns.Add("ID Hóa đơn", typeof(int));
            hoadonDataTable.Columns.Add("Ngày lập đơn", typeof(DateTime));
            hoadonDataTable.Columns.Add("Thời gian", typeof(string));
            hoadonDataTable.Columns.Add("Tổng tiền", typeof(string));
            hoadonDataTable.Columns.Add("Tên nhân viên", typeof(string));

            // Khởi tạo cấu trúc DataTable cho nhanvienDataTable
            nhanvienDataTable.Columns.Add("STT", typeof(int));
            nhanvienDataTable.Columns.Add("Tên nhân viên", typeof(string));
            nhanvienDataTable.Columns.Add("Username", typeof(string));
            nhanvienDataTable.Columns.Add("Cấp bậc", typeof(int));
            nhanvienDataTable.Columns.Add("Điểm thưởng", typeof(int));


            // Load dữ liệu vào DataTable
            LoadDataToDataTable(date);
            LoadDataNhanVien();

            // Gán hoadonDataTable làm nguồn dữ liệu cho hoadonGridView
            hoadonGridView.DataSource = hoadonDataTable;

            // Gán nhanvienDataTable làm nguồn dữ liệu cho nhanvienGridView
            //nhanvienGridView.DataSource = nhanvienDataTable;

            // Thiết lập số thứ tự cho từng dòng trong DataGridView
            SetRowNumber();


            //DateTime today = DateTime.Now.Date;

            // Tính và hiển thị tổng doanh thu
            int totalRevenue = CalculateTotalRevenue(date);
            Box_doanhthu.Text = totalRevenue.ToString() + "đ";

            //nhanvienGridView.Columns["Username"].Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Day_Start_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_chitiet_hoadon_Click_1(object sender, EventArgs e)
        {

        }

        #region ThanhPhat

        private void LoadDataToDataTable(string day)
        {
            DataTable result = HoaDon.Instance.LoadDataHoaDonDate(day);

            int stt = 1;

            if (result != null && result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    int id_hd = Convert.ToInt32(row["ID_hoadon"]);
                    //string monan = row["Tenmonan"].ToString();
                    //int dongia = Convert.ToInt32(row["Gia"]);
                    DateTime ngaylapdon = Convert.ToDateTime(row["Ngaylapdon"]);
                    TimeSpan thoigianlapdon = TimeSpan.Parse(row["Thoigianlapdon"].ToString());
                    int tongtien = Convert.ToInt32(row["TongTien"]);
                    string money = tongtien.ToString("0,0") + " đ";
                    string tenNV = row["TenNV"].ToString();

                    // Thêm dữ liệu vào hoadonDataTable
                    hoadonDataTable.Rows.Add(stt, id_hd, ngaylapdon, thoigianlapdon, money, tenNV);

                    stt++;
                }
            }
        }

        private void LoadDataNhanVien()
        {
            DataTable result = HoaDon.Instance.LoadDataNhanVien();

            int stt = 1;

            foreach (DataRow row in result.Rows)
            {
                string tenNV = row["TenNV"].ToString();
                string username = row["Username"].ToString();
                int capbac = Convert.ToInt32(row["Capbac"]);
                int diemthuong = Convert.ToInt32(row["DiemThuong"]);
                nhanvienDataTable.Rows.Add(stt, tenNV, username, capbac, diemthuong);

                stt++;
            }
        }

        void LoadHoaDonDate(string day)
        {
            hoadonDataTable.Rows.Clear();
            hoadonGridView.DataSource = hoadonDataTable;
            LoadDataToDataTable(day);
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
            DataTable result = HoaDon.Instance.TongDoanhThu(startDate);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                if (!row["TONGDT"].ToString().Equals(""))
                    return Convert.ToInt32(row["TONGDT"]);
            }
            return 0;
        }


        private void Day_Start_ValueChanged_1(object sender, EventArgs e)
        {
            //DateTime today = DateTime.Now.Date;
            DateTime selectedDate = new DateTime(Day_Start.Value.Year, Day_Start.Value.Month, Day_Start.Value.Day);
            LoadHoaDonDate(selectedDate.ToString());

            // Tính và hiển thị tổng doanh thu của ngày được chọn
            int totalRevenue = CalculateTotalRevenue(selectedDate.ToString());
            Box_doanhthu.Text = totalRevenue.ToString("0,0") + "đ";
        }

        private void btn_chitiet_hoadon_Click(object sender, EventArgs e)
        {
            
        }


        #endregion

        private void btn_chitiet_hoadon_Click_2(object sender, EventArgs e)
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
                    int id_donhang = Convert.ToInt32(hoadonGridView.Rows[selectedRowIndex].Cells["ID Hóa đơn"].Value);
                    //string monan = hoadonGridView.Rows[selectedRowIndex].Cells["MonAn"].Value.ToString();
                    //int dongia = Convert.ToInt32(hoadonGridView.Rows[selectedRowIndex].Cells["DonGia"].Value);
                    string ngaylapdon = hoadonGridView.Rows[selectedRowIndex].Cells["Ngày lập đơn"].Value.ToString();
                    string tenNV = hoadonGridView.Rows[selectedRowIndex].Cells["Tên nhân viên"].Value.ToString();
                    string thoigianlapdon = hoadonGridView.Rows[selectedRowIndex].Cells["Thời gian"].Value.ToString();


                    // Truy vấn SQL để lấy thông tin chi tiết các món ăn trong đơn hàng
                    string query = $"SELECT td.Tenmonan, td.Gia AS [DonGiaGoc], ct.Dongia, ct.Soluong, hd.Thoigianlapdon FROM tb_chitiethoadon ct INNER JOIN tb_thucdon td ON ct.ID_monan = td.ID_monan INNER JOIN tb_hoadon hd ON ct.ID_hoadon = hd.ID_hoadon WHERE ct.ID_hoadon = {id_donhang};";
                    DataTable result = DataProvider.Instance.ExecuteQuery(query);

                    // Xây dựng chuỗi thông tin chi tiết hóa đơn
                    StringBuilder invoiceBuilder = new StringBuilder();
                    invoiceBuilder.AppendLine("Thông tin chi tiết hóa đơn");
                    invoiceBuilder.AppendLine("-------------------------------------");
                    invoiceBuilder.AppendLine($"Mã đơn hàng: {id_donhang}");
                    invoiceBuilder.AppendLine($"Ngày lập đơn: {ngaylapdon}");
                    invoiceBuilder.AppendLine($"Nhân viên: {tenNV}");
                    invoiceBuilder.AppendLine("\r\nDanh sách món ăn:");

                    int tongtienGoc = 0;
                    int tongtien = 0; // Khởi tạo tổng tiền
                    if (result != null && result.Rows.Count > 0)
                    {
                        foreach (DataRow row in result.Rows)
                        {
                            string tenMonAn = row["Tenmonan"].ToString();

                            int donGiaGoc = Convert.ToInt32(row["DonGiaGoc"]);
                            int donGia = Convert.ToInt32(row["Dongia"]);
                            int soLuong = Convert.ToInt32(row["Soluong"]);

                            int thanhtienGoc = donGiaGoc * soLuong;
                            int thanhTien = donGia * soLuong; // Tính thành tiền cho món ăn

                            invoiceBuilder.AppendLine($"- Món ăn: {tenMonAn}\r\n   +Đơn giá: {donGia.ToString("0,0")}đ\r\n   +Số lượng: {soLuong}");

                            tongtien += thanhTien; // Cộng vào tổng tiền
                            tongtienGoc += thanhtienGoc;
                        }
                    }
                    invoiceBuilder.AppendLine("-------------------------------------");
                    invoiceBuilder.AppendLine($"\r\nTổng tiền: {tongtien.ToString("0,0")}đ");
                    // Truyền chi tiết hóa đơn vào ô TextBox
                    Bill bill = new Bill(id_donhang, ngaylapdon, tenNV, tongtien, tongtienGoc, thoigianlapdon);
                    bill.ShowDialog();
                    //Box_chitiet_hoadon.Text = invoiceText;
                }
                else
                {
                    // Hiển thị thông báo khi chọn vào dòng trống
                    MessageBox.Show("Không có hóa đơn !! Vui lòng thử lại");
                }
            }
        }
    }
}
