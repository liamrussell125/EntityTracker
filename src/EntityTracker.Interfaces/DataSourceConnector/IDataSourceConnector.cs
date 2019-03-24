using EntityTracker.Models.Entity;
using System.Threading.Tasks;

namespace EntityTracker.Interfaces.DataSourceConnector
{
    public interface IDataSourceConnector
    {
        Task SaveEntityEvent(string entityId, TrackedEntityEvent entityEvent);
        Task<TrackedEntity> GetEntity(string entityId);
    }
}
