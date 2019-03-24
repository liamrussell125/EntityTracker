using EntityTracker.Dtos.Entity;
using System.Threading.Tasks;

namespace EntityTracker.Interfaces.Services
{
    public interface IEntityTrackerService
    {
        Task<TrackedEntityDto> GetTrackedEntity(string entityId);
        Task SaveTrackedEntityEvent(string entityId, string serviceId);
    }
}
