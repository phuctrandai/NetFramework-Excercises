namespace QuanLyHang.View
{
    partial class form_BanHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_hoaDonThanhToan = new System.Windows.Forms.DataGridView();
            this.button_InHoaDon = new System.Windows.Forms.Button();
            this.button_BanHang = new System.Windows.Forms.Button();
            this.pictureBox_Anh = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MaSach = new System.Windows.Forms.TextBox();
            this.comboBox_Sach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Gia = new System.Windows.Forms.TextBox();
            this.textBox_ThanhTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numUpDwn_SoLuongMua = new System.Windows.Forms.NumericUpDown();
            this.listBox_LoaiSach = new System.Windows.Forms.ListBox();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnhBia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoaDonThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Anh)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_SoLuongMua)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dgv_hoaDonThanhToan);
            this.panel1.Controls.Add(this.button_InHoaDon);
            this.panel1.Controls.Add(this.button_BanHang);
            this.panel1.Controls.Add(this.pictureBox_Anh);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(193, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 528);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hóa đơn thanh toán";
            // 
            // dgv_hoaDonThanhToan
            // 
            this.dgv_hoaDonThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hoaDonThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoaDonThanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.GiaBan,
            this.SoLuongMua,
            this.AnhBia});
            this.dgv_hoaDonThanhToan.Location = new System.Drawing.Point(6, 305);
            this.dgv_hoaDonThanhToan.MultiSelect = false;
            this.dgv_hoaDonThanhToan.Name = "dgv_hoaDonThanhToan";
            this.dgv_hoaDonThanhToan.ReadOnly = true;
            this.dgv_hoaDonThanhToan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hoaDonThanhToan.Size = new System.Drawing.Size(589, 211);
            this.dgv_hoaDonThanhToan.TabIndex = 7;
            this.dgv_hoaDonThanhToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoaDonThanhToan_CellClick);
            // 
            // button_InHoaDon
            // 
            this.button_InHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button_InHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_InHoaDon.Location = new System.Drawing.Point(503, 257);
            this.button_InHoaDon.Name = "button_InHoaDon";
            this.button_InHoaDon.Size = new System.Drawing.Size(92, 42);
            this.button_InHoaDon.TabIndex = 6;
            this.button_InHoaDon.Text = "In hóa đơn";
            this.button_InHoaDon.UseVisualStyleBackColor = true;
            this.button_InHoaDon.Click += new System.EventHandler(this.button_InHoaDon_Click);
            // 
            // button_BanHang
            // 
            this.button_BanHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button_BanHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_BanHang.Location = new System.Drawing.Point(350, 257);
            this.button_BanHang.Name = "button_BanHang";
            this.button_BanHang.Size = new System.Drawing.Size(121, 42);
            this.button_BanHang.TabIndex = 6;
            this.button_BanHang.Text = "Bán hàng";
            this.button_BanHang.UseVisualStyleBackColor = true;
            this.button_BanHang.Click += new System.EventHandler(this.button_BanHang_Click);
            // 
            // pictureBox_Anh
            // 
            this.pictureBox_Anh.Location = new System.Drawing.Point(350, 12);
            this.pictureBox_Anh.Name = "pictureBox_Anh";
            this.pictureBox_Anh.Size = new System.Drawing.Size(237, 239);
            this.pictureBox_Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Anh.TabIndex = 5;
            this.pictureBox_Anh.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.25641F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.74359F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_MaSach, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Sach, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_SoLuong, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Gia, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_ThanhTien, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numUpDwn_SoLuongMua, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 274);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn sách";
            // 
            // textBox_MaSach
            // 
            this.textBox_MaSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_MaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_MaSach.Location = new System.Drawing.Point(98, 48);
            this.textBox_MaSach.Name = "textBox_MaSach";
            this.textBox_MaSach.ReadOnly = true;
            this.textBox_MaSach.Size = new System.Drawing.Size(214, 24);
            this.textBox_MaSach.TabIndex = 3;
            this.textBox_MaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox_Sach
            // 
            this.comboBox_Sach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Sach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_Sach.FormattingEnabled = true;
            this.comboBox_Sach.Location = new System.Drawing.Point(98, 3);
            this.comboBox_Sach.Name = "comboBox_Sach";
            this.comboBox_Sach.Size = new System.Drawing.Size(214, 26);
            this.comboBox_Sach.TabIndex = 1;
            this.comboBox_Sach.SelectedIndexChanged += new System.EventHandler(this.comboBox_Sach_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng hiện có";
            // 
            // textBox_SoLuong
            // 
            this.textBox_SoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_SoLuong.Location = new System.Drawing.Point(98, 93);
            this.textBox_SoLuong.Name = "textBox_SoLuong";
            this.textBox_SoLuong.ReadOnly = true;
            this.textBox_SoLuong.Size = new System.Drawing.Size(214, 24);
            this.textBox_SoLuong.TabIndex = 3;
            this.textBox_SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Thành tiền";
            // 
            // textBox_Gia
            // 
            this.textBox_Gia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_Gia.Location = new System.Drawing.Point(98, 138);
            this.textBox_Gia.Name = "textBox_Gia";
            this.textBox_Gia.ReadOnly = true;
            this.textBox_Gia.Size = new System.Drawing.Size(214, 29);
            this.textBox_Gia.TabIndex = 3;
            this.textBox_Gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_ThanhTien
            // 
            this.textBox_ThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ThanhTien.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ThanhTien.ForeColor = System.Drawing.Color.Red;
            this.textBox_ThanhTien.Location = new System.Drawing.Point(98, 228);
            this.textBox_ThanhTien.Name = "textBox_ThanhTien";
            this.textBox_ThanhTien.ReadOnly = true;
            this.textBox_ThanhTien.Size = new System.Drawing.Size(214, 28);
            this.textBox_ThanhTien.TabIndex = 3;
            this.textBox_ThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhập số lượng mua";
            // 
            // numUpDwn_SoLuongMua
            // 
            this.numUpDwn_SoLuongMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numUpDwn_SoLuongMua.Location = new System.Drawing.Point(98, 183);
            this.numUpDwn_SoLuongMua.Name = "numUpDwn_SoLuongMua";
            this.numUpDwn_SoLuongMua.Size = new System.Drawing.Size(214, 26);
            this.numUpDwn_SoLuongMua.TabIndex = 5;
            this.numUpDwn_SoLuongMua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDwn_SoLuongMua.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDwn_SoLuongMua.ValueChanged += new System.EventHandler(this.numUpDwn_SoLuongMua_ValueChanged);
            // 
            // listBox_LoaiSach
            // 
            this.listBox_LoaiSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_LoaiSach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_LoaiSach.FormattingEnabled = true;
            this.listBox_LoaiSach.ItemHeight = 21;
            this.listBox_LoaiSach.Location = new System.Drawing.Point(0, 0);
            this.listBox_LoaiSach.Name = "listBox_LoaiSach";
            this.listBox_LoaiSach.Size = new System.Drawing.Size(193, 528);
            this.listBox_LoaiSach.TabIndex = 2;
            this.listBox_LoaiSach.SelectedIndexChanged += new System.EventHandler(this.listBox_LoaiSach_SelectedIndexChanged);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // SoLuongMua
            // 
            this.SoLuongMua.DataPropertyName = "SoLuongMua";
            this.SoLuongMua.HeaderText = "Số lượng mua";
            this.SoLuongMua.Name = "SoLuongMua";
            this.SoLuongMua.ReadOnly = true;
            // 
            // AnhBia
            // 
            this.AnhBia.DataPropertyName = "AnhBia";
            this.AnhBia.HeaderText = "Ảnh bìa";
            this.AnhBia.Name = "AnhBia";
            this.AnhBia.ReadOnly = true;
            this.AnhBia.Visible = false;
            // 
            // form_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.listBox_LoaiSach);
            this.Controls.Add(this.panel1);
            this.Name = "form_BanHang";
            this.Text = "BanHang";
            this.Load += new System.EventHandler(this.form_BanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoaDonThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Anh)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_SoLuongMua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MaSach;
        private System.Windows.Forms.ComboBox comboBox_Sach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Gia;
        private System.Windows.Forms.TextBox textBox_ThanhTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_hoaDonThanhToan;
        private System.Windows.Forms.Button button_InHoaDon;
        private System.Windows.Forms.Button button_BanHang;
        private System.Windows.Forms.PictureBox pictureBox_Anh;
        private System.Windows.Forms.ListBox listBox_LoaiSach;
        private System.Windows.Forms.NumericUpDown numUpDwn_SoLuongMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnhBia;
    }
}