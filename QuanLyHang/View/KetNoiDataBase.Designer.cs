namespace QuanLyHang.View
{
    partial class form_KetNoiDatabase
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
            this.textBox_ServerName = new System.Windows.Forms.TextBox();
            this.textBox_UserName = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Password = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.comboBox_Databases = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Authentication = new System.Windows.Forms.ComboBox();
            this.panel_ConnectToSqlServer = new System.Windows.Forms.Panel();
            this.panel_SQLServerAuthentication = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_DataSource = new System.Windows.Forms.ComboBox();
            this.panel_ConnectToExcel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ExcelFile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel_ConnectToSqlServer.SuspendLayout();
            this.panel_SQLServerAuthentication.SuspendLayout();
            this.panel_ConnectToExcel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_ServerName
            // 
            this.textBox_ServerName.Location = new System.Drawing.Point(133, 34);
            this.textBox_ServerName.Name = "textBox_ServerName";
            this.textBox_ServerName.Size = new System.Drawing.Size(176, 20);
            this.textBox_ServerName.TabIndex = 2;
            this.textBox_ServerName.Text = ".\\SQLEXPRESS";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(130, 3);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(176, 20);
            this.textBox_UserName.TabIndex = 5;
            this.textBox_UserName.Text = "sa";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(130, 32);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(176, 20);
            this.textBox_Password.TabIndex = 6;
            this.textBox_Password.Text = "0946901161";
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password:";
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(146, 313);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 32);
            this.button_Connect.TabIndex = 3;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(247, 313);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 32);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // comboBox_Databases
            // 
            this.comboBox_Databases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Databases.FormattingEnabled = true;
            this.comboBox_Databases.Location = new System.Drawing.Point(133, 60);
            this.comboBox_Databases.Name = "comboBox_Databases";
            this.comboBox_Databases.Size = new System.Drawing.Size(176, 21);
            this.comboBox_Databases.TabIndex = 3;
            this.comboBox_Databases.DropDown += new System.EventHandler(this.comboBox_Databases_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Authentication:";
            // 
            // comboBox_Authentication
            // 
            this.comboBox_Authentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Authentication.FormattingEnabled = true;
            this.comboBox_Authentication.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.comboBox_Authentication.Location = new System.Drawing.Point(133, 87);
            this.comboBox_Authentication.Name = "comboBox_Authentication";
            this.comboBox_Authentication.Size = new System.Drawing.Size(176, 21);
            this.comboBox_Authentication.TabIndex = 4;
            this.comboBox_Authentication.SelectedIndexChanged += new System.EventHandler(this.comboBox_Authentication_SelectedIndexChanged);
            // 
            // panel_ConnectToSqlServer
            // 
            this.panel_ConnectToSqlServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ConnectToSqlServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ConnectToSqlServer.Controls.Add(this.panel_SQLServerAuthentication);
            this.panel_ConnectToSqlServer.Controls.Add(this.label9);
            this.panel_ConnectToSqlServer.Controls.Add(this.textBox_ServerName);
            this.panel_ConnectToSqlServer.Controls.Add(this.comboBox_Authentication);
            this.panel_ConnectToSqlServer.Controls.Add(this.label5);
            this.panel_ConnectToSqlServer.Controls.Add(this.label1);
            this.panel_ConnectToSqlServer.Controls.Add(this.comboBox_Databases);
            this.panel_ConnectToSqlServer.Controls.Add(this.label2);
            this.panel_ConnectToSqlServer.Enabled = false;
            this.panel_ConnectToSqlServer.Location = new System.Drawing.Point(12, 131);
            this.panel_ConnectToSqlServer.Name = "panel_ConnectToSqlServer";
            this.panel_ConnectToSqlServer.Size = new System.Drawing.Size(365, 176);
            this.panel_ConnectToSqlServer.TabIndex = 2;
            // 
            // panel_SQLServerAuthentication
            // 
            this.panel_SQLServerAuthentication.Controls.Add(this.textBox_UserName);
            this.panel_SQLServerAuthentication.Controls.Add(this.textBox_Password);
            this.panel_SQLServerAuthentication.Controls.Add(this.label3);
            this.panel_SQLServerAuthentication.Controls.Add(this.label4);
            this.panel_SQLServerAuthentication.Enabled = false;
            this.panel_SQLServerAuthentication.Location = new System.Drawing.Point(3, 114);
            this.panel_SQLServerAuthentication.Name = "panel_SQLServerAuthentication";
            this.panel_SQLServerAuthentication.Size = new System.Drawing.Size(357, 54);
            this.panel_SQLServerAuthentication.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Connect to Microsoft SQL Server:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data Source:";
            // 
            // comboBox_DataSource
            // 
            this.comboBox_DataSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DataSource.FormattingEnabled = true;
            this.comboBox_DataSource.Items.AddRange(new object[] {
            "Microsoft SQL Server",
            "Microsoft Excel File"});
            this.comboBox_DataSource.Location = new System.Drawing.Point(145, 45);
            this.comboBox_DataSource.Name = "comboBox_DataSource";
            this.comboBox_DataSource.Size = new System.Drawing.Size(176, 21);
            this.comboBox_DataSource.TabIndex = 0;
            this.comboBox_DataSource.SelectedIndexChanged += new System.EventHandler(this.comboBox_DataSource_SelectedIndexChanged);
            // 
            // panel_ConnectToExcel
            // 
            this.panel_ConnectToExcel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ConnectToExcel.Controls.Add(this.label8);
            this.panel_ConnectToExcel.Controls.Add(this.textBox_ExcelFile);
            this.panel_ConnectToExcel.Controls.Add(this.label7);
            this.panel_ConnectToExcel.Enabled = false;
            this.panel_ConnectToExcel.Location = new System.Drawing.Point(12, 72);
            this.panel_ConnectToExcel.Name = "panel_ConnectToExcel";
            this.panel_ConnectToExcel.Size = new System.Drawing.Size(365, 53);
            this.panel_ConnectToExcel.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Connect to Excel:";
            // 
            // textBox_ExcelFile
            // 
            this.textBox_ExcelFile.Location = new System.Drawing.Point(133, 24);
            this.textBox_ExcelFile.Name = "textBox_ExcelFile";
            this.textBox_ExcelFile.Size = new System.Drawing.Size(176, 20);
            this.textBox_ExcelFile.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Excel File:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(137, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Choose your connect";
            // 
            // form_KetNoiDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 352);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel_ConnectToExcel);
            this.Controls.Add(this.comboBox_DataSource);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel_ConnectToSqlServer);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Connect);
            this.Name = "form_KetNoiDatabase";
            this.Text = "KetNoiDataBase";
            this.Load += new System.EventHandler(this.KetNoiDataBase_Load);
            this.panel_ConnectToSqlServer.ResumeLayout(false);
            this.panel_ConnectToSqlServer.PerformLayout();
            this.panel_SQLServerAuthentication.ResumeLayout(false);
            this.panel_SQLServerAuthentication.PerformLayout();
            this.panel_ConnectToExcel.ResumeLayout(false);
            this.panel_ConnectToExcel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ServerName;
        private System.Windows.Forms.MaskedTextBox textBox_UserName;
        private System.Windows.Forms.MaskedTextBox textBox_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.ComboBox comboBox_Databases;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Authentication;
        private System.Windows.Forms.Panel panel_ConnectToSqlServer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_DataSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel_ConnectToExcel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ExcelFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel_SQLServerAuthentication;
    }
}