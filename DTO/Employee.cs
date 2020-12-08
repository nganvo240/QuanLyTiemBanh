using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyTiemBanh.DTO
{
    class Employee
    {
        private int id;
        private string name;
        private string address;
        private string PhoneNumber;
        private string sex;
        private string position;
        private int salary;
        private int status;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => PhoneNumber; set => PhoneNumber = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Position { get => position; set => position = value; }
        public int Salary { get => salary; set => salary = value; }
        public int Status { get => status; set => status = value; }

        public Employee(int id, string name, string address, string phonenumber, string sex, string position, int salary, int status)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = PhoneNumber;
            this.Sex = sex;
            this.Position = position;
            this.Salary = salary;
            this.Status = status;
        }
        public Employee(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Address = row["address"].ToString();
            this.Phone = row["PhoneNumber"].ToString();
            this.Sex = row["sex"].ToString();
            this.Position = row["position"].ToString();
            this.Salary = (int)row["salary"];
            this.Status = (int)row["status"];
        }



    }
}
