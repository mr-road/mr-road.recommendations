using NUnit.Framework;
using System;

namespace mrroad.recommendations.tests.unit
{
	[TestFixture()]
	public class UserSimilarityCalculatorTests
	{
		[Test()]
		public void TestCase1 ()
		{
			double expected = 1;
			UserItems userA = new UserItems();
			UserItems userB = new UserItems();

			double sim = new UserSimilarityCalculator().Calc(userA, userB);

			Assert.That(sim, Is.EqualTo (expected));
		}

		[Test()]
		public void TestCase2 ()
		{
			double expected = 0;
			UserItems userA = new UserItems{itemIds = new[]{1}};
			UserItems userB = new UserItems();

			double sim = new UserSimilarityCalculator().Calc(userA, userB);

			Assert.That(sim, Is.EqualTo (expected));
		}

		[Test()]
		public void TestCase3 ()
		{
			double expected = 1.0/2.0;
			UserItems userA = new UserItems{itemIds =  new[]{1, 2}};
			UserItems userB = new UserItems{itemIds = new[]{2}};

			double sim = new UserSimilarityCalculator().Calc(userA, userB);

			Assert.That(sim, Is.EqualTo(expected));
		}

		[Test()]
		public void TestCase4 ()
		{
			double expected = 1.0/3.0;
			UserItems userA = new UserItems{itemIds = new[]{1, 2, 4}};
			UserItems userB = new UserItems{itemIds = new[]{2, 4}};

			double sim = new UserSimilarityCalculator().Calc(userA, userB);

			Assert.That(sim, Is.EqualTo(expected));
		}
	}
}

