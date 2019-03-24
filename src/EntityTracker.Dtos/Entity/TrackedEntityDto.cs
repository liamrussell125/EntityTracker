using System.Collections.Generic;

namespace EntityTracker.Dtos.Entity
{
    public class TrackedEntityDto
    {
        public string EntityId { get; set; }
        public IEnumerable<TrackedEntityEventDto> Events { get; set; }
    }
}
