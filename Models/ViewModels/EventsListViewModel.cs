using System.Collections.Generic;
using Modas.Models;

namespace Modas.Models.ViewModels
{
    public class EventsListViewModel
    {
        public IEnumerable<Event> Events { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
