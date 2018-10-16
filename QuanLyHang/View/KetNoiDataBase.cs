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
            bool isConnected = false;
            if (comboBox_DataSource.SelectedIndex == MicrosoftSQLServer)
            {
                isConnected = connectToSQLServer();
            }
            else if (comboBox_DataSource.SelectedIndex == MicrosoftExcel)
            {
                isConnected = connectToExcel();
            }
            else
            {
                MessageBox.Show("Chua chon Data source!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(isConnected)
            {
                this.Hide();
                new QuanLyNhanVien().ShowDialog();
                ConnectSqlServer.getInstance().Disconnect();
                ConnectOleDB.getInstance().Disconnect();
                this.Show();
            }
        }

        private bool connectToSQLServer()
        {
            if (comboBox_Databases.SelectedIndex != -1)
            {
                try
                {
                    if (comboBox_Authentication.SelectedIndex == WindowsAuthentication)
                    {
                        ConnectSqlServer.getInstance().Connect(textBox_ServerName.Text, comboBox_Databases.Text);
                    }
                    else
                    {
                        ConnectSqlServer.getInstance().Connect(textBox_ServerName.Text, comboBox_Databases.Text, textBox_UserName.Text, textBox_Password.Text);
                    }
                    return true;
                } catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Chua chon Database!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool connectToExcel()
        {
            try
            {
                ConnectOleDB.getInstance().Connect(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + textBox_ExcelFile.Text + "';Extended Properties='Excel 12.0;HDR=YES;';");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_DataSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_DataSource.SelectedIndex == MicrosoftSQLServer)
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
            if (comboBox_Authentication.SelectedIndex == SQLAuthentication)
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
            try
            {
                ConnectSqlServer.getInstance().Connect(textBox_ServerName.Text, "master");
                SqlCommand sqlCommand = new SqlCommand("Select * from sys.databases", ConnectSqlServer.getInstance().SqlConnection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                comboBox_Databases.Items.Clear();
                while (dataReader.Read())
                {
                    comboBox_Databases.Items.Add(dataReader["name"].ToString());
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnectSqlServer.getInstance().Disconnect();
            }
        }

        private void button_BrowseFile_Click(object sender, EventArgs e)
        {
            openFileDialog_BrowseExcelFile.ShowDialog();
            textBox_ExcelFile.Text = openFileDialog_BrowseExcelFile.FileName;
        }
    }
}
