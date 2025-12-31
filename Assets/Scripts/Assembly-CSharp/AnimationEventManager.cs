using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AnimationEventManager : MonoBehaviour
{
	public static event Action<string> OnAnimationEventFire
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void OnHitAnimationEvent(string param)
	{
	}
}
