using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.FrameworkCore
{
    public interface ISchedulableItem
    {
        string Name { get; set; }
        ICollection<IScheduleContact> Contacts { get; }
        decimal Length { get; set; }
        ICollection<ISchedulableAmmendment> Ammendments { get; }
    }
}
