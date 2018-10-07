using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.FrameworkCore
{
    public interface IEventRoom
    {
        /// <summary>
        /// Event Descripive name for the room.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Venue information for a room.
        /// </summary>
        IVenueRoom Room { get; set; }

        /// <summary>
        /// General availability times for the room. Used by scheduler to check that scheduled items run within Open/Closed times.
        /// 
        /// NOTE: Not all rooms have the same schedule everday.
        /// </summary>
        ICollection<IOpenClose> OpenCloseSchedule { get; set; }

        /// <summary>
        /// Scheduled items for the room.
        /// </summary>
        ICollection<ISchedulableItem> ScheduleItems { get; }

        /// <summary>
        /// Allows modification to the scheduler for the room. Such as allow adult track, hard cutoff times, special use
        /// </summary>
        ICollection<string> SchedulerAmmendments { get; }

        /// <summary>
        /// Ordered of items in schedule
        /// </summary>
        IList<ISchedulableItem> ScheduleOrder { get; set; }

        /// <summary>
        /// Adds a break time between schedule items
        /// </summary>
        TimeSpan ScheduleBreaks { get; set; }
    }
}
