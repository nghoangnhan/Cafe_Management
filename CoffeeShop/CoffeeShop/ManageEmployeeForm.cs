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
    // Da thay 3 ham add, edit, delete = Instance
    public partial class ManageEmployeeForm : Form
    {
        public ManageEmployeeForm()
        {
            InitializeComponent();
        }
        private void btedit_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name = tbname.Text;
                string address = tbaddress.Text;
                string phone = tbphone.Text;
                int salary = Convert.ToInt32(tbsalary.Text);
                string position = cbposi.Text;
                string id = tbid.Text;
                if (EmployeeDAO.Instance.editEmployee(id, name, phone, address, salary, position))
                {
                    MessageBox.Show("Đã cập nhật!", "Cập nhật nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbid.Text = "";
                    tbname.Text = "";
                    tbphone.Text = "";
                    tbaddress.Text = "";
                    tbsalary.Text = "";
                    cbposi.Text = "";
                }
                else
                {
                    MessageBox.Show("Lỗi!", "Cập nhật nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Quản lý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btcancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void btfind_Click(object sender, EventArgs e)
        {
            try
            {
                string id = tbid.Text;
                SqlCommand com = new SqlCommand("SELECT * FROM Employees WHERE E_ID = '" + id + "'");
                DataTable table = EmployeeDAO.Instance.GetEmployee(com);
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
                    MessageBox.Show("Không thể tìm thấy nhân viên với mã số này!", "Tìm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Quản lý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btdismiss_Click(object sender, EventArgs e)
        {
            try
            {
                string id = tbid.Text;
                string name = tbname.Text;
                string address = tbaddress.Text;
                string phone = tbphone.Text;
                int salary = Convert.ToInt32(tbsalary.Text);
                string position = cbposi.Text;
                if (!EmployeeDAO.Instance.dismissEmployee(id, name, phone, address, salary, position))
                {
                    MessageBox.Show("Đã xóa!", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbid.Text = "";
                    tbname.Text = "";
                    tbphone.Text = "";
                    tbaddress.Text = "";
                    tbsalary.Text = "";
                    cbposi.Text = "";
                }
                else
                {
                    MessageBox.Show("Lỗi!", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Quản lý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            try
            {
                string id = tbid.Text;
                string name = tbname.Text;
                string address = tbaddress.Text;
                string phone = tbphone.Text;
                int salary = Convert.ToInt32(tbsalary.Text);
                string position = cbposi.Text;
                if (EmployeeDAO.Instance.addEmployee(id, name, phone, address, salary, position))
                {
                    MessageBox.Show("Đã thêm!", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbid.Text = "";
                    tbname.Text = "";
                    tbphone.Text = "";
                    tbaddress.Text = "";
                    tbsalary.Text = "";
                    cbposi.Text = "";
                }
                else
                {
                    MessageBox.Show("Lỗi!", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Quản lý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
