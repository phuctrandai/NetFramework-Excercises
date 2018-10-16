namespace QuanLyHang.View
{
    partial class form_QuanLyLoaiSach
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
            this.button_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ViewMode = new System.Windows.Forms.ComboBox();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.button_HienThi = new System.Windows.Forms.Button();
            this.button_In = new System.Windows.Forms.Button();
            this.dataGridView_Sach = new System.Windows.Forms.DataGridView();
            this.textBox_MaLoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_TenLoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sach)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Close.Location = new System.Drawing.Point(551, 400);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 36);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách các loại sách";
            // 
            // comboBox_ViewMode
            // 
            this.comboBox_ViewMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_ViewMode.FormattingEnabled = true;
            this.comboBox_ViewMode.Location = new System.Drawing.Point(491, 14);
            this.comboBox_ViewMode.Name = "comboBox_ViewMode";
            this.comboBox_ViewMode.Size = new System.Drawing.Size(135, 21);
            this.comboBox_ViewMode.TabIndex = 3;
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(159, 126);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(75, 43);
            this.button_Them.TabIndex = 4;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(240, 126);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 43);
            this.button_Xoa.TabIndex = 4;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.Location = new System.Drawing.Point(321, 126);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(75, 43);
            this.button_Sua.TabIndex = 4;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.Location = new System.Drawing.Point(402, 126);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(75, 43);
            this.button_TimKiem.TabIndex = 4;
            this.button_TimKiem.Text = "Tìm kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = true;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
            // 
            // button_HienThi
            // 
            this.button_HienThi.Location = new System.Drawing.Point(78, 126);
            this.button_HienThi.Name = "button_HienThi";
            this.button_HienThi.Size = new System.Drawing.Size(75, 43);
            this.button_HienThi.TabIndex = 4;
            this.button_HienThi.Text = "Hiển thị";
            this.button_HienThi.UseVisualStyleBackColor = true;
            this.button_HienThi.Click += new System.EventHandler(this.button_HienThi_Click);
            // 
            // button_In
            // 
            this.button_In.Location = new System.Drawing.Point(483, 126);
            this.button_In.Name = "button_In";
            this.button_In.Size = new System.Drawing.Size(75, 43);
            this.button_In.TabIndex = 4;
            this.button_In.Text = "In";
            this.button_In.UseVisualStyleBackColor = true;
            this.button_In.Click += new System.EventHandler(this.button_In_Click);
            // 
            // dataGridView_Sach
            // 
            this.dataGridView_Sach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sach.Location = new System.Drawing.Point(12, 175);
            this.dataGridView_Sach.Name = "dataGridView_Sach";
            this.dataGridView_Sach.ReadOnly = true;
            this.dataGridView_Sach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Sach.Size = new System.Drawing.Size(614, 219);
            this.dataGridView_Sach.TabIndex = 5;
            this.dataGridView_Sach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Sach_CellClick);
            // 
            // textBox_MaLoai
            // 
            this.textBox_MaLoai.Location = new System.Drawing.Point(78, 55);
            this.textBox_MaLoai.Name = "textBox_MaLoai";
            this.textBox_MaLoai.Size = new System.Drawing.Size(227, 20);
            this.textBox_MaLoai.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã loại";
            // 
            // textBox_TenLoai
            // 
            this.textBox_TenLoai.Location = new System.Drawing.Point(377, 55);
            this.textBox_TenLoai.Name = "textBox_TenLoai";
            this.textBox_TenLoai.Size = new System.Drawing.Size(249, 20);
            this.textBox_TenLoai.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên loại";
            // 
            // form_QuanLyLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Close;
            this.ClientSize = new System.Drawing.Size(638, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_TenLoai);
            this.Controls.Add(this.textBox_MaLoai);
            this.Controls.Add(this.dataGridView_Sach);
            this.Controls.Add(this.button_In);
            this.Controls.Add(this.button_TimKiem);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_HienThi);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.comboBox_ViewMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Close);
            this.Name = "form_QuanLyLoaiSach";
            this.ShowIcon = false;
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.form_QuanLyLoaiSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ViewMode;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.Button button_HienThi;
        private System.Windows.Forms.Button button_In;
        private System.Windows.Forms.DataGridView dataGridView_Sach;
        private System.Windows.Forms.TextBox textBox_MaLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_TenLoai;
        private System.Windows.Forms.Label label3;
    }
}