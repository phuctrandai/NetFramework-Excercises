using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHang.Model.Dao
{
    class ConnectDataBase
    {
        private static ConnectDataBase instance;

        public static ConnectDataBase getInstance()
        {
            if (instance == null) instance = new ConnectDataBase(); return instance;
        }

        public SqlConnection sqlConnection;
        
        public void Connect(string serverName, string database, string userName, string password)
        {
            string connectionString = String.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True;User ID={2};Password={3}",serverName,database,userName,password);
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();            
        }

        public void Connect(string serverName, string database)
        {
            string connectionString = String.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True", serverName, database);
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }

        public void Disconnect()
        {
            sqlConnection.Close();
        }


    }
}
