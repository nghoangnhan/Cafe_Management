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
using CoffeeShop.DTO;
using CoffeeShop.DAO;
namespace CoffeeShop
{
    // them addguest vao nut add bill
    public partial class HomePage : Form
    {
        int id;
        int count = 0;
        public HomePage()
        {
            InitializeComponent();
        }

        private static HomePage homePage;
        public static HomePage homepage
        {
            get
            {
                if (homePage == null)
                    homePage = new HomePage();
                return homePage;
            }
            private set => homePage = value;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region Function

        void refresh()
        {
            panel_Menu.Hide();

            panel_Menu.Show();
            dataGridView1.Show();
            pn_Menu_dataGridView1.Show();
            bt_SCart.Show();
            tb_Amount.Show();
            bt_Remove.Show();
        }
        private DataTable GetItem()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Item", DB.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private DataTable GetOrder()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Order_Item", DB.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public int checkItem(DataTable table, string name, int quan)
        {
            quan = 1;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i]["It_Name"].ToString() == name)
                {
                    quan = Convert.ToInt32(table.Rows[i]["It_Quantity"]);
                    quan++;
                    return quan;
                }
            }
            return quan;
        }
        bool verif()
        {
            if (tb_Phone.Text.Trim() == "")
                return false;
            return true;
        }
        void reset()
        {
            count = 0;
            tb_Amount.Text = 0.ToString();
            DataGridView dtg = new DataGridView();
            dataGridView1.DataSource = dtg.DataSource;
        }
        #endregion

        #region Button

        private void bt_Customer_Click(object sender, EventArgs e)
        {
            pn_Menu_dataGridView1.AllowUserToAddRows = false;
            pn_Menu_dataGridView1.ReadOnly = true;
            dataGridView1.ReadOnly = true;
            SqlCommand command = new SqlCommand("SELECT E_ID,E_Name FROM Employees WHERE E_Position='Cashier'", DB.Instance.getConnection);

            comboBox1.DataSource = EmployeeDAO.Instance.GetEmployee(command);
            comboBox1.DisplayMember = "E_Name";
            comboBox1.ValueMember = "E_ID";

            panel_Menu.Hide();
            refresh();
            panel_Menu.Show();

            pn_Menu_dataGridView1.DataSource = ItemDAO.Instance.getAllItem();
            pn_Menu_dataGridView1.AllowUserToAddRows = false;
            pn_Menu_dataGridView1.ReadOnly = true;
            pn_Menu_dataGridView1.Columns[0].Visible = false;
        }

        private void bt_Staff_Click(object sender, EventArgs e)
        {
            Hide();
            Manager mana = new Manager();
            mana.Show();
        }
        private void bt_SCart_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            if (verif())
            {
                BillForm billform = new BillForm();

                bill.Order_Number = id;
                bill.C_ID = CustomerDAO.Instance.findCustomerByPhone(tb_Phone.Text).ID;
                bill.E_ID = comboBox1.SelectedValue.ToString();
                bill.Description = tbDes.Text;

                billform.bill = bill;
                billform.Show();
                Hide();
            }
            else
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Không có sản phẩm nào được chọn!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    BillForm billform = new BillForm();
                    bill.Order_Number = id;
                    bill.C_ID = 10;
                    bill.E_ID = comboBox1.SelectedValue.ToString();
                    bill.Description = tbDes.Text;

                    billform.bill = bill;
                    billform.Show();
                    Hide();
                }
            }
        }
        private void bt_Reset_Click(object sender, EventArgs e)
        {
            reset();
            tb_CusName.Clear();
            tb_Phone.Clear();
            tbDes.Clear();
            SqlCommand com = new SqlCommand("SELECT * FROM _Order ");
            DataTable table = OrderDAO.Instance.GetOrder(com);
            int num = Convert.ToInt32(table.Rows[table.Rows.Count - 1]["O_Num"]);
            BillDAO.Instance.delete_Bill(num);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                int quan = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
                quan--;
                if (tb_Amount.Text == 1.ToString())
                    dataGridView1.Rows.RemoveAt(0);
                if (quan < 1)
                {
                    if (Order_ItemDAO.Instance.deleteOrderItem(id, name))
                    {
                        count--;
                        tb_Amount.Text = (count).ToString();
                    }
                }
                else
                {
                    OrderDAO.Instance.updateOrder(id, name, quan);
                    count--;
                    tb_Amount.Text = (count).ToString();
                }
            }


            SqlCommand command = new SqlCommand("SELECT * FROM Order_Item WHERE O_Num = " + id);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = DB.Instance.getConnection;
            DataTable table1 = new DataTable();
            adapter.Fill(table1);
            if (table1.Rows.Count > 0)
            {
                dataGridView1.DataSource = table1;
            }
        }
        private void bt_Find_Click(object sender, EventArgs e)
        {
            if (CustomerDAO.Instance.checkCustomer(tb_Phone.Text) == null)
            {
                CustomerForm ct = new CustomerForm();
                ct.Show();
            }
            else
            {
                tb_CusName.Text = CustomerDAO.Instance.checkCustomer(tb_Phone.Text);
            }

        }
        private void bt_Checking_Click(object sender, EventArgs e)
        {
            Hide();
            CheckingForm emp = new CheckingForm();
            emp.Show();
        }

        private void bt_Customer_Click_1(object sender, EventArgs e)
        {
            CustomerForm ct = new CustomerForm();
            ct.Show();
            Hide();
        }

        private void bt_Income_Click(object sender, EventArgs e)
        {
            IncomeForm icf = new IncomeForm();
            icf.Show();
            Hide();
        }
        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            reset();
            tb_Phone.Text = null;
            tb_CusName.Clear();
            tbDes.Clear();
        }
        #endregion


        private void HomePage_Load(object sender, EventArgs e)
        {
            reset();
        }
       
        private void pn_Menu_dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = pn_Menu_dataGridView1.CurrentRow.Cells[1].Value.ToString();
            int num;
            SqlCommand com = new SqlCommand("SELECT * FROM _Order ");
            DataTable table = OrderDAO.Instance.GetOrder(com);
            num = Convert.ToInt32(table.Rows[table.Rows.Count - 1]["O_Num"]);

            SqlCommand com1 = new SqlCommand("SELECT * FROM Order_Item WHERE O_Num = " + num);
            DataTable table_Item = OrderDAO.Instance.GetOrder(com1);

            count++;
            tb_Amount.Text = (count).ToString();

            if (count == 1)
            {
                if (table.Rows.Count < 1)
                    num = 1;
                else
                {
                    num++;
                }
                OrderDAO.Instance.AddOrder(num);
            }
            Order_ItemDAO.Instance.AddOrder_Item(num, name, 1);
            id = num;

            SqlCommand command = new SqlCommand("SELECT O_Num[Số Order], It_Name[Tên món], It_Quantity[Số lượng] FROM Order_Item WHERE O_Num = " + id);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = DB.Instance.getConnection;
            DataTable table1 = new DataTable();
            adapter.Fill(table1);
            if (table1.Rows.Count > 0)
            {
                dataGridView1.DataSource = table1;
            }
        }
        private void btsignout_Click(object sender, EventArgs e)
        {
            LoginForm.loginform.Show();
            Hide();
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.loginform.Close();
        }

        private void btguest_Click(object sender, EventArgs e)
        {

        }
    }
}
