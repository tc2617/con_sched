using System.Collections.Generic;

namespace Framework.FrameworkCore
{
    public interface ISchedulableAmmendment : ISchedulableResource
    {
        /// <summary>
        /// Optional value specifying what this object's data pertains to
        /// </summary>
        ScheduleProperties Property { get; set; }
        
        /// <summary>
        /// Useful name for the entry
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// What describes the Values for this data.
        /// </summary>
        IObjectType ObjectType { get; set; }

        /// <summary>
        /// Binary data
        /// </summary>
        ICollection<object> Value { get; }
    }
}
