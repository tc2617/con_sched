using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT_PluginHost.mocks
{
    class MockPlugin : Framework.PluginInterfaces.BasePlugin
    {
        public MockPlugin()
        {
            this.Name = "MockPlugin";
            this.GUID = "7DFD6480-9462-473C-9946-452B8B8EA894";
            this.Description = "Mock plugin for unit testing";
            this.State = "Stopped";
        }

        public override void Pause()
        {
            State = "Paused";
        }

        public override void Start()
        {
            State = "Running";
        }

        public override void Stop()
        {
            State = "Stopped";
        }
    }
}
