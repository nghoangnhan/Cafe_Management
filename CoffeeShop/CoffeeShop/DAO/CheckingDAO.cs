using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
    public class CheckingDAO
    {
        private static CheckingDAO instance;
        public static CheckingDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CheckingDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private CheckingDAO() { }
        public bool CHECKING(string E_ID, int DAY_ID, int DAY_CHECK, int MONTH_ID)
        {
            SqlCommand command = new SqlCommand("EXECUTE CHAM @E_id,@DAY_id,@DAY_check,@MONTH_id", DB.Instance.getConnection);
            command.Parameters.Add("@E_id", SqlDbType.NVarChar).Value = E_ID;
            command.Parameters.Add("@DAY_id", SqlDbType.Int).Value = DAY_ID;
            command.Parameters.Add("@DAY_check", SqlDbType.Int).Value = DAY_CHECK;
            command.Parameters.Add("@MONTH_id", SqlDbType.Int).Value = MONTH_ID;

            return DB.Instance.executeFunction(command);
        }
        public bool deleteChecking(string E_ID, int DAY_ID, int MONTH_ID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM CHECKING WHERE E_ID=@eid AND DAY_ID=@dayid AND MONTH_ID=@monthid", DB.Instance.getConnection);
            command.Parameters.Add("@eid", SqlDbType.NChar).Value = E_ID;
            command.Parameters.Add("@dayid", SqlDbType.Int).Value = DAY_ID;
            command.Parameters.Add("@monthid", SqlDbType.Int).Value = MONTH_ID;

            return DB.Instance.executeFunction(command);
        }
    }
}
