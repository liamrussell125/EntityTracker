using EntityTracker.Dtos.Entity;
using System;

namespace EntityTracker.ViewModels.Entity
{
    public class ViewEntityEventVM
    {
        public string ServiceId { get; set; }
        public DateTime CreatedOn { get; set; }

        public ViewEntityEventVM(TrackedEntityEventDto trackedEntityEventDto)
        {
            ServiceId = trackedEntityEventDto.ServiceId;
            CreatedOn = trackedEntityEventDto.CreatedOn;
        }
    }
}
