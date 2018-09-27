using System;
using System.Data.SqlClient;

namespace QuanLyHang.Model.Dao
{
    class ConnectDataBase
    {
        private static ConnectDataBase instance;

        public static ConnectDataBase getInstance()
        {
            if (instance == null) instance = new ConnectDataBase(); return instance;
        }

        private SqlConnection sqlConnection;

        public SqlConnection SqlConnection { get => sqlConnection; set => sqlConnection = value; }

        public void Connect(string serverName, string database, string userName, string password)
        {
            string connectionString = String.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True;User ID={2};Password={3}",serverName,database,userName,password);
            SqlConnection = new SqlConnection(connectionString);
            SqlConnection.Open();            
        }

        public void Connect(string serverName, string database)
        {
            string connectionString = String.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True", serverName, database);
            SqlConnection = new SqlConnection(connectionString);
            SqlConnection.Open();
        }

        public void Disconnect()
        {
            SqlConnection.Close();
        }


    }
}
