using UnityEngine;

public class VisiblemodeListenr : MonoBehaviour, IVisibelModeListener<Transform>
{
	public VisibleModeNew visibleModeNew;

	[SerializeField]
	private GameObject Content;

	[SerializeField]
	private GameObject ButtontoActivate;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnbuttonClickEventraised(Transform data)
	{
	}
}
