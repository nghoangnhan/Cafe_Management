using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTO
{
    public class Checking
    {
        string e_id;
        int day_id;
        int day_check;
        int month_id;

        public string E_ID
        {
            get => e_id;
            set => e_id = value;
        }
        public int Day_ID
        {
            get => day_id;
            set => day_id = value;
        }
        public int Day_Check
        {
            get => day_check;
            set => day_check = value;
        }
        public int Month_ID
        {
            get => month_id;
            set => month_id = value;
        }
        public Checking(DataRow row)
        {
            this.E_ID = row["E_ID"].ToString();
            this.Day_ID = int.Parse(row["DAY_ID"].ToString());
            this.Month_ID = int.Parse(row["MONTH_ID"].ToString());
            this.Day_Check = int.Parse(row["DAY_CHECK"].ToString());
        }
        public Checking(string e_id, int day_id, int day_check, int month_id)
        {
            this.e_id = e_id;
            this.day_id = day_id;
            this.day_check = day_check;
            this.month_id = month_id;
        }
    }
}
