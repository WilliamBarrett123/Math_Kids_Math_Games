using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
	private static T instance;

	public static T Instance => null;

	private void Awake()
	{
	}
}
