using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCoSo.DTO
{
    public class NhanVien
    {
        private string id;
        private string name;
        private string numberphone;
        private string email;
        private string address;
        private DateTime date;

        public NhanVien(string id, string name, string numberphone, string email, string address, DateTime date)
        {
            this.Id = id;
            this.Name = name;
            this.Numberphone = numberphone;
            this.Email = email;
            this.Address = address;
            this.Date = date;
        }

        public NhanVien(DataRow row)
        {
            this.Id = row["MaNV"].ToString();
            this.Name = row["TenNV"].ToString();
            this.Numberphone = row["SDT"].ToString();
            this.Email = row["Email"].ToString();
            this.Address = row["DiaChi"].ToString();
            this.Date = (DateTime)row["NgaySinh"];
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Numberphone { get => numberphone; set => numberphone = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
