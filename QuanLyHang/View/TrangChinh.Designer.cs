namespace QuanLyHang.View
{
    partial class form_TrangChinh
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_QuanLySach = new System.Windows.Forms.Button();
            this.button_QuanLyNhanVien = new System.Windows.Forms.Button();
            this.button_BanHang = new System.Windows.Forms.Button();
            this.button_QuanLyLoaiSach = new System.Windows.Forms.Button();
            this.button_DangXuat = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.mnstrip_TrangChinh = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrMnItem_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrMnItem_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrMnItem_BanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrMnItem_QuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrMnItem_QuanLyNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrMnItem_QuanLySach = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrMnItem_QuanLyLoaiSach = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrMnItem_ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.mnstrip_TrangChinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.button_BanHang);
            this.flowLayoutPanel1.Controls.Add(this.button_QuanLyNhanVien);
            this.flowLayoutPanel1.Controls.Add(this.button_QuanLySach);
            this.flowLayoutPanel1.Controls.Add(this.button_QuanLyLoaiSach);
            this.flowLayoutPanel1.Controls.Add(this.button_DangXuat);
            this.flowLayoutPanel1.Controls.Add(this.button_Thoat);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(462, 324);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button_QuanLySach
            // 
            this.button_QuanLySach.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QuanLySach.Location = new System.Drawing.Point(3, 109);
            this.button_QuanLySach.Name = "button_QuanLySach";
            this.button_QuanLySach.Size = new System.Drawing.Size(225, 100);
            this.button_QuanLySach.TabIndex = 0;
            this.button_QuanLySach.Text = "Quản lý sách";
            this.button_QuanLySach.UseVisualStyleBackColor = true;
            this.button_QuanLySach.Click += new System.EventHandler(this.button_QuanLySach_Click);
            // 
            // button_QuanLyNhanVien
            // 
            this.button_QuanLyNhanVien.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QuanLyNhanVien.Location = new System.Drawing.Point(234, 3);
            this.button_QuanLyNhanVien.Name = "button_QuanLyNhanVien";
            this.button_QuanLyNhanVien.Size = new System.Drawing.Size(225, 100);
            this.button_QuanLyNhanVien.TabIndex = 0;
            this.button_QuanLyNhanVien.Text = "Quản lý nhân viên";
            this.button_QuanLyNhanVien.UseVisualStyleBackColor = true;
            this.button_QuanLyNhanVien.Click += new System.EventHandler(this.button_QuanLyNhanVien_Click);
            // 
            // button_BanHang
            // 
            this.button_BanHang.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BanHang.Location = new System.Drawing.Point(3, 3);
            this.button_BanHang.Name = "button_BanHang";
            this.button_BanHang.Size = new System.Drawing.Size(225, 100);
            this.button_BanHang.TabIndex = 0;
            this.button_BanHang.Text = "Bán hàng";
            this.button_BanHang.UseVisualStyleBackColor = true;
            this.button_BanHang.Click += new System.EventHandler(this.button_BanHang_Click);
            // 
            // button_QuanLyLoaiSach
            // 
            this.button_QuanLyLoaiSach.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QuanLyLoaiSach.Location = new System.Drawing.Point(234, 109);
            this.button_QuanLyLoaiSach.Name = "button_QuanLyLoaiSach";
            this.button_QuanLyLoaiSach.Size = new System.Drawing.Size(225, 100);
            this.button_QuanLyLoaiSach.TabIndex = 0;
            this.button_QuanLyLoaiSach.Text = "Quản lý loại sách";
            this.button_QuanLyLoaiSach.UseVisualStyleBackColor = true;
            this.button_QuanLyLoaiSach.Click += new System.EventHandler(this.button_QuanLyLoaiSach_Click);
            // 
            // button_DangXuat
            // 
            this.button_DangXuat.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangXuat.Location = new System.Drawing.Point(3, 215);
            this.button_DangXuat.Name = "button_DangXuat";
            this.button_DangXuat.Size = new System.Drawing.Size(225, 100);
            this.button_DangXuat.TabIndex = 0;
            this.button_DangXuat.Text = "Đăng xuất";
            this.button_DangXuat.UseVisualStyleBackColor = true;
            this.button_DangXuat.Click += new System.EventHandler(this.button_DangXuat_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thoat.Location = new System.Drawing.Point(234, 215);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(225, 100);
            this.button_Thoat.TabIndex = 0;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // mnstrip_TrangChinh
            // 
            this.mnstrip_TrangChinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.tlStrMnItem_BanHang,
            this.tlStrMnItem_QuanLy,
            this.tlStrMnItem_ThongKe});
            this.mnstrip_TrangChinh.Location = new System.Drawing.Point(0, 0);
            this.mnstrip_TrangChinh.Name = "mnstrip_TrangChinh";
            this.mnstrip_TrangChinh.Size = new System.Drawing.Size(466, 24);
            this.mnstrip_TrangChinh.TabIndex = 1;
            this.mnstrip_TrangChinh.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStrMnItem_DangXuat,
            this.tlStrMnItem_Thoat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tlStrMnItem_DangXuat
            // 
            this.tlStrMnItem_DangXuat.Name = "tlStrMnItem_DangXuat";
            this.tlStrMnItem_DangXuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.tlStrMnItem_DangXuat.Size = new System.Drawing.Size(180, 22);
            this.tlStrMnItem_DangXuat.Text = "Đăng xuất";
            this.tlStrMnItem_DangXuat.Click += new System.EventHandler(this.tlStrMnItem_DangXuat_Click);
            // 
            // tlStrMnItem_Thoat
            // 
            this.tlStrMnItem_Thoat.Name = "tlStrMnItem_Thoat";
            this.tlStrMnItem_Thoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tlStrMnItem_Thoat.Size = new System.Drawing.Size(180, 22);
            this.tlStrMnItem_Thoat.Text = "Thoát";
            this.tlStrMnItem_Thoat.Click += new System.EventHandler(this.tlStrMnItem_Thoat_Click);
            // 
            // tlStrMnItem_BanHang
            // 
            this.tlStrMnItem_BanHang.Name = "tlStrMnItem_BanHang";
            this.tlStrMnItem_BanHang.Size = new System.Drawing.Size(69, 20);
            this.tlStrMnItem_BanHang.Text = "Bán hàng";
            this.tlStrMnItem_BanHang.Click += new System.EventHandler(this.tlStrMnItem_BanHang_Click);
            // 
            // tlStrMnItem_QuanLy
            // 
            this.tlStrMnItem_QuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStrMnItem_QuanLyNhanVien,
            this.tlStrMnItem_QuanLySach,
            this.tlStrMnItem_QuanLyLoaiSach});
            this.tlStrMnItem_QuanLy.Name = "tlStrMnItem_QuanLy";
            this.tlStrMnItem_QuanLy.Size = new System.Drawing.Size(60, 20);
            this.tlStrMnItem_QuanLy.Text = "Quản lý";
            // 
            // tlStrMnItem_QuanLyNhanVien
            // 
            this.tlStrMnItem_QuanLyNhanVien.Name = "tlStrMnItem_QuanLyNhanVien";
            this.tlStrMnItem_QuanLyNhanVien.Size = new System.Drawing.Size(180, 22);
            this.tlStrMnItem_QuanLyNhanVien.Text = "Quản lý nhân viên";
            this.tlStrMnItem_QuanLyNhanVien.Click += new System.EventHandler(this.tlStrMnItem_QuanLyNhanVien_Click);
            // 
            // tlStrMnItem_QuanLySach
            // 
            this.tlStrMnItem_QuanLySach.Name = "tlStrMnItem_QuanLySach";
            this.tlStrMnItem_QuanLySach.Size = new System.Drawing.Size(180, 22);
            this.tlStrMnItem_QuanLySach.Text = "Quản lý sách";
            this.tlStrMnItem_QuanLySach.Click += new System.EventHandler(this.tlStrMnItem_QuanLySach_Click);
            // 
            // tlStrMnItem_QuanLyLoaiSach
            // 
            this.tlStrMnItem_QuanLyLoaiSach.Name = "tlStrMnItem_QuanLyLoaiSach";
            this.tlStrMnItem_QuanLyLoaiSach.Size = new System.Drawing.Size(180, 22);
            this.tlStrMnItem_QuanLyLoaiSach.Text = "Quản lý loại sách";
            this.tlStrMnItem_QuanLyLoaiSach.Click += new System.EventHandler(this.tlStrMnItem_QuanLyLoaiSach_Click);
            // 
            // tlStrMnItem_ThongKe
            // 
            this.tlStrMnItem_ThongKe.Name = "tlStrMnItem_ThongKe";
            this.tlStrMnItem_ThongKe.Size = new System.Drawing.Size(69, 20);
            this.tlStrMnItem_ThongKe.Text = "Thống kê";
            this.tlStrMnItem_ThongKe.Click += new System.EventHandler(this.tlStrMnItem_ThongKe_Click);
            // 
            // form_TrangChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 386);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.mnstrip_TrangChinh);
            this.MainMenuStrip = this.mnstrip_TrangChinh;
            this.Name = "form_TrangChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChinh";
            this.Load += new System.EventHandler(this.form_TrangChinh_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.mnstrip_TrangChinh.ResumeLayout(false);
            this.mnstrip_TrangChinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_QuanLySach;
        private System.Windows.Forms.Button button_QuanLyNhanVien;
        private System.Windows.Forms.Button button_BanHang;
        private System.Windows.Forms.Button button_QuanLyLoaiSach;
        private System.Windows.Forms.Button button_DangXuat;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.MenuStrip mnstrip_TrangChinh;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tlStrMnItem_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem tlStrMnItem_Thoat;
        private System.Windows.Forms.ToolStripMenuItem tlStrMnItem_BanHang;
        private System.Windows.Forms.ToolStripMenuItem tlStrMnItem_QuanLy;
        private System.Windows.Forms.ToolStripMenuItem tlStrMnItem_QuanLyNhanVien;
        private System.Windows.Forms.ToolStripMenuItem tlStrMnItem_QuanLySach;
        private System.Windows.Forms.ToolStripMenuItem tlStrMnItem_QuanLyLoaiSach;
        private System.Windows.Forms.ToolStripMenuItem tlStrMnItem_ThongKe;
    }
}