using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Framework.PluginInterfaces
{
    [DataContract]
    public abstract class BaseServicePlugin : BasePlugin, IServicePlugin
    {
        [DataMember]
        public string State { get; protected set; }

        public virtual void Pause() { }

        public abstract void Start();

        public abstract void Stop();
    }
}
