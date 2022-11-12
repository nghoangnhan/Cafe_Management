using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeShop.DTO
{
    public class Order_Item
    {
        int number;
        string name;
        int quantity;

        public int Number
        {
            get => number;
            set => number = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public Order_Item(DataRow row)
        {
            this.Number = int.Parse(row["O_Num"].ToString());
            this.Name = row["It_Name"].ToString();
            this.Quantity = int.Parse(row["It_Quantity"].ToString());
        }

    }
}
