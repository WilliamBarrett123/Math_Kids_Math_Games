using System;
using UnityEngine;

namespace Anima2D
{
	[Serializable]
	public class IkSolver2DCCD : IkSolver2D
	{
		public int iterations;

		public float damping;

		protected override void DoSolverUpdate()
		{
		}

		private Vector3 RotatePositionFrom(Vector3 position, Vector3 pivot, Quaternion rotation)
		{
			return default(Vector3);
		}
	}
}
