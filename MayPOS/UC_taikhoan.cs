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
    public partial class UC_taikhoan : UserControl
    {
        DataTable nhanvienDataTable = new DataTable();

        public UC_taikhoan()
        {
            InitializeComponent();
            // Khởi tạo cấu trúc DataTable cho nhanvienDataTable
            nhanvienDataTable.Columns.Add("STT", typeof(int));
            nhanvienDataTable.Columns.Add("Tên nhân viên", typeof(string));
            nhanvienDataTable.Columns.Add("Username", typeof(string));
            nhanvienDataTable.Columns.Add("Cấp bậc", typeof(int));
            nhanvienDataTable.Columns.Add("Điểm thưởng", typeof(int));
            // Gán nhanvienDataTable làm nguồn dữ liệu cho nhanvienGridView
            nhanvienGridView.DataSource = nhanvienDataTable;
            LoadDataNhanVien();
        }

        private void LoadDataNhanVien()
        {
            DataTable result = AccountDAO.Instance.LoadAccount();

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


        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn hay không
            if (nhanvienGridView.SelectedRows.Count > 0)
            {
                // Lấy chỉ số dòng được chọn
                int selectedRowIndex = nhanvienGridView.SelectedRows[0].Index;

                // Kiểm tra xem dòng được chọn có phải là dòng trống hay không
                if (selectedRowIndex != nhanvienGridView.Rows.Count - 1)
                {
                    string tennv = nhanvienGridView.Rows[selectedRowIndex].Cells["Tên nhân viên"].Value.ToString();
                    string username = nhanvienGridView.Rows[selectedRowIndex].Cells["Username"].Value.ToString();
                    int capBac = Convert.ToInt32(nhanvienGridView.Rows[selectedRowIndex].Cells["Cấp bậc"].Value);
                    int diemThuong = Convert.ToInt32(nhanvienGridView.Rows[selectedRowIndex].Cells["Điểm thưởng"].Value);

                    // Truy vấn SQL để lấy thông tin chi tiết các nhan vien
                    string query = $"SELECT * FROM tb_taikhoan WHERE Username = N'{username}'";
                    DataTable result = DataProvider.Instance.ExecuteQuery(query);
                    if (result.Rows.Count > 0)
                    {
                        string hinhanhValue = result.Rows[0]["Hinh"].ToString();
                        ThemNhanVien themnhanvien = new ThemNhanVien(tennv, username, capBac, diemThuong, hinhanhValue);
                        themnhanvien.ShowDialog();
                        RefreshNhanVien();

                    }

                }
                else
                {
                    // Hiển thị thông báo khi chọn vào dòng trống
                    MessageBox.Show("Không có nhân viên được chọn !! Vui lòng thử lại");
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ThemNhanVien themnhanvien = new ThemNhanVien();
            themnhanvien.ShowDialog();
            RefreshNhanVien();
        }

        void RefreshNhanVien()
        {
            nhanvienDataTable.Rows.Clear();
            LoadDataNhanVien();
        }
    }
}
