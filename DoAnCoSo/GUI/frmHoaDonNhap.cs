using DoAnCoSo.DAO;
using DoAnCoSo.DTO;
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

namespace DoAnCoSo.GUI
{
    public partial class frmHoaDonNhap : Form
    {
        BindingSource billimportList = new BindingSource();
        private frmtrangchu parentForm;
        public frmHoaDonNhap(frmtrangchu parent)
        {
            InitializeComponent();
            LoadProductIntoCombobox(cbxmahh);
            LoadListBillImport();
            parentForm = parent;
            dgvhdnhap.DataSource = billimportList;
        }
        #region
        private event EventHandler insertBillImport;
        public event EventHandler InsertBillImport
        {
            add { insertBillImport += value; }
            remove { insertBillImport -= value; }
        }

        private event EventHandler deleteBillImport;
        public event EventHandler DeleteBillImport
        {
            add { deleteBillImport += value; }
            remove { deleteBillImport -= value; }
        }

        private event EventHandler updateBillImport;
        public event EventHandler UpdateBillImport
        {
            add { updateBillImport += value; }
            remove { updateBillImport -= value; }
        }
        #endregion

        private void tRANGCHỦToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmtrangchu ftc = new frmtrangchu(parentForm.LoginAccount);
            this.Close();
            ftc.Show();
        }

        void LoadProductIntoCombobox(ComboBox cb)
        {
            cb.DataSource = HangHoaDAO.Instance.GetListProduct();
            cb.DisplayMember = "Id";
        }
        void LoadListBillImport()
        {
            billimportList.DataSource = HoaDonNhapDAO.Instance.GetListBillImport();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string id = txtmahdnhap.Text;
            string id_product = (cbxmahh.SelectedItem as HangHoa).Id;
            string name_product = txttenhh.Text;
            string ncc = txtncc.Text;
            int gianhap = Convert.ToInt32(txtgianhap.Text);
            int sl = Convert.ToInt32(txtsl.Text);
            DateTime date_import = dtpngaynhap.Value;

            if (HoaDonNhapDAO.Instance.InsertBillImport(id, id_product, name_product, ncc, gianhap, sl, date_import))
            {
                MessageBox.Show("Thêm thành công");
                LoadListBillImport();
                if (insertBillImport != null)
                {
                    insertBillImport(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Nhập sai");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string id = txtmahdnhap.Text;
            string id_product = (cbxmahh.SelectedItem as HangHoa).Id;
            string name_product = txttenhh.Text;
            string ncc = txtncc.Text;
            int gianhap = Convert.ToInt32(txtgianhap.Text);
            int sl = Convert.ToInt32(txtsl.Text);
            DateTime date_import = dtpngaynhap.Value;

            if (HoaDonNhapDAO.Instance.UpdateBillImportt(id, id_product, name_product, ncc, gianhap, sl, date_import))
            {
                MessageBox.Show("Sửa thành công");
                LoadListBillImport();
                if (updateBillImport != null)
                {
                    updateBillImport(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Nhập sai");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string id = txtmahdnhap.Text;

            if (HoaDonNhapDAO.Instance.DeleteBillImport(id))
            {
                MessageBox.Show("Xóa thành công");
                LoadListBillImport();
                if (deleteBillImport != null)
                {
                    deleteBillImport(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void cbxmahh_TextChanged(object sender, EventArgs e)
        {
            string selectedId = cbxmahh.Text;
            HangHoaDAO hangHoaDAO = HangHoaDAO.Instance;
            HangHoa product = hangHoaDAO.GetProductById(selectedId);

            if (product != null)
            {
                txttenhh.Text = product.Name;
                txtncc.Text = product.Supplier;
                txtgianhap.Text = product.Entry_price.ToString();
            }
            else
            {
                txttenhh.Text = string.Empty;
                txtncc.Text = string.Empty;
                txtgianhap.Text = string.Empty;
            }
        }

        private void dgvhdnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvhdnhap.Rows[e.RowIndex];
            txtmahdnhap.Text = Convert.ToString(row.Cells[0].Value);
            cbxmahh.Text = Convert.ToString(row.Cells[1].Value);
            txttenhh.Text = Convert.ToString(row.Cells[2].Value);
            txtncc.Text = Convert.ToString(row.Cells[3].Value);
            txtgianhap.Text = Convert.ToString(row.Cells[4].Value);
            txtsl.Text = Convert.ToString(row.Cells[5].Value);
            dtpngaynhap.Text = Convert.ToString(row.Cells[6].Value);
        }
    }
}
