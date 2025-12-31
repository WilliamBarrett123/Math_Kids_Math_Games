using System.Collections.Generic;
using UnityEngine;

namespace Anima2D
{
	[ExecuteInEditMode]
	public class SpriteMeshInstance : MonoBehaviour
	{
		[SerializeField]
		private SpriteMesh m_SpriteMesh;

		[SerializeField]
		private Color m_Color;

		[SerializeField]
		private Material[] m_Materials;

		[SerializeField]
		private int m_SortingLayerID;

		[SerializeField]
		private int m_SortingOrder;

		[SerializeField]
		[HideInInspector]
		private Transform[] m_BoneTransforms;

		private List<Bone2D> m_CachedBones;

		private MaterialPropertyBlock m_MaterialPropertyBlock;

		private Renderer mCachedRenderer;

		private MeshFilter mCachedMeshFilter;

		private SkinnedMeshRenderer mCachedSkinnedRenderer;

		private Mesh m_InitialMesh;

		private Mesh m_CurrentMesh;

		public SpriteMesh spriteMesh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material sharedMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material[] sharedMaterials
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

		public int sortingLayerID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string sortingLayerName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int sortingOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<Bone2D> bones
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private MaterialPropertyBlock materialPropertyBlock => null;

		public Renderer cachedRenderer => null;

		public MeshFilter cachedMeshFilter => null;

		public SkinnedMeshRenderer cachedSkinnedRenderer => null;

		private Texture2D spriteTexture => null;

		public Mesh sharedMesh => null;

		public Mesh mesh => null;

		private void OnDestroy()
		{
		}

		private void Awake()
		{
		}

		private void UpdateInitialMesh()
		{
		}

		private void UpdateCurrentMesh()
		{
		}

		private void SetSpriteUVs(Mesh mesh, Sprite sprite)
		{
		}

		private void UpdateRenderers()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnWillRenderObject()
		{
		}
	}
}
