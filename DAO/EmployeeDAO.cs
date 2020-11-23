using QuanLyTiemBanh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemBanh.DAO
{
    class EmployeeDAO
    {
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable GetListEmployee()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT name, address, phonenumber, sex, position, salary, status FROM Employee");
        }
        //xử lý cột là ID nhưng hiển thị là tên nhân viên
        public List<Employee> GetListEmpToCb()
        {
            List<Employee> list = new List<Employee>();

            string query = "select * from Employee";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Employee category = new Employee(item);
                list.Add(category);
            }

            return list;
        }
    }
}
