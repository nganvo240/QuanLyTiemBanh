using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemBanh.DAO
{
    class CakeDAO
    {
        private static CakeDAO instance;

        public static CakeDAO Instance
        {
            get { if (instance == null) instance = new CakeDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable GetListCake()
        {
            return DataProvider.Instance.ExecuteQuery("Select id, name, price, category_id, amount, place From Cake");
        }

        public bool InsertCake(int id, string name, int price, int category_id, int amount, string place)
        {
            string query = string.Format("INSERT Cake ( id, name, price, category_id, amount, place )VALUES  ( {0}, N'{1}', {2}, {3}, {4}, N'{5}')", id, name, price, category_id, amount, place);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCake(int id, string name, int price, int category_id, int amount, string place)
        {
            string query = string.Format("UPDATE Cake SET id = {0}, name = N'{1}', price = {2}, category_id = {3}, amount = {4}, place = N'{5}' where id={0}", id, name, price, category_id, amount, place);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCake(int id)
        {
            //xóa trên bảng BILL_INFOR trước


            string query = string.Format("Delete Cake where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
