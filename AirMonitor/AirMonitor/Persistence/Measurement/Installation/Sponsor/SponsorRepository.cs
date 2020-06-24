using AirMonitor.Core.Application.Installation.Repository;
using AirMonitor.Persistence.Utility;

namespace AirMonitor.Persistence.Measurement.Installation.Sponsor
{
    public class SponsorRepository : ISponsorRepository
    {
        private readonly IDbConnection _connection;

        public SponsorRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        
        public Core.Domain.Installation.Sponsor FindById(long id)
            => _connection.Get.Get<SponsorEntity>(id)?.ToDomain();

        public Core.Domain.Installation.Sponsor Save(Core.Domain.Installation.Sponsor sponsor)
        {
            if (_connection.Get.InsertOrReplace(SponsorEntity.FromDomain(sponsor)) > 0)
            {
                return sponsor;
            }
            return null;
        }
    }
}
