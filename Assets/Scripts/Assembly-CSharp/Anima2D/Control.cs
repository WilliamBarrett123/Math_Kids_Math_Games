using UnityEngine;

namespace Anima2D
{
	public class Control : MonoBehaviour
	{
		[SerializeField]
		private Transform m_BoneTransform;

		private Bone2D m_CachedBone;

		public Color color => default(Color);

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

		private void LateUpdate()
		{
		}
	}
}
