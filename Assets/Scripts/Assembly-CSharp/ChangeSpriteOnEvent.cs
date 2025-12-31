using UnityEngine;

public class ChangeSpriteOnEvent : MonoBehaviour
{
	public Sprite[] lstofImages;

	public int CurrentIndex;

	[SerializeField]
	private Transform Object;

	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private AudioClip[] Clip;

	public void OnImageChangebuttonClick()
	{
	}

	public void PlayClip()
	{
	}

	private AudioClip[] RotateArray(AudioClip[] arr)
	{
		return null;
	}
}
