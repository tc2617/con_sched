using System.Runtime.Serialization;

namespace Framework.PluginInterfaces
{
    [DataContract]
    public abstract class BasePluginService : BasePlugin, IPluginService
    {
        [DataMember]
        public string State { get; protected set; }

        public virtual void Pause() { }

        public abstract void Start();

        public abstract void Stop();

		protected BasePluginService(string name, string guid, string description = "")
			: base(name, guid, description)
		{

		}
    }
}
