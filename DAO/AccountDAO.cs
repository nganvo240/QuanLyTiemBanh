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
            string query = "USP_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }
        public Account GetAccountByUserName(string userName)
        {
            string query = "USP_GetAccountByUserName @userName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("select * from v_GetListAccount");
        }
        public bool InsertAccount(string userName, string pass, int type, int nhanvien_id)
        {
            string query = string.Format("SP_insAccount @userName , @pass , @type , @nhanvien_id");
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, pass, type, nhanvien_id });

            return result > 0;
        }
        public bool UpdateAccount(string userName, string pass, int type, int nhanvien_id)
        {
            string query = string.Format("UPDATE dbo.Account SET username = N'{0}', password = {1}, type = {2}, nhanvien_id = {3} where username=N'{0}'", userName, pass, type, nhanvien_id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;   
        }
        public bool DeleteAccount(string userName, string usernameislogged)
        {
            string query = "SP_DeleteAccount @userName , @usernameislogged";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, usernameislogged });

            return result > 0;
        }
    }
}

