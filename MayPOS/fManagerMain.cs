using Guna.UI2.WinForms;
using MayPOS.DAO;
using MayPOS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MayPOS.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using Menu = MayPOS.DTO.Menu;


namespace MayPOS
{
    public partial class fManagerMain : Form
    {
        public class GlobalRate
        {
            // % Thuế
            public static int Rate;
        }

        public class GlobalLevels
        {
            public static int Level;
        }

        double TongChinh = 0;
        int chonloai = 0;
        private double rate;

        public fManagerMain()
        {
            InitializeComponent();
            LoadTongThe();
        }

        #region Method

        void LoadTongThe()
        {
            LoadThue();
            hienthi_setting();
            LoadMenu(chonloai);
            LoadTheLoai();
            LoadThongTinTaiKhoan(GlobalUsername.UsernameGlobal);
            LoadButtonForAdmin();
        }

        void LoadButtonForAdmin()
        {
            if (GlobalLevels.Level == 1)
            {
                guna2Button4.Visible = true;
            }
        }

        void LoadThue()
        {
            string query = "SELECT * FROM dbo.tb_thue";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            DataRow dr = dataTable.Rows[0];
            GlobalRate.Rate = (int)dr["Thue"];
            rate = Math.Truncate(100 * ((double)GlobalRate.Rate / 100)) / 100;
            labelThue.Text = "Thuế (" + GlobalRate.Rate + "%)";
        }

        //Hiển thị tất cả món đang có
        void LoadMenu(int chonloai)
        {
            if (chonloai == 0)
            {
                List<Menu> menuList = MenuDAO.Instance.LoadMenuList();

                //Vòng lặp card của menu
                foreach (Menu item in menuList)
                {
                    string number = item.Gia;
                    int parsedNumber = int.Parse(number);
                    string chuyendoi = parsedNumber.ToString("0,0") + "đ";

                    CardMenu cardmenu = new CardMenu(item.Tenmonan, chuyendoi, item.Hinhmonan);

                    //Gọi các phần tử ra để click chuột
                    Panel cardPanel = cardmenu.CardpanelClick;
                    Label cardPanel1 = cardmenu.TenmonanClick;
                    Label cardPanel2 = cardmenu.GiamonanClick;
                    PictureBox cardPanel3 = cardmenu.AnhmonanClick;

                    cardPanel.Click += ClickCard;
                    cardPanel1.Click += ClickCard;
                    cardPanel2.Click += ClickCard;
                    cardPanel3.Click += ClickCard;

                    void ClickCard(object sender, EventArgs e)
                    {
                        ThemMonAnVaoGioHang(item.ID_monan, item.Tenmonan, item.Gia, 1, item.Hinhmonan);
                    }

                    PanelMenu.Controls.Add(cardmenu);
                }
            }
            else
            {
                List<Menu> menuList = MenuDAO.Instance.LoadMenuListTheoID(chonloai);
                foreach (Menu item in menuList)
                {
                    string number = item.Gia;
                    int parsedNumber = int.Parse(number);
                    string chuyendoi = parsedNumber.ToString("0,0") + "đ";

                    CardMenu cardmenu = new CardMenu(item.Tenmonan, chuyendoi, item.Hinhmonan);

                    //Gọi các phần tử ra để click chuột
                    Panel cardPanel = cardmenu.CardpanelClick;
                    Label cardPanel1 = cardmenu.TenmonanClick;
                    Label cardPanel2 = cardmenu.GiamonanClick;
                    PictureBox cardPanel3 = cardmenu.AnhmonanClick;

                    cardPanel.Click += ClickCard;
                    cardPanel1.Click += ClickCard;
                    cardPanel2.Click += ClickCard;
                    cardPanel3.Click += ClickCard;

                    void ClickCard(object sender, EventArgs e)
                    {
                        ThemMonAnVaoGioHang(item.ID_monan, item.Tenmonan, item.Gia, 1, item.Hinhmonan);
                    }

                    PanelMenu.Controls.Add(cardmenu);
                }
            }
        }

        void GetSearchMenu()
        {
            PanelMenu.Controls.Clear();
            LoadMenuSearch(TimKiem.Text);
            ActiveControl = null;
        }

        void LoadMenuSearch(string search)
        {
            List<Menu> menuList = MenuDAO.Instance.SearchMenu(search);

            //Vòng lặp card của menu
            foreach (Menu item in menuList)
            {
                string number = item.Gia;
                int parsedNumber = int.Parse(number);
                string chuyendoi = parsedNumber.ToString("0,0") + "đ";

                CardMenu cardmenu = new CardMenu(item.Tenmonan, chuyendoi, item.Hinhmonan);

                //Gọi các phần tử ra để click chuột
                Panel cardPanel = cardmenu.CardpanelClick;
                Label cardPanel1 = cardmenu.TenmonanClick;
                Label cardPanel2 = cardmenu.GiamonanClick;
                PictureBox cardPanel3 = cardmenu.AnhmonanClick;

                cardPanel.Click += ClickCard;
                cardPanel1.Click += ClickCard;
                cardPanel2.Click += ClickCard;
                cardPanel3.Click += ClickCard;

                void ClickCard(object sender, EventArgs e)
                {
                    ThemMonAnVaoGioHang(item.ID_monan, item.Tenmonan, item.Gia, 1, item.Hinhmonan);
                }

                PanelMenu.Controls.Add(cardmenu);
            }
        }

