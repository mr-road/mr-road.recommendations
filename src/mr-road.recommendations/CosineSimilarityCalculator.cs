using System;

namespace mrroad.recommendations
{
	public class CosineSimilarityCalculator
	{
		public CosineSimilarityCalculator ()
		{
		}

		public double Calc (int[] a, int[] b)
		{
			//http://en.wikipedia.org/wiki/Cosine_similarity

			double dotProduct = 0;
			double absVectorA = 0;
			double absVectorB = 0;

			for (int i = 0; i < a.Length; i++)
			{
				dotProduct += a [i] * b [i];
				absVectorA += a[i] * a[i];
				absVectorB += b[i] * b[i];
			}
			if ((absVectorA + absVectorB) == 0)
			{
				return 1;
			}
			else if(dotProduct == 0)
			{
				return 0;
			}

			return dotProduct / (Math.sqrt(absVectorA) * Math.sqrt(absVectorB));
		}
	}
}

