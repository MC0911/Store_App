using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCoSo.DTO
{
    public class HoaDonNhap
    {
        private string id;
        private string id_product;
        private string name_product;
        private string supplier_product;
        private int entry_price;
        private int quantity;
        private DateTime date_import;

        public HoaDonNhap(string id, string id_product, string name_product, string supplier_product, int entry_price, int quantity, DateTime date_import)
        {
            this.Id = id;
            this.Id_product = id_product;
            this.Name_product = name_product;
            this.Supplier_product = supplier_product;
            this.Entry_price = entry_price;
            this.Quantity = quantity;
            this.Date_import = date_import;
        }

        public HoaDonNhap(DataRow row)
        {
            this.Id = row["MaNhap"].ToString();
            this.Id_product = row["MaHangHoa"].ToString();
            this.Name_product = row["TenHangHoa"].ToString();
            this.Supplier_product = row["Ncc"].ToString();
            this.Entry_price = (int)row["GiaNhap"];
            this.Quantity = (int)row["SoLuong"];
            this.Date_import = (DateTime)row["NgayNhap"];
        }

        public HoaDonNhap()
        {
        }

        public string Id { get => id; set => id = value; }
        public string Id_product { get => id_product; set => id_product = value; }
        public string Name_product { get => name_product; set => name_product = value; }
        public string Supplier_product { get => supplier_product; set => supplier_product = value; }
        public int Entry_price { get => entry_price; set => entry_price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime Date_import { get => date_import; set => date_import = value; }
    }
}
