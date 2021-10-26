
namespace Quanlykhohang
{
    partial class FormTrangChu
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
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUser = new System.Windows.Forms.ToolStripMenuItem();
            this.blockUser = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.logOut = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKếToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhânTíchThịTrườngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đảmBảoChấtLượngKinhDoanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.quảnLýKếToánToolStripMenuItem,
            this.quảnLýPhânTíchThịTrườngToolStripMenuItem,
            this.quảnLýKhoToolStripMenuItem,
            this.đảmBảoChấtLượngKinhDoanhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1120, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUser,
            this.blockUser,
            this.changePassword,
            this.logOut});
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(161, 27);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            // 
            // addUser
            // 
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(224, 28);
            this.addUser.Text = "Cấp tài khoản";
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // blockUser
            // 
            this.blockUser.Name = "blockUser";
            this.blockUser.Size = new System.Drawing.Size(224, 28);
            this.blockUser.Text = "Khóa tài khoản";
            this.blockUser.Click += new System.EventHandler(this.blockUser_Click);
            // 
            // changePassword
            // 
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(224, 28);
            this.changePassword.Text = "Đổi mật khẩu";
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // logOut
            // 
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(224, 28);
            this.logOut.Text = "Đăng xuất";
            // 
            // quảnLýKếToánToolStripMenuItem
            // 
            this.quảnLýKếToánToolStripMenuItem.Name = "quảnLýKếToánToolStripMenuItem";
            this.quảnLýKếToánToolStripMenuItem.Size = new System.Drawing.Size(147, 27);
            this.quảnLýKếToánToolStripMenuItem.Text = "Quản lý kế toán";
            // 
            // quảnLýPhânTíchThịTrườngToolStripMenuItem
            // 
            this.quảnLýPhânTíchThịTrườngToolStripMenuItem.Name = "quảnLýPhânTíchThịTrườngToolStripMenuItem";
            this.quảnLýPhânTíchThịTrườngToolStripMenuItem.Size = new System.Drawing.Size(244, 27);
            this.quảnLýPhânTíchThịTrườngToolStripMenuItem.Text = "Quản lý phân tích thị trường";
            // 
            // quảnLýKhoToolStripMenuItem
            // 
            this.quảnLýKhoToolStripMenuItem.Name = "quảnLýKhoToolStripMenuItem";
            this.quảnLýKhoToolStripMenuItem.Size = new System.Drawing.Size(118, 27);
            this.quảnLýKhoToolStripMenuItem.Text = "Quản lý kho";
            // 
            // đảmBảoChấtLượngKinhDoanhToolStripMenuItem
            // 
            this.đảmBảoChấtLượngKinhDoanhToolStripMenuItem.Name = "đảmBảoChấtLượngKinhDoanhToolStripMenuItem";
            this.đảmBảoChấtLượngKinhDoanhToolStripMenuItem.Size = new System.Drawing.Size(274, 27);
            this.đảmBảoChấtLượngKinhDoanhToolStripMenuItem.Text = "Đảm bảo chất lượng kinh doanh";
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormTrangChu";
            this.Text = "FormTrangChu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUser;
        private System.Windows.Forms.ToolStripMenuItem blockUser;
        private System.Windows.Forms.ToolStripMenuItem changePassword;
        private System.Windows.Forms.ToolStripMenuItem logOut;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKếToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhânTíchThịTrườngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đảmBảoChấtLượngKinhDoanhToolStripMenuItem;
    }
}