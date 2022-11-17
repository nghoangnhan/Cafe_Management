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
        public string checkCustomer(string phone)
        {
            SqlCommand command = new SqlCommand("EXECUTE checkCustomer @phone", DB.Instance.getConnection);
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            DB.Instance.openConnection();

            DataTable table = OrderDAO.Instance.GetOrder(command);
            if (table.Rows.Count > 0)
                return table.Rows[0]["C_Name"].ToString();
            else return null;
        }
        public bool addCustomer(string cname, string phone, string address)
        {
            SqlCommand command = new SqlCommand("EXECUTE addCustomer @cname, @phone, @address, @totalpay", DB.Instance.getConnection);
            command.Parameters.Add("@cname", SqlDbType.NVarChar).Value = cname;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@totalpay", SqlDbType.Int).Value = 0;
            return DB.Instance.executeFunction(command);
        }
        public bool deleteCustomer(int cid)
        {
            SqlCommand command = new SqlCommand("DELETE Customer WHERE C_ID = @cid", DB.Instance.getConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = cid;

            return DB.Instance.executeFunction(command);
        }
        public DataTable searchCustomer(string searchString)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE CONCAT (C_ID, C_Name, C_Phone) LIKE '%" + searchString + "%'", DB.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return table;
            else
                return null;
        }
        public DataTable getAllCustomer()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Customer", DB.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
