using UnityEngine;

namespace Anima2D
{
	public class IkCCD2D : Ik2D
	{
		public int iterations;

		[Range(0f, 1f)]
		public float damping;

		[SerializeField]
		private IkSolver2DCCD m_Solver;

		protected override IkSolver2D GetSolver()
		{
			return null;
		}

		protected override void OnIkUpdate()
		{
		}
	}
}
