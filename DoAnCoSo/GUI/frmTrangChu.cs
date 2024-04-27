using DoAnCoSo.DAO;
using DoAnCoSo.DTO;
using DoAnCoSo.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAnCoSo
{
    public partial class frmtrangchu : Form
    {

        public frmtrangchu(TaiKhoan acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;

        }

        private TaiKhoan loginAccount;

        public TaiKhoan LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Permission); }
        }
        void ChangeAccount(string permission)
        {
            if (permission != "Admin") 
            {
                tàiKhoảnToolStripMenuItem.Enabled = false;
                btnnhanvien.Enabled = false;
                nhânViênToolStripMenuItem.Enabled =false;
            }
        }

        private void frmtrangchu_Load(object sender, EventArgs e)
        {
            if (LoginAccount != null)
            {
                quyềnToolStripMenuItem.Text += " (" + LoginAccount.Permission + ")";
                ChangeAccount(LoginAccount.Permission);
            }
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            frmNhanVien fnv = new frmNhanVien(this);
            this.Hide();
            fnv.Show();
        }

        private void btnkhohang_Click(object sender, EventArgs e)
        {
            frmKhoHang fkh = new frmKhoHang(this);
            this.Hide();
            fkh.Show();
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            frmLuaChon flc = new frmLuaChon(this);
            this.Hide();
            flc.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien fnv = new frmNhanVien(this);
            this.Hide();
            fnv.Show();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonNhap fhdn = new frmHoaDonNhap(this);
            this.Hide();
            fhdn.Show();
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonXuat fhdx = new frmHoaDonXuat(this);
            this.Hide();
            fhdx.Show();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoHang frmKhoHang = new frmKhoHang(this);
            this.Hide();
            frmKhoHang.Show();
        }

        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangKy fdk = new frmDangKy(this);
            this.Hide();
            fdk.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            frmThongKe ftk = new frmThongKe(this);
            this.Hide();
            ftk.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau fdmk = new frmDoiMatKhau(this);
            this.Hide();
            fdmk.Show();
        }

        private void frmtrangchu_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmdangnhap fdn = new frmdangnhap();
            this.Hide();
            fdn.Show();
        }

        private void thốngKêTheoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe ftk = new frmThongKe(this);
            this.Hide();
            ftk.Show();
        }
    }
}
