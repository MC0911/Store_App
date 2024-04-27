using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCoSo.DTO
{
    public class HoaDonXuat
    {
        private string id;
        private string id_product;
        private string name_product;
        private string supplier_product;
        private int price;
        private int quantity;
        private DateTime date_export;

        public HoaDonXuat(string id, string id_product, string name_product, string supplier_product, int price, int quantity, DateTime date_export)
        {
            this.Id = id;
            this.Id_product = id_product;
            this.Name_product = name_product;
            this.Supplier_product = supplier_product;
            this.Price = price;
            this.Quantity = quantity;
            this.Date_export = date_export;
        }

        public HoaDonXuat(DataRow row)
        {
            this.Id = row["MaXuat"].ToString();
            this.Id_product = row["MaHangHoa"].ToString();
            this.Name_product = row["TenHangHoa"].ToString();
            this.Supplier_product = row["Ncc"].ToString();
            this.Price = (int)row["GiaXuat"];
            this.Quantity = (int)row["SoLuong"];
            this.Date_export = (DateTime)row["NgayXuat"];
        }

        public HoaDonXuat()
        {
        }

        public string Id { get => id; set => id = value; }
        public string Id_product { get => id_product; set => id_product = value; }
        public string Name_product { get => name_product; set => name_product = value; }
        public string Supplier_product { get => supplier_product; set => supplier_product = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime Date_export { get => date_export; set => date_export = value; }
    }
}
