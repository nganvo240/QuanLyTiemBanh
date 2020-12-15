using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemBanh.DAO
{
    class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable GetListCake()
        {
            return DataProvider.Instance.ExecuteQuery("Select id, name From Category");
        }
        public bool InsertCategory(int id, string name)
        {
            string query = string.Format("INSERT Category ( id, name)VALUES  ( {0}, N'{1}')", id, name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateCategory(int id, string name)
        {
            string query = string.Format("UPDATE Category SET id = {0}, name = N'{1}' where id={0}", id, name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteCategory(int id)
        {
            //xóa trên bảng CAKE trước
            CakeDAO.Instance.DeleteCake(id);

            string query = string.Format("Delete Category where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
