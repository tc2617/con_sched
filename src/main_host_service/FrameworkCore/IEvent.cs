using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.FrameworkCore
{
    public interface IEvent
    {
        /// <summary>
        /// Name for the event
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Start and Close date for the Event.
        /// </summary>
        IOpenClose OpenClose { get; set; }

        /// <summary>
        /// Rooms used for schedulable events
        /// </summary>
        ICollection<IEventRoom> EventRooms { get; }

        /// <summary>
        /// Venues used for the events. Must exist before the <seealso cref="EventRooms"/> may be created.
        /// </summary>
        ICollection<IVenue> Venues { get; }

        /// <summary>
        /// Primary Staff to contact for the event
        /// </summary>
        ICollection<IScheduleContact> Contacts { get; }
    }
}
