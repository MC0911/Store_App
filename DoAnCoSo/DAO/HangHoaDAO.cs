using DoAnCoSo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCoSo.DAO
{
    public class HangHoaDAO
    {
        private static HangHoaDAO instance;

        public static HangHoaDAO Instance
        {
            get { if (instance == null) instance = new HangHoaDAO(); return HangHoaDAO.instance; }
            private set { HangHoaDAO.instance = value; }
        }

        private HangHoaDAO() { }


        public List<HangHoa> GetListProduct()
        {
            List<HangHoa> list = new List<HangHoa>();

            string query = "select * from HangHoa";

            DataTable data = Connection.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HangHoa hh = new HangHoa(item);
                list.Add(hh);
            }

            return list;
        }

        public HangHoa GetProductById(string id)
        {
            string query = "SELECT Name, Ncc, Entry_price, Price FROM HangHoa WHERE Id = @MaHangHoa";

            using (SqlConnection connection = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=DoAnCoSo;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaHangHoa", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            HangHoa product = new HangHoa
                            {
                                Name = reader["Name"].ToString(),
                                Supplier = reader["Ncc"].ToString(),
                                Entry_price = Convert.ToInt32(reader["Entry_price"]),
                                Price = Convert.ToInt32(reader["Price"])
                            };

                            return product;
                        }
                    }
                }
            }

            return null;
        }

        public bool InsertProduct(string mahh, string tenhh, int id_hh, string ncc, int gianhap, int giaban, string DVT, DateTime HSD, DateTime NSX, int sl)
        {
            string query = string.Format("INSERT dbo.HangHoa ( Id, Name, Id_Loaihh, Ncc, Entry_price, Price, Unit, HSD, NSX, Quantity )" +
                "VALUES  ( N'{0}', N'{1}', {2}, N'{3}', {4}, {5}, N'{6}', '{7}', '{8}', {9}  )", mahh, tenhh, id_hh, ncc, gianhap, giaban, DVT, HSD.ToString("yyyy-MM-dd"), NSX.ToString("yyyy-MM-dd"), sl);
            int result = Connection.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateProduct(string mahh, string tenhh, int id_hh, string ncc, int gianhap, int giaban, string DVT, DateTime HSD, DateTime NSX, int sl)
        {
            string query = string.Format("UPDATE dbo.HangHoa SET Name = N'{0}', Id_Loaihh = {1}, Ncc = N'{2}', Entry_price = {3}, Price = {4}, Unit = N'{5}', HSD = '{6}', NSX = '{7}', Quantity = {8} WHERE Id = N'{9}' "
                , tenhh, id_hh, ncc, gianhap, giaban, DVT, HSD.ToString("yyyy-MM-dd"), NSX.ToString("yyyy-MM-dd"), sl, mahh);
            int result = Connection.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteProduct(string mahh)
        {
            string query = string.Format("Delete HangHoa where Id = N'{0}'", mahh);
            int result = Connection.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<HangHoa> SearchProductByName(string name)
        {
            List<HangHoa> list = new List<HangHoa>();

            string query = string.Format("SELECT * FROM dbo.HangHoa WHERE Name LIKE N'%{0}%'", name);

            DataTable data = Connection.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HangHoa hh = new HangHoa(item);
                list.Add(hh);
            }

            return list;
        }
    }
}
