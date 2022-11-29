
namespace CoffeeShop
{
    partial class ManageEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployee));
            this.pnwaiter = new System.Windows.Forms.Panel();
            this.cbposi = new System.Windows.Forms.ComboBox();
            this.btdismiss = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btfind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btedit = new System.Windows.Forms.Button();
            this.tbsalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.pnwaiter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnwaiter
            // 
            this.pnwaiter.Controls.Add(this.cbposi);
            this.pnwaiter.Controls.Add(this.btdismiss);
            this.pnwaiter.Controls.Add(this.btadd);
            this.pnwaiter.Controls.Add(this.btfind);
            this.pnwaiter.Controls.Add(this.label1);
            this.pnwaiter.Controls.Add(this.label5);
            this.pnwaiter.Controls.Add(this.btedit);
            this.pnwaiter.Controls.Add(this.tbsalary);
            this.pnwaiter.Controls.Add(this.label6);
            this.pnwaiter.Controls.Add(this.tbaddress);
            this.pnwaiter.Controls.Add(this.label7);
            this.pnwaiter.Controls.Add(this.tbphone);
            this.pnwaiter.Controls.Add(this.label8);
            this.pnwaiter.Controls.Add(this.tbname);
            this.pnwaiter.Controls.Add(this.label9);
            this.pnwaiter.Controls.Add(this.tbid);
            this.pnwaiter.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnwaiter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnwaiter.Location = new System.Drawing.Point(25, 12);
            this.pnwaiter.Name = "pnwaiter";
            this.pnwaiter.Size = new System.Drawing.Size(521, 516);
            this.pnwaiter.TabIndex = 18;
            this.pnwaiter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnwaiter_Paint);
            // 
            // cbposi
            // 
            this.cbposi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbposi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbposi.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbposi.FormattingEnabled = true;
            this.cbposi.Items.AddRange(new object[] {
            "Waiter",
            "Barista",
            "Cashier",
            "Manager"});
            this.cbposi.Location = new System.Drawing.Point(195, 354);
            this.cbposi.Name = "cbposi";
            this.cbposi.Size = new System.Drawing.Size(183, 33);
            this.cbposi.TabIndex = 30;
            // 
            // btdismiss
            // 
            this.btdismiss.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btdismiss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdismiss.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdismiss.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btdismiss.Location = new System.Drawing.Point(371, 445);
            this.btdismiss.Name = "btdismiss";
            this.btdismiss.Size = new System.Drawing.Size(117, 46);
            this.btdismiss.TabIndex = 29;
            this.btdismiss.Text = "Xóa";
            this.btdismiss.UseVisualStyleBackColor = false;
            this.btdismiss.Click += new System.EventHandler(this.btdismiss_Click);
            // 
            // btadd
            // 
            this.btadd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btadd.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btadd.Location = new System.Drawing.Point(29, 445);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(117, 46);
            this.btadd.TabIndex = 28;
            this.btadd.Text = "Thêm";
            this.btadd.UseVisualStyleBackColor = false;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btfind
            // 
            this.btfind.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btfind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btfind.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btfind.Location = new System.Drawing.Point(410, 5);
            this.btfind.Name = "btfind";
            this.btfind.Size = new System.Drawing.Size(96, 37);
            this.btfind.TabIndex = 27;
            this.btfind.Text = "Tìm";
            this.btfind.UseVisualStyleBackColor = false;
            this.btfind.Click += new System.EventHandler(this.btfind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(24, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "Chức vụ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(24, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Họ tên:";
            // 
            // btedit
            // 
            this.btedit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btedit.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btedit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btedit.Location = new System.Drawing.Point(195, 445);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(117, 46);
            this.btedit.TabIndex = 2;
            this.btedit.Text = "Sửa";
            this.btedit.UseVisualStyleBackColor = false;
            this.btedit.Click += new System.EventHandler(this.btedit_Click_1);
            // 
            // tbsalary
            // 
            this.tbsalary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsalary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbsalary.Location = new System.Drawing.Point(195, 288);
            this.tbsalary.Name = "tbsalary";
            this.tbsalary.Size = new System.Drawing.Size(183, 30);
            this.tbsalary.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(24, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã nhân viên:";
            // 
            // tbaddress
            // 
            this.tbaddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbaddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbaddress.Location = new System.Drawing.Point(195, 178);
            this.tbaddress.Multiline = true;
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(183, 89);
            this.tbaddress.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(24, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Địa chỉ:";
            // 
            // tbphone
            // 
            this.tbphone.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbphone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbphone.Location = new System.Drawing.Point(195, 129);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(183, 30);
            this.tbphone.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(24, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "Số điện thoại:";
            // 
            // tbname
            // 
            this.tbname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbname.Location = new System.Drawing.Point(195, 71);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(183, 30);
            this.tbname.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(24, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "Lương:";
            // 
            // tbid
            // 
            this.tbid.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbid.Location = new System.Drawing.Point(195, 12);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(117, 30);
            this.tbid.TabIndex = 19;
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(578, 540);
            this.Controls.Add(this.pnwaiter);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.pnwaiter.ResumeLayout(false);
            this.pnwaiter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnwaiter;
        private System.Windows.Forms.Button btfind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.TextBox tbsalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.ComboBox cbposi;
        private System.Windows.Forms.Button btdismiss;
        private System.Windows.Forms.Button btadd;
    }
}