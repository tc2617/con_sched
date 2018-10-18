using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Framework.PluginInterfaces;

namespace plugin_host_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPluginHostServiceContract<T> : IPluginService<T> where T : IServicePlugin
	{
        IDictionary<string, T> Plugins { get; }
    }
}
