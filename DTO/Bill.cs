using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemBanh.DTO
{
    class Bill
    {
        private int id;
        private string day_Out;
        private int emp_Id;
        public Bill(int id, string day_Out, int emp_Id)
        {
            this.Id = id;
            this.Day_Out = day_Out;
            this.Emp_Id = emp_Id;
        }
        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Day_Out = (string)row["day_out"];
            this.Emp_Id = (int)row["emp_id"];
        }
        public int Id { get => id; set => id = value; }
        public string Day_Out { get => day_Out; set => day_Out = value; }
        public int Emp_Id { get => emp_Id; set => emp_Id = value; }
    }
}
