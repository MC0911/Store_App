using DoAnCoSo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCoSo.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";

            DataTable result = Connection.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }

        public bool UpdateAccount(string userName, string pass, string newPass)
        {
            int result = Connection.Instance.ExecuteNonQuery("exec USP_UpdateAccount @username  , @password , @newpass", new object[] { userName, pass, newPass });

            return result > 0;
        }

        public bool RegisterAccount(string userName, string password, string email)
        {
            string query = "INSERT INTO TaiKhoan VALUES('Staff','" + userName + "','" + email + "', '" + password + "')";
            int result = Connection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool CheckEmail(string email)
        {
            string query = "SELECT * FROM TaiKhoan WHERE Email = '" + email + "'";
            DataTable result = Connection.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public DataTable GetListAccount()
        {
            return Connection.Instance.ExecuteQuery("SELECT username, permission, email FROM dbo.TaiKhoan");
        }

        public TaiKhoan GetAccountByUserName(string userName)
        {
            DataTable data = Connection.Instance.ExecuteQuery("Select * from TaiKhoan where userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new TaiKhoan(item);
            }

            return null;
        }
    }
}
