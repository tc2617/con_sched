using System.Collections.Generic;

namespace Framework.FrameworkCore
{
    /// <summary>
    /// Describes a code type object which handles a resource.
    /// </summary>
    public interface IObjectType
    {
        string Name { get; set; }

        string Version { get; set; }

        bool Obsolete { get; set; }

        ICollection<IObjectType> Replaces { get; set; }
    }
}
