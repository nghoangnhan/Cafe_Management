using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CoffeeShop.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            private set => instance = value;
        }

        public bool signIn (string username, string password, string position)
        {
            string tableDBO = "LO_GIN_Manager";
            if (position == "employee")
                tableDBO = "LO_GIN_Employee";

            SqlCommand command = new SqlCommand("SELECT * FROM " + tableDBO + " WHERE username=@user AND pass_word=@pass", DB.Instance.getConnection);
            command.Parameters.Add("@user", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);


            return table.Rows.Count > 0;
        }
    }
}
