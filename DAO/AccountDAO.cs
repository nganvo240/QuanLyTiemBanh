using QuanLyTiemBanh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemBanh.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        public bool Login(string userName, string passWord)
        {
            string query = "select * from Account where username= '"+userName+"' and password= '"+ passWord + "' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {});

            return result.Rows.Count > 0;
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from account where userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("select username, password, type, name as Tên_nhân_viên from employee, account where employee.id=account.nhanvien_id");
        }
        public bool InsertAccount(string userName, string pass, int type, int nhanvien_id)
        {
            string query = string.Format("INSERT Account ( username, password, type, nhanvien_id )VALUES  ( N'{0}', {1}, {2}, {3})", userName, pass, type, nhanvien_id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateAccount(string userName, string pass, int type, int nhanvien_id)
        {
            string query = string.Format("UPDATE dbo.Account SET username = N'{0}', password = {1}, type = {2}, nhanvien_id = {3} where username=N'{0}'", userName, pass, type, nhanvien_id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteAccount(string userName)
        {
            string query = string.Format("Delete Account where UserName = N'{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}

