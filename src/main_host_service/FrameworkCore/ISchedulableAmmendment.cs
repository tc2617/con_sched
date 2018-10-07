using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.FrameworkCore
{
    public interface ISchedulableAmmendment
    {
        ScheduleProperties Property { get; }
        string Description { get; set; }
        bool Required { get; set; }
    }
}
