using AirMonitor.Core.Application.Installation.Repository;
using AirMonitor.Core.Domain.Installation;
using AirMonitor.Persistence.Entity.Installation;
using AirMonitor.Persistence.Utility;

namespace AirMonitor.Persistence.Repository.Installation
{
    public class SponsorRepository : ISponsorRepository
    {
        private readonly IDbConnection _connection;

        public SponsorRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        
        public Sponsor FindById(long id)
            => _connection.Get.Get<SponsorEntity>(id)?.ToDomain();

        public Sponsor Save(Sponsor sponsor)
        {
            if (_connection.Get.InsertOrReplace(SponsorEntity.FromDomain(sponsor)) > 0)
            {
                return sponsor;
            }
            return null;
        }
    }
}
