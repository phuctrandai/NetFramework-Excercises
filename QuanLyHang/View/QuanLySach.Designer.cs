namespace QuanLyHang.View
{
    partial class form_QuanLySach
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
            this.groupBox_ThaoTac = new System.Windows.Forms.GroupBox();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.button_In = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Sach = new System.Windows.Forms.DataGridView();
            this.groupBox_ThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_ThaoTac
            // 
            this.groupBox_ThaoTac.Controls.Add(this.label1);
            this.groupBox_ThaoTac.Controls.Add(this.button_In);
            this.groupBox_ThaoTac.Controls.Add(this.button_TimKiem);
            this.groupBox_ThaoTac.Controls.Add(this.button_Sua);
            this.groupBox_ThaoTac.Controls.Add(this.button_Xoa);
            this.groupBox_ThaoTac.Controls.Add(this.button_Them);
            this.groupBox_ThaoTac.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_ThaoTac.Location = new System.Drawing.Point(0, 0);
            this.groupBox_ThaoTac.Name = "groupBox_ThaoTac";
            this.groupBox_ThaoTac.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox_ThaoTac.Size = new System.Drawing.Size(725, 88);
            this.groupBox_ThaoTac.TabIndex = 0;
            this.groupBox_ThaoTac.TabStop = false;
            this.groupBox_ThaoTac.Text = "Thao tác";
            // 
            // button_Them
            // 
            this.button_Them.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Them.Location = new System.Drawing.Point(3, 16);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(75, 69);
            this.button_Them.TabIndex = 0;
            this.button_Them.Text = "Thêm sách";
            this.button_Them.UseVisualStyleBackColor = true;
            // 
            // button_Xoa
            // 
            this.button_Xoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Xoa.Location = new System.Drawing.Point(78, 16);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 69);
            this.button_Xoa.TabIndex = 1;
            this.button_Xoa.Text = "Xóa sách";
            this.button_Xoa.UseVisualStyleBackColor = true;
            // 
            // button_Sua
            // 
            this.button_Sua.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Sua.Location = new System.Drawing.Point(153, 16);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(75, 69);
            this.button_Sua.TabIndex = 2;
            this.button_Sua.Text = "Sửa thông tin sách";
            this.button_Sua.UseVisualStyleBackColor = true;
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_TimKiem.Location = new System.Drawing.Point(228, 16);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(75, 69);
            this.button_TimKiem.TabIndex = 3;
            this.button_TimKiem.Text = "Tìm kiếm sách";
            this.button_TimKiem.UseVisualStyleBackColor = true;
            // 
            // button_In
            // 
            this.button_In.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_In.Location = new System.Drawing.Point(303, 16);
            this.button_In.Name = "button_In";
            this.button_In.Size = new System.Drawing.Size(75, 69);
            this.button_In.TabIndex = 4;
            this.button_In.Text = "In báo cáo";
            this.button_In.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(441, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản Lý Sách";
            // 
            // dataGridView_Sach
            // 
            this.dataGridView_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Sach.Location = new System.Drawing.Point(0, 88);
            this.dataGridView_Sach.Name = "dataGridView_Sach";
            this.dataGridView_Sach.Size = new System.Drawing.Size(725, 362);
            this.dataGridView_Sach.TabIndex = 1;
            // 
            // form_QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.dataGridView_Sach);
            this.Controls.Add(this.groupBox_ThaoTac);
            this.Name = "form_QuanLySach";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.form_QuanLySach_Load);
            this.groupBox_ThaoTac.ResumeLayout(false);
            this.groupBox_ThaoTac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_ThaoTac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_In;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.DataGridView dataGridView_Sach;
    }
}