using AirMonitor.Persistence.Entity.Installation;
using AirMonitor.Persistence.Entity.Measurement;

namespace AirMonitor.Infrastructure.Persistence
{
    public class DbInitializer : IDbInitializer
    {
        private IDbConnection _connection;

        public DbInitializer(IDbConnection connection)
        {
            _connection = connection;
        }

        public void Execute()
        {
            // Installation Relations
            _connection.Get.CreateTable<AddressEntity>();
            _connection.Get.CreateTable<LocationEntity>();
            _connection.Get.CreateTable<SponsorEntity>();
            // Installation
            _connection.Get.CreateTable<InstallationEntity>();
            
            // Measurement Relations
            _connection.Get.CreateTable<AirQualityStandardEntity>();
            _connection.Get.CreateTable<AirQualityIndexEntity>();
            _connection.Get.CreateTable<MeasurementValueEntity>();
            _connection.Get.CreateTable<MeasurementItemEntity>();
            //Measurement
            _connection.Get.CreateTable<MeasurementEntity>();
        }
    }
}
