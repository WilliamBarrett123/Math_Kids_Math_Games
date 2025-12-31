using System;
using UnityEngine;

namespace SimpleSpritePacker
{
	[Serializable]
	public class SPAction
	{
		public enum ActionType
		{
			Sprite_Add = 0,
			Sprite_Remove = 1
		}

		public ActionType actionType;

		public UnityEngine.Object resource;

		public SPSpriteInfo spriteInfo;
	}
}
