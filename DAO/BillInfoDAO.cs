using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemBanh.DAO
{
    class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable GetListBillInfo(int billid)
        {
            string query = string.Format("select cake_id, amount, price From BILL_INFORCAKE Where bill_id = {0}", billid);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetListBillInfo()
        {
            return DataProvider.Instance.ExecuteQuery("select name From Cake");
        }
        public bool InsertBillInfo( int Bill_ID, int Cake_ID, int Amount )
        {
            string query = string.Format("INSERT BILL_INFORCAKE ( bill_id, cake_id, amount )VALUES  ( {0}, {1}, {2})", Bill_ID, Cake_ID, Amount);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteBillInfo(int cakeid)
        {
            string query = string.Format("Delete BILL_INFORCAKE where cake_id = {0}", cakeid);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
