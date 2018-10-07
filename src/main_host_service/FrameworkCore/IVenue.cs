using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.FrameworkCore
{
    public interface IVenue
    {
        /// <summary>
        /// Actual name for the venue
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Physical Address for the venue
        /// </summary>
        IPhysicalAddress Address { get; set; }

        /// <summary>
        /// Extra access addresses for the venue. Service entrances, Loading dock entrance, etc.
        /// </summary>
        ICollection<IPhysicalAddress> ServiceAddresses { get; set; }

        /// <summary>
        /// Known contacts for the venue.
        /// </summary>
        ICollection<IContact> Contacts { get; }

        /// <summary>
        /// Non event specific description of rooms for a venue.
        /// </summary>
        ICollection<IVenueRoom> VenueRooms { get; }
    }
}
