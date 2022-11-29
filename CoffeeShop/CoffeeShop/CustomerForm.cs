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
            string search = tb_Search.Text;
            DataTable table = CustomerDAO.Instance.searchCustomer(search);
            if(table.Rows.Count > 0)
                dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbC_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_Cname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_Address.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_Phone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_TotalPay.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Create_Click(object sender, EventArgs e)
        {
            string cname = tb_Cname.Text;
            string phone = tb_Phone.Text;
            string address = tb_Address.Text;
            if(CustomerDAO.Instance.checkCustomer(phone) == null)
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
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = CustomerDAO.Instance.getAllCustomer();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btdel_Click(object sender, EventArgs e)
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

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage.homepage.Show();
        }
    }
}
