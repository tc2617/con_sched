using System.Collections.Generic;

namespace Framework.FrameworkCore
{
    public interface IVenueRoom
    {
        // NOTE: Do not make any Open/Close times in here. This says that a room exists. Not how that room can be used for an event.

        /// <summary>
        /// Venue's Name for a room.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Venue's number for a room
        /// </summary>
        string RoomNumber { get; set; }

        /// <summary>
        /// Use to specify things like Service Entrance, Food or Drink allowed, Staff Only, etc.
        /// </summary>
        ICollection<string> Features { get; }
    }
}