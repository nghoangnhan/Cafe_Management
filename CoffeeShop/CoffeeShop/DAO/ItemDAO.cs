using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
    public class ItemDAO
    {
        private static ItemDAO instance;

        public static ItemDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ItemDAO();
                return instance;
            }
            private set => instance = value;
        }

        private ItemDAO() { }
        public bool updateItem(string id, string name, int price)
        {
            SqlCommand command = new SqlCommand("UPDATE Item SET It_Name = @name, It_Cost = @price WHERE It_ID = @id", DB.Instance.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;

            return DB.Instance.executeFunction(command);
        }
        public bool addItem(string id, string itname, int price)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Item (It_ID, It_Name, It_Cost) VALUES (@id, @name, @price)", DB.Instance.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = itname;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;

            return DB.Instance.executeFunction(command);
        }
        public bool deleteItem(string id)
        {
            SqlCommand command = new SqlCommand("DELETE Item WHERE It_ID = @id", DB.Instance.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

            return DB.Instance.executeFunction(command);
        }
    }
}
