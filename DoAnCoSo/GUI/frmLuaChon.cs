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
    public partial class frmLuaChon : Form
    {
        private frmtrangchu parentForm;
        public frmLuaChon(frmtrangchu parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void btnlcok_Click(object sender, EventArgs e)
        {
            if (rdbnhap.Checked == true)
            {
                frmHoaDonNhap fhdn = new frmHoaDonNhap(this.parentForm);
                this.Hide();
                fhdn.Show();
            }
            if (rdbxuat.Checked == true)
            {
                frmHoaDonXuat fhdx = new frmHoaDonXuat(this.parentForm);
                this.Hide();
                fhdx.Show();
            }
        }

        private void btnlcback_Click(object sender, EventArgs e)
        {
            frmtrangchu ftc = new frmtrangchu(parentForm.LoginAccount);
            this.Close(); 
            ftc.Show();
        }
    }
}
