using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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

        public DataTable getBill()
        {
            DataTable table = MY_DB.Instance.ExecuteQuery("SELECT * FROM Bill");
            return table;
        }
    }
}
