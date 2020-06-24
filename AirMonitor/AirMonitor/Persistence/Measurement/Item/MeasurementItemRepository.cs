using System;
using System.Collections.Generic;
using System.Linq;
using AirMonitor.Core.Application.Measurement.Repository.Item;
using AirMonitor.Core.Domain.Measurement.Item;
using AirMonitor.Persistence.Utility;

namespace AirMonitor.Persistence.Measurement.Item
{
    public class MeasurementItemRepository : IMeasurementItemRepository
    {
        private readonly IDbConnection _connection;
        private readonly IAirQualityIndexRepository _indexRepository;
        private readonly IAirQualityStandardRepository _standardRepository;
        private readonly IMeasurementItemValueRepository _valueRepository;

        public MeasurementItemRepository(IDbConnection connection,
                                         IAirQualityIndexRepository indexRepository,
                                         IAirQualityStandardRepository standardRepository,
                                         IMeasurementItemValueRepository valueRepository)
        {
            _connection = connection;
            _indexRepository = indexRepository;
            _standardRepository = standardRepository;
            _valueRepository = valueRepository;
        }


        public List<MeasurementItem> FindAllByMeasurementId(long measurementId)
            => _connection.Get.Table<MeasurementItemEntity>()
                              .Select(item =>
                                  {
                                      var itemId = item.Id ?? throw new ArgumentException("MeasurementItem id is null");
                                      var values = _valueRepository.FindAllyMeasurementItemId(itemId);
                                      var indexes = _indexRepository.FindAllyMeasurementItemId(itemId);
                                      var standards = _standardRepository.FindAllyMeasurementItemId(itemId);
                                      return item.ToDomain(values, indexes, standards);
                                  }
                              ).ToList();

        public List<MeasurementItem> SaveAll(List<MeasurementItem> items, long measurementId)
            => items.Select(item => Save(item, measurementId)).ToList();

        public MeasurementItem Save(MeasurementItem item, long measurementId)
        {
            if (_connection.Get.Insert(MeasurementItemEntity.FromDomain(item, measurementId)) > 0)
            {
                return item.WithId(_connection.LastIndex)
                           .WithIndexes(_indexRepository.SaveAllFromMeasurementItem(item))
                           .WithStandards(_standardRepository.SaveAllFromMeasurementItem(item))
                           .WithValues(_valueRepository.SaveAllFromMeasurementItem(item));
            }
            return null;
        }
        
        public void DeleteAll()
        {
            _connection.Get.DeleteAll<MeasurementItemEntity>();
            _indexRepository.DeleteAll();
            _standardRepository.DeleteAll();
            _valueRepository.DeleteAll();
        }   
    }
}
