using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ActivationContext;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeeShop
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }
        private static LoadingForm loadingForm;
        public static LoadingForm loadingform
        {
            get
            {
                if (loadingForm == null)
                    loadingForm = new LoadingForm();
                return loadingForm;
            }
            private set => loadingForm = value;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (progressBar1.Value < 100)
                {
                    progressBar1.Value += 10;
                    label1.Text = progressBar1.Value.ToString() + "%";
                }
                else
                {
                    timer2.Stop();
                    Hide();
                    HomePageForm.homepage.Show();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi tải dữ liệu", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
