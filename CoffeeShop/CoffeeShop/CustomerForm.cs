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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string search = tb_Search.Text;
                DataTable table = CustomerDAO.Instance.searchCustomer(search);
                if (table.Rows.Count > 0)
                    dataGridView1.DataSource = table;
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbC_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tb_Cname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tb_Address.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                tb_Phone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tb_TotalPay.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bt_Create_Click(object sender, EventArgs e)
        {
            try
            {
                string cname = tb_Cname.Text;
                string phone = tb_Phone.Text;
                string address = tb_Address.Text;
                if (CustomerDAO.Instance.checkCustomer(phone) == null)
                {
                    if (CustomerDAO.Instance.addCustomer(cname, phone, address))
                        MessageBox.Show("Thêm thành công!", "Khách hàng mới", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Lỗi!", "Khách hàng mới", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Số điện thoại này đã tồn tại!", "Khách hàng mới", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                //refresh the DataGridView
                dataGridView1.DataSource = CustomerDAO.Instance.getAllCustomer();
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = CustomerDAO.Instance.getAllCustomer();
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btdel_Click(object sender, EventArgs e)
        {
            try
            {
                int cid = Convert.ToInt32(tbC_ID.Text);
                ;
                if (CustomerDAO.Instance.deleteCustomer(cid))
                {
                    MessageBox.Show("Xóa thành công!", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = CustomerDAO.Instance.getAllCustomer();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi xóa khách hàng", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePageForm.homepage.Show();
        }
    }
}
