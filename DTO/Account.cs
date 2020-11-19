using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemBanh.DTO
{
    class Account
    {
        private string userName;
        private string password;
        private int type;
        private int nhanvien_id;
        public Account(string userName, string password,  int type, int nhanvien_id)
        {
            this.UserName = userName;
            this.Password = password;
            this.Type = type;
            this.Nhanvien_id = nhanvien_id;
        }
        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.Password = row["password"].ToString();
            this.Type = (int)row["type"];
            this.Nhanvien_id = (int)row["nhanvien_id"];
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int Type { get => type; set => type = value; }
        public int Nhanvien_id { get => nhanvien_id; set => nhanvien_id = value; }
    }
}
