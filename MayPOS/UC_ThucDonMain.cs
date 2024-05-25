using Guna.UI2.WinForms.Suite;
using MayPOS.DAO;
using MayPOS.DTO;
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
    public partial class UC_ThucDonMain : UserControl
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        BindingSource thucDons = new BindingSource();
        private int id_the = 0;
        private bool getCheck = true;
        private string path1 = "", path2 = "", defaultpath = GlobalDirection.PathLinkGlobal + "\\images\\", newPicture = "";
        public UC_ThucDonMain()
        {
            openFileDialog.Filter = "|*.jpg;*.png;*.img";
            InitializeComponent();
            LoadAllAssets();
        }

        public UC_ThucDonMain(int id_theloai)
        {
            openFileDialog.Filter = "|*.jpg;*.png;*.img";
            InitializeComponent();
            LoadAllAssetsTheTheLoai(id_theloai);
        }

        void LoadAllAssetsTheTheLoai(int id_theloai)
        {
            id_the = id_theloai;
            dataGridViewThucDon.DataSource = thucDons;
            LoadThucDonTheoLoai(id_theloai);
            ThucdonBinding();
            LoadTheLoaiThucDon(ComBoxTheLoai);
        }

        void LoadAllAssets()
        {
            dataGridViewThucDon.DataSource = thucDons;
            LoadThucDon();
            ThucdonBinding();
            LoadTheLoaiThucDon(ComBoxTheLoai);
        }

        void LoadThucDonTheoLoai(int id_theloai)
        {
            thucDons.DataSource = ThucDonDAO.Instance.LoadThucDonTheoLoai(id_theloai);
        }

        void LoadThucDon()
        {
            thucDons.DataSource = ThucDonDAO.Instance.LoadThucDon();
        }

        void LoadTheLoaiThucDon(ComboBox cb)
        {
            cb.DataSource = TheLoaiMonDAO.Instance.LoadTheLoaiMon();
            cb.DisplayMember = "Tentheloai";
        }

        DataTable SearchThucDon(string ten)
        {
            DataTable thucdon = ThucDonDAO.Instance.SearchThucDon(ten);
            return thucdon;
        }

        DataTable SearchThucDonTheoLoai(string ten)
        {
            DataTable thucdon = ThucDonDAO.Instance.SearchThucDonTheoLoai(ten, id_the);
            return thucdon;
        }

        void ThucdonBinding()
        {
            txtBoxID.DataBindings.Add(new Binding("Text", dataGridViewThucDon.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtBoxTenMon.DataBindings.Add(new Binding("Text", dataGridViewThucDon.DataSource, "Tên Món Ăn", true, DataSourceUpdateMode.Never));
            numGia.DataBindings.Add(new Binding("Value", dataGridViewThucDon.DataSource, "Đơn Giá", true, DataSourceUpdateMode.Never));
            txtBoxHinhAnh.DataBindings.Add(new Binding("Text", dataGridViewThucDon.DataSource, "Hình Ảnh", true, DataSourceUpdateMode.Never));
            txtBoxMoTa.DataBindings.Add(new Binding("Text", dataGridViewThucDon.DataSource, "Mô Tả", true, DataSourceUpdateMode.Never));
        }

        void Enable_Edit(bool check)
        {
            txtBoxTenMon.ReadOnly = check;
            txtBoxMoTa.ReadOnly = check;
            button_ThemAnh.Enabled = !check;
            numGia.Enabled = !check;
            buttonSave.Enabled = !check;
            ComBoxTheLoai.Enabled = !check;
        }


        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void BThucDonTimKiem_Click_1(object sender, EventArgs e)
        {
            if (id_the == 0)
                thucDons.DataSource = SearchThucDon(txtBoxThucDonTinKiem.Text);
            else
                thucDons.DataSource = SearchThucDonTheoLoai(txtBoxThucDonTinKiem.Text);
        }

        private void BThucDonXoa_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBoxID.Text);
            if (ThucDonDAO.Instance.Xoa_ThucDon(id))
            {
                MessageBox.Show("XÓA MÓN THÀNH CÔNG!");
                if (id_the == 0)
                    LoadThucDon();
                else
                    LoadThucDonTheoLoai(id_the);
            }
            else
            {
                MessageBox.Show("XÓA KHÔNG THÀNH CÔNG!");
            }
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            string tenmonan = txtBoxTenMon.Text;
            int theloaimon = (ComBoxTheLoai.SelectedItem as TheLoaiMon).Id_Theloaimon;
            float gia = (float)numGia.Value;
            string hinhanh = txtBoxHinhAnh.Text;
            string mota = txtBoxMoTa.Text;
            int id = Convert.ToInt32(txtBoxID.Text);
            if (!tenmonan.Equals(""))
            {
                if (ThucDonDAO.Instance.Update_ThucDon(id, tenmonan, theloaimon, gia, mota, hinhanh))
                {
                    if (!path1.Equals("") && !path2.Equals(""))
                    {
                        try
                        {
                            File.Copy(path1, path2, true);
                        }
                        catch { }
                    }
                    path1 = "";
                    path2 = "";
                    MessageBox.Show("CẬP NHẬT MÓN THÀNH CÔNG!");
                    Enable_Edit(true);
                    if (id_the == 0)
                        LoadThucDon();
                    else
                        LoadThucDonTheoLoai(id_the);
                }
                else
                {
                    MessageBox.Show("CẬP NHẬT KHÔNG THÀNH CÔNG!");
                }
            }
            else
            {
                MessageBox.Show("TÊN MÓN ĂN CHƯA CÓ!");
            }
        }

        private void BThucDonSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewThucDon.SelectedCells.Count > 0 && dataGridViewThucDon.SelectedCells[0].OwningRow.Cells["ID Thể Loại"].Value != null)
            {
                if (!getCheck)
                    getCheck = true;
                else
                    getCheck = false;
                Enable_Edit(getCheck);
            }
        }

        private void dataGridViewThucDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBoxThucDonTinKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (id_the == 0)
                    thucDons.DataSource = SearchThucDon(txtBoxThucDonTinKiem.Text);
                else
                    thucDons.DataSource = SearchThucDonTheoLoai(txtBoxThucDonTinKiem.Text);
                ActiveControl = null;
            }
        }

        private void BThucDonThem_Click(object sender, EventArgs e)
        {
            ThemMonAnMain them = new ThemMonAnMain();
            them.ShowDialog();
            if (id_the == 0)
                LoadThucDon();
            else
                LoadThucDonTheoLoai(id_the);
        }

        private void txtBoxID_TextChanged_1(object sender, EventArgs e)
        {
            path1 = "";
            path2 = "";
            if (!getCheck)
            {
                getCheck = true;
                Enable_Edit(getCheck);
            }
            try
            {
                if (dataGridViewThucDon.SelectedCells.Count > 0 && dataGridViewThucDon.SelectedCells[0].OwningRow.Cells["ID Thể Loại"].Value != null)
                {
                    int id = (int)dataGridViewThucDon.SelectedCells[0].OwningRow.Cells["ID Thể Loại"].Value;

                    TheLoaiMon theLoai = TheLoaiMonDAO.Instance.Lay_TheLoaiMon(id);

                    int index = -1;
                    int i = 0;
                    foreach (TheLoaiMon item in ComBoxTheLoai.Items)
                    {
                        if (item.Id_Theloaimon == theLoai.Id_Theloaimon)
                        {
                            index = i; break;
                        }
                        i++;
                    }
                    ComBoxTheLoai.SelectedIndex = index;
                }
            }
            catch
            {
                return;
            }
        }

        private void button_ThemAnh_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                newPicture = openFileDialog.SafeFileName;
                path1 = openFileDialog.FileName;
                path2 = defaultpath + newPicture;
                txtBoxHinhAnh.Text = newPicture;
            }
        }
    }
}
