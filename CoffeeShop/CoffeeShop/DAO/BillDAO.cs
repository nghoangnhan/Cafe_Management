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
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return instance;
            }
            private set => instance = value;
        }

        private BillDAO() { }

        public DataTable GetAllBill()
        {
            SqlCommand command = new SqlCommand("SELECT * From Bill", DB.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public Bill getBill(int ordernum, DateTime date)
        {
            
            SqlCommand command = new SqlCommand("SELECT B_Total FROM Bill WHERE O_Num = @ordernum AND B_Date = @bdate", DB.Instance.getConnection);
            command.Parameters.Add("@ordernum", SqlDbType.Int).Value = ordernum;
            command.Parameters.Add("@bdate", SqlDbType.DateTime).Value = date;

            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adap.Fill(table);

            Bill bill = new Bill();
            bill.Number = int.Parse(table.Rows[0]["B_Num"].ToString());
            bill.Order_Number = int.Parse(table.Rows[0]["O_Num"].ToString());
            bill.E_ID = table.Rows[0]["E_ID"].ToString();
            bill.C_ID = int.Parse(table.Rows[0]["C_ID"].ToString());
            bill.Date = (DateTime)(table.Rows[0]["B_Date"]);
            bill.Total = int.Parse(table.Rows[0]["B_Total"].ToString());
            bill.Description = table.Rows[0]["B_Description"].ToString();

            return bill;
        }
        public bool delete_Bill(int num)
        {
            SqlCommand command = new SqlCommand("EXECUTE DeleteBill @onum", DB.Instance.getConnection);
            command.Parameters.Add("@onum", SqlDbType.Int).Value = num;

            return DB.Instance.executeFunction(command);
        }
        public bool addBill(int ordernum, string eid, int cid, DateTime date, int price, string des)
        {
            SqlCommand command = new SqlCommand("EXECUTE addBill @ordernum, @eid, @cid, @date, @price, @des", DB.Instance.getConnection);
            command.Parameters.Add("@ordernum", SqlDbType.Int).Value = ordernum;
            command.Parameters.Add("@eid", SqlDbType.VarChar).Value = eid;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            command.Parameters.Add("@des", SqlDbType.VarChar).Value = des;

            return DB.Instance.executeFunction(command);
        }
        public int checkPrice(string name)
        {
            Function fn = new Function();
            SqlCommand command = new SqlCommand("SELECT dbo.CheckPrice(@itemname)", DB.Instance.getConnection);
            command.Parameters.Add("@itemname", SqlDbType.VarChar).Value = name;
            DB.Instance.openConnection();

            DataTable table = OrderDAO.Instance.GetOrder(command);
            if (table.Rows.Count > 0)
                return Convert.ToInt32(table.Rows[0][0]);
            return 0;
        }
    }
}
