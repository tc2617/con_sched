using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Framework.PluginInterfaces;

public class Service : IService<Framework.PluginInterfaces.BasePluginService>
{
	ServiceHost _PluginService;

	public string GetData(int value)
	{
		return $"You entered: {value}";
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}

	public void Load(BasePluginService plugin)
	{
		return;
	}

	public void Pause()
	{
		Stop();
	}

	public void Start()
	{
		_PluginService = plugin_host_service.CreateWCFService.Start();
	}

	public void Stop()
	{
		_PluginService.Close();
	}
}
