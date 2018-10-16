namespace QuanLyHang.View
{
    partial class form_KetNoiServer
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
            this.panel_ConnectToSqlServer = new System.Windows.Forms.Panel();
            this.panel_SQLServerAuthentication = new System.Windows.Forms.Panel();
            this.textBox_UserName = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Password = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_ServerName = new System.Windows.Forms.TextBox();
            this.comboBox_Authentication = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.panel_ConnectToSqlServer.SuspendLayout();
            this.panel_SQLServerAuthentication.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ConnectToSqlServer
            // 
            this.panel_ConnectToSqlServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ConnectToSqlServer.Controls.Add(this.panel_SQLServerAuthentication);
            this.panel_ConnectToSqlServer.Controls.Add(this.label9);
            this.panel_ConnectToSqlServer.Controls.Add(this.textBox_ServerName);
            this.panel_ConnectToSqlServer.Controls.Add(this.comboBox_Authentication);
            this.panel_ConnectToSqlServer.Controls.Add(this.label5);
            this.panel_ConnectToSqlServer.Controls.Add(this.label1);
            this.panel_ConnectToSqlServer.Location = new System.Drawing.Point(12, 12);
            this.panel_ConnectToSqlServer.Name = "panel_ConnectToSqlServer";
            this.panel_ConnectToSqlServer.Size = new System.Drawing.Size(387, 146);
            this.panel_ConnectToSqlServer.TabIndex = 3;
            // 
            // panel_SQLServerAuthentication
            // 
            this.panel_SQLServerAuthentication.Controls.Add(this.textBox_UserName);
            this.panel_SQLServerAuthentication.Controls.Add(this.textBox_Password);
            this.panel_SQLServerAuthentication.Controls.Add(this.label3);
            this.panel_SQLServerAuthentication.Controls.Add(this.label4);
            this.panel_SQLServerAuthentication.Enabled = false;
            this.panel_SQLServerAuthentication.Location = new System.Drawing.Point(3, 87);
            this.panel_SQLServerAuthentication.Name = "panel_SQLServerAuthentication";
            this.panel_SQLServerAuthentication.Size = new System.Drawing.Size(357, 54);
            this.panel_SQLServerAuthentication.TabIndex = 11;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Connect to Microsoft SQL Server:";
            // 
            // textBox_ServerName
            // 
            this.textBox_ServerName.Location = new System.Drawing.Point(133, 34);
            this.textBox_ServerName.Name = "textBox_ServerName";
            this.textBox_ServerName.Size = new System.Drawing.Size(176, 20);
            this.textBox_ServerName.TabIndex = 2;
            this.textBox_ServerName.Text = ".\\SQLEXPRESS";
            // 
            // comboBox_Authentication
            // 
            this.comboBox_Authentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Authentication.FormattingEnabled = true;
            this.comboBox_Authentication.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.comboBox_Authentication.Location = new System.Drawing.Point(133, 60);
            this.comboBox_Authentication.Name = "comboBox_Authentication";
            this.comboBox_Authentication.Size = new System.Drawing.Size(176, 21);
            this.comboBox_Authentication.TabIndex = 4;
            this.comboBox_Authentication.SelectedIndexChanged += new System.EventHandler(this.comboBox_Authentication_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Authentication:";
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
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(247, 175);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 32);
            this.button_Exit.TabIndex = 6;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(146, 175);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 32);
            this.button_Connect.TabIndex = 5;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // form_KetNoiServer
            // 
            this.AcceptButton = this.button_Connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Exit;
            this.ClientSize = new System.Drawing.Size(411, 219);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.panel_ConnectToSqlServer);
            this.Name = "form_KetNoiServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to server";
            this.Load += new System.EventHandler(this.form_KetNoiServer_Load);
            this.panel_ConnectToSqlServer.ResumeLayout(false);
            this.panel_ConnectToSqlServer.PerformLayout();
            this.panel_SQLServerAuthentication.ResumeLayout(false);
            this.panel_SQLServerAuthentication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ConnectToSqlServer;
        private System.Windows.Forms.Panel panel_SQLServerAuthentication;
        private System.Windows.Forms.MaskedTextBox textBox_UserName;
        private System.Windows.Forms.MaskedTextBox textBox_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_ServerName;
        private System.Windows.Forms.ComboBox comboBox_Authentication;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Connect;
    }
}