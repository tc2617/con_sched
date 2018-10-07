using System;

namespace Framework.FrameworkCore
{
    public interface IOpenClose
    {
        /// <summary>
        /// Room available for a use.
        /// </summary>
        DateTime OpenTime { get; set; }

        /// <summary>
        /// Room closed for ALL uses.
        /// </summary>
        DateTime CloseTime { get; set; }

        /// <summary>
        /// When set room is considered open for non-attendee purposes only.
        /// e.g. Setup/Teardown purposes. Not between usage purposes.
        /// </summary>
        bool NonAttendeeUsage { get; set; }
    }
}