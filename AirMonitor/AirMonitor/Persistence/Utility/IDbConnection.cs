using SQLite;

namespace AirMonitor.Persistence.Utility
{
    public interface IDbConnection
    {
        SQLiteConnection Get { get; }

        long LastIndex { get; }

        void Connect();

        void Disconnect();

        void BeginTransaction();

        void RollbackTransaction();

        void CommitTransaction();
    }
}
