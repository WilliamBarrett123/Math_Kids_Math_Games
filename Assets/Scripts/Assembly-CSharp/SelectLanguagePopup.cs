using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SelectLanguagePopup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDisableAndEnableCanvasAfterTime_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SelectLanguagePopup _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDisableAndEnableCanvasAfterTime_003Ed__28(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public static SelectLanguagePopup Instance;

	[SerializeField]
	private Transform Content_Filtered;

	[SerializeField]
	private Transform Content_All;

	[SerializeField]
	private Transform ScrollParent;

	[SerializeField]
	private Transform btnContinue;

	[SerializeField]
	private Transform btnOtherLang;

	[SerializeField]
	private Transform btnEnglishLang;

	[SerializeField]
	private Transform ScrollContent;

	[SerializeField]
	private Transform CloneObject;

	[SerializeField]
	private Transform btn_close;

	[SerializeField]
	private Color selectedMainColor;

	[SerializeField]
	private Color SelectedSubColor;

	[SerializeField]
	private Color defaultMainColor;

	[SerializeField]
	private Color defaultSubColor;

	private string DeviceLanguage;

	public Text Title;

	public Text title_filtered;

	public Text title_All;

	public bool isIndianLangugae;

	private string detectedRegion;

	public Font defaultFont;

	[SerializeField]
	private GameObject translationFeedback;

	[SerializeField]
	private GridLayoutGroup Content_All_gridlayout;

	private GameObject MainScreen;

	[HideInInspector]
	public bool isfromMain;

	private Text Txt_main;

	private string SelectedLANCode;

	private Transform selectedItemForScroll;

	[SerializeField]
	private GameObject topShadow;

	[SerializeField]
	private GameObject bottomShadow;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CDisableAndEnableCanvasAfterTime_003Ed__28))]
	private IEnumerator DisableAndEnableCanvasAfterTime()
	{
		return null;
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 obj)
	{
	}

	private void UpdateLanguagePoPUpUI()
	{
	}

	private void UpdateLayout()
	{
	}

	private void FillLanguagesButtons()
	{
	}

	private void EnableLayoutAfterDelay()
	{
	}

	private void GenerateLanguageBlock(Locale currentLC, Transform parent)
	{
	}

	private void SetSelectedItem(string TappedItemCode, bool isFromStart = false)
	{
	}

	private void SetTextColor(bool isSelected, Transform currentItem)
	{
	}

	private void ScrollToSelectedItem()
	{
	}

	public void OnButtonEnglishLangClick(Transform thisTransform)
	{
	}

	public void OnButtonOtherLangClick(Transform thisTransform)
	{
	}

	public void OnButtonLanguageItemClick(Transform thisTransform)
	{
	}

	public void OnContinueButtonClick(Transform thisObjest)
	{
	}

	public void OnBackbuttonClicked(Transform PressedButton)
	{
	}

	public void OnScrollValueChanged(Vector2 value)
	{
	}

	private void OnClose()
	{
	}

	private void OnCloseBtnEnglishSet()
	{
	}

	private void OnLocaleChanged(Locale locale)
	{
	}

	private void OnDisable()
	{
	}

	private void OnDownloadAssetBundle(string bundle)
	{
	}

	private void SetKeyboardNavigations()
	{
	}

	private void AddIntoSelectableList(GameObject selectableGameobject, bool IsAddInDefault = false)
	{
	}

	private void SetButtonNavigationsDirections(Transform TempTransform)
	{
	}

	public void onTranslationFeedbackButtonClicked(Transform thisTransform)
	{
	}

	public void OnBackButton()
	{
	}
}
