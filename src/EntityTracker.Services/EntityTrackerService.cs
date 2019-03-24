using System.Threading.Tasks;
using EntityTracker.Dtos.Entity;
using EntityTracker.Interfaces.Services;

namespace EntityTracker.Services
{
    public class EntityTrackerService : IEntityTrackerService
    {
        public Task<TrackedEntityDto> GetTrackedEntity(string entityId)
        {
            throw new System.NotImplementedException();
        }

        public Task SaveTrackedEntityEvent(string entityId, string serviceId)
        {
            throw new System.NotImplementedException();
        }
    }
}
