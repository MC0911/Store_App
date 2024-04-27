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
using System.Xml.Linq;

namespace DoAnCoSo.GUI
{
    public partial class frmKhoHang : Form
    {
        BindingSource productList = new BindingSource();
        private frmtrangchu parentForm;
        public frmKhoHang(frmtrangchu parent)
        {
            InitializeComponent();
            parentForm = parent;
            dgvkhohang.DataSource = productList;
            LoadCategoryIntoCombobox(cbxloaihanghoa);
            LoadListProduct();
        }

        private void tRANGCHỦToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmtrangchu ftc = new frmtrangchu(parentForm.LoginAccount);
            this.Close();
            ftc.Show();
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhmuchanghoa fdnhh = new frmDanhmuchanghoa(this.parentForm);
            this.Hide();
            fdnhh.Show();
        }
        void LoadListProduct()
        {
            productList.DataSource = HangHoaDAO.Instance.GetListProduct();
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = LoaiHangHoaDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        List<HangHoa> SearchProductByName(string name)
        {
            List<HangHoa> listProduct = HangHoaDAO.Instance.SearchProductByName(name);


            return listProduct;
        }

        #region
        private event EventHandler insertProduct;
        public event EventHandler InsertProduct
        {
            add { insertProduct += value; }
            remove { insertProduct -= value; }
        }

        private event EventHandler deleteProduct;
        public event EventHandler DeleteProduct
        {
            add { deleteProduct += value; }
            remove { deleteProduct -= value; }
        }

        private event EventHandler updateProduct;
        public event EventHandler UpdateProduct
        {
            add { updateProduct += value; }
            remove { updateProduct -= value; }
        }
        #endregion
        private void btnthem_Click(object sender, EventArgs e)
        {
            string mahh = txtmahh.Text;
            string tenhh = txttenhh.Text;
            int id_hh = (cbxloaihanghoa.SelectedItem as LoaiHangHoa).Id;
            string ncc = txtncc.Text;
            int gianhap = Convert.ToInt32(txtgianhap.Text);
            int giaban = Convert.ToInt32(txtgiaban.Text);
            string dvt = txtdonvitinh.Text;
            DateTime hsd = dtphsd.Value;
            DateTime nsx = dtpnsx.Value;
            int sl = Convert.ToInt32(txtsl.Text);

            if (HangHoaDAO.Instance.InsertProduct(mahh, tenhh, id_hh, ncc, gianhap, giaban, dvt, hsd, nsx, sl))
            {
                MessageBox.Show("Thêm thành công");
                LoadListProduct();
                if (insertProduct != null)
                {
                    insertProduct(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Nhập sai");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string mahh = txtmahh.Text;
            string tenhh = txttenhh.Text;
            int id_hh = (cbxloaihanghoa.SelectedItem as LoaiHangHoa).Id;
            string ncc = txtncc.Text;
            int gianhap = Convert.ToInt32(txtgianhap.Text);
            int giaban = Convert.ToInt32(txtgiaban.Text);
            string dvt = txtdonvitinh.Text;
            DateTime hsd = dtphsd.Value;
            DateTime nsx = dtpnsx.Value;
            int sl = Convert.ToInt32(txtsl.Text);

            if (HangHoaDAO.Instance.UpdateProduct(mahh, tenhh, id_hh, ncc, gianhap, giaban, dvt, hsd, nsx, sl))
            {
                MessageBox.Show("Sửa thành công");
                LoadListProduct();
                if (updateProduct != null)
                {
                    updateProduct(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Nhập sai");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string mahh = txtmahh.Text;

            if (HangHoaDAO.Instance.DeleteProduct(mahh))
            {
                MessageBox.Show("Xóa thành công");
                LoadListProduct();
                if (deleteProduct != null)
                {
                    deleteProduct(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            productList.DataSource = SearchProductByName(txttimkiem.Text);
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            LoadListProduct();
        }

        private void dgvkhohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvkhohang.Rows[e.RowIndex];
            txtmahh.Text = Convert.ToString(row.Cells[0].Value);
            txttenhh.Text = Convert.ToString(row.Cells[1].Value);
            cbxloaihanghoa.Text = Convert.ToString(row.Cells[2].Value);
            txtncc.Text = Convert.ToString(row.Cells[3].Value);
            txtgianhap.Text = Convert.ToString(row.Cells[4].Value);
            txtgiaban.Text = Convert.ToString(row.Cells[5].Value);
            txtdonvitinh.Text = Convert.ToString(row.Cells[6].Value);
            dtphsd.Text = Convert.ToString(row.Cells[7].Value);
            dtpnsx.Text = Convert.ToString(row.Cells[8].Value);
            txtsl.Text = Convert.ToString(row.Cells[9].Value);
        }
    }
}
