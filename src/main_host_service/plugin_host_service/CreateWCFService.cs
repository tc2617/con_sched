using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Framework.PluginInterfaces;

namespace plugin_host_service
{
	public class CreateWCFService
	{
		public static ServiceHost Start(string[] args = null)
		{
			ServiceHost host = null;
			try
			{
				var baseUri = new Uri(@"http://localhost:8733/Design_Time_Addresses/plugin_host_service/Service1/");
				var baseUris = new Uri[]
				{
					baseUri
				};

				host = new ServiceHost(typeof(PluginHostService<BasePluginService>), baseUri);

				host.AddServiceEndpoint(typeof(IPluginHostServiceContract<BasePluginService>), new BasicHttpBinding(), "");

				var smb = new ServiceMetadataBehavior()
				{
					HttpGetEnabled = true,
					HttpsGetEnabled = true
				};
				host.Description.Behaviors.Add(smb);
				host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

				host.Open();

				return host;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error in hosting WCF: {ex.Message}");
				if (host != null && (host.State == CommunicationState.Opened || host.State == CommunicationState.Opening))
				{
					host.Close();
					host = null;
				}
			}

			return null;
		}
	}
}
