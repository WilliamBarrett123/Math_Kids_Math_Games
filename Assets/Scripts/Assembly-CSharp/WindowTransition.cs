using UnityEngine;
using UnityEngine.UI;

public class WindowTransition : MonoBehaviour
{
	public GameObject WindowContent;

	public Image imgBlackBG;

	public bool doAnimateOnSpawn;

	public bool doAnimateOnDespawn;

	public bool doShowOpacityOnSpawn;

	public bool doShowOpacityOnDespawn;

	public bool RemoveOnDespawn;

	public bool ResetOnDespawn;

	public float DespawnAnimationDelay;

	public float DespawnDelay;

	private GameObject currentScreen;

	public bool doPlayTransitionSound;

	public void OnWindowSpawn()
	{
	}

	public void OnWindowDespawn()
	{
	}

	private void doAnimateDespawnDelay()
	{
	}
}
