using System;
using System.Collections.Generic;
using UnityEngine;

namespace Anima2D
{
	[Serializable]
	public abstract class IkSolver2D
	{
		[Serializable]
		public class SolverPose
		{
			[SerializeField]
			private Transform m_BoneTransform;

			private Bone2D m_CachedBone;

			public Vector3 solverPosition;

			public Quaternion solverRotation;

			public Quaternion defaultLocalRotation;

			public Bone2D bone
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public void StoreDefaultPose()
			{
			}

			public void RestoreDefaultPose()
			{
			}
		}

		[SerializeField]
		private Transform m_RootBoneTransform;

		[SerializeField]
		private List<SolverPose> m_SolverPoses;

		[SerializeField]
		private float m_Weight;

		[SerializeField]
		private bool m_RestoreDefaultPose;

		private Bone2D m_CachedRootBone;

		public Vector3 targetPosition;

		public Bone2D rootBone
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public List<SolverPose> solverPoses => null;

		public float weight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool restoreDefaultPose
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void Initialize(Bone2D _rootBone, int numChilds)
		{
		}

		public void Update()
		{
		}

		public void StoreDefaultPoses()
		{
		}

		public void RestoreDefaultPoses()
		{
		}

		private void UpdateBones()
		{
		}

		protected abstract void DoSolverUpdate();
	}
}
