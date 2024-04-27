using DoAnCoSo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCoSo.DAO
{
    public class LoaiHangHoaDAO
    {
        private static LoaiHangHoaDAO instance;

        public static LoaiHangHoaDAO Instance
        {
            get { if (instance == null) instance = new LoaiHangHoaDAO(); return LoaiHangHoaDAO.instance; }
            private set { LoaiHangHoaDAO.instance = value; }
        }

        private LoaiHangHoaDAO() { }

        public List<LoaiHangHoa> GetListCategory()
        {
            List<LoaiHangHoa> list = new List<LoaiHangHoa>();

            string query = "select * from LoaiHangHoa";

            DataTable data = Connection.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LoaiHangHoa loaihanghoa = new LoaiHangHoa(item);
                list.Add(loaihanghoa);
            }

            return list;
        }

        public LoaiHangHoa GetCategoryByID(int id)
        {
            LoaiHangHoa loaihanghoa = null;

            string query = "select * from LoaiHangHoa where Id = " + id;

            DataTable data = Connection.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                loaihanghoa = new LoaiHangHoa(item);
                return loaihanghoa;
            }

            return loaihanghoa;
        }

        public bool InsertCategory(string name)
        {
            string query = string.Format("INSERT dbo.LoaiHangHoa ( Name )VALUES  ( N'{0}')", name);
            int result = Connection.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCategory(string name, int id)
        {
            string query = string.Format("UPDATE dbo.LoaiHangHoa SET Name = N'{0}' WHERE Id = {1}", name, id);
            int result = Connection.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCategory(int id)
        {
            string query = string.Format("Delete LoaiHangHoa where id = {0}", id);
            int result = Connection.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
