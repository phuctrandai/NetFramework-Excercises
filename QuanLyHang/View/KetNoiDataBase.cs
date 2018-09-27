using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyHang.Model.Dao;

namespace QuanLyHang.View
{
    public partial class form_KetNoiDatabase : Form
    {
        public form_KetNoiDatabase()
        {
            InitializeComponent();
        }

        private const int MicrosoftSQLServer = 0;
        private const int MicrosoftExcel = MicrosoftSQLServer + 1;

        private const int WindowsAuthentication = 0;
        private const int SQLAuthentication = WindowsAuthentication + 1;

        private void KetNoiDataBase_Load(object sender, EventArgs e)
        {
            comboBox_Authentication.SelectedIndex = 0;
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (comboBox_DataSource.SelectedIndex == -1)
            {
                MessageBox.Show("Chua chon Data source!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox_Databases.SelectedIndex == -1)
            {
                MessageBox.Show("Chua chon Database!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(comboBox_Authentication.SelectedIndex == WindowsAuthentication)
                {
                    ConnectDataBase.getInstance().Connect(textBox_ServerName.Text, comboBox_Databases.Text);
                }
                else
                {
                    ConnectDataBase.getInstance().Connect(textBox_ServerName.Text, comboBox_Databases.Text, textBox_UserName.Text, textBox_Password.Text);
                }
                MessageBox.Show(ConnectDataBase.getInstance().sqlConnection.State.ToString());
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox_DataSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_DataSource.SelectedIndex == MicrosoftSQLServer)
            {
                panel_ConnectToExcel.Enabled = false;
                panel_ConnectToSqlServer.Enabled = true;
            }
            else if (comboBox_DataSource.SelectedIndex == MicrosoftExcel)
            {
                panel_ConnectToExcel.Enabled = true;
                panel_ConnectToSqlServer.Enabled = false;
            }
        }

        private void comboBox_Authentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_Authentication.SelectedIndex == SQLAuthentication)
            {
                panel_SQLServerAuthentication.Enabled = true;
            }
            else
            {
                panel_SQLServerAuthentication.Enabled = false;
            }
        }

        private void comboBox_Databases_DropDown(object sender, EventArgs e)
        {
            GetDatabases();
        }

        private void GetDatabases()
        {
            ConnectDataBase.getInstance().Connect(textBox_ServerName.Text, "master");
            SqlCommand sqlCommand = new SqlCommand("Select * from sys.databases", ConnectDataBase.getInstance().sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            comboBox_Databases.Items.Clear();
            while (dataReader.Read())
            {
                comboBox_Databases.Items.Add(dataReader["name"].ToString());
            }
            ConnectDataBase.getInstance().Disconnect();
        }
    }
}
