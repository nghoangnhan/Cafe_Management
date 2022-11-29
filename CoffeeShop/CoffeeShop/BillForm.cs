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
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using System.Drawing.Drawing2D;
using CoffeeShop.DTO;
using CoffeeShop.DAO;


namespace CoffeeShop
{

    // Item.checkPrice() da sua
    // Bug: Chi add vao C_ID = 10
    public partial class BillForm : Form
    {
        public Bill bill;
        int total = 0;
        public BillForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Bill_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime bdate = new DateTime();
                bdate = DateTime.Now;

                listBox_Bill.Show();

                SqlCommand command = new SqlCommand("SELECT * FROM Order_Item WHERE O_Num = " + bill.Order_Number);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.Connection = DB.Instance.getConnection;
                DataTable table1 = new DataTable();
                adapter.Fill(table1);
                if (table1.Rows.Count > 0)
                    for (int i = 0; i < table1.Rows.Count; i++)
                    {
                        listBox_Bill.Items.Add(table1.Rows[i]["It_Name"].ToString() + " x " + table1.Rows[i]["It_Quantity"]
                        + "      = " + (BillDAO.Instance.checkPrice(table1.Rows[i]["It_Name"].ToString()) * Convert.ToInt32(table1.Rows[i]["It_Quantity"])));
                        total += BillDAO.Instance.checkPrice(table1.Rows[i]["It_Name"].ToString()) * Convert.ToInt32(table1.Rows[i]["It_Quantity"]);
                    }
                if (bill.C_ID == 10)
                {
                    listBox_Bill.Items.Add("Tổng: " + total);
                    BillDAO.Instance.addBill(bill.Order_Number, bill.E_ID, 10, bdate, total, bill.Description);     // 10: co' the? la` so' khac' (phai? ton` tai.)
                }
                else
                {
                    BillDAO.Instance.addBill(bill.Order_Number, bill.E_ID, bill.C_ID, bdate, total, bill.Description);
                    int total_discounted = BillDAO.Instance.getBill(bill.Order_Number, bdate).Total;
                    if (total_discounted < total)
                    {
                        listBox_Bill.Items.Add("Giảm giá: 10%");
                        total = total_discounted;
                        listBox_Bill.Items.Add("Giá đã giảm: " + total);
                    }
                }
                listBox_Bill.Items.Add("Thu ngân: " + HomePage.homepage.comboBox1.Text);
                listBox_Bill.Items.Add("Mô tả: " + bill.Description);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void bt_Done_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(tb_cashin.Text) < total)
                {
                    MessageBox.Show("Số tiền không hợp lệ!", "Hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int cashin = Convert.ToInt32(tb_cashin.Text);
                    tb_Cashback.Text = (cashin - total).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox_Bill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }
        private void btmomo_Click(object sender, EventArgs e)
        {
            try
            {
                var qrcode_text = $"2|99|0938591504|Le Hoang Lam|0|0|0|{total}|";
                BarcodeWriter barcodeWriter = new BarcodeWriter();
                EncodingOptions encodingOptions = new EncodingOptions() { Width = 250, Height = 250, Margin = 0, PureBarcode = false };
                encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
                barcodeWriter.Renderer = new BitmapRenderer();
                barcodeWriter.Options = encodingOptions;
                barcodeWriter.Format = BarcodeFormat.QR_CODE;
                Bitmap bitmap = barcodeWriter.Write(qrcode_text);
                Bitmap logo = resizeImage(Properties.Resources.momo, 64, 64) as Bitmap;
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
                picboxqr.Image = bitmap;
                picboxqr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btzalopay_Click(object sender, EventArgs e)
        {
            try
            {
                var qrcode_text = $"https://qr.zalopay.vn/u/205112657624";
                BarcodeWriter barcodeWriter = new BarcodeWriter();
                EncodingOptions encodingOptions = new EncodingOptions() { Width = 250, Height = 250, Margin = 0, PureBarcode = false };
                encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
                barcodeWriter.Renderer = new BitmapRenderer();
                barcodeWriter.Options = encodingOptions;
                barcodeWriter.Format = BarcodeFormat.QR_CODE;
                Bitmap bitmap = barcodeWriter.Write(qrcode_text);
                Bitmap logo = resizeImage(Properties.Resources.zalopay, 64, 64) as Bitmap;
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
                picboxqr.Image = bitmap;
                picboxqr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BillForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage.homepage.Show();
        }
    }
}
