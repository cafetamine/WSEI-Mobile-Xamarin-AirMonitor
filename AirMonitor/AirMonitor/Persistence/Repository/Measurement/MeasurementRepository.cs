using System;
using System.Collections.Generic;
using System.Linq;
using AirMonitor.Core.Application.Installation.Repository;
using AirMonitor.Core.Application.Measurement.Repository;
using AirMonitor.Core.Application.Measurement.Repository.Item;
using AirMonitor.Persistence.Entity.Measurement;
using AirMonitor.Persistence.Utility;
using MeasurementDomain = AirMonitor.Core.Domain.Measurement.Measurement;

namespace AirMonitor.Persistence.Repository.Measurement
{
    public class MeasurementRepository : IMeasurementRepository
    {
        private readonly IDbConnection _connection;
        private readonly IInstallationRepository _installationRepository;
        private readonly IMeasurementItemRepository _itemRepository;

        public MeasurementRepository(IDbConnection connection,
                                     IInstallationRepository installationRepository,
                                     IMeasurementItemRepository itemRepository)
        {
            _connection = connection;
            _installationRepository = installationRepository;
            _itemRepository = itemRepository;
        }

        public MeasurementDomain FindById(long id)
        {
            var entity = _connection.Get.Get<MeasurementEntity>(id);
            return entity != null ? FindReferences(entity) : null;
        }

        public List<MeasurementDomain> FindAll()
            => _connection.Get.Table<MeasurementEntity>()
                              .Select(FindReferences)
                              .ToList();

        public MeasurementDomain Save(MeasurementDomain measurement)
        {
            var successFlag = _connection.Get.Insert(measurement);
            if (successFlag <= 0)
            {
                return null;
            }
            var measurementId = _connection.LastIndex;
            return measurement.WIthId(measurementId)
                              .WithCurrent(_itemRepository.Save(measurement.Current, measurementId))
                              .WithHistory(_itemRepository.SaveAll(measurement.History, measurementId))
                              .WithForecast(_itemRepository.SaveAll(measurement.Forecast, measurementId))
                              .WithInstallation(_installationRepository.Save(measurement.Installation));
        }

        public List<MeasurementDomain> SaveAll(List<MeasurementDomain> measurements)
            => measurements.Select(Save).ToList();

        private MeasurementDomain FindReferences(MeasurementEntity measurement)
        {
            var installation = _installationRepository.FindById(measurement.InstallationRef);
            var items = _itemRepository.FindAllByMeasurementId(measurement.Id ?? throw new ArgumentException("Measurement id is null"));
            return measurement.ToDomain(items, installation);
        }
    }
}
