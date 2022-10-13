
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
            this.btrefresh = new System.Windows.Forms.Button();
            this.gridcashier = new System.Windows.Forms.DataGridView();
            this.Manage_Toolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.findStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridcashier)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btrefresh
            // 
            this.btrefresh.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btrefresh.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btrefresh.Location = new System.Drawing.Point(485, 544);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(116, 36);
            this.btrefresh.TabIndex = 33;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = false;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click_1);
            // 
            // gridcashier
            // 
            this.gridcashier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridcashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcashier.Location = new System.Drawing.Point(12, 47);
            this.gridcashier.Name = "gridcashier";
            this.gridcashier.RowHeadersWidth = 51;
            this.gridcashier.RowTemplate.Height = 24;
            this.gridcashier.Size = new System.Drawing.Size(1065, 491);
            this.gridcashier.TabIndex = 34;
            // 
            // Manage_Toolstrip
            // 
            this.Manage_Toolstrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Manage_Toolstrip.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_Toolstrip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Manage_Toolstrip.Name = "Manage_Toolstrip";
            this.Manage_Toolstrip.Size = new System.Drawing.Size(144, 24);
            this.Manage_Toolstrip.Text = "Manage Employee";
            this.Manage_Toolstrip.Click += new System.EventHandler(this.Manage_Toolstrip_Click);
            // 
            // findStaffToolStripMenuItem
            // 
            this.findStaffToolStripMenuItem.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findStaffToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.findStaffToolStripMenuItem.Name = "findStaffToolStripMenuItem";
            this.findStaffToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.findStaffToolStripMenuItem.Text = "Find Staff";
            this.findStaffToolStripMenuItem.Click += new System.EventHandler(this.findStaffToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(91, 24);
            this.toolStripMenuItem1.Text = "Edit Item";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.goBackToolStripMenuItem.Text = "Go Back To Home Page";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Manage_Toolstrip,
            this.findStaffToolStripMenuItem,
            this.toolStripMenuItem1,
            this.goBackToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1091, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1091, 595);
            this.Controls.Add(this.btrefresh);
            this.Controls.Add(this.gridcashier);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
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
        private System.Windows.Forms.ToolStripMenuItem findStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}