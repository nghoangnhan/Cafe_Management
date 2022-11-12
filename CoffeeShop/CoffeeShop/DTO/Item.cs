using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeShop.DTO
{
    public class Item
    {
        string id;
        string name;
        int cost;

        public string ID
        {
            get => id;
            set => id = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Cost
        {
            get => cost;
            set => cost = value;
        }

        public Item (DataRow row)
        {
            this.ID = row["It_ID"].ToString();
            this.Name = row["It_Name"].ToString();
            this.Cost = int.Parse(row["It_Cost"].ToString());
        }
    }
}
