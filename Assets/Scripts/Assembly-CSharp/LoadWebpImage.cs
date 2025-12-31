using UnityEngine;

public class LoadWebpImage : MonoBehaviour
{
	private bool isCheckEnableEveryTime;

	private bool isCheckedEnable;

	[SerializeField]
	private TextAsset AssignBytesFile;

	[SerializeField]
	private Sprite AssignSprite;

	private void OnEnable()
	{
	}

	public void ResetImagesAfterSet(TextAsset getAsset = null, Sprite getSprite = null)
	{
	}
}
