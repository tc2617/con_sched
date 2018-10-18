using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.PluginInterfaces;

namespace UT_PluginHost
{
    [TestClass]
    public class utHostBasic
    {
        IPluginService<IServicePlugin> _Host;
        mocks.MockPlugin _Mock;

        [TestInitialize]
        public void Init()
        {
            _Host = new plugin_host_service.PluginHostService<IServicePlugin>();
            _Mock = new mocks.MockPlugin();

            _Host.Load(_Mock);
        }

        [TestMethod]
        public void TestAddPlugin()
        {
            var p = new mocks.MockPlugin();
            var host = new plugin_host_service.PluginHostService<IServicePlugin>();
            host.Load(p);

            Assert.IsTrue(p.State == "Stopped");
            host.Start();
            Assert.IsTrue(p.State == "Running");
        }

        [TestMethod]
        public void TestStartPlugins()
        {
            Assert.IsTrue(_Mock.State == "Stopped");
            _Host.Start();
            Assert.IsTrue(_Mock.State == "Running");
        }

        [TestMethod]
        public void TestStopPlugins()
        {
            _Host.Start();
            Assert.IsTrue(_Mock.State == "Running");
            _Host.Stop();
            Assert.IsTrue(_Mock.State == "Stopped");
        }

        [TestMethod]
        public void TestPausePlugins()
        {
            _Host.Start();
            Assert.IsTrue(_Mock.State == "Running");
            _Host.Pause();
            Assert.IsTrue(_Mock.State == "Paused");
        }
    }
}
