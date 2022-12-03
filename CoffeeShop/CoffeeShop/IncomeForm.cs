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

        private void bt_Previous_Click(object sender, EventArgs e)
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

        private void bt_Check_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT B_Num[Số hóa đơn], O_Num[Số Order], E_ID[Mã nhân viên], C_ID[Mã khách hàng], B_Date[Ngày in hóa đơn], B_Total[Tổng hóa đơn], B_Description[Mô tả hóa đơn] FROM Bill WHERE DAY(B_Date) = DAY(@bdate) AND MONTH (B_Date) = MONTH (@bdate)", DB.Instance.getConnection);
            command.Parameters.Add("@bdate", SqlDbType.Date).Value = (DateTime)dateTimePicker1.Value;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            int total = 0;
            for(int i = 0; i < table.Rows.Count; i ++)
            {
                total += Convert.ToInt32(table.Rows[i]["Tổng hóa đơn"]);
            }
            lb_Total.Text = "Tổng: " + total.ToString() + " VND";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void bt_Checkmonth_Click(object sender, EventArgs e)
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
        private void IncomeForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            Close();
            HomePage hp = new HomePage();
            hp.Show();
        }
        private void IncomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage.homepage.Show();
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
                            word.exportDataToWord(dataGridView1, "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM", "Độc lập - Tự do - Hạnh phúc", "Total Course: " + dataGridView1.Rows.Count.ToString(), saveFileDialog1.FileName);
                        }
                    }
                    catch
                    {
                    }
                }
                else
                {
                    MessageBox.Show("No Record To Export !!!", "Notification");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
