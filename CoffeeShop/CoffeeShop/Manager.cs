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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }
        
        private void Manager_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Employees", DB.Instance.getConnection);
            gridcashier.ReadOnly = true;
            gridcashier.AllowUserToAddRows = false;
            gridcashier.DataSource = EmployeeDAO.Instance.GetEmployee(command);
        }
        private void btrefresh_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(@"SELECT * FROM Employees");
            gridcashier.ReadOnly = true;
            gridcashier.AllowUserToAddRows = false;
            gridcashier.DataSource = EmployeeDAO.Instance.GetEmployee(command);
        }

        private void findStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find f = new Find();
            f.Show();

        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditItemForm eitem = new EditItemForm();
            eitem.Show();
        }

        private void Manage_Toolstrip_Click(object sender, EventArgs e)
        {
            ManageEmployee mana=new ManageEmployee();
            mana.Show();
        }
    }
}
