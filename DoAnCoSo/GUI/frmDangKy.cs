using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DoAnCoSo.DAO;

namespace DoAnCoSo.GUI
{
    public partial class frmDangKy : Form
    {
        BindingSource accountList = new BindingSource();
        private frmtrangchu parentForm;
        public frmDangKy(frmtrangchu parentForm)
        {
            InitializeComponent();
            dgvtttaikhoan.DataSource = accountList;
            LoadListAccount();
            this.parentForm = parentForm;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmtrangchu ftc = new frmtrangchu(parentForm.LoginAccount);
            this.Hide();
            ftc.Show();
        }
        void LoadListAccount ()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        public bool checkPassword(string psw)
        {
            return Regex.IsMatch(psw, "^[a-zA-Z0-9]{6,24}$");
        }
        private void btndangky_Click(object sender, EventArgs e)
        {
            frmtrangchu ftc = new frmtrangchu(parentForm.LoginAccount);
            string tentk = txttendangky.Text;
            string matkhau = txtmatkhau.Text;
            string xnmk = txtxacnhanmk.Text;
            string email = txtemail.Text;
            if (!checkPassword(matkhau))
            {
                MessageBox.Show("Mật khẩu chỉ từ 6-24 ký tự và không có ký tự đặc biệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (xnmk != matkhau)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (AccountDAO.Instance.CheckEmail(email))
            {
                MessageBox.Show("Email này đã được đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (AccountDAO.Instance.RegisterAccount(tentk, email, matkhau))
                    if (MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Hide();
                        ftc.Show();
                    }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
