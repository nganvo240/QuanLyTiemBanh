using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemBanh.DTO
{
    class Cake
    {
        private int id;
        private string name;
        private int price;
        private int category_id;
        private int amount;
        private string place;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Category_id { get => category_id; set => category_id = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Place { get => place; set => place = value; }

        public Cake(int id, string name, int price, int category_id, int amount, string place)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Category_id = category_id;
            this.Amount = amount;
            this.Place = place;
        }
        public Cake(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Price = (int)row["price"];
            this.Category_id = category_id;
            this.Amount = (int)row["amount"];
            this.Place = row["place"].ToString();
        }

    }
}
