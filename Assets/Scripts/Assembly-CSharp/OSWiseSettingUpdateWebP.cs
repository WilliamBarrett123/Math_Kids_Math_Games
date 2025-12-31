using UnityEngine;

public class OSWiseSettingUpdateWebP : MonoBehaviour
{
	[SerializeField]
	private GameObject thisGameObject;

	[Header("Show Button")]
	[SerializeField]
	private bool isObjectDisable;

	[SerializeField]
	private bool isObjectDisableGoogle;

	[SerializeField]
	private bool isObjectDisableiOS;

	[SerializeField]
	private bool isObjectDisableAmazon;

	[SerializeField]
	private bool isObjectDisableWindowStore;

	[SerializeField]
	[Header("Change Sprite")]
	private bool isChangeSprite;

	[SerializeField]
	private TextAsset spriteGoogle;

	[SerializeField]
	private TextAsset spriteIOS;

	[SerializeField]
	private TextAsset spriteAmazon;

	[SerializeField]
	private bool isScriptDisableWindowsStore;

	private void OnEnable()
	{
	}
}
