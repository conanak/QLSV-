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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void dSKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DanhSachKhachHang"] == null)
            {
                frm_DanhSachKhachHang kh = new frm_DanhSachKhachHang();
                kh.MdiParent = this;
                kh.Show();
            }
            else Application.OpenForms["frm_DanhSachKhachHang"].Activate();
        }
    }
}
