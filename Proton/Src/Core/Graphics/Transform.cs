using System;

namespace Proton
{
	public class Transform
	{
		public Vector3 position;
		public Quaternion rotation;

		public Transform()
		{
			position = new Vector3();
			rotation = Quaternion.identity;
		}
	}
}
