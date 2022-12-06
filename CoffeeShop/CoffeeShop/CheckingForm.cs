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
   
    public partial class CheckingForm : Form
    {
        public Form homepage;
        public CheckingForm()
        {
            InitializeComponent();
        }
        private void btfind_Click(object sender, EventArgs e)
        {
            try
            {
                bttotalsalary.ForeColor = Color.Black;

                string id = tbid.Text;
                SqlCommand com = new SqlCommand("SELECT * FROM Employees WHERE E_ID = '" + id + "'");
                DataTable table = EmployeeDAO.Instance.GetEmployee(com);
                if (table.Rows.Count > 0)
                {
                    tbname.Text = table.Rows[0]["E_Name"].ToString();
                    tbaddress.Text = table.Rows[0]["E_Address"].ToString();
                    tbphone.Text = table.Rows[0]["E_Phone"].ToString();
                    tbsala.Text = table.Rows[0]["E_Salary"].ToString();
                    tbposi.Text = table.Rows[0]["E_Position"].ToString();
                }
                btcheck.Enabled = true;
                try
                {
                    string eid = tbid.Text;
                    int total = 0;
                    SqlCommand com1 = new SqlCommand("SELECT COUNT(DAY_CHECK) AS TOTAL_DAY FROM CHECKING WHERE E_ID= '" + eid + "' AND MONTH_ID=" + dateTimePicker1.Value.Month, DB.Instance.getConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(com1);
                    DataTable table1 = new DataTable();
                    adapter.Fill(table1);
                    total = Convert.ToInt32(table1.Rows[0]["TOTAL_DAY"]);
                    if (total > 0)
                    {
                        lbtotal.Text = total.ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn chưa Check-in trong tháng này!", "Tìm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bttotalsalary.Text = "Check Salary";
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Check-in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btcheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.Rows.Count > 0)
                {
                    if (tbid.Text == dataGridView2.CurrentRow.Cells[0].Value.ToString() && Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value) == dateTimePicker1.Value.Day && Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value) == dateTimePicker1.Value.Month)
                    {
                        MessageBox.Show("Bạn đã Check-in rồi!", "Check-in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DateTime myDate = DateTime.Now;
                        string current = myDate.ToString("dd/MM/yyyy");
                        DateTime d = Convert.ToDateTime(dateTimePicker1.Value);
                        string picker = d.ToString("dd/MM/yyyy");
                        if (picker == current)
                        {
                            DateTime dayy = dateTimePicker1.Value;
                            checkedListBox1.SetItemChecked(dayy.Day - 1, true);
                            int count = checkedListBox1.CheckedItems.Count;
                            int dayid = Convert.ToInt32(dayy.Day);
                            string eid = tbid.Text;
                            int checkday = count;
                            int monthid = Convert.ToInt32(dayy.Month);
                            if (CheckingDAO.Instance.CHECKING(eid, dayid, checkday, monthid))
                            {
                                MessageBox.Show("Check-in thành công!", "Check-in", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Check-in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            btcheck.Enabled = false;
                        }
                        SqlCommand command = new SqlCommand(@"SELECT E_ID[Mã nhân viên],DAY_ID[Ngày],DAY_CHECK[Check],MONTH_ID[Tháng] FROM CHECKING");
                        dataGridView2.ReadOnly = true;
                        dataGridView2.AllowUserToAddRows = false;
                        dataGridView2.DataSource = EmployeeDAO.Instance.GetEmployee(command);
                    }
                }
                else
                {
                    DateTime myDate = DateTime.Now;
                    string current = myDate.ToString("dd/MM/yyyy");
                    DateTime d = Convert.ToDateTime(dateTimePicker1.Value);
                    string picker = d.ToString("dd/MM/yyyy");
                    if (picker == current)
                    {
                        DateTime dayy = dateTimePicker1.Value;
                        checkedListBox1.SetItemChecked(dayy.Day - 1, true);
                        int count = checkedListBox1.CheckedItems.Count;
                        int dayid = Convert.ToInt32(dayy.Day);
                        string eid = tbid.Text;
                        int checkday = count;
                        int monthid = Convert.ToInt32(dayy.Month);
                        if (CheckingDAO.Instance.CHECKING(eid, dayid, checkday, monthid))
                        {
                            MessageBox.Show("Check-in thành công!", "Check-in", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Check-in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        btcheck.Enabled = false;
                    }
                    SqlCommand command = new SqlCommand(@"SELECT E_ID[Mã nhân viên],DAY_ID[Ngày],DAY_CHECK[Check],MONTH_ID[Tháng] FROM CHECKING");
                    dataGridView2.ReadOnly = true;
                    dataGridView2.AllowUserToAddRows = false;
                    dataGridView2.DataSource = EmployeeDAO.Instance.GetEmployee(command);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Check-in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand(@"SELECT E_ID[Mã nhân viên],DAY_ID[Ngày],DAY_CHECK[Check],MONTH_ID[Tháng] FROM CHECKING");
                dataGridView2.ReadOnly = true;
                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.DataSource = EmployeeDAO.Instance.GetEmployee(command);
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Check-in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btdelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa lần Check-in này không?", "Xóa Check-in", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CheckingDAO.Instance.deleteChecking(dataGridView2.CurrentRow.Cells[0].Value.ToString(), Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value)))
                    {
                        MessageBox.Show("Check-in đã xóa!", "Xóa Check-in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi!", "Xóa Check-in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                SqlCommand command = new SqlCommand(@"SELECT E_ID[Mã nhân viên],DAY_ID[Ngày],DAY_CHECK[Check],MONTH_ID[Tháng] FROM CHECKING");
                dataGridView2.ReadOnly = true;
                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.DataSource = EmployeeDAO.Instance.GetEmployee(command);
            }
            catch
            {
                MessageBox.Show("Lỗi xóa check-in", "Check-in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttotalsalary_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tbid.Text != "")
                {
                    int total = (Convert.ToInt32(tbsala.Text) * Convert.ToInt32(lbtotal.Text)) / 30;
                    bttotalsalary.Text = total.ToString() + "VND";
                    bttotalsalary.ForeColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kiểm tra lương", "Check-in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();           
            homepage.Show();
        }
        private void bt_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand(@"SELECT E_ID[Mã nhân viên],DAY_ID[Ngày],DAY_CHECK[Check],MONTH_ID[Tháng] FROM CHECKING");
                dataGridView2.ReadOnly = true;
                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.DataSource = EmployeeDAO.Instance.GetEmployee(command);
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Check-in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePageForm.homepage.Show();
        }
    }
}
