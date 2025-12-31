using UnityEngine;

public class DualPlayerDifficultyScreen : MonoBehaviour
{
	[SerializeField]
	private Transform btn_1;

	[SerializeField]
	private Transform btn_2;

	[SerializeField]
	private Transform btn_3;

	[SerializeField]
	private Transform btn_4;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnDifficultyButtonClick(Transform thisTransform)
	{
	}

	private void SetData(string selectedType = "")
	{
	}

	public void OnPlayButtonClick(Transform thisTransform)
	{
	}

	public void OnCloseButtonClick(Transform thisTransform)
	{
	}
}
