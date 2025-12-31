using System.Collections.Generic;
using UnityEngine;

public class PlaySectionRandomSpawn : MonoBehaviour
{
	public static PlaySectionRandomSpawn instance;

	[SerializeField]
	private List<GameObject> interactableObjects;

	private int count;

	public GameObject HelpHand;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	private void SpawnRandomly()
	{
	}

	public void StopAll()
	{
	}
}
