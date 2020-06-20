using System.IO;
using SQLite;

namespace AirMonitor.Infrastructure.Persistence
{
    public class DbConnection : IDbConnection
    {
        private const string DbName = "AirMonitorDb";

        private string DbPath
            => Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData), DbName);


        public SQLiteConnection Get => new SQLiteConnection(DbPath);
    }
}
