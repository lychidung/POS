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

namespace MayPOS
{
    public partial class UC_theloai_admin_sub : UserControl
    {
        private int id;
        public UC_theloai_admin_sub(int soluongloai, int id_loai, string giamax, string giamin, string hinh, string tenloai)
        {
            InitializeComponent();
            this.ID = id_loai;
            TenLoai.Text = tenloai;
            Thongkegia.Text = giamin.ToString() + " đến " + giamax.ToString();
            try
            {
                HinhLoai.Image = Image.FromFile(GlobalDirection.PathLinkGlobal + "\\icon-theloai-mon\\" + hinh + "");
            }
            catch
            {
            }

            Thongkemon.Text = soluongloai.ToString() + " món";
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public Panel PanelAllLoaiClick
        {
            get { return PanelAllLoai; }
        }

        public Panel PanelAllLoai1Click
        {
            get { return PanelAllLoai1; }
        }

        public Label TenLoaiClick
        {
            get { return TenLoai; }
        }

        public Label ThongkemonClick
        {
            get { return Thongkemon; }
        }

        public Label ThongkegiaClick
        {
            get { return Thongkegia; }
        }

        public PictureBox HinhLoaiClick
        {
            get { return HinhLoai; }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT * FROM dbo.tb_theloaimon WHERE ID_theloaimon = {0}", this.ID);
            DataTable db = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow dr in db.Rows) 
            {
                ThemDanhMuc themdanhmuc = new ThemDanhMuc((int)dr["ID_theloaimon"], dr["Tentheloai"].ToString(), dr["Hinhtheloai"].ToString(), dr["Hinhbanner"].ToString());
                themdanhmuc.ShowDialog();
            }
        }
    }
}
