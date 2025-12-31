using System.Collections.Generic;
using UnityEngine;

namespace SimpleSpritePacker
{
	public class SPInstance : ScriptableObject
	{
		public enum PackingMethod
		{
			MaxRects = 0,
			Unity = 1
		}

		[SerializeField]
		private Texture2D m_Texture;

		[SerializeField]
		private int m_Padding;

		[SerializeField]
		private int m_MaxSize;

		[SerializeField]
		private PackingMethod m_PackingMethod;

		[SerializeField]
		private SpriteAlignment m_DefaultPivot;

		[SerializeField]
		private Vector2 m_DefaultCustomPivot;

		[SerializeField]
		private List<SPSpriteInfo> m_Sprites;

		[SerializeField]
		private List<SPAction> m_PendingActions;

		public Texture2D texture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int padding
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int maxSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public PackingMethod packingMethod
		{
			get
			{
				return default(PackingMethod);
			}
			set
			{
			}
		}

		public SpriteAlignment defaultPivot
		{
			get
			{
				return default(SpriteAlignment);
			}
			set
			{
			}
		}

		public Vector2 defaultCustomPivot
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public List<SPSpriteInfo> sprites => null;

		public List<SPSpriteInfo> copyOfSprites => null;

		public List<SPAction> pendingActions => null;

		public void ChangeSpriteSource(SPSpriteInfo spriteInfo, Object newSource)
		{
		}

		public void QueueAction_AddSprite(Object resource)
		{
		}

		public void QueueAction_AddSprites(Object[] resources)
		{
		}

		public void QueueAction_RemoveSprite(SPSpriteInfo spriteInfo)
		{
		}

		public void UnqueueAction(SPAction action)
		{
		}

		protected List<SPAction> GetAddSpriteActions()
		{
			return null;
		}

		protected List<SPAction> GetRemoveSpriteActions()
		{
			return null;
		}

		public void ClearSprites()
		{
		}

		public void AddSprite(SPSpriteInfo spriteInfo)
		{
		}

		public void ClearActions()
		{
		}

		public List<SPSpriteInfo> GetSpriteListWithAppliedActions()
		{
			return null;
		}
	}
}
