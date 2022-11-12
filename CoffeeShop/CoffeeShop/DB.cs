﻿using System.Data;
using System.Data.SqlClient;

namespace CoffeeShop
{
    class DB
    {
        public SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7CAKEUV0;Initial Catalog=CafeManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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
    }

}
