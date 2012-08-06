using System;
using System.Runtime.Serialization;
using ServiceStack.ServiceHost;

namespace mrroad.recommendations.api
{
	public class StatusResponse
	{
		public Status Status {get; set;}
	}

	public class Status{
		public string stat {get;set;}
	}
}

