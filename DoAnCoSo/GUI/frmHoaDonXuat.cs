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
    public partial class frmHoaDonXuat : Form
    {
        BindingSource billExportList = new BindingSource();
        private frmtrangchu parentForm;
        public frmHoaDonXuat(frmtrangchu parent)
        {
            InitializeComponent();
            LoadProductIntoCombobox(cbxmahh);
            LoadListBillExport();
            dgvhdxuat.DataSource = billExportList;
            parentForm = parent;
        }

        #region
        private event EventHandler insertBillExport;
        public event EventHandler InsertBillExport
        {
            add { insertBillExport += value; }
            remove { insertBillExport -= value; }
        }

        private event EventHandler deleteBillExport;
        public event EventHandler DeleteBillExport
        {
            add { deleteBillExport += value; }
            remove { deleteBillExport -= value; }
        }

        private event EventHandler updateBillExport;
        public event EventHandler UpdateBillExport
        {
            add { updateBillExport += value; }
            remove { updateBillExport -= value; }
        }
        #endregion

        void LoadProductIntoCombobox(ComboBox cb)
        {
            cb.DataSource = HangHoaDAO.Instance.GetListProduct();
            cb.DisplayMember = "Id";
        }

        void LoadListBillExport()
        {
            billExportList.DataSource = HoaDonXuatDAO.Instance.GetListBillExport();
        }

        private void tRANGCHỦToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmtrangchu ftc = new frmtrangchu(parentForm.LoginAccount);
            this.Close();
            ftc.Show();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string id = txtmahdxuat.Text;
            string id_product = (cbxmahh.SelectedItem as HangHoa).Id;
            string name_product = txttenhh.Text;
            string ncc = txtncc.Text;
            int giaxuat = Convert.ToInt32(txtgiaxuat.Text);
            int sl = Convert.ToInt32(txtsl.Text);
            DateTime date_export = dtpngayxuat.Value;

            if (HoaDonXuatDAO.Instance.InsertBillExport(id, id_product, name_product, ncc, giaxuat, sl, date_export))
            {
                MessageBox.Show("Thêm thành công");
                LoadListBillExport();
                if (insertBillExport != null)
                {
                    insertBillExport(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Nhập sai");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string id = txtmahdxuat.Text;
            string id_product = (cbxmahh.SelectedItem as HangHoa).Id;
            string name_product = txttenhh.Text;
            string ncc = txtncc.Text;
            int giaxuat = Convert.ToInt32(txtgiaxuat.Text);
            int sl = Convert.ToInt32(txtsl.Text);
            DateTime date_export = dtpngayxuat.Value;

            if (HoaDonXuatDAO.Instance.UpdateBillExport(id, id_product, name_product, ncc, giaxuat, sl, date_export))
            {
                MessageBox.Show("Thêm thành công");
                LoadListBillExport();
                if (updateBillExport != null)
                {
                    updateBillExport(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Nhập sai");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string id = txtmahdxuat.Text;

            if (HoaDonXuatDAO.Instance.DeleteBillExport(id))
            {
                MessageBox.Show("Xóa thành công");
                LoadListBillExport();
                if (deleteBillExport != null)
                {
                    deleteBillExport(this, new EventArgs());
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
                txtgiaxuat.Text = product.Price.ToString();
            }
            else
            {
                txttenhh.Text = string.Empty;
                txtncc.Text = string.Empty;
                txtgiaxuat.Text = string.Empty;
            }
        }

        private void dgvhdxuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvhdxuat.Rows[e.RowIndex];
            txtmahdxuat.Text = Convert.ToString(row.Cells[0].Value);
            cbxmahh.Text = Convert.ToString(row.Cells[1].Value);
            txttenhh.Text = Convert.ToString(row.Cells[2].Value);
            txtncc.Text = Convert.ToString(row.Cells[3].Value);
            txtgiaxuat.Text = Convert.ToString(row.Cells[4].Value);
            txtsl.Text = Convert.ToString(row.Cells[5].Value);
            dtpngayxuat.Text = Convert.ToString(row.Cells[6].Value);
        }
    }
}
