using DoAnCoSo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCoSo.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            private set { NhanVienDAO.instance = value; }
        }

        private NhanVienDAO() { }

        public List<NhanVien> GetListStaff()
        {
            List<NhanVien> list = new List<NhanVien>();

            string query = "select * from NhanVien";

            DataTable data = Connection.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien nv = new NhanVien(item);
                list.Add(nv);
            }

            return list;
        }

        public bool InsertStaff(string id, string name, string numberphone, string email, string address, DateTime date)
        {
            string query = string.Format("INSERT dbo.NhanVien ( MaNV, TenNV, SDT, Email, DiaChi, NgaySinh )" +
                "VALUES  ( N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}')", id, name, numberphone, email, address, date.ToString("yyyy-MM-dd"));
            int result = Connection.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateStaff(string id, string name, string numberphone, string email, string address, DateTime date)
        {
            string query = string.Format("UPDATE dbo.NhanVien SET TenNV = N'{0}', SDT = N'{1}', Email = N'{2}', DiaChi = N'{3}', NgaySinh = '{4}' WHERE MaNV = N'{5}' "
                , name, numberphone, email, address, date.ToString("yyyy-MM-dd"), id);
            int result = Connection.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteStaff(string id)
        {
            string query = string.Format("Delete NhanVien where MaNV = N'{0}'", id);
            int result = Connection.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<NhanVien> SearchStaffByName(string name)
        {
            List<NhanVien> list = new List<NhanVien>();

            string query = string.Format("SELECT * FROM dbo.NhanVien WHERE TenNV LIKE N'%{0}%'", name);

            DataTable data = Connection.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien nv = new NhanVien(item);
                list.Add(nv);
            }

            return list;
        }
    }
}
