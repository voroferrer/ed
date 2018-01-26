using NUnit.Framework;
using System;

namespace CVector
{
	[TestFixture ()]
	public class VectorTest
	{
		[Test]
		public void Sort (){
			int[] v = {12,9,15,7,13};
			Vector.Sort (v);
			CollectionAssert.AreEqual (new int[]{ 7, 9, 12, 13, 15 }, v);

		}
	}
}

