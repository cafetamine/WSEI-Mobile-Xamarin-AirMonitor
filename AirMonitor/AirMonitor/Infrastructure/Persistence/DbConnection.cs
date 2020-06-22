using System;
using AirMonitor.Persistence.Utility;
using AirMonitor.Util;
using SQLite;

namespace AirMonitor.Infrastructure.Persistence
{
    public class DbConnection : IDbConnection
    {
        private const string DbName = "AirMonitorDb.db3";
        private static string DbPath = FileHelper.InPersonalDir(DbName);
        private static SQLiteConnection _connection;

        public SQLiteConnection Get => _connection ?? throw new Exception("Connection closed");

        public DbConnection()
        {
            Connect();
        }

        public long LastIndex => Get.ExecuteScalar<long>("select last_insert_rowid()");

        public void Connect()
        {
            if (_connection == null)
            {
                _connection = new SQLiteConnection(DbPath);
            }
        }

        public void Disconnect()
        {
            if (_connection != null)
            {
                _connection.Close();
                _connection = null;
            }
        }
    }
}
