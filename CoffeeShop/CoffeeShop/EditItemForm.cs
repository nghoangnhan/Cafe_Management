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
    public partial class EditItemForm : Form
    {
        int item_count = 0;
        public EditItemForm()
        {
            InitializeComponent();
        }
        void refresh()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Item", DB.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tableitem = new DataTable();
            adapter.Fill(tableitem);
            item_count = tableitem.Rows.Count;
            dataGridView1.DataSource = tableitem;
        }
        private void EditItemForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            SqlCommand command = new SqlCommand("SELECT * FROM Item", DB.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tableitem = new DataTable();
            adapter.Fill(tableitem);
            item_count = tableitem.Rows.Count;
            dataGridView1.DataSource = tableitem;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_ItemID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_ItemName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_Price.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        private void bt_edit_Click(object sender, EventArgs e)
        {
            string id = tb_ItemID.Text;
            string name = tb_ItemName.Text;
            int price = Convert.ToInt32(tb_Price.Text);
            if(ItemDAO.Instance.updateItem(id, name, price))
                MessageBox.Show("Updated", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            refresh();

        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            string id = "i" + (item_count + 1).ToString();
            MessageBox.Show(id.ToString());
            string name = tb_ItemName.Text;
            int price = Convert.ToInt32(tb_Price.Text);

            if (ItemDAO.Instance.addItem(id, name, price))
                MessageBox.Show("Added", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            refresh();
        }
        private void bt_remove_Click(object sender, EventArgs e)
        {
            string id = tb_ItemID.Text;
            if(ItemDAO.Instance.deleteItem(id))
                MessageBox.Show("Deleted", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            refresh();
        }
    }
}
