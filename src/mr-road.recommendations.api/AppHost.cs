//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Web;
using ServiceStack.WebHost.Endpoints;
using Funq;
namespace mrroad.recommendations.api
{
	public class AppHost : AppHostHttpListenerBase 
    {
        //Tell Service Stack the name of your application and where to find your web services
        public AppHost() : base("Recommender Web Services", typeof(StatusService).Assembly) { }

        public override void Configure(Container container)
        {
            //register user-defined REST-ful urls
            Routes
				.Add<Status>("/status", "GET");
        }
    }
}
