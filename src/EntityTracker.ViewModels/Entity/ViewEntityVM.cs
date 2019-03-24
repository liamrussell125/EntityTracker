using EntityTracker.Dtos.Entity;
using System.Collections.Generic;
using System.Linq;

namespace EntityTracker.ViewModels.Entity
{
    public class ViewEntityVM
    {
        public string EntityId { get; set; }
        public IEnumerable<ViewEntityEventVM> Events { get; set; }

        public ViewEntityVM(string entityId, IEnumerable<ViewEntityEventVM> events)
        {
            EntityId = entityId;
            Events = events;
        }

        public static ViewEntityVM FromTrackedEntityDto(TrackedEntityDto trackedEntityDto)
        {
            return new ViewEntityVM(trackedEntityDto.EntityId, trackedEntityDto.Events.Select(e => new ViewEntityEventVM(e)));
        }
    }
}
