using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeShop.DTO
{
    public class Employee
    {
        string id;
        string name;
        string address;
        string phone;
        string position;
        int salary;

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
        public string Position
        {
            get => position;
            set => position = value;
        }
        public int Salary
        {
            get => salary;
            set => salary = value;
        }

        public Employee(DataRow row)
        {
            this.ID = row["E_ID"].ToString();
            this.Name = row["E_Name"].ToString();
            this.Address = row["E_Address"].ToString();
            this.Phone = row["E_Phone"].ToString();
            this.Position = row["E_Position"].ToString();
            this.Salary = int.Parse(row["E_Salary"].ToString());
        }
    }
}
