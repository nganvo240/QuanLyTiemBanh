using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemBanh.DAO
{
    class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable GetListBill()
        {
            return DataProvider.Instance.ExecuteQuery("select id, day_out, emp_id From BILL");
        }
        public bool InsertBill(  int Emp_ID)
        {
            string query = string.Format("INSERT BILL ( day_out, emp_id )VALUES  ( GETDATE(), {0})",  Emp_ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteBill(int id)
        {
            string query = string.Format("Delete BILL where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
