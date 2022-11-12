using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeShop.DTO
{
    public class Order
    {
        int number;
        string description;

        public int Number
        {
            get => number;
            set => number = value;
        }
        public string Description
        {
            get => description;
            set => description = value;
        }

        public Order (DataRow row)
        {
            this.Number = int.Parse(row["O_Num"].ToString());
            this.Description = row["O_Description"].ToString();
        }
    }
}