        List<int> mamon_giohang = new List<int>();
        List<string> tenmon_giohang = new List<string>();
        List<string> giamon_giohang = new List<string>();
        List<int> soluong_monan = new List<int>();
        List<string> hinhmon_giohang = new List<string>();

        void ThemMonAnVaoGioHang(int maMonAn, string tenMonAn, string giaMonAn, int soLuong, string hinhMon)
        {
            // Kiểm tra xem món ăn đã có trong giỏ hàng chưa
            int index = mamon_giohang.IndexOf(maMonAn);

            if (index == -1)
            {
                // Nếu món ăn chưa có trong giỏ hàng, thêm mới
                mamon_giohang.Add(maMonAn);
                tenmon_giohang.Add(tenMonAn);
                giamon_giohang.Add(giaMonAn);
                soluong_monan.Add(soLuong);
                hinhmon_giohang.Add(hinhMon);
                index = mamon_giohang.IndexOf(maMonAn); //Lấy lại thứ tự món trong giỏ hàng
                LoadChonMonAn(index, false, soluong_monan[index]); // Cập nhật hiển thị trên DataGridView
            }
            else
            {
                // Nếu món ăn đã có trong giỏ hàng, tăng số lượng
                if (soluong_monan[index] + soLuong <= 100) // Nếu số lượng tăng <= 100
                {
                    soluong_monan[index] += soLuong;
                    LoadChonMonAn(index, true, soluong_monan[index]); // Cập nhật hiển thị trên DataGridView
                }
            }
        }

        //Hiển thị tất cả các món đã chọn
        List<int> soLuongMonAnList = new List<int>(); // Danh sách lưu trữ số lượng của mỗi item
        void LoadChonMonAn(int index, bool change, int getSoLuong)
        {
            if (!change) // Nếu món chưa tồn tại trong giỏ hàng
            {
                int mamon = mamon_giohang[index];
                string ten = tenmon_giohang[index];
                int gia = int.Parse(giamon_giohang[index]);
                string hinh = hinhmon_giohang[index];
                int soLuong = getSoLuong;
                TinhTien();

                UC_Item uc_item = new UC_Item(mamon, ten, gia, hinh, index);
                PanelListMonAn.Controls.Add(uc_item); //Thêm vào giỏ hàng

                Guna2NumericUpDown chonmon = uc_item.SoLuongMonClick;
                int thutu = uc_item.LayThuTu();
                chonmon.Value = soLuong;

                chonmon.ValueChanged += chonmon_ValueChanged; //Đăng ký hàm chonmon_ValueChanged
                void chonmon_ValueChanged(object sender, EventArgs e)
                {
                    int newValue = (int)chonmon.Value;
                    if (newValue > soluong_monan[thutu])
                    {
                        ++soluong_monan[thutu];
                    }
                    else if (newValue < soluong_monan[thutu])
                    {
                        --soluong_monan[thutu];
                    }
                    TinhTien();
                }
            }
            else // Nếu món đã tồn tại trong giỏ hàng
            {
                UC_Item uc_item = (UC_Item)PanelListMonAn.Controls[index];
                Guna2NumericUpDown chonmon = uc_item.SoLuongMonClick;
                chonmon.Value = getSoLuong;
            }
        }

        void TinhTien()
        {
            string TongPhuString;
            int TongPhuTichLuy = 0;
            if (mamon_giohang.Count > 0)
            {
                for (int i = 0; i < mamon_giohang.Count; i++)
                {
                    int tongGia = int.Parse(giamon_giohang[i]) * soluong_monan[i];
                    TongPhuTichLuy += tongGia;
                    TongPhuString = TongPhuTichLuy.ToString("0,0") + "đ";
                    textTongphu.Text = TongPhuString;
                    TongChinh = TongPhuTichLuy + (TongPhuTichLuy * rate);
                    string TongChinhString = TongChinh.ToString("0,0") + "đ";

                    textTong.Text = TongChinhString;

                    double TongThue = TongPhuTichLuy * rate;
                    string ThueString = TongThue.ToString("0,0") + "đ";

                    textThue.Text = ThueString;
                }
            }
            else
            {
                textTongphu.Text = "0đ";
                textTong.Text = "0đ";
                textThue.Text = "0đ";
            }
        }

        private void textTongphu_TextChanged(object sender, EventArgs e)
        {
        }

