using DG.Tweening;
using UnityEngine;

public class GardenStateInfo : MonoBehaviour
{
	[HideInInspector]
	public Transform _Viewport;

	[HideInInspector]
	public Transform _Content;

	[HideInInspector]
	public int AnimCounter;

	[HideInInspector]
	public bool IsActivityFree;

	[HideInInspector]
	public Ease LineareaseType;

	public CharacterPrefix currentCharacterPrefix;

	public int characterActivityOffSet;

	private void Start()
	{
	}

	public void SetAltrnateParent(bool IsContent = false, ICharacter character = null)
	{
	}

	public void ReSpawnObjects(Status status, GameObject spwanObject, float scale = 1f)
	{
	}

	public static string GetActivityWithPrefix(ICharacter character, string activityName)
	{
		return null;
	}

	public static string GetActivitySongWithPrefix(ICharacter character, string activityName)
	{
		return null;
	}

	public void WhosePerformingActivityAndStatus(ICharacter character, bool activityStatus = false)
	{
	}

	protected void SetActivityLayer(GameObject thisActivityObject)
	{
	}
}
