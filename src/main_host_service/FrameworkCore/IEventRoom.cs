using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.FrameworkCore
{
    public interface IEventRoom
    {
        string Name { get; set; }
        ICollection<ISchedulableItem> Panels { get; set; }
        ICollection<string> Ammendments { get; }
    }
}
