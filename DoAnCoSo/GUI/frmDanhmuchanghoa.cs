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
    public partial class frmDanhmuchanghoa : Form
    {
        private frmtrangchu parentForm;

        public frmDanhmuchanghoa(frmtrangchu parentForm)
        {
            InitializeComponent();
            LoadListCatrgory();
            this.parentForm = parentForm;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmKhoHang fkh = new frmKhoHang(this.parentForm);
            this.Hide();
            fkh.Show();
        }
        void LoadListCatrgory()
        {
            dtvdanhmuchh.DataSource = LoaiHangHoaDAO.Instance.GetListCategory();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string name = txttenloai.Text;

            if (LoaiHangHoaDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm thành công");
                LoadListCatrgory();
            }
            else
            {
                MessageBox.Show("Nhập sai");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtidloai.Text);

            if (LoaiHangHoaDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa thành công");
                LoadListCatrgory();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string name = txttenloai.Text;
            int id = Convert.ToInt32(txtidloai.Text);

            if (LoaiHangHoaDAO.Instance.UpdateCategory(name, id))
            {
                MessageBox.Show("Sửa thành công");
                LoadListCatrgory();

            }
            else
            {
                MessageBox.Show("Nhập sai");
            }
        }
    }
}
