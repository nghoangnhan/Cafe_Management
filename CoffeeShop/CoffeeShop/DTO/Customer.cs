using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeShop.DTO
{
    public class Customer
    {
        int id;
        string name;
        string address;
        string phone;
        int totalPay;

        public int ID
        {
            get => id;
            set => id = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Address
        {
            get => address;
            set => address = value;
        }
        public string Phone
        {
            get => phone;
            set => phone = value;
        }
        public int TotalPay
        {
            get => totalPay;
            set => totalPay = value;
        }

        public Customer(DataRow row)
        {
            this.ID = int.Parse(row["C_ID"].ToString());
            this.Name = row["C_Name"].ToString();
            this.Address = row["C_Address"].ToString();
            this.Phone = row["C_Phone"].ToString();
            this.TotalPay = int.Parse(row["C_TotalPay"].ToString());
        }
    }
}
