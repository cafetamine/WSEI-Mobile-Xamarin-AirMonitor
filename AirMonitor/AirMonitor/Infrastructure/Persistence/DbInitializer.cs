using AirMonitor.Persistence.Entity.Installation;
using AirMonitor.Persistence.Utility;

namespace AirMonitor.Infrastructure.Persistence
{
    public class DbInitializer : IDbInitializer
    {
        private readonly IDbConnection _connection;

        public DbInitializer(IDbConnection connection)
        {
            _connection = connection;
            Execute();
        }

        public void Execute()
        {
            // Installation Relations
            _connection.Get.CreateTable<AddressEntity>();
            _connection.Get.CreateTable<LocationEntity>();
            _connection.Get.CreateTable<SponsorEntity>();

            // Installation
            _connection.Get.CreateTable<InstallationEntity>();
        }
    }
}
