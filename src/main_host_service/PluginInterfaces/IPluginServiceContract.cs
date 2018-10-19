using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Framework.PluginInterfaces
{
    [ServiceContract]
    public interface IPluginServiceContract<T> where T : IPluginService
	{
        [OperationContract]
        void Start();

        [OperationContract]
        void Stop();

        [OperationContract]
        void Pause();

        void Load(T plugin);
    }
}
