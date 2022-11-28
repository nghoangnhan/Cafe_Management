using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CoffeeShop.DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;
        public static EmployeeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private EmployeeDAO() { }
        public bool addEmployee(string ID, string name, string address, string phone, int salary, string position)
        {
            SqlCommand com = new SqlCommand("EXECUTE Add_Employee @eid, @ename, @ephone, @eaddr,  @esalary, @eposition", DB.Instance.getConnection);
            com.Parameters.Add("@eid", SqlDbType.VarChar).Value = ID;
            com.Parameters.Add("@ename", SqlDbType.VarChar).Value = name;
            com.Parameters.Add("@eaddr", SqlDbType.VarChar).Value = address;
            com.Parameters.Add("@ephone", SqlDbType.NVarChar).Value = phone;
            com.Parameters.Add("@esalary", SqlDbType.Int).Value = salary;
            com.Parameters.Add("@eposition", SqlDbType.NVarChar).Value = position;

            return DB.Instance.executeFunction(com);
        }
        public bool editEmployee(string ID, string name, string address, string phone, int salary, string position)
        {
            SqlCommand com = new SqlCommand("EXECUTE Edit @E_id, @E_name, @E_phone, @E_addr,  @E_salary, @E_position", DB.Instance.getConnection);
            com.Parameters.Add("@E_id", SqlDbType.NVarChar).Value = ID;
            com.Parameters.Add("@E_name", SqlDbType.NVarChar).Value = name;
            com.Parameters.Add("@E_addr", SqlDbType.NVarChar).Value = address;
            com.Parameters.Add("@E_phone", SqlDbType.NVarChar).Value = phone;
            com.Parameters.Add("@E_salary", SqlDbType.Int).Value = salary;
            com.Parameters.Add("@E_position", SqlDbType.NVarChar).Value = position;

            return DB.Instance.executeFunction(com);
        }
        public bool dismissEmployee(string ID, string name, string address, string phone, int salary, string position)
        {
            SqlCommand command = new SqlCommand("DELETE Employees WHERE E_ID = @E_id ", DB.Instance.getConnection);
            command.Parameters.AddWithValue("@E_id", ID);

            return DB.Instance.executeFunction(command);

        }
        public DataTable GetEmployee(SqlCommand command)
        {
            command.Connection = DB.Instance.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
