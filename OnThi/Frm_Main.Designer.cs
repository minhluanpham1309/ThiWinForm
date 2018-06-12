namespace OnThi
{
    partial class Frm_Main
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
            this.MenuDM = new System.Windows.Forms.MenuStrip();
            this.MenuItem_TT = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSinhViênTheoDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDM.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuDM
            // 
            this.MenuDM.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuDM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_TT,
            this.quảnLýSinhViênTheoDanhMụcToolStripMenuItem});
            this.MenuDM.Location = new System.Drawing.Point(0, 0);
            this.MenuDM.Name = "MenuDM";
            this.MenuDM.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.MenuDM.Size = new System.Drawing.Size(1333, 35);
            this.MenuDM.TabIndex = 0;
            this.MenuDM.Text = "menuStrip1";
            // 
            // MenuItem_TT
            // 
            this.MenuItem_TT.Name = "MenuItem_TT";
            this.MenuItem_TT.Size = new System.Drawing.Size(181, 29);
            this.MenuItem_TT.Text = "Thông Tin Sinh Viên";
            this.MenuItem_TT.Click += new System.EventHandler(this.MenuItem_TT_Click);
            // 
            // quảnLýSinhViênTheoDanhMụcToolStripMenuItem
            // 
            this.quảnLýSinhViênTheoDanhMụcToolStripMenuItem.Name = "quảnLýSinhViênTheoDanhMụcToolStripMenuItem";
            this.quảnLýSinhViênTheoDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(284, 29);
            this.quảnLýSinhViênTheoDanhMụcToolStripMenuItem.Text = "Quản lý sinh viên theo danh mục";
            this.quảnLýSinhViênTheoDanhMụcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSinhViênTheoDanhMụcToolStripMenuItem_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 675);
            this.Controls.Add(this.MenuDM);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuDM;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuDM.ResumeLayout(false);
            this.MenuDM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuDM;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_TT;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSinhViênTheoDanhMụcToolStripMenuItem;
    }
}

