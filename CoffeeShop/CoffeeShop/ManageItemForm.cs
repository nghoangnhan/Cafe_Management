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
    public partial class ManageItemForm : Form
    {
        int item_count = 0;
        public ManageItemForm()
        {
            InitializeComponent();
        }
        void refresh()
        {
            try
            {
                dataGridView1.DataSource = ItemDAO.Instance.getAllItem();
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditItemForm_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.ReadOnly = true;
                DataTable tableitem = ItemDAO.Instance.getAllItem();
                item_count = tableitem.Rows.Count;
                dataGridView1.DataSource = tableitem;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_ItemID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tb_ItemName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tb_Price.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bt_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string id = tb_ItemID.Text;
                string name = tb_ItemName.Text;
                int price = Convert.ToInt32(tb_Price.Text);
                if (ItemDAO.Instance.updateItem(id, name, price))
                    MessageBox.Show("Đã cập nhật!", "Cập nhật sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Lỗi!", "Cập nhật sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                refresh();
            }
            catch
            {
                MessageBox.Show("Lỗi sửa sản phẩm", "Sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "i" + (item_count + 1).ToString();
                string name = tb_ItemName.Text;
                int price = Convert.ToInt32(tb_Price.Text);

                if (ItemDAO.Instance.addItem(id, name, price))
                    MessageBox.Show("Đã thêm sản phẩm!", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Lỗi!", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                refresh();
            }
            catch
            {
                MessageBox.Show("Lỗi thêm sản phẩm", "Sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bt_remove_Click(object sender, EventArgs e)
        {
            try
            {
                string id = tb_ItemID.Text;
                if (ItemDAO.Instance.deleteItem(id))
                    MessageBox.Show("Đã xóa sản phẩm!", "Xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Lỗi!", "Xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                refresh();
            }
            catch
            {
                MessageBox.Show("Lỗi xóa sản phẩm", "Sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
