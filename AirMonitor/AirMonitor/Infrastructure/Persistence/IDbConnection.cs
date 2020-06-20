using SQLite;

namespace AirMonitor.Infrastructure.Persistence
{
    public interface IDbConnection
    {
        SQLiteConnection Get { get; }
    }
}
