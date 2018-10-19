using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using Framework.PluginInterfaces;

namespace plugin_host_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class PluginHostService<T> : IPluginHostServiceContract<T> where T : IPluginService
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
#if DEBUG
			Console.WriteLine($"{System.Reflection.MethodInfo.GetCurrentMethod().Module.Name}.{System.Reflection.MethodInfo.GetCurrentMethod().Name}");
#endif
			OperateOnAll((T svc) =>
            {
                svc.Pause();
            });
        }

        public void Start()
		{
#if DEBUG
			Console.WriteLine($"{System.Reflection.MethodInfo.GetCurrentMethod().Module.Name}.{System.Reflection.MethodInfo.GetCurrentMethod().Name}");
#endif
			OperateOnAll((T svc) =>
            {
                svc.Start();
            });
        }

        public void Stop()
		{
#if DEBUG
			Console.WriteLine($"{System.Reflection.MethodInfo.GetCurrentMethod().Module.Name}.{System.Reflection.MethodInfo.GetCurrentMethod().Name}");
#endif
			OperateOnAll((T svc) =>
            {
                svc.Stop();
            });
        }

        public void Load(T plugin)
		{
#if DEBUG
			Console.WriteLine($"Loading Plugin: {plugin.Name}_{plugin.GUID}");
#endif
			Plugins[plugin.GUID] = plugin;
        }
    }
}
