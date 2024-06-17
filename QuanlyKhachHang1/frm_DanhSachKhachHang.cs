using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKhachHang1
{
    public partial class frm_DanhSachKhachHang : Form
    {
        public frm_DanhSachKhachHang()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public void LoadKH()
        {
            string sql = "Select * from KHACHHANG";
            dt_KhachHang.DataSource = lopchung.LoadDL(sql);
        }
        public void LoadKLoaiKH()
        {
            string sql = "Select * from LOAIKHACH";
            cb_LoaiKhachHang.DataSource = lopchung.LoadDL(sql);
            cb_LoaiKhachHang.DisplayMember = "LoaiKhach";
            cb_LoaiKhachHang.ValueMember = "IDLoaiKhach";
        }

        private void frm_DanhSachKhachHang_Load(object sender, EventArgs e)
        {
            LoadKLoaiKH();
            LoadKH();

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into KHACHHANG values ('"+txt_IDKhachHang.Text+"',convert(datetime,'"+dt_NgaySinh.Text+"',103),N'"+txt_HoTen.Text+"',N'"+txt_DiaChi.Text+"','"+cb_LoaiKhachHang.SelectedValue+"')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm khách hàng thành công");
           else MessageBox.Show("Thêm khách hàng thất bại");
            LoadKH();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update KHACHHANG set NgaySinh = convert(datetime,'" + dt_NgaySinh.Text + "',103),HoTen = N'" + txt_HoTen.Text + "',DiaChi = N'" + txt_DiaChi.Text + "',IDLoaiKhach = '" + cb_LoaiKhachHang.SelectedValue + "' where IDKhachHang = '" + txt_IDKhachHang.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm khách hàng thành công");
            else MessageBox.Show("Thêm khách hàng thất bại");
            LoadKH();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete KHACHHANG where IDKhachHang = '" + txt_IDKhachHang.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm khách hàng thành công");
            else MessageBox.Show("Thêm khách hàng thất bại");
            LoadKH();
        }

        private void dt_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IDKhachHang.Text = dt_KhachHang.CurrentRow.Cells["IDKhachHang"].Value.ToString();
            txt_DiaChi.Text = dt_KhachHang.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_HoTen.Text = dt_KhachHang.CurrentRow.Cells["HoTen"].Value.ToString();
            dt_NgaySinh.Text = dt_KhachHang.CurrentRow.Cells["NgaySinh"].Value.ToString();
            cb_LoaiKhachHang.SelectedValue = dt_KhachHang.CurrentRow.Cells["IDLoaiKhach"].Value.ToString();
        }
    }
}
