using DoAnCoSo.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCoSo.GUI
{
    public partial class frmDoiMatKhau : Form
    {
        private frmtrangchu parentForm;
        public frmDoiMatKhau(frmtrangchu parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        void UpdateAccount()
        {
            string username = txttendangnhap.Text;
            string password = txtmkcu.Text;
            string newpass = txtmatkhaumoi.Text;
            string xnmk = txtxacnhanmk.Text;
            frmdangnhap fdn = new frmdangnhap();
        
            if (xnmk != newpass)
            {
                MessageBox.Show("Mật khẩu không trùng khớp với mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(username, password, newpass))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    fdn.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            frmtrangchu ftc = new frmtrangchu(parentForm.LoginAccount);
            this.Hide();
            ftc.Show();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }
    }
}
