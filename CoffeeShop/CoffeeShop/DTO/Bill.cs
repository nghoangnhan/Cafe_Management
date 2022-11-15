using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeShop.DTO
{
    public class Bill
    {
        int number;
        int order_Number;
        string e_id;
        int c_id;
        DateTime date;
        int total;
        string description;

        public int Number
        {
            get => number;
            set => number = value;
        }
        public int Order_Number
        {
            get => order_Number;
            set => order_Number = value;
        }
        public string E_ID
        {
            get => e_id;
            set => e_id = value;
        }
        public int C_ID
        {
            get => c_id;
            set => c_id = value;
        }
        public DateTime Date
        {
            get => date;
            set => date = value;
        }
        public int Total
        {
            get => total;
            set => total = value;
        }
        public string Description
        {
            get => description;
            set => description = value;
        }
        public Bill() { }
        public Bill(DataRow row)
        {
            this.Number = int.Parse(row["B_Num"].ToString());
            this.Order_Number = int.Parse(row["O_Num"].ToString());
            this.E_ID = row["E_ID"].ToString();
            this.C_ID = int.Parse(row["C_ID"].ToString());
            this.Date = (DateTime)(row["B_Date"]);
            this.Total = int.Parse(row["B_Total"].ToString());
            this.Description = row["B_Description"].ToString();
        }
        public Bill(int bnum, int ordernum, string eid, int cid, DateTime date, int total, string des)
        {
            this.Number = bnum;
            this.Order_Number = ordernum;
            this.E_ID = eid;
            this.C_ID = cid;
            this.Date = date;
            this.Total = total;
            this.Description = des;
        }
    }
}
