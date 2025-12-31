using UnityEngine;

namespace Anima2D
{
	public class Bone2D : MonoBehaviour
	{
		[SerializeField]
		private Color m_Color;

		[SerializeField]
		private float m_Length;

		[HideInInspector]
		[SerializeField]
		private Transform m_ChildTransform;

		[SerializeField]
		private Ik2D m_AttachedIK;

		private Bone2D m_CachedChild;

		private Bone2D m_ParentBone;

		public Ik2D attachedIK
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Bone2D child
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 localEndPosition => default(Vector3);

		public Vector3 endPosition => default(Vector3);

		public float localLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float length => 0f;

		public Bone2D parentBone => null;

		public Bone2D linkedParentBone => null;

		public Bone2D root => null;

		public Bone2D chainRoot => null;

		public int chainLength => 0;

		public static Bone2D GetChainBoneByIndex(Bone2D chainTip, int index)
		{
			return null;
		}

		private void OnDrawGizmos()
		{
		}
	}
}
