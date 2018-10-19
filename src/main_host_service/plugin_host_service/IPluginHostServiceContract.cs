using System.Collections.Generic;
using System.ServiceModel;
using Framework.PluginInterfaces;

namespace plugin_host_service
{
	[ServiceContract]
    public interface IPluginHostServiceContract<T> : IPluginServiceContract<T> where T : IPluginService
	{
    }
}
