using System;

namespace mrroad.recommendations
{

	public class UserItems
	{
		public UserItems(){

		}

		private int[] _itemIds = new int[]{};

		public int[] itemIds 
		{
			get{ return _itemIds;}
			set{ _itemIds = value;} 
		}
	}
}
