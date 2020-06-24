using System;
using System.Collections.Generic;
using System.Linq;
using AirMonitor.Core.Application.Installation.Repository;
using AirMonitor.Core.Application.Measurement.Repository;
using AirMonitor.Core.Application.Measurement.Repository.Item;
using AirMonitor.Persistence.Utility;
using MeasurementDomain = AirMonitor.Core.Domain.Measurement.Measurement;

namespace AirMonitor.Persistence.Measurement
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
            _connection.BeginTransaction();
            try
            {
                var successFlag = _connection.Get.Insert(MeasurementEntity.FromDomain(measurement));
                if (successFlag <= 0)
                {
                    _connection.RollbackTransaction();
                    return null;
                }

                var measurementId = _connection.LastIndex;
                measurement = measurement.WithId(measurementId)
                                         .WithCurrent(_itemRepository.Save(measurement.Current, measurementId))
                                         .WithHistory(_itemRepository.SaveAll(measurement.History, measurementId))
                                         .WithForecast(_itemRepository.SaveAll(measurement.Forecast, measurementId))
                                         .WithInstallation(_installationRepository.Save(measurement.Installation));

                _connection.CommitTransaction();
                return measurement;
            }
            catch (Exception e)
            {
                _connection.RollbackTransaction();
            }

            return measurement;
        }

        public List<MeasurementDomain> SaveAll(List<MeasurementDomain> measurements)
            => measurements.Select(Save).ToList();

        private MeasurementDomain FindReferences(MeasurementEntity measurement)
        {
            var installation = _installationRepository.FindById(measurement.InstallationRef);
            var items = _itemRepository.FindAllByMeasurementId(measurement.Id ?? throw new ArgumentException("Measurement id is null"));
            return measurement.ToDomain(items, installation);
        }
        
        public void DeleteAll()
        {
            _connection.Get.DeleteAll<MeasurementEntity>();
            _itemRepository.DeleteAll();
        } 
    }
}
