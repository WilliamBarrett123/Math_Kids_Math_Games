using System;
using System.Collections.Generic;
using Spine.Unity;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
	[Serializable]
	public struct SpineCharcterInfo
	{
		public SkeletonGraphic skeletonGraphic;

		public string[] AnimatioName;

		public AudioClip[] audioClip;
	}

	[SerializeField]
	public SpineCharcterInfo[] _Characters;

	public Dictionary<string, SpineCharcterInfo> characterInfoDictionary;

	private SkeletonGraphic DefaultLucasSkeleton;

	[SerializeField]
	public AudioSource audioSource;

	[SerializeField]
	public RectTransform mainConatiner;

	private readonly string Toran_Touch;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void ChacterButtonClick(Transform _Character)
	{
	}

	public void PlaySpecificAnimation(string _AnimationName, SkeletonGraphic _SkeletonGraphic = null, bool Isloop = false)
	{
	}

	public void PlayAndAddAnimation(List<string> AnimationList, SkeletonGraphic _SkeletonGraphic = null, bool Isloop = false)
	{
	}

	public void AddAnimation(string Animationname, SkeletonGraphic _SkeletonGraphic = null, bool Isloop = false)
	{
	}

	public float GetAnimationDuartion(SkeletonGraphic _SkeletonGraphic = null)
	{
		return 0f;
	}

	public void ChangeSpriteOnButtonClick_valentineTheme(Transform thisTransForm)
	{
	}

	public void ChangeSpriteOnButtonClick(Transform thisTransForm)
	{
	}

	private SkeletonGraphic CheckSkeltonGraphicISnull(SkeletonGraphic _skeletonGraphic)
	{
		return null;
	}

	private T[] RotateArray<T>(T[] arr)
	{
		return null;
	}

	public void ClearTrack(SkeletonGraphic _skeletonGraphic)
	{
	}
}
