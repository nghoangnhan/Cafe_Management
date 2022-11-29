namespace CoffeeShop
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btSignin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.rb_Manager = new System.Windows.Forms.RadioButton();
            this.rb_Employee = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btSignin
            // 
            this.btSignin.BackColor = System.Drawing.Color.Transparent;
            this.btSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignin.ForeColor = System.Drawing.Color.Transparent;
            this.btSignin.Location = new System.Drawing.Point(51, 272);
            this.btSignin.Name = "btSignin";
            this.btSignin.Size = new System.Drawing.Size(376, 48);
            this.btSignin.TabIndex = 1;
            this.btSignin.Text = "Đăng nhập";
            this.btSignin.UseVisualStyleBackColor = false;
            this.btSignin.Click += new System.EventHandler(this.btSignin_Click);
            this.btSignin.MouseEnter += new System.EventHandler(this.btSignin_MouseEnter);
            this.btSignin.MouseLeave += new System.EventHandler(this.btSignin_MouseLeave);
            this.btSignin.MouseHover += new System.EventHandler(this.btSignin_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(47, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(47, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mật khẩu:";
            // 
            // tb_Username
            // 
            this.tb_Username.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_Username.Location = new System.Drawing.Point(236, 46);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(191, 30);
            this.tb_Username.TabIndex = 8;
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_Password.Location = new System.Drawing.Point(236, 130);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(191, 30);
            this.tb_Password.TabIndex = 9;
            // 
            // rb_Manager
            // 
            this.rb_Manager.AutoSize = true;
            this.rb_Manager.BackColor = System.Drawing.Color.Transparent;
            this.rb_Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Manager.ForeColor = System.Drawing.Color.Transparent;
            this.rb_Manager.Location = new System.Drawing.Point(51, 206);
            this.rb_Manager.Name = "rb_Manager";
            this.rb_Manager.Size = new System.Drawing.Size(108, 29);
            this.rb_Manager.TabIndex = 10;
            this.rb_Manager.TabStop = true;
            this.rb_Manager.Text = "Quản lý";
            this.rb_Manager.UseVisualStyleBackColor = false;
            // 
            // rb_Employee
            // 
            this.rb_Employee.AutoSize = true;
            this.rb_Employee.BackColor = System.Drawing.Color.Transparent;
            this.rb_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Employee.ForeColor = System.Drawing.Color.Transparent;
            this.rb_Employee.Location = new System.Drawing.Point(321, 206);
            this.rb_Employee.Name = "rb_Employee";
            this.rb_Employee.Size = new System.Drawing.Size(130, 29);
            this.rb_Employee.TabIndex = 11;
            this.rb_Employee.TabStop = true;
            this.rb_Employee.Text = "Nhân viên";
            this.rb_Employee.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShop.Properties.Resources.Logo_New;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 382);
            this.Controls.Add(this.rb_Employee);
            this.Controls.Add(this.rb_Manager);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btSignin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSignin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_Username;
        public System.Windows.Forms.TextBox tb_Password;
        public System.Windows.Forms.RadioButton rb_Manager;
        public System.Windows.Forms.RadioButton rb_Employee;
    }
}