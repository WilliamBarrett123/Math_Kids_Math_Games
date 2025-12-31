using System;
using UnityEngine;

[Serializable]
public class ObjectData
{
	public string key;

	public GameObject objectPrefab;

	public AudioClip objectSound;

	public Vector3 objectPosition;

	public Vector3 ParticlesPosition;

	public bool isAnimal;
}