        // Tạo nút cho các thể loại
        void LoadButtonTheLoai(int ID_theloaimon, string Tentheloai, string Hinhtheloai)
        {
            UC_theloai uC_Theloai = new UC_theloai(Tentheloai, Hinhtheloai);
            PanelTheLoai.Controls.Add(uC_Theloai);

            //Gọi các phần tử ra để click chuột
            Panel cardPanel = uC_Theloai.CardpanelClick;
            Label cardPanel1 = uC_Theloai.TenLoaiClick;
            PictureBox cardPanel2 = uC_Theloai.HinhLoaiClick;

            cardPanel.Click += Buttonclick;
            cardPanel1.Click += Buttonclick;
            cardPanel2.Click += Buttonclick;

            void Buttonclick(object sender, EventArgs e)
            {
                PanelMenu.Controls.Clear();
                chonloai = ID_theloaimon;
                LoadMenu(chonloai);
                Tieude.Text = Tentheloai;
            }
        }

        //Hiển thị tất cả thể loại đang có
        void LoadTheLoai()
        {
            LoadButtonTheLoai(0, "Tất cả", "combo.png"); // Thêm 1 nút default
            List<TheLoai> theloai = TheLoaiDAO.Instance.LoadTheLoaiList();
            foreach (TheLoai item in theloai)
            {
                LoadButtonTheLoai(item.ID_theloaimon, item.Tentheloai, item.Hinhtheloai);
            }
        }

        void LoadThongTinTaiKhoan(string username)
        {
            List<TaiKhoan> taikhoan = AccountDAO.Instance.LoadThongTinList(username);
            foreach (TaiKhoan item in taikhoan)
            {
                GlobalLevels.Level = item.Capbac;
                TenNV.Text = item.Tennv;
                if (item.Capbac == 1)
                {
                    CapNV.Text = "Quản lý";
                }
                else
                {
                    CapNV.Text = "Nhân viên";
                }

                try
                {
                    HinhNV.Image = Image.FromFile(GlobalDirection.PathLinkGlobal + "\\avatar\\" + item.Hinh + "");
                }
                catch { }
            }
               
        }

        void RefreshListMenu()
        {
            PanelMenu.Controls.Clear();
            LoadMenu(0);
        }

        void RefreshGioHang()
        {
            PanelListMonAn.Controls.Clear();
            mamon_giohang.Clear();
            tenmon_giohang.Clear();
            giamon_giohang.Clear();
            soluong_monan.Clear();
            hinhmon_giohang.Clear();
            TinhTien();
        }

        void RefreshLoaiList()
        {
            PanelTheLoai.Controls.Clear();
            LoadTheLoai();
        }

        void RefreshMain()
        {
            LoadThue();
            RefreshLoaiList();
            RefreshListMenu();
            RefreshGioHang();
        }

        public void LoadHoaDon(bool check)
        {
            if (check) 
            {
                bool ch = check;
                int Tongtien = 0;
                string username = GlobalUsername.UsernameGlobal;
                DataTable dt = HoaDon.Instance.Insert_HoaDon();
                DataRow dr = dt.Rows[0];
                int ID_HoaDon = (int)dr["ID_hoadon"];
                foreach (System.Windows.Forms.Control ctrl in PanelListMonAn.Controls)
                {
                    UC_Item uc_item = ctrl as UC_Item;
                    Guna2NumericUpDown chonmon = uc_item.SoLuongMonClick;
                    int Soluong = (int)chonmon.Value;
                    int ID_monan = uc_item.LayID_Mon();
                    int Dongia = uc_item.LayDonGia();
                    if (Soluong > 0)
                    {
                        Dongia += (int) (Dongia * rate);
                        if (HoaDon.Instance.Insert_ChiTietHoaDon(ID_HoaDon, ID_monan, Soluong, Dongia, username))
                        {
                            Tongtien += Soluong * Dongia;
                        }
                        else
                        {
                            MessageBox.Show("Lỗi!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ch = false;
                            break;
                        }
                    }
                }
                if (ch)
                {
                    BillCash billcash = new BillCash(ID_HoaDon);
                    billcash.ShowDialog();
                    //MessageBox.Show("HOÀN TẤT ĐƠN HÀNG");
                    int diem = (int) (Tongtien * 0.00005);
                    if (AccountDAO.Instance.CongDiemNhanVien(username, diem))
                    {
                    }
                }
                RefreshGioHang();
            }
        }

        #endregion

        private void fManagerMain_Load(object sender, EventArgs e)
        {
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (GlobalLevels.Level == 1)
            {
                fAdminMain fAdminMain = new fAdminMain();
                this.Hide();
                fAdminMain.ShowDialog();
                this.Show();
                RefreshMain();
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
        }

        private void hienthi_setting()
        {
            UC_inforAccount settingacc = new UC_inforAccount();
            ConfigAccount.Controls.Add(settingacc);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            UC_inforAccount settingacc = new UC_inforAccount();

            settingacc.Visible = !settingacc.Visible;
            ConfigAccount.Visible = !ConfigAccount.Visible;
        }

        private void fManagerMain_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            RefreshMain();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (PanelListMonAn.Controls.Count > 0 && TongChinh > 0)
            {
                Calculator calculator = new Calculator(TongChinh);
                calculator.ShowDialog();
            }
        }

        private void TimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            GetSearchMenu();
        }

        private void TimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetSearchMenu();
            }
        }
    }
}
