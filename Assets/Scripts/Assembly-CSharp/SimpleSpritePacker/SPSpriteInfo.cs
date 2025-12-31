using System;
using UnityEngine;

namespace SimpleSpritePacker
{
	[Serializable]
	public class SPSpriteInfo : IComparable<SPSpriteInfo>
	{
		public UnityEngine.Object source;

		public Sprite targetSprite;

		public string name => null;

		public Vector2 sizeForComparison => default(Vector2);

		public int CompareTo(SPSpriteInfo other)
		{
			return 0;
		}
	}
}
