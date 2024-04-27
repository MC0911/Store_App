using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCoSo.DTO
{
    public class LoaiHangHoa
    {
        private string name;
        private int id;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }

        public LoaiHangHoa(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public LoaiHangHoa(DataRow row) 
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();          
        }
    }
}
