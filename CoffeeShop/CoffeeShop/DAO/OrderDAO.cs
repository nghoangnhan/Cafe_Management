using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
    public class OrderDAO
    {
        private static OrderDAO instance;

        public static OrderDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new OrderDAO();
                return instance;
            }
            private set => instance = value;
        }

        private OrderDAO() { }
        public DataTable GetOrder(SqlCommand command)
        {
            command.Connection = DB.Instance.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool AddOrder(int num)
        {
            SqlCommand command1 = new SqlCommand("EXECUTE Add_Order @onum", DB.Instance.getConnection);

            command1.Parameters.Add("@onum", SqlDbType.Int).Value = num;
            return DB.Instance.executeFunction(command1);
        }
        public bool updateOrder(int num, string itname, int quan)
        {
            SqlCommand command = new SqlCommand("EXECUTE Update_OrderItem @onum, @itname, @quan", DB.Instance.getConnection);
            command.Parameters.Add("@onum", SqlDbType.Int).Value = num;
            command.Parameters.Add("@itname", SqlDbType.VarChar).Value = itname;
            command.Parameters.Add("@quan", SqlDbType.Int).Value = quan;

            return DB.Instance.executeFunction(command);
        }
        public bool deleteOrder(int num)
        {
            SqlCommand command = new SqlCommand("EXECUTE DeleteOrder @onum", DB.Instance.getConnection);
            command.Parameters.Add("@onum", SqlDbType.Int).Value = num;

            return DB.Instance.executeFunction(command);
        }
        public int countOrder()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM _Order", DB.Instance.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows.Count;
        }
    }
}
