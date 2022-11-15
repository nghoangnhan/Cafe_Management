using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
    public class Order_ItemDAO
    {
        private static Order_ItemDAO instance;

        public static Order_ItemDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Order_ItemDAO();
                return instance;
            }
            private set => instance = value;
        }

        private Order_ItemDAO() { }
        public bool AddOrder_Item(int num, string itname, int quan)
        {
            SqlCommand command = new SqlCommand("EXECUTE Add_OrderItem @num, @itname, @quan", DB.Instance.getConnection);

            command.Parameters.Add("@num", SqlDbType.Int).Value = num;
            command.Parameters.Add("@itname", SqlDbType.VarChar).Value = itname;
            command.Parameters.Add("@quan", SqlDbType.Int).Value = quan;

            return DB.Instance.executeFunction(command);
        }
        public bool deleteOrderItem(int num, string itname)
        {
            SqlCommand command = new SqlCommand("EXECUTE Delete_OrderItem @onum, @itname", DB.Instance.getConnection);
            command.Parameters.Add("@onum", SqlDbType.Int).Value = num;
            command.Parameters.Add("@itname", SqlDbType.VarChar).Value = itname;

            return DB.Instance.executeFunction(command);
        }
        
    }
}
