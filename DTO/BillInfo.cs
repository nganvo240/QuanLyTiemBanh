using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemBanh.DTO
{
    class BillInfo
    {
        private int id;
        private int bill_Id;
        private int cake_Id;
        private int amount;
        private int price;
        public BillInfo(int id, int billid, int cakeid, int amount, int price)
        {
            this.Id = id;
            this.Bill_Id = billid;
            this.Cake_Id = cakeid;
            this.Amount = amount;
            this.Price = price;
        }
        public BillInfo(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Bill_Id = (int)row["bill_id"];
            this.Cake_Id = (int)row["cake_id"];
            this.Amount = (int)row["amount"];
            this.Price = (int)row["price"];
        }
        public int Id { get => id; set => id = value; }
        public int Bill_Id { get => bill_Id; set => bill_Id = value; }
        public int Cake_Id { get => cake_Id; set => cake_Id = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Price { get => price; set => price = value; }
    }
}
