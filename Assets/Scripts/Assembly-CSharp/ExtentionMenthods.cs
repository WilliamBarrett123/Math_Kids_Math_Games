using System;
using System.Collections.Generic;
using UnityEngine;

public static class ExtentionMenthods
{
	public static class ThreadSafeRandom
	{
		[ThreadStatic]
		private static System.Random Local;

		public static System.Random ThisThreadsRandom => null;
	}

	public static bool OnWindowSpawned(this GameObject thisWindow)
	{
		return false;
	}

	public static bool OnWindowDepawned(this GameObject thisWindow)
	{
		return false;
	}

	public static void ResetRectTransform(this GameObject thisObject)
	{
	}

	public static void ResetRectTransformFB(this GameObject thisObject)
	{
	}

	public static AudioSource audioSource(this Transform thisObject)
	{
		return null;
	}

	public static int TryParseInt(this string Value, int defaultValueToReturn = 0)
	{
		return 0;
	}

	public static float TryParseFloat(this string Value, float defaultValueToReturn = 0f)
	{
		return 0f;
	}

	public static void SetLayerRecursively(this GameObject gameObject, int layer)
	{
	}

	public static void FadeInAlpha(this GameObject BlackBG, float time, float AlphaValue = 0.7f)
	{
	}

	public static void FadeOutAlpha(this GameObject BlackBG, float time, float delay = 0f, bool DestroyBlackBg = true)
	{
	}

	public static void Shuffle<T>(this IList<T> list)
	{
	}
}
