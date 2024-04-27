using DoAnCoSo.DAO;
using DoAnCoSo.DTO;
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
    public partial class frmNhanVien : Form
    {
        BindingSource staffList = new BindingSource();
        private frmtrangchu parentForm;
        public frmNhanVien(frmtrangchu parentForm)
        {
            InitializeComponent();
            LoadListStaff();
            dgvnhanvien.DataSource = staffList;
            this.parentForm = parentForm;
        }

        void LoadListStaff()
        {
            staffList.DataSource = NhanVienDAO.Instance.GetListStaff();
        }


        #region 
        private event EventHandler insertStaff;
        public event EventHandler InsertStaff
        {
            add { insertStaff += value; }
            remove { insertStaff -= value; }
        }

        private event EventHandler deleteStaff;
        public event EventHandler DeleteStaff
        {
            add { deleteStaff += value; }
            remove { deleteStaff -= value; }
        }

        private event EventHandler updateStaff;
        public event EventHandler UpdateStaff
        {
            add { updateStaff += value; }
            remove { updateStaff -= value; }
        }
        #endregion
        List<NhanVien> SearchStaffByName(string name)
        {
            List<NhanVien> listStaff = NhanVienDAO.Instance.SearchStaffByName(name);
            return listStaff;
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtrangchu ftc = new frmtrangchu(parentForm.LoginAccount);
            this.Close();
            ftc.Show();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string id = txtmanv.Text;

            if (NhanVienDAO.Instance.DeleteStaff(id))
            {
                MessageBox.Show("Xóa thành công");
                LoadListStaff();
                if (deleteStaff != null)
                {
                    deleteStaff(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string id = txtmanv.Text;
            string name = txttennv.Text;
            string numberphone = txtdienthoai.Text;
            string email = txtemail.Text;
            string address = txtdiachi.Text;
            DateTime date = dtpngaysinh.Value;

            if (NhanVienDAO.Instance.InsertStaff(id, name, numberphone, email, address, date))
            {
                MessageBox.Show("Thêm thành công");
                LoadListStaff();
                if (insertStaff != null)
                {
                    insertStaff(this, new EventArgs());
                }

            }
            else
            {
                MessageBox.Show("Nhập sai");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string id = txtmanv.Text;
            string name = txttennv.Text;
            string numberphone = txtdienthoai.Text;
            string email = txtemail.Text;
            string address = txtdiachi.Text;
            DateTime date = dtpngaysinh.Value;

            if (NhanVienDAO.Instance.UpdateStaff(id, name, numberphone, email, address, date))
            {
                MessageBox.Show("Sửa thành công");
                LoadListStaff();
                if (updateStaff != null)
                {
                    updateStaff(this, new EventArgs());
                }

            }
            else
            {
                MessageBox.Show("Nhập sai");
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            staffList.DataSource = SearchStaffByName(txttimkiem.Text);
        }

        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvnhanvien.Rows[e.RowIndex];
            txtmanv.Text = Convert.ToString(row.Cells[0].Value);
            txttennv.Text = Convert.ToString(row.Cells[1].Value);
            txtdienthoai.Text = Convert.ToString(row.Cells[2].Value);
            txtemail.Text = Convert.ToString(row.Cells[3].Value);
            txtdiachi.Text = Convert.ToString(row.Cells[4].Value);
            dtpngaysinh.Text = Convert.ToString(row.Cells[5].Value);
        }
    }
}
