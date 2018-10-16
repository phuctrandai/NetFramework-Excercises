using System.Data.OleDb;

namespace QuanLyHang.Model.Dao
{
    class ConnectOleDB
    {
        private static ConnectOleDB instance;

        public static ConnectOleDB getInstance()
        {
            if (instance == null) instance = new ConnectOleDB(); return instance;
        }

        private OleDbConnection oleDbConnection;

        public OleDbConnection OleDbConnection
        {
            get { if (oleDbConnection == null) oleDbConnection = new OleDbConnection(); return oleDbConnection; }
            set => oleDbConnection = value;
        }

        private ConnectOleDB() { }

        public void Connect(string stringConnection)
        {
            try
            {
                OleDbConnection = new OleDbConnection(stringConnection);
                OleDbConnection.Open();
            }
            catch (OleDbException e)
            {
                throw e;
            }
        }

        public void Disconnect()
        {
            if(OleDbConnection.State == System.Data.ConnectionState.Open)
            {
                OleDbConnection.Close();
            }
        }
    }
}
