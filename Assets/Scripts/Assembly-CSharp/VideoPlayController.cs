using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
public class VideoPlayController : MonoBehaviour
{
	public VideoPlayer player;

	public static event Action<VideoPlayer> OnVideoPlayCompleted
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

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Player_loopPointReached(VideoPlayer source)
	{
	}
}
