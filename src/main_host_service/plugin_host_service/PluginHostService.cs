using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Framework.PluginInterfaces;

namespace plugin_host_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class PluginHostService<T> : IPluginHostServiceContract<T> where T : IServicePlugin
	{
        public IDictionary<string, T> Plugins { get; private set; }

        public PluginHostService()
        {
            Plugins = new ConcurrentDictionary<string, T>();
        }

        void OperateOnAll(Action<T> action)
        {
            try
            {
                Parallel.ForEach(Plugins, item =>
                {
                    action(item.Value);
                });
            }
            catch(Exception ex)
            {
                Console.WriteLine($"ERR: {ex.Message}");
            }
        }

        public void Pause()
        {
            OperateOnAll((T svc) =>
            {
                svc.Pause();
            });
        }

        public void Start()
        {
            OperateOnAll((T svc) =>
            {
                svc.Start();
            });
        }

        public void Stop()
        {
            OperateOnAll((T svc) =>
            {
                svc.Stop();
            });
        }

        public void Load(T plugin)
        {
            Plugins[plugin.GUID] = plugin;
        }
    }
}
