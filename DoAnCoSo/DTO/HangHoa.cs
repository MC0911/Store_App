using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCoSo.DTO
{
    public class HangHoa
    {
        private string id;
        private string name;
        private int id_category;
        private string supplier;
        private int entry_price;
        private int price;
        private string unit;
        private DateTime manufacture_date;
        private DateTime expiry_date;
        private int quantity;

        public HangHoa()
        {
        }

        public HangHoa(DataRow row)
        {
            this.Id = row["Id"].ToString();
            this.Name = row["Name"].ToString();
            this.Id_category = (int)row["Id_Loaihh"];
            this.Supplier = row["Ncc"].ToString();
            this.Entry_price = (int)row["Entry_price"];
            this.Price = (int)row["Price"];
            this.Unit = row["Unit"].ToString();
            this.Manufacture_date = (DateTime)row["NSX"];
            this.Expiry_date = (DateTime)row["HSD"];
            this.Quantity = (int)row["Quantity"];
        }

        public HangHoa(string id, string name, int id_category, string supplier, int entry_price, int price, string unit, DateTime manufacture_date, DateTime expiry_date, int quantity)
        {
            this.Id = id;
            this.Name = name;
            this.Id_category = id_category;
            this.Supplier = supplier;
            this.Entry_price = entry_price;
            this.Price = price;
            this.Unit = unit;
            this.Manufacture_date = manufacture_date;
            this.Expiry_date = expiry_date;
            this.Quantity = quantity;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Id_category { get => id_category; set => id_category = value; }
        public string Supplier { get => supplier; set => supplier = value; }
        public int Entry_price { get => entry_price; set => entry_price = value; }
        public int Price { get => price; set => price = value; }
        public string Unit { get => unit; set => unit = value; }
        public DateTime Manufacture_date { get => manufacture_date; set => manufacture_date = value; }
        public DateTime Expiry_date { get => expiry_date; set => expiry_date = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
