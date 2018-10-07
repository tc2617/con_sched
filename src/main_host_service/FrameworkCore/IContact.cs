using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.FrameworkCore
{
    public interface IContact
    {
        string DisplayName { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string EMail { get; set; }
        string Phone { get; set; }
        IPhysicalAddress PhysicalAddress { get; set; }
    }
}
