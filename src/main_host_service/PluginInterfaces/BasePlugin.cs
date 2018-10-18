using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Framework.PluginInterfaces
{
    [DataContract]
    public abstract class BasePlugin : IPlugin
    {
        [DataMember]
        public string Name { get; protected set; }

        [DataMember]
        public string GUID { get; protected set; }

        [DataMember]
        public string Description { get; protected set; }
    }
}
