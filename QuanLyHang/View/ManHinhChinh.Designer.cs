namespace QuanLyHang.View
{
    partial class form_ManHinhChinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_DSHang = new System.Windows.Forms.DataGridView();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Tim = new System.Windows.Forms.Button();
            this.button_In = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MaHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TenHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_GiaBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_SoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_ChiNhanh = new System.Windows.Forms.ComboBox();
            this.button_DangXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hàng:";
            // 
            // dataGridView_DSHang
            // 
            this.dataGridView_DSHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_DSHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSHang.Location = new System.Drawing.Point(12, 160);
            this.dataGridView_DSHang.Name = "dataGridView_DSHang";
            this.dataGridView_DSHang.ReadOnly = true;
            this.dataGridView_DSHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DSHang.Size = new System.Drawing.Size(529, 226);
            this.dataGridView_DSHang.TabIndex = 1;
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(5, 19);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(75, 41);
            this.button_Them.TabIndex = 2;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(86, 19);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 41);
            this.button_Xoa.TabIndex = 2;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.Location = new System.Drawing.Point(167, 19);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(75, 41);
            this.button_Sua.TabIndex = 2;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_Tim
            // 
            this.button_Tim.Location = new System.Drawing.Point(248, 19);
            this.button_Tim.Name = "button_Tim";
            this.button_Tim.Size = new System.Drawing.Size(75, 41);
            this.button_Tim.TabIndex = 2;
            this.button_Tim.Text = "Tìm kiếm";
            this.button_Tim.UseVisualStyleBackColor = true;
            this.button_Tim.Click += new System.EventHandler(this.button_Tim_Click);
            // 
            // button_In
            // 
            this.button_In.Location = new System.Drawing.Point(329, 19);
            this.button_In.Name = "button_In";
            this.button_In.Size = new System.Drawing.Size(75, 41);
            this.button_In.TabIndex = 2;
            this.button_In.Text = "In báo cáo";
            this.button_In.UseVisualStyleBackColor = true;
            this.button_In.Click += new System.EventHandler(this.button_In_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Xoa);
            this.groupBox1.Controls.Add(this.button_In);
            this.groupBox1.Controls.Add(this.button_Them);
            this.groupBox1.Controls.Add(this.button_Tim);
            this.groupBox1.Controls.Add(this.button_Sua);
            this.groupBox1.Location = new System.Drawing.Point(74, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã hàng";
            // 
            // textBox_MaHang
            // 
            this.textBox_MaHang.Location = new System.Drawing.Point(59, 12);
            this.textBox_MaHang.Name = "textBox_MaHang";
            this.textBox_MaHang.Size = new System.Drawing.Size(142, 20);
            this.textBox_MaHang.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên hàng";
            // 
            // textBox_TenHang
            // 
            this.textBox_TenHang.Location = new System.Drawing.Point(59, 38);
            this.textBox_TenHang.Name = "textBox_TenHang";
            this.textBox_TenHang.Size = new System.Drawing.Size(142, 20);
            this.textBox_TenHang.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá bán";
            // 
            // textBox_GiaBan
            // 
            this.textBox_GiaBan.Location = new System.Drawing.Point(266, 12);
            this.textBox_GiaBan.Name = "textBox_GiaBan";
            this.textBox_GiaBan.Size = new System.Drawing.Size(142, 20);
            this.textBox_GiaBan.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng";
            // 
            // textBox_SoLuong
            // 
            this.textBox_SoLuong.Location = new System.Drawing.Point(266, 38);
            this.textBox_SoLuong.Name = "textBox_SoLuong";
            this.textBox_SoLuong.Size = new System.Drawing.Size(142, 20);
            this.textBox_SoLuong.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Chi nhánh";
            // 
            // comboBox_ChiNhanh
            // 
            this.comboBox_ChiNhanh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_ChiNhanh.FormattingEnabled = true;
            this.comboBox_ChiNhanh.Location = new System.Drawing.Point(420, 38);
            this.comboBox_ChiNhanh.Name = "comboBox_ChiNhanh";
            this.comboBox_ChiNhanh.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ChiNhanh.TabIndex = 7;
            this.comboBox_ChiNhanh.SelectedIndexChanged += new System.EventHandler(this.comboBox_ChiNhanh_SelectedIndexChanged);
            // 
            // button_DangXuat
            // 
            this.button_DangXuat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_DangXuat.Location = new System.Drawing.Point(466, 392);
            this.button_DangXuat.Name = "button_DangXuat";
            this.button_DangXuat.Size = new System.Drawing.Size(75, 23);
            this.button_DangXuat.TabIndex = 8;
            this.button_DangXuat.Text = "Đăng xuất";
            this.button_DangXuat.UseVisualStyleBackColor = true;
            this.button_DangXuat.Click += new System.EventHandler(this.button_DangXuat_Click);
            // 
            // form_ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_DangXuat;
            this.ClientSize = new System.Drawing.Size(553, 418);
            this.Controls.Add(this.button_DangXuat);
            this.Controls.Add(this.comboBox_ChiNhanh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_SoLuong);
            this.Controls.Add(this.textBox_TenHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_GiaBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_MaHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_DSHang);
            this.Controls.Add(this.label1);
            this.Name = "form_ManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hàng";
            this.Load += new System.EventHandler(this.form_ManHinhChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_DSHang;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Tim;
        private System.Windows.Forms.Button button_In;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_MaHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TenHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_GiaBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_SoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_ChiNhanh;
        private System.Windows.Forms.Button button_DangXuat;
    }
}