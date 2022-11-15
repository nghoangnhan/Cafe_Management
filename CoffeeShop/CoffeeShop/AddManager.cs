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
using CoffeeShop.DAO;

namespace CoffeeShop
{
    public partial class AddManager : Form
    {
        public AddManager()
        {
            InitializeComponent();
        }

        private void bt_AddManager_Click(object sender, EventArgs e)
        {
            string id = tbbaristaid.Text;
            string name = tbbaristaname.Text;
            string address = tbbaristaaddress.Text;
            string phone = tbbaristaphone.Text;
            int salary = Convert.ToInt32(tbbaristasalary.Text);
            string position = tbposi.Text;
            if (EmployeeDAO.Instance.addEmployee(id, name, address, phone, salary, position))
            {
                MessageBox.Show("Added", "Add New Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Add New Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void AddManager_Load(object sender, EventArgs e)
        {

        }
    }
}
