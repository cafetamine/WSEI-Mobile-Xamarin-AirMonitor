using AirMonitor.Persistence.Measurement;
using AirMonitor.Persistence.Measurement.Installation;
using AirMonitor.Persistence.Measurement.Installation.Address;
using AirMonitor.Persistence.Measurement.Installation.Loaction;
using AirMonitor.Persistence.Measurement.Installation.Sponsor;
using AirMonitor.Persistence.Measurement.Item;
using AirMonitor.Persistence.Measurement.Item.AirQuality;
using AirMonitor.Persistence.Measurement.Item.Value;
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

            // MeasurementItem Relations
            _connection.Get.CreateTable<AirQualityIndexEntity>();
            _connection.Get.CreateTable<AirQualityStandardEntity>();
            _connection.Get.CreateTable<MeasurementValueEntity>();

            // MeasurementItem
            _connection.Get.CreateTable<MeasurementItemEntity>();

            // Measurement
            _connection.Get.CreateTable<MeasurementEntity>();
        }
    }
}
