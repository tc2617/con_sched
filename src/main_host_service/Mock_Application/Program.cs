using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mock_Application
{
	class Program
	{
		static AutoResetEvent _ManualReset;

		static void RunHost(object stateInfo)
		{
			ServiceHost host = null;
			host = plugin_host_service.CreateWCFService.Start();

			if (host == null)
			{
				Console.WriteLine("\n!!!\nPROGRAM FAILED");
				return;
			}

			if(host.State != CommunicationState.Opened)
			{
				host.Open();
			}

			Console.WriteLine("\n---\nPROGRAM RUNNING");

			_ManualReset.WaitOne();
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Console Testing Application for checking that a WCF Service is created correctly without using the app.config file.");
			Console.WriteLine("Starting the ServiceHost through code becomes necessary when the ServiceContract is a generic.\nSee: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/");

			_ManualReset = new AutoResetEvent(false);

			ThreadPool.QueueUserWorkItem(RunHost);

			Console.WriteLine("\nPROGRAM COMPLETE");
			Console.ReadLine();
			_ManualReset.Set();
		}
	}
}
