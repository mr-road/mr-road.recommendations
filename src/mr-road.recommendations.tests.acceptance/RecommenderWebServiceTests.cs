using NUnit.Framework;
using ServiceStack.WebHost.Endpoints;
using ServiceStack.ServiceInterface;
using System;
using mrroad.recommendations.api;
using System.Net;

namespace mrroad.recommendations.tests.acceptance
{
	[TestFixture()]
	public class RecommenderWebServiceTests
	{
		[TestFixtureSetUp]
		public void FixtureSetup(){
			var listeningOn = "http://*:1338/";
			var appHost = new AppHost();
			appHost.Init();
			appHost.Start(listeningOn);
		}

		[Test()]
		public void Returns200 ()
		{
			var webRequest = (HttpWebRequest)WebRequest.Create("http://localhost:1338/status");
			webRequest.Method = "GET";

			HttpWebResponse  rep = (HttpWebResponse)webRequest.GetResponse();

			Assert.That(rep.StatusCode, Is.EqualTo (HttpStatusCode.OK));
		}

		[Test()]
		public void Returns503(){}
		[Test()]
		public void ReturnsAUserProductRecommendation(){}
		[Test()]
		public void ReturnsAProductProductReccomendation(){}
		[Test()]
		public void ReturnsNeighbouringUser(){}
		[Test()]
		public void ReturnsA(){}
		[Test()]
		public void ReturnsB(){}
	}
}

