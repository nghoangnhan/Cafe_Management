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
            SqlCommand command = new SqlCommand("SELECT E_ID[Mã nhân viên], E_Name[Họ tên], E_Phone[Số điện thoại], E_Address[Địa chỉ], E_Salary[Lương], E_Position[Chức vụ]  FROM Employees", DB.Instance.getConnection);
            gridcashier.ReadOnly = true;
            gridcashier.AllowUserToAddRows = false;
            gridcashier.DataSource = EmployeeDAO.Instance.GetEmployee(command);
        }
        private void btrefresh_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT E_ID[Mã nhân viên], E_Name[Họ tên], E_Phone[Số điện thoại], E_Address[Địa chỉ], E_Salary[Lương], E_Position[Chức vụ]  FROM Employees", DB.Instance.getConnection);
            gridcashier.ReadOnly = true;
            gridcashier.AllowUserToAddRows = false;
            gridcashier.DataSource = EmployeeDAO.Instance.GetEmployee(command);
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
        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage.homepage.Show();
        }
    }
}
