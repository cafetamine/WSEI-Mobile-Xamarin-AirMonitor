using AirMonitor.Core.Application.Installation;
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
        {
            var sponsor = _connection.Get.Get<SponsorEntity>(id);
            _connection.Get.Close();
            return sponsor?.ToDomain();
        }

        public bool Save(Sponsor sponsor)
        {
            var successFlag = _connection.Get.Insert(SponsorEntity.FromDomain(sponsor));
            _connection.Get.Close();
            return successFlag > 0;
        }
    }
}