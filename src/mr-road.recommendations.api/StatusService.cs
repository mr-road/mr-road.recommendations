using System;
using ServiceStack.ServiceInterface;
using ServiceStack.WebHost.Endpoints;

namespace mrroad.recommendations.api
{

	public class StatusService : ServiceBase<Status> 
	{
		protected override object Run(Status request) 
		{
			return new StatusResponse ();
		}
	}
}

