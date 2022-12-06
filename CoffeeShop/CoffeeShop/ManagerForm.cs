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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }
        
        private void Manager_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT E_ID[Mã nhân viên], E_Name[Họ tên], E_Phone[Số điện thoại], E_Address[Địa chỉ], E_Salary[Lương], E_Position[Chức vụ]  FROM Employees", DB.Instance.getConnection);
                gridcashier.ReadOnly = true;
                gridcashier.AllowUserToAddRows = false;
                gridcashier.DataSource = EmployeeDAO.Instance.GetEmployee(command);
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Quản lý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btrefresh_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT E_ID[Mã nhân viên], E_Name[Họ tên], E_Phone[Số điện thoại], E_Address[Địa chỉ], E_Salary[Lương], E_Position[Chức vụ]  FROM Employees", DB.Instance.getConnection);
                gridcashier.ReadOnly = true;
                gridcashier.AllowUserToAddRows = false;
                gridcashier.DataSource = EmployeeDAO.Instance.GetEmployee(command);
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Quản lý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManageItemForm eitem = new ManageItemForm();
            eitem.Show();
        }

        private void Manage_Toolstrip_Click(object sender, EventArgs e)
        {
            ManageEmployeeForm mana=new ManageEmployeeForm();
            mana.Show();
        }
        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePageForm.homepage.Show();
        }
    }
}
