using ServiceStack.WebHost.Endpoints;
using System;
using mrroad.recommendations.api;

namespace mrroad.recommendations.api.host
{
	class MainClass
	{
		static void Main(string[] args)
		{
			var listeningOn = args.Length == 0 ? "http://*:1337/" : args[0];
			var appHost = new AppHost();
			appHost.Init();
			appHost.Start(listeningOn);

			Console.WriteLine("AppHost Created at {0}, listening on {1}", DateTime.Now, listeningOn);
			Console.ReadKey();
		}
	}
}
