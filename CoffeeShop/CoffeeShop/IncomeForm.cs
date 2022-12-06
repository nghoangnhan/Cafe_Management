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
    public partial class IncomeForm : Form
    {
        public IncomeForm()
        {
            InitializeComponent();
        }

        private void bt_Next_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime nextday = dateTimePicker1.Value.AddDays(1);
                dateTimePicker1.Value = nextday;

                SqlCommand command = new SqlCommand("SELECT B_Num[Số hóa đơn], O_Num[Số Order], E_ID[Mã nhân viên], C_ID[Mã khách hàng], B_Date[Ngày in hóa đơn], B_Total[Tổng hóa đơn], B_Description[Mô tả hóa đơn] FROM BILL WHERE B_Date = @bdate", DB.Instance.getConnection);
                command.Parameters.Add("@bdate", SqlDbType.Date).Value = (DateTime)dateTimePicker1.Value;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                int total = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    total += Convert.ToInt32(table.Rows[i]["B_Total"]);
                }
                lb_Total.Text = "Tổng: " + total.ToString() + " VND";
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Thu nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Previous_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime previousday = dateTimePicker1.Value.AddDays(-1);
                dateTimePicker1.Value = previousday;

                SqlCommand command = new SqlCommand("SELECT B_Num[Số hóa đơn], O_Num[Số Order], E_ID[Mã nhân viên], C_ID[Mã khách hàng], B_Date[Ngày in hóa đơn], B_Total[Tổng hóa đơn], B_Description[Mô tả hóa đơn] FROM BILL WHERE B_Date = @bdate", DB.Instance.getConnection);
                command.Parameters.Add("@bdate", SqlDbType.Date).Value = (DateTime)dateTimePicker1.Value;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                int total = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    total += Convert.ToInt32(table.Rows[i]["B_Total"]);
                }
                lb_Total.Text = "Tổng: " + total.ToString() + " VND";
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Thu nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Check_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT B_Num[Số hóa đơn], O_Num[Số Order], E_ID[Mã nhân viên], C_ID[Mã khách hàng], B_Date[Ngày in hóa đơn], B_Total[Tổng hóa đơn], B_Description[Mô tả hóa đơn] FROM Bill WHERE DAY(B_Date) = DAY(@bdate) AND MONTH (B_Date) = MONTH (@bdate)", DB.Instance.getConnection);
                command.Parameters.Add("@bdate", SqlDbType.Date).Value = (DateTime)dateTimePicker1.Value;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                int total = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    total += Convert.ToInt32(table.Rows[i]["Tổng hóa đơn"]);
                }
                lb_Total.Text = "Tổng: " + total.ToString() + " VND";
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Thu nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Checkmonth_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime day = dateTimePicker1.Value;
                SqlCommand command = new SqlCommand("SELECT B_Num[Số hóa đơn], O_Num[Số Order], E_ID[Mã nhân viên], C_ID[Mã khách hàng], B_Date[Ngày in hóa đơn], B_Total[Tổng hóa đơn], B_Description[Mô tả hóa đơn] FROM BILL WHERE Month(B_Date) = Month(@bdate)", DB.Instance.getConnection);
                command.Parameters.Add("@bdate", SqlDbType.Date).Value = (DateTime)dateTimePicker1.Value;


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                int total = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    total += Convert.ToInt32(table.Rows[i]["Tổng hóa đơn"]);
                }
                dataGridView1.DataSource = table;
                lb_Total.Text = "Tổng: " + total.ToString() + " VND";
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Thu nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void IncomeForm_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Thu nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            Close();
            HomePageForm hp = new HomePageForm();
            hp.Show();
        }
        private void IncomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePageForm.homepage.Show();
        }

        private void btprintBill_Click(object sender, EventArgs e)
        {
            try
            {
                Print word = new Print();
                if (dataGridView1.Rows.Count > 0)
                {
                    try
                    {
                        saveFileDialog1.Filter = "Word Documents (.docx)|.docx";
                        saveFileDialog1.FileName = ".docx";
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            word.exportDataToWord(dataGridView1, "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM", "Độc lập - Tự do - Hạnh phúc", "Tổng số hóa đơn: " + dataGridView1.Rows.Count.ToString(), saveFileDialog1.FileName);
                        }
                    }
                    catch
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu trống !!!", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Thu nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
