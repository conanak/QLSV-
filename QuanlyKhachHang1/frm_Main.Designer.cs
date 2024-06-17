namespace QuanlyKhachHang1
{
    partial class frm_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dSKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.hoáĐơnToolStripMenuItem,
            this.kiểmToánToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(129, 34);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dSKháchHàngToolStripMenuItem});
            this.quảnLýKháchHàngToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // hoáĐơnToolStripMenuItem
            // 
            this.hoáĐơnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoáĐơnToolStripMenuItem.Name = "hoáĐơnToolStripMenuItem";
            this.hoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(121, 34);
            this.hoáĐơnToolStripMenuItem.Text = "Hoá đơn";
            // 
            // kiểmToánToolStripMenuItem
            // 
            this.kiểmToánToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kiểmToánToolStripMenuItem.Name = "kiểmToánToolStripMenuItem";
            this.kiểmToánToolStripMenuItem.Size = new System.Drawing.Size(145, 34);
            this.kiểmToánToolStripMenuItem.Text = "Kiểm toán";
            // 
            // dSKháchHàngToolStripMenuItem
            // 
            this.dSKháchHàngToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dSKháchHàngToolStripMenuItem.Name = "dSKháchHàngToolStripMenuItem";
            this.dSKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.dSKháchHàngToolStripMenuItem.Text = "DS Khách hàng";
            this.dSKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.dSKháchHàngToolStripMenuItem_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Text = "Danh Mục Chính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dSKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoáĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmToánToolStripMenuItem;
    }
}

