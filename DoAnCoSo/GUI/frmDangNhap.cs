using DoAnCoSo.DAO;
using DoAnCoSo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCoSo
{
    public partial class frmdangnhap : Form
    {
        private bool isLogout = false;
        public frmdangnhap()
        {
            InitializeComponent();

        }
        private void frmdangnhap_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                txttendangnhap.Text = Properties.Settings.Default.UserName;
                txtmatkhau.Text = Properties.Settings.Default.PassWord;
            }
        }
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string tentk = txttendangnhap.Text;
            string matkhau = txtmatkhau.Text;
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if (Login(tentk, matkhau))
                {
                    TaiKhoan loginAccount = AccountDAO.Instance.GetAccountByUserName(tentk);
                    isLogout = true;
                    frmtrangchu ftc = new frmtrangchu(loginAccount);
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ftc.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (cbghinho.Checked)
            {
                Properties.Settings.Default.UserName = txttendangnhap.Text;
                Properties.Settings.Default.PassWord = txtmatkhau.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmdangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLogout)
            {
                if (MessageBox.Show("Thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
