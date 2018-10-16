using QuanLyHang.Bo;
using QuanLyHang.Model.Dao;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace QuanLyHang.View
{
    public partial class form_QuanLySach : Form
    {
        public form_QuanLySach()
        {
            InitializeComponent();
        }

        private void form_QuanLySach_Load(object sender, EventArgs e)
        {
            if(ConnectSqlServer.getInstance().SqlConnection.State == System.Data.ConnectionState.Open)
                LoadDanhSach();
            else
            {
                LoadFromExcelFile();
            }
        }

        private void LoadDanhSach()
        {
            try
            {
                dataGridView_Sach.DataSource = SachBo.getInstance().GetSach();
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void LoadFromExcelFile()
        {
            OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM [Sheet1$]", ConnectOleDB.getInstance().OleDbConnection);
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
            DataSet dataSet = new DataSet();
            oleDbDataAdapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            dataGridView_Sach.DataSource = dataTable;
        }

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
