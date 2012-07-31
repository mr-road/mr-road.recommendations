using NUnit.Framework;
using mrroad.recommendations;
using System;

namespace mrroad.recommendations.tests.unit
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void TestCase1 ()
		{
			double expected = 1.0;
			int[] i = {0,0,0,0};
			int[] j = {0,0,0,0};
			var calc = new CosineSimilarityCalculator();
			var sim = calc.Calc(i, j);
			Assert.That(sim, Is.EqualTo(expected));
		}

		[Test()]
		public void TestCase2 ()
		{
			double expected = 0.0;
			int[] i = {0};
			int[] j = {1};
			var calc = new CosineSimilarityCalculator();
			var sim = calc.Calc(i, j);
			Assert.That(sim, Is.EqualTo(expected));
		}

		[Test()]
		public void TestCase3 ()
		{
			double expected = 1.0/2.0;
			int[] i = {1,1};
			int[] j = {0,1};
			var calc = new CosineSimilarityCalculator();
			var sim = calc.Calc(i, j);
			Assert.That(sim, Is.EqualTo(expected));
		}

		[Test()]
		public void TestCase4 ()
		{	
			double expected = 1.0/3.0;
			int[] i = {1,1,0,1};
			int[] j = {0,1,0,1};
			var calc = new CosineSimilarityCalculator();
			var sim = calc.Calc(i, j);

			Assert.That(sim, Is.EqualTo(expected));
		}
	}
}

