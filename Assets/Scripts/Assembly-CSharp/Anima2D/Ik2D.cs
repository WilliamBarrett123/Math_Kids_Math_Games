using UnityEngine;

namespace Anima2D
{
	public abstract class Ik2D : MonoBehaviour
	{
		[SerializeField]
		private bool m_Record;

		[SerializeField]
		private Transform m_TargetTransform;

		[SerializeField]
		private int m_NumBones;

		[SerializeField]
		private float m_Weight;

		[SerializeField]
		private bool m_RestoreDefaultPose;

		[SerializeField]
		private bool m_OrientChild;

		private Bone2D m_CachedTarget;

		public IkSolver2D solver => null;

		public bool record => false;

		public Bone2D target
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int numBones
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

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

		public bool orientChild
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void OnDrawGizmos()
		{
		}

		private void OnValidate()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void SetAttachedIK(Ik2D ik2D)
		{
		}

		public void UpdateIK()
		{
		}

		protected virtual void OnIkUpdate()
		{
		}

		private void InitializeSolver()
		{
		}

		protected virtual int ValidateNumBones(int numBones)
		{
			return 0;
		}

		protected virtual void Validate()
		{
		}

		protected virtual void OnStart()
		{
		}

		protected virtual void OnUpdate()
		{
		}

		protected virtual void OnLateUpdate()
		{
		}

		protected abstract IkSolver2D GetSolver();
	}
}
