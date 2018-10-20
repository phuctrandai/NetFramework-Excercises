using System;
using System.Data.SqlClient;

namespace QuanLyHang.Model.Dao
{
    class ConnectSqlServer
    {
        private static ConnectSqlServer instance;

        public static ConnectSqlServer GetInstance()
        {
            if (instance == null) instance = new ConnectSqlServer(); return instance;
        }

        private SqlConnection sqlConnection;

        public SqlConnection SqlConnection
        {
            get { if (sqlConnection == null) { sqlConnection = new SqlConnection(); } return sqlConnection; }
            private set => sqlConnection = value;
        }

        public void Connect(string serverName, string database, string userName, string password)
        {
            try
            {
                string connectionString = String.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True;User ID={2};Password={3}", serverName, database, userName, password);
                SqlConnection = new SqlConnection(connectionString);
                SqlConnection.Open();
            } catch (SqlException e)
            {
                throw e;
            }
        }

        public void Connect(string serverName, string database)
        {
            try
            {
                string connectionString = String.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True", serverName, database);
                SqlConnection = new SqlConnection(connectionString);
                SqlConnection.Open();
            } catch (SqlException e)
            {
                throw e;
            }
        }

        public void Disconnect()
        {
            if(SqlConnection.State == System.Data.ConnectionState.Open)
                SqlConnection.Close();
        }
    }
}
