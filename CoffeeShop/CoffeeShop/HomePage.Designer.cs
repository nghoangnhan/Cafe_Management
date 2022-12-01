
namespace CoffeeShop
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.bt_Manager = new System.Windows.Forms.Button();
            this.bt_Staff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btsignout = new System.Windows.Forms.Button();
            this.bt_Income = new System.Windows.Forms.Button();
            this.bt_Customer = new System.Windows.Forms.Button();
            this.bt_Checking = new System.Windows.Forms.Button();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.tbDes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.bt_Find = new System.Windows.Forms.Button();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_Amount = new System.Windows.Forms.TextBox();
            this.bt_SCart = new System.Windows.Forms.Button();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.pn_Menu_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_CusName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_Menu_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Manager
            // 
            this.bt_Manager.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Manager.FlatAppearance.BorderSize = 2;
            this.bt_Manager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.bt_Manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Manager.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Manager.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Manager.Location = new System.Drawing.Point(7, 52);
            this.bt_Manager.Name = "bt_Manager";
            this.bt_Manager.Size = new System.Drawing.Size(155, 48);
            this.bt_Manager.TabIndex = 0;
            this.bt_Manager.Text = "Quản lý";
            this.bt_Manager.UseVisualStyleBackColor = false;
            this.bt_Manager.Click += new System.EventHandler(this.bt_Staff_Click);
            // 
            // bt_Staff
            // 
            this.bt_Staff.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Staff.FlatAppearance.BorderSize = 2;
            this.bt_Staff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.bt_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Staff.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Staff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Staff.Location = new System.Drawing.Point(7, 168);
            this.bt_Staff.Name = "bt_Staff";
            this.bt_Staff.Size = new System.Drawing.Size(155, 48);
            this.bt_Staff.TabIndex = 1;
            this.bt_Staff.Text = "Bán hàng";
            this.bt_Staff.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_Staff.UseVisualStyleBackColor = false;
            this.bt_Staff.Click += new System.EventHandler(this.bt_Customer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btsignout);
            this.panel1.Controls.Add(this.bt_Income);
            this.panel1.Controls.Add(this.bt_Customer);
            this.panel1.Controls.Add(this.bt_Checking);
            this.panel1.Controls.Add(this.bt_Staff);
            this.panel1.Controls.Add(this.bt_Manager);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 698);
            this.panel1.TabIndex = 2;
            // 
            // btsignout
            // 
            this.btsignout.BackColor = System.Drawing.Color.White;
            this.btsignout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btsignout.FlatAppearance.BorderSize = 2;
            this.btsignout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btsignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsignout.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsignout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btsignout.Location = new System.Drawing.Point(7, 615);
            this.btsignout.Name = "btsignout";
            this.btsignout.Size = new System.Drawing.Size(155, 48);
            this.btsignout.TabIndex = 5;
            this.btsignout.Text = "Đăng xuất";
            this.btsignout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsignout.UseVisualStyleBackColor = false;
            this.btsignout.Click += new System.EventHandler(this.btsignout_Click);
            // 
            // bt_Income
            // 
            this.bt_Income.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Income.FlatAppearance.BorderSize = 2;
            this.bt_Income.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.bt_Income.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Income.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Income.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Income.Location = new System.Drawing.Point(7, 398);
            this.bt_Income.Name = "bt_Income";
            this.bt_Income.Size = new System.Drawing.Size(155, 48);
            this.bt_Income.TabIndex = 4;
            this.bt_Income.Text = "Thu nhập";
            this.bt_Income.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_Income.UseVisualStyleBackColor = false;
            this.bt_Income.Click += new System.EventHandler(this.bt_Income_Click);
            // 
            // bt_Customer
            // 
            this.bt_Customer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Customer.FlatAppearance.BorderSize = 2;
            this.bt_Customer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.bt_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Customer.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Customer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Customer.Location = new System.Drawing.Point(7, 280);
            this.bt_Customer.Name = "bt_Customer";
            this.bt_Customer.Size = new System.Drawing.Size(155, 48);
            this.bt_Customer.TabIndex = 3;
            this.bt_Customer.Text = "Khách hàng";
            this.bt_Customer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_Customer.UseVisualStyleBackColor = false;
            this.bt_Customer.Click += new System.EventHandler(this.bt_Customer_Click_1);
            // 
            // bt_Checking
            // 
            this.bt_Checking.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Checking.FlatAppearance.BorderSize = 2;
            this.bt_Checking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.bt_Checking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Checking.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Checking.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Checking.Location = new System.Drawing.Point(7, 507);
            this.bt_Checking.Name = "bt_Checking";
            this.bt_Checking.Size = new System.Drawing.Size(155, 48);
            this.bt_Checking.TabIndex = 2;
            this.bt_Checking.Text = "Check-in";
            this.bt_Checking.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_Checking.UseVisualStyleBackColor = false;
            this.bt_Checking.Click += new System.EventHandler(this.bt_Checking_Click);
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.Transparent;
            this.panel_Menu.Controls.Add(this.tbDes);
            this.panel_Menu.Controls.Add(this.label7);
            this.panel_Menu.Controls.Add(this.comboBox1);
            this.panel_Menu.Controls.Add(this.label6);
            this.panel_Menu.Controls.Add(this.bt_Refresh);
            this.panel_Menu.Controls.Add(this.bt_Find);
            this.panel_Menu.Controls.Add(this.bt_Reset);
            this.panel_Menu.Controls.Add(this.bt_Remove);
            this.panel_Menu.Controls.Add(this.dataGridView1);
            this.panel_Menu.Controls.Add(this.tb_Amount);
            this.panel_Menu.Controls.Add(this.bt_SCart);
            this.panel_Menu.Controls.Add(this.tb_Phone);
            this.panel_Menu.Controls.Add(this.pn_Menu_dataGridView1);
            this.panel_Menu.Controls.Add(this.tb_CusName);
            this.panel_Menu.Controls.Add(this.label4);
            this.panel_Menu.Controls.Add(this.label5);
            this.panel_Menu.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Menu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_Menu.Location = new System.Drawing.Point(169, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(1123, 698);
            this.panel_Menu.TabIndex = 4;
            this.panel_Menu.Visible = false;
            // 
            // tbDes
            // 
            this.tbDes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbDes.Location = new System.Drawing.Point(285, 181);
            this.tbDes.Multiline = true;
            this.tbDes.Name = "tbDes";
            this.tbDes.Size = new System.Drawing.Size(212, 139);
            this.tbDes.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(16, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mô tả:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(285, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 33);
            this.comboBox1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(16, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Thu ngân:";
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Refresh.FlatAppearance.BorderSize = 2;
            this.bt_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.bt_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Refresh.Location = new System.Drawing.Point(990, 10);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(121, 47);
            this.bt_Refresh.TabIndex = 14;
            this.bt_Refresh.Text = "Làm mới";
            this.bt_Refresh.UseVisualStyleBackColor = false;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            // 
            // bt_Find
            // 
            this.bt_Find.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Find.FlatAppearance.BorderSize = 2;
            this.bt_Find.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.bt_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Find.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Find.Location = new System.Drawing.Point(526, 15);
            this.bt_Find.Name = "bt_Find";
            this.bt_Find.Size = new System.Drawing.Size(121, 44);
            this.bt_Find.TabIndex = 13;
            this.bt_Find.Text = "Tìm";
            this.bt_Find.UseVisualStyleBackColor = false;
            this.bt_Find.Click += new System.EventHandler(this.bt_Find_Click);
            // 
            // bt_Reset
            // 
            this.bt_Reset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Reset.FlatAppearance.BorderSize = 2;
            this.bt_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.bt_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Reset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Reset.Location = new System.Drawing.Point(729, 274);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(91, 46);
            this.bt_Reset.TabIndex = 12;
            this.bt_Reset.Text = "Reset";
            this.bt_Reset.UseVisualStyleBackColor = false;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Remove.FlatAppearance.BorderSize = 2;
            this.bt_Remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Remove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Remove.Location = new System.Drawing.Point(878, 274);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(91, 46);
            this.bt_Remove.TabIndex = 11;
            this.bt_Remove.Text = "Xóa";
            this.bt_Remove.UseVisualStyleBackColor = false;
            this.bt_Remove.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(729, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(370, 355);
            this.dataGridView1.TabIndex = 10;
            // 
            // tb_Amount
            // 
            this.tb_Amount.BackColor = System.Drawing.Color.Red;
            this.tb_Amount.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Amount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Amount.Location = new System.Drawing.Point(1010, 242);
            this.tb_Amount.Name = "tb_Amount";
            this.tb_Amount.ReadOnly = true;
            this.tb_Amount.Size = new System.Drawing.Size(26, 23);
            this.tb_Amount.TabIndex = 9;
            // 
            // bt_SCart
            // 
            this.bt_SCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_SCart.BackgroundImage")));
            this.bt_SCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_SCart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_SCart.FlatAppearance.BorderSize = 2;
            this.bt_SCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_SCart.Location = new System.Drawing.Point(1021, 247);
            this.bt_SCart.Name = "bt_SCart";
            this.bt_SCart.Size = new System.Drawing.Size(78, 73);
            this.bt_SCart.TabIndex = 8;
            this.bt_SCart.UseVisualStyleBackColor = true;
            this.bt_SCart.Click += new System.EventHandler(this.bt_SCart_Click);
            // 
            // tb_Phone
            // 
            this.tb_Phone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Phone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_Phone.Location = new System.Drawing.Point(285, 21);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(212, 30);
            this.tb_Phone.TabIndex = 7;
            // 
            // pn_Menu_dataGridView1
            // 
            this.pn_Menu_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pn_Menu_dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.pn_Menu_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pn_Menu_dataGridView1.Location = new System.Drawing.Point(19, 326);
            this.pn_Menu_dataGridView1.Name = "pn_Menu_dataGridView1";
            this.pn_Menu_dataGridView1.RowHeadersWidth = 51;
            this.pn_Menu_dataGridView1.RowTemplate.Height = 24;
            this.pn_Menu_dataGridView1.Size = new System.Drawing.Size(599, 355);
            this.pn_Menu_dataGridView1.TabIndex = 1;
            this.pn_Menu_dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pn_Menu_dataGridView1_CellContentDoubleClick);
            // 
            // tb_CusName
            // 
            this.tb_CusName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_CusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CusName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_CusName.Location = new System.Drawing.Point(285, 71);
            this.tb_CusName.Name = "tb_CusName";
            this.tb_CusName.Size = new System.Drawing.Size(212, 30);
            this.tb_CusName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(15, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số điện thoại khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(16, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên khách hàng:";
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataMember = "Order_Item";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::CoffeeShop.Properties.Resources.backgroundHomePage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1292, 693);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePage_FormClosed);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_Menu_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button bt_Manager;
        private System.Windows.Forms.Button bt_Staff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.DataGridView pn_Menu_dataGridView1;
        public System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.TextBox tb_CusName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Amount;
        private System.Windows.Forms.Button bt_SCart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.Button bt_Checking;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.Button bt_Find;
        public System.Windows.Forms.Button bt_Customer;
        public System.Windows.Forms.Button bt_Income;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.Button bt_Refresh;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbDes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btsignout;
    }
}