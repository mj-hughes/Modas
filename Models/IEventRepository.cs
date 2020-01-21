using Modas.Models;
using System.Linq;

namespace Modus.Models
{
    public interface IEventRepository
    {
        IQueryable<Event> Events { get; }
        IQueryable<Location> Locations { get; }
    }
}
