
namespace CoffeeShop
{
    partial class IncomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomeForm));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bt_Check = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_Next = new System.Windows.Forms.Button();
            this.bt_Previous = new System.Windows.Forms.Button();
            this.lb_Total = new System.Windows.Forms.Label();
            this.bt_Checkmonth = new System.Windows.Forms.Button();
            this.btprintBill = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateTimePicker1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(298, 78);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(639, 40);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // bt_Check
            // 
            this.bt_Check.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Check.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Check.Location = new System.Drawing.Point(298, 151);
            this.bt_Check.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Check.Name = "bt_Check";
            this.bt_Check.Size = new System.Drawing.Size(289, 50);
            this.bt_Check.TabIndex = 1;
            this.bt_Check.Text = "Kiểm tra trong ngày";
            this.bt_Check.UseVisualStyleBackColor = false;
            this.bt_Check.Click += new System.EventHandler(this.bt_Check_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 226);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1217, 397);
            this.dataGridView1.TabIndex = 2;
            // 
            // bt_Next
            // 
            this.bt_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Next.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Next.Location = new System.Drawing.Point(947, 78);
            this.bt_Next.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Next.Name = "bt_Next";
            this.bt_Next.Size = new System.Drawing.Size(82, 52);
            this.bt_Next.TabIndex = 3;
            this.bt_Next.Text = ">>";
            this.bt_Next.UseVisualStyleBackColor = true;
            this.bt_Next.Click += new System.EventHandler(this.bt_Next_Click);
            // 
            // bt_Previous
            // 
            this.bt_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Previous.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Previous.Location = new System.Drawing.Point(208, 78);
            this.bt_Previous.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Previous.Name = "bt_Previous";
            this.bt_Previous.Size = new System.Drawing.Size(82, 52);
            this.bt_Previous.TabIndex = 4;
            this.bt_Previous.Text = "<<";
            this.bt_Previous.UseVisualStyleBackColor = true;
            this.bt_Previous.Click += new System.EventHandler(this.bt_Previous_Click);
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Total.Location = new System.Drawing.Point(36, 659);
            this.lb_Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(69, 25);
            this.lb_Total.TabIndex = 5;
            this.lb_Total.Text = "Tổng:";
            // 
            // bt_Checkmonth
            // 
            this.bt_Checkmonth.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Checkmonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Checkmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Checkmonth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Checkmonth.Location = new System.Drawing.Point(650, 151);
            this.bt_Checkmonth.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Checkmonth.Name = "bt_Checkmonth";
            this.bt_Checkmonth.Size = new System.Drawing.Size(289, 50);
            this.bt_Checkmonth.TabIndex = 6;
            this.bt_Checkmonth.Text = "Kiểm tra trong tháng";
            this.bt_Checkmonth.UseVisualStyleBackColor = false;
            this.bt_Checkmonth.Click += new System.EventHandler(this.bt_Checkmonth_Click);
            // 
            // btprintBill
            // 
            this.btprintBill.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btprintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btprintBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btprintBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btprintBill.Location = new System.Drawing.Point(964, 634);
            this.btprintBill.Margin = new System.Windows.Forms.Padding(4);
            this.btprintBill.Name = "btprintBill";
            this.btprintBill.Size = new System.Drawing.Size(289, 50);
            this.btprintBill.TabIndex = 7;
            this.btprintBill.Text = "In báo cáo thu chi";
            this.btprintBill.UseVisualStyleBackColor = false;
            this.btprintBill.Click += new System.EventHandler(this.btprintBill_Click);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1288, 762);
            this.Controls.Add(this.btprintBill);
            this.Controls.Add(this.bt_Checkmonth);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.bt_Previous);
            this.Controls.Add(this.bt_Next);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_Check);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IncomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thu nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IncomeForm_FormClosed);
            this.Load += new System.EventHandler(this.IncomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bt_Check;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Next;
        private System.Windows.Forms.Button bt_Previous;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Button bt_Checkmonth;
        private System.Windows.Forms.Button btprintBill;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}