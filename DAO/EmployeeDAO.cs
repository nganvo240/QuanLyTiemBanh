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
            return DataProvider.Instance.ExecuteQuery("SELECT id, name, address, PhoneNumber, sex, position, salary, status FROM Employee");
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
        
        public bool InsertEmployee(int ID, string Name, string Address, string Phone, string Sex, string Position, int Salary, int Status)
        {
            string query = string.Format("INSERT Employee (id, name, address, PhoneNumber, sex, position, salary, status )VALUES  ( {0}, N'{1}', N'{2}', {3}, N'{4}', N'{5}', {6}, {7})", ID, Name, Address, Phone, Sex, Position, Salary, Status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateEmployee(int ID, string Name, string Address, string Phone, string Sex, string Position, int Salary, int Status)
        {
            string query = string.Format("UPDATE dbo.Employee SET id = {0}, name = N'{1}', address = N'{2}', PhoneNumber = {3}, sex = N'{4}', position = N'{5}', salary = {6}, status = {7} where id = {0}", ID, Name, Address, Phone, Sex, Position, Salary, Status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteEmployee(int ID)
        {
            string query = string.Format("SP_delEmployee @id");
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID });

            return result > 0;
        }
    }
}
