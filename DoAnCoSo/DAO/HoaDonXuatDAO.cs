using DoAnCoSo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCoSo.DAO
{
    public class HoaDonXuatDAO
    {
        private static HoaDonXuatDAO instance;

        public static HoaDonXuatDAO Instance
        {
            get { if (instance == null) instance = new HoaDonXuatDAO(); return HoaDonXuatDAO.instance; }
            private set { HoaDonXuatDAO.instance = value; }
        }

        public HoaDonXuatDAO() { }

        public List<HoaDonXuat> GetListBillExport()
        {
            List<HoaDonXuat> list = new List<HoaDonXuat>();

            string query = "select * from HoaDonXuat";

            DataTable data = Connection.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HoaDonXuat hdx = new HoaDonXuat(item);
                list.Add(hdx);
            }
            return list;
        }

        public DataTable GetBillExportListByDate(DateTime date_export)
        {
            return Connection.Instance.ExecuteQuery("exec USP_GetListBillExportByDate @ngayxuat", new object[] { date_export });
        }

        public bool InsertBillExport(string id, string id_product, string name_product, string supplier_product, int price, int quantity, DateTime date_export)
        {
            string query = string.Format("INSERT dbo.HoaDonXuat ( MaXuat, MaHangHoa, TenHangHoa, Ncc, GiaXuat, SoLuong, NgayXuat )" +
                "VALUES  ( N'{0}', N'{1}', N'{2}', N'{3}', {4}, {5}, '{6}')", id, id_product, name_product, supplier_product, price, quantity, date_export.ToString("yyyy-MM-dd"));
            int result = Connection.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateBillExport(string id, string id_product, string name_product, string supplier_product, int price, int quantity, DateTime date_export)
        {
            string query = string.Format("UPDATE dbo.HoaDonXuat SET MaHangHoa = N'{0}', TenHangHoa = N'{1}', Ncc = N'{2}', GiaXuat = {3}, SoLuong = {4}, NgayXuat = '{5}' WHERE MaXuat = N'{6}' "
                , id_product, name_product, supplier_product, price, quantity, date_export.ToString("yyyy-MM-dd"), id);
            int result = Connection.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteBillExport(string id)
        {
            string query = string.Format("Delete HoaDonXuat where MaXuat = N'{0}'", id);
            int result = Connection.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}


