using UnityEngine;

namespace Anima2D
{
	public class IkLimb2D : Ik2D
	{
		public bool flip;

		[SerializeField]
		private IkSolver2DLimb m_Solver;

		protected override IkSolver2D GetSolver()
		{
			return null;
		}

		protected override void Validate()
		{
		}

		protected override int ValidateNumBones(int numBones)
		{
			return 0;
		}

		protected override void OnIkUpdate()
		{
		}

		private void OnValidate()
		{
		}
	}
}
