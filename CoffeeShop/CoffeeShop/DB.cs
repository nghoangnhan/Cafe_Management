using System.Data;
using System.Data.SqlClient;

namespace CoffeeShop
{
    public class DB
    {
        private static DB instance;
        
        public static DB Instance
        {
            get
            {
                if (instance == null)
                    instance = new DB();
                return DB.instance;
            }
            private set { DB.instance = value; }
        }

        private DB() { }

        public SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7CAKEUV0;Initial Catalog=CafeManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //public SqlConnection con = new SqlConnection(@"Data Source=MSI\MSSQLSEVER;Initial Catalog=CafeManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public bool executeFunction(SqlCommand command)
        {
            DB.Instance.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                DB.Instance.closeConnection();
                return true;
            }
            DB.Instance.closeConnection();
            return false;
        }
    }

}
