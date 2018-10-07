using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.FrameworkCore
{
    public interface IScheduleContact
    {
        IContact Contact { get; set; }
        bool Primary { get; set; }
        bool Required { get; set; }
        bool EventVIP { get; set; }
    }
}
