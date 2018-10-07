using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.PluginInterfaces
{
    public interface IPlugin
    {
        string Name { get; }
        string Description { get; }
        string GUID { get; }
        string State { get; }

        void Pause();

        void Start();

        void Stop();
    }
}
