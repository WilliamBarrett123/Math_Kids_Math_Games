using UnityEngine;

namespace Anima2D
{
	public class SpriteMesh : ScriptableObject
	{
		public const int api_version = 4;

		[HideInInspector]
		[SerializeField]
		private int m_ApiVersion;

		[SerializeField]
		private Sprite m_Sprite;

		[SerializeField]
		private Mesh m_SharedMesh;

		[SerializeField]
		[HideInInspector]
		private Material[] m_SharedMaterials;

		public Sprite sprite
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Mesh sharedMesh
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}
	}
}
