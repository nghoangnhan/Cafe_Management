using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CoffeeShop
{
    public partial class ManageEmployee : Form
    {
        public ManageEmployee()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }
        DB mydb = new DB();
        Function fn=new Function();

        private void btedit_Click_1(object sender, EventArgs e)
        {
            string name = tbname.Text;
            string address = tbaddress.Text;
            string phone = tbphone.Text;
            int salary = Convert.ToInt32(tbsalary.Text);
            string position = cbposi.Text;

            try
            {
                string id = tbid.Text;
                if (fn.editEmployee(id, name, address, phone, salary, position))
                {
                    MessageBox.Show("Edited", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Empty Field", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit");
            }
        }

        private void btcancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        Staff st = new Staff();
        private void btfind_Click(object sender, EventArgs e)
        {
            string id = tbid.Text;
            SqlCommand com = new SqlCommand("SELECT * FROM Employees WHERE E_ID = '" + id + "'");
            DataTable table = st.GetStaff(com);
            if (table.Rows.Count > 0)
            {
                tbname.Text = table.Rows[0]["E_Name"].ToString();
                tbaddress.Text = table.Rows[0]["E_Address"].ToString();
                tbphone.Text = table.Rows[0]["E_Phone"].ToString();
                tbsalary.Text = table.Rows[0]["E_Salary"].ToString();
                cbposi.Text = table.Rows[0]["E_Position"].ToString();
            }
            else
            {
                MessageBox.Show("Cannot Find Staff", "Find Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btdismiss_Click(object sender, EventArgs e)
        {
            string id = tbid.Text;
            string name = tbname.Text;
            string address = tbaddress.Text;
            string phone = tbphone.Text;
            int salary = Convert.ToInt32(tbsalary.Text);
            string position = cbposi.Text;
            if (fn.dismissEmployee(id, name, address, phone, salary, position))
            {
                MessageBox.Show("Dismissed", "Dismiss Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Dismiss Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            string id = tbid.Text;
            string name = tbname.Text;
            string address = tbaddress.Text;
            string phone = tbphone.Text;
            int salary = Convert.ToInt32(tbsalary.Text);
            string position = cbposi.Text;
            if(fn.addEmployee(id,name,address,phone,salary,position))
            {
                MessageBox.Show("Added", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
