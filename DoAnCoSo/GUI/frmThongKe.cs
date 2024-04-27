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
    public partial class frmThongKe : Form
    {
        BindingSource billimportList = new BindingSource();
        BindingSource billExportList = new BindingSource();
        private frmtrangchu parentForm;

        public frmThongKe(frmtrangchu parentForm)
        {
            InitializeComponent();
            LoadDateTimePickerBill();
            this.parentForm = parentForm;
        }

        void LoadListBillImportByDate(DateTime date_import)
        {
            dgvthongkehd.DataSource = HoaDonNhapDAO.Instance.GetBillImportListByDate(date_import);
        }

        void LoadListBillExportByDate(DateTime date_export)
        {
            dgvthongkehd.DataSource = HoaDonXuatDAO.Instance.GetBillExportListByDate(date_export);
        }
        void LoadListBillImport()
        {
            billimportList.DataSource = HoaDonNhapDAO.Instance.GetListBillImport();
        }
        void LoadListBillExport()
        {
            billExportList.DataSource = HoaDonXuatDAO.Instance.GetListBillExport();
        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpdatefrom.Value = new DateTime(today.Year, today.Month, 1);
            dtpdateto.Value = dtpdatefrom.Value.AddMonths(1).AddDays(-1);
        }

        private void btnxembill_Click(object sender, EventArgs e)
        {
            if (rdbhdnhap.Checked == true)
            {
                LoadListBillImportByDate(dtpdateto.Value);
                
            }
            if (rdbhdxuat.Checked == true)
            {
                LoadListBillExportByDate(dtpdateto.Value);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmtrangchu ftc = new frmtrangchu(parentForm.LoginAccount);
            this.Hide();
            ftc.Show();
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            if (rdbhdnhap.Checked == true)
            {
                LoadListBillImport();
                dgvthongkehd.DataSource = billimportList;
            }
            if (rdbhdxuat.Checked == true)
            {
                LoadListBillExport();
                dgvthongkehd.DataSource = billExportList;
            }
        }
    }
}
