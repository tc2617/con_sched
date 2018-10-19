﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Framework.PluginInterfaces
{
    public interface IPluginService : IPlugin
    {
        string State { get; }

        void Pause();

        void Start();

        void Stop();
    }
}
