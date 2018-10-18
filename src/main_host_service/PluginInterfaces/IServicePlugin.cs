using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.PluginInterfaces
{
    public interface IServicePlugin : IPlugin
    {
        string State { get; }

        void Pause();

        void Start();

        void Stop();
    }
}
