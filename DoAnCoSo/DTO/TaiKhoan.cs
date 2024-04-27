using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCoSo.DTO
{
    public class TaiKhoan
    {
        private static TaiKhoan instance;
        public static TaiKhoan Instance
        {
            get { if (instance == null) instance = new TaiKhoan(); return instance; }
            private set { instance = value; }
        }

        private TaiKhoan()
        {

        }

        private int id_user;
        public int Id_User
        {
            get { return id_user; }
            set { id_user = value; }
        }
        private string permission;
        public string Permission
        {
            get { return permission; }
            set { permission = value; }
        }
        private string username;
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        private string password;
        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public TaiKhoan(int id_user, string permission, string username, string password, string email)
        {
            this.id_user = id_user;
            this.permission = permission;
            this.username = username;
            this.password = password;
            this.email = email;
        }
        public TaiKhoan(DataRow row)
        {
            this.id_user = (int)row["id_user"];
            this.permission = row["permission"].ToString();
            this.username = row["username"].ToString();
            this.password = row["password"].ToString();
            this.email = row["email"].ToString();
        }
    }
}
