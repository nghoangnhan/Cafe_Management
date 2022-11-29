using CoffeeShop.DAO;
using CoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private static LoginForm loginForm;
        public static LoginForm loginform
        {
            get
            {
                if (loginForm == null)
                    loginForm = new LoginForm();
                return loginForm;
            }
            private set => loginForm = value;
        }
        private void btSignin_Click(object sender, EventArgs e)
        {
            if (rb_Manager.Checked == true)
            {
                if (AccountDAO.Instance.signIn(tb_Username.Text, tb_Password.Text, "manager"))
                {
                    tb_Username.Clear();
                    tb_Password.Clear();
                    HomePage.homepage.bt_Income.Enabled = true;
                    HomePage.homepage.bt_Manager.Enabled = true;
                    LoadingForm.loadingform.progressBar1.Value = 0;
                    LoadingForm.loadingform.Show();
                    LoadingForm.loadingform.timer2.Start();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại, sai tên đăng nhập hoặc mật khẩu!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_Employee.Checked == true)
            {
                if (AccountDAO.Instance.signIn(tb_Password.Text, tb_Password.Text, "employee"))
                {
                    tb_Username.Clear();
                    tb_Password.Clear();
                    HomePage.homepage.bt_Income.Enabled = false;
                    HomePage.homepage.bt_Manager.Enabled = false;
                    LoadingForm.loadingform.progressBar1.Value = 0;
                    LoadingForm.loadingform.Show();
                    LoadingForm.loadingform.timer2.Start();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại, sai tên đăng nhập hoặc mật khẩu!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chọn chức vụ của bạn!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btSignin_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btSignin_MouseLeave(object sender, EventArgs e)
        {
            btSignin.BackColor = Color.Transparent;
            btSignin.ForeColor = Color.Transparent;
        }

        private void btSignin_MouseEnter(object sender, EventArgs e)
        {
            btSignin.BackColor = Color.White;
            btSignin.ForeColor = Color.Black;
        }
    }
}
