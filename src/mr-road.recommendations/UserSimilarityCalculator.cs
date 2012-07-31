using System;

namespace mrroad.recommendations
{
	public class UserSimilarityCalculator
	{
		public UserSimilarityCalculator ()
		{
		}

		public double Calc (UserItems userA, UserItems userB)
		{
			int maxItemId = GetMaxItemId(userA, userB);

			int[] userAItemVector = GenerateItemIdVector(userA, maxItemId);
			int[] userBItemVector = GenerateItemIdVector(userB, maxItemId);

			var cosineSimilarityCalculator = new CosineSimilarityCalculator();
			var sim = cosineSimilarityCalculator.Calc(userAItemVector, userBItemVector);

			return sim;
		}

		int GetMaxItemId (UserItems userA, UserItems userB)
		{
			int max = 0;

			foreach (int id in userA.itemIds) {
				if(id > max){max = id;}
			}

			foreach (int id in userB.itemIds) {
				if(id > max){max = id;}
			}

			return max;
		}		

		int[] GenerateItemIdVector (UserItems userItems, int maxItemId)
		{
			int[] vector = new int[maxItemId];

			foreach (int id in userItems.itemIds)
			{
				//asumming no id=0
				vector[id-1] += 1;
			}

			return vector;
		}
	}
}


