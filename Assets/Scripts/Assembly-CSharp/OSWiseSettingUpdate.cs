using UnityEngine;

public class OSWiseSettingUpdate : MonoBehaviour
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
	private bool isObjectDisableHuawei;

	[Header("Change Sprite")]
	[SerializeField]
	private bool isChangeSprite;

	[SerializeField]
	private Sprite spriteGoogle;

	[SerializeField]
	private Sprite spriteIOS;

	[SerializeField]
	private Sprite spriteAmazon;

	[SerializeField]
	private Sprite spriteWindowStore;

	[SerializeField]
	private Sprite spriteHuawei;

	[SerializeField]
	private bool isScriptDisableAndroidStore;

	private void OnEnable()
	{
	}
}
