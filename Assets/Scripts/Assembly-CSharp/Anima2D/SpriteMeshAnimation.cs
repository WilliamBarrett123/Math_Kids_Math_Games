using UnityEngine;

namespace Anima2D
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(SpriteMeshInstance))]
	public class SpriteMeshAnimation : MonoBehaviour
	{
		[SerializeField]
		private float m_Frame;

		[SerializeField]
		private SpriteMesh[] m_Frames;

		private int m_OldFrame;

		private SpriteMeshInstance m_SpriteMeshInstance;

		public SpriteMesh[] frames
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SpriteMeshInstance cachedSpriteMeshInstance => null;

		public int frame
		{
			get
			{
				return 0;
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
