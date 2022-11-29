
namespace CoffeeShop
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.btrefresh = new System.Windows.Forms.Button();
            this.gridcashier = new System.Windows.Forms.DataGridView();
            this.Manage_Toolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridcashier)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btrefresh
            // 
            this.btrefresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btrefresh.Location = new System.Drawing.Point(524, 389);
            this.btrefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(188, 56);
            this.btrefresh.TabIndex = 33;
            this.btrefresh.Text = "Làm mới";
            this.btrefresh.UseVisualStyleBackColor = false;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click_1);
            // 
            // gridcashier
            // 
            this.gridcashier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridcashier.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridcashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcashier.Location = new System.Drawing.Point(20, 39);
            this.gridcashier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridcashier.Name = "gridcashier";
            this.gridcashier.RowHeadersWidth = 51;
            this.gridcashier.RowTemplate.Height = 24;
            this.gridcashier.Size = new System.Drawing.Size(1233, 326);
            this.gridcashier.TabIndex = 34;
            // 
            // Manage_Toolstrip
            // 
            this.Manage_Toolstrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Manage_Toolstrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_Toolstrip.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Manage_Toolstrip.Name = "Manage_Toolstrip";
            this.Manage_Toolstrip.Size = new System.Drawing.Size(201, 29);
            this.Manage_Toolstrip.Text = "Quản lý nhân viên";
            this.Manage_Toolstrip.Click += new System.EventHandler(this.Manage_Toolstrip_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 29);
            this.toolStripMenuItem1.Text = "Quản lý sản phẩm";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1262, 35);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1262, 472);
            this.Controls.Add(this.btrefresh);
            this.Controls.Add(this.gridcashier);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Manager_FormClosed);
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridcashier)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btrefresh;
        private System.Windows.Forms.DataGridView gridcashier;
        private System.Windows.Forms.ToolStripMenuItem Manage_Toolstrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}