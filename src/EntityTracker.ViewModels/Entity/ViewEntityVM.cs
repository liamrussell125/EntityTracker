using System.Collections.Generic;

namespace EntityTracker.ViewModels.Entity
{
    public class ViewEntityVM
    {
        public string EntityId { get; set; }
        public IEnumerable<ViewEntityEventVM> Events { get; set; }
    }
}
