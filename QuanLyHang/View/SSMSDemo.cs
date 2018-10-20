using QuanLyHang.Model.Dao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyHang.View
{
    public partial class form_SSMSDemo : Form
    {
        public form_SSMSDemo()
        {
            InitializeComponent();
        }

        private void form_SSMSDemo_Load(object sender, EventArgs e)
        {
            if (ConnectSqlServer.GetInstance().SqlConnection.State == System.Data.ConnectionState.Open)
            {
                LoadAllDatabase();
            }
        }

        private void LoadAllDatabase()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT [name] FROM [master].[sys].[databases]";
            command.Connection = ConnectSqlServer.GetInstance().SqlConnection;
            SqlDataReader databases;

            TreeNode serverNode = new TreeNode(form_KetNoiServer.serverName);
            serverNode.ImageIndex = 0;
            serverNode.SelectedImageIndex = 0;
            treeView_Databases.Nodes.Add(serverNode);

            try
            {
                databases = command.ExecuteReader();
                while (databases.Read())
                {
                    TreeNode database = new TreeNode(databases[0].ToString());
                    database.ImageIndex = database.SelectedImageIndex = 1;
                    serverNode.Nodes.Add(database);
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            ConnectSqlServer.GetInstance().Disconnect();

            foreach (TreeNode node in serverNode.Nodes)
            {
                try
                {
                    SqlDataReader tables = LoadAllTable(node.Text);
                    while (tables.Read())
                    {
                        TreeNode table = new TreeNode(tables[0].ToString());
                        table.ImageIndex = table.SelectedImageIndex = 2;
                        node.Nodes.Add(table);

                        ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                        contextMenuStrip.Items.Add("Select top 1000 rows", Image.FromFile(@"C:\Users\phuc\Pictures\Wallpaper\man_solitude_desert.jpg"), new EventHandler(selectTop1000_click));
                        contextMenuStrip.Items.Add("Show structure", Image.FromFile(@"C:\Users\phuc\Pictures\Wallpaper\man_solitude_desert.jpg"), new EventHandler(showStructure_click));
                        table.ContextMenuStrip = contextMenuStrip;
                    }
                } catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                ConnectSqlServer.GetInstance().Disconnect();
            }
        }

        private SqlDataReader LoadAllTable(string databaseName)
        {
            ConnectSqlServer.GetInstance().Connect(@".\SQLEXPRESS", databaseName);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM [" + databaseName + "].[sys].[tables]";
            command.Connection = ConnectSqlServer.GetInstance().SqlConnection;

            SqlDataReader data = command.ExecuteReader();
            return data;
        }

        private void selectTop1000_click(object sender, EventArgs e)
        {
            SelectTop1000();
        }

        private void SelectTop1000()
        {
            TreeNode selectedNode = treeView_Databases.SelectedNode;
            string tableName = selectedNode.Text;

            ConnectSqlServer.GetInstance().Connect(@".\SQLEXPRESS", selectedNode.Parent.Text);
            string commandText = "SELECT * FROM [" + selectedNode.Parent.Text + "].[dbo].[" + tableName + "]";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commandText, ConnectSqlServer.GetInstance().SqlConnection);

            DataTable table = new DataTable(tableName);
            sqlDataAdapter.Fill(table);

            dataGridView_View.DataSource = table;
            ConnectSqlServer.GetInstance().Disconnect();
        }

        private void showStructure_click(object sender, EventArgs e)
        {
            ShowStructureTable();
        }

        private void ShowStructureTable()
        {
            TreeNode selectedNode = treeView_Databases.SelectedNode;
            string tableName = selectedNode.Text;

            ConnectSqlServer.GetInstance().Connect(@".\SQLEXPRESS", selectedNode.Parent.Text);
            string commandText = "SELECT [COLUMN_NAME], [IS_NULLABLE],[DATA_TYPE],[CHARACTER_MAXIMUM_LENGTH]FROM[QLSach].[INFORMATION_SCHEMA].[COLUMNS] WHERE TABLE_NAME='" + tableName + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commandText, ConnectSqlServer.GetInstance().SqlConnection);
            DataTable table = new DataTable(tableName);
            sqlDataAdapter.Fill(table);

            dataGridView_View.DataSource = table;
            ConnectSqlServer.GetInstance().Disconnect();
        }

        private void treeView_Databases_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView_Databases.SelectedNode = e.Node;
        }
    }
}
