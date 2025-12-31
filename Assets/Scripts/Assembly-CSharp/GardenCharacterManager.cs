using System;
using UnityEngine;

public class GardenCharacterManager : MonoBehaviour
{
	[SerializeField]
	private Transform[] characters;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void CharcterTriggerStatus(object sender, CharacterEventArgs characterArgs)
	{
	}

	private void SetCharacterDragStatus(object sender, Transform currentCharacter)
	{
	}

	private void SetCharacterEndDragStatus(object sender, EventArgs e)
	{
	}
}
