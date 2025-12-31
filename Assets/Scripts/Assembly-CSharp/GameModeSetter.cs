using System;
using System.Collections.Generic;
using UnityEngine;

public class GameModeSetter : MonoBehaviour
{
	[Serializable]
	public class PositionSetter
	{
		public Vector3 rectPosition;

		public Transform parent;
	}

	public List<PositionSetter> lstofPosition;

	private Vector2 sizeDelta;

	private Vector2 anchorMin;

	private Vector2 anchorMax;

	private Vector2 pivot;

	public List<GameObject> lstOfGameMode;
}
