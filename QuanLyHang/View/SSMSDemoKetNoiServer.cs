using QuanLyHang.Model.Dao;
using System;
using System.Windows.Forms;

namespace QuanLyHang.View
{
    public partial class form_KetNoiServer : Form
    {
        public form_KetNoiServer()
        {
            InitializeComponent();
        }

        private const int WindowsAuthentication = 0;
        private const int SQLAuthentication = WindowsAuthentication + 1;
        public static string serverName;

        private void form_KetNoiServer_Load(object sender, System.EventArgs e)
        {
            comboBox_Authentication.SelectedIndex = 0;
        }

        private void button_Exit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void comboBox_Authentication_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBox_Authentication.SelectedIndex == SQLAuthentication)
            {
                panel_SQLServerAuthentication.Enabled = true;
            }
            else
            {
                panel_SQLServerAuthentication.Enabled = false;
            }
        }

        private void button_Connect_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (comboBox_Authentication.SelectedIndex == WindowsAuthentication)
                {
                    ConnectSqlServer.getInstance().Connect(textBox_ServerName.Text, "master");
                }
                else
                {
                    ConnectSqlServer.getInstance().Connect(textBox_ServerName.Text, "master", textBox_UserName.Text, textBox_Password.Text);
                }
                serverName = textBox_ServerName.Text;
                this.Hide();
                new form_SSMSDemo().ShowDialog();
                ConnectSqlServer.getInstance().Disconnect();
                this.Show();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
