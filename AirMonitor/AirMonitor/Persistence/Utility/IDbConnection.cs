using SQLite;

namespace AirMonitor.Persistence.Utility
{
    public interface IDbConnection
    {
        SQLiteConnection Get { get; }
    }
}
