using DoAnCoSo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCoSo.DAO
{
    public class HoaDonNhapDAO
    {
        private static HoaDonNhapDAO instance;

        public static HoaDonNhapDAO Instance
        {
            get { if (instance == null) instance = new HoaDonNhapDAO(); return HoaDonNhapDAO.instance; }
            private set { HoaDonNhapDAO.instance = value; }
        }

        public HoaDonNhapDAO() { }

        public List<HoaDonNhap> GetListBillImport()
        {
            List<HoaDonNhap> list = new List<HoaDonNhap>();

            string query = "select * from HoaDonNhap";

            DataTable data = Connection.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HoaDonNhap hdn = new HoaDonNhap(item);
                list.Add(hdn);
            }
            return list;
        }

        public DataTable GetBillImportListByDate(DateTime date_import)
        {
            return Connection.Instance.ExecuteQuery("exec USP_GetListBillImportByDate @ngaynhap", new object[] { date_import });
        }

        public bool InsertBillImport(string id, string id_product, string name_product, string supplier_product, int entry_price, int quantity, DateTime date_import)
        {
            string query = string.Format("INSERT dbo.HoaDonNhap ( MaNhap, MaHangHoa, TenHangHoa, Ncc, GiaNhap, SoLuong, NgayNhap )" +
                "VALUES  ( N'{0}', N'{1}', N'{2}', N'{3}', {4}, {5}, '{6}')", id,  id_product,  name_product,  supplier_product,  entry_price,  quantity,  date_import.ToString("yyyy-MM-dd"));
            int result = Connection.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateBillImportt(string id, string id_product, string name_product, string supplier_product, int entry_price, int quantity, DateTime date_import)
        {
            string query = string.Format("UPDATE dbo.HoaDonNhap SET MaHangHoa = N'{0}', TenHangHoa = N'{1}', Ncc = N'{2}', GiaNhap = {3}, SoLuong = {4}, NgayNhap = '{5}' WHERE MaNhap = N'{6}' "
                , id_product, name_product, supplier_product, entry_price, quantity, date_import.ToString("yyyy-MM-dd"), id);
            int result = Connection.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteBillImport(string id)
        {
            string query = string.Format("Delete HoaDonNhap where MaNhap = N'{0}'", id);
            int result = Connection.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}


