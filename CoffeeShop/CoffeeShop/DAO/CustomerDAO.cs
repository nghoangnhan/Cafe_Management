using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CoffeeShop.DTO;

namespace CoffeeShop.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerDAO();
                return instance;
            }
            private set => instance = value;
        }
        private CustomerDAO() { }

        public Customer findCustomerByPhone(string phone)
        {
            SqlCommand command1 = new SqlCommand("SELECT * FROM Customer WHERE C_Phone = @phone", DB.Instance.getConnection);
            command1.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            SqlDataAdapter adap = new SqlDataAdapter(command1);
            DataTable table = new DataTable();
            adap.Fill(table);

            Customer customer = new Customer(table.Rows[0]);
            
            return customer;
        }


    }
}
