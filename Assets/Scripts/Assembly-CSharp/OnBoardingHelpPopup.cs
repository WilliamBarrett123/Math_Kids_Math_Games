using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class OnBoardingHelpPopup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003ConScreenAnim_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OnBoardingHelpPopup _003C_003E4__this;

		public bool isNextClick;

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
		public _003ConScreenAnim_003Ed__43(int _003C_003E1__state)
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

	public static OnBoardingHelpPopup Instance;

	[SerializeField]
	private GameObject screenContainer;

	[SerializeField]
	private GameObject Hand_ClickParent;

	private int currentPageCount;

	private List<EnumOnBoardingHelp> lstActiveTabs;

	[SerializeField]
	private Transform BottomButtonPanel;

	[SerializeField]
	private Animator RibbonAnimator;

	[SerializeField]
	private Animator cameraAnimtor;

	[SerializeField]
	private GameObject Lucas;

	[SerializeField]
	private GameObject Ruby;

	[SerializeField]
	private GameObject Father;

	[SerializeField]
	private GameObject Mother;

	[SerializeField]
	private GameObject closeButtonIcon;

	[SerializeField]
	private GameObject PlayICon;

	[SerializeField]
	private GameObject ConfettiMiddle;

	private bool doOnce;

	[SerializeField]
	private Transform txt_message;

	[SerializeField]
	private GameObject _parrentTextMessage;

	[SerializeField]
	private GameObject gm_1;

	[SerializeField]
	private GameObject gm_2;

	[SerializeField]
	private Text messageForParents;

	[SerializeField]
	private Text daveText;

	[SerializeField]
	private Text daveText2;

	[SerializeField]
	private Transform nextbtn;

	private string previousScreenName;

	private void Awake()
	{
	}

	private void SetParentTextMessage(Locale locale)
	{
	}

	private void ManageVideoButtonVisibility()
	{
	}

	private void Start()
	{
	}

	private void UpdateTextSizeAccordingToLanguage(Locale locale)
	{
	}

	private void AutoClose()
	{
	}

	private void SetMinTextFont()
	{
	}

	private void AnimateLucasRubyFunction()
	{
	}

	private void EnableClose()
	{
	}

	private void AnimateFatherMotherFunction()
	{
	}

	private void Reset()
	{
	}

	private void OnEnable()
	{
	}

	private void AnimateNextPrevious()
	{
	}

	private void OnDisable()
	{
	}

	public void OnScreenStatusUpdatedEventFire(bool isStatus, string screenName)
	{
	}

	private void SelectFirstSelectable()
	{
	}

	private void Object_Scale_Animation(Transform thisObject)
	{
	}

	public void onNextButtonClick(Transform thisObject)
	{
	}

	[IteratorStateMachine(typeof(_003ConScreenAnim_003Ed__43))]
	private IEnumerator onScreenAnim(bool isNextClick)
	{
		return null;
	}

	public void closeButton(Transform thisObject)
	{
	}

	public void onPlayVideoButtonClick(Transform thisObject)
	{
	}

	private void showMaskLayer(int pageCount)
	{
	}

	public void onPreviousButtonclick(Transform thisObject)
	{
	}

	public void ButtonOnOff(int currentPageNo)
	{
	}

	private EnumOnBoardingHelp GetActiveTab(int TabIndex)
	{
		return default(EnumOnBoardingHelp);
	}

	public bool OnBackButton()
	{
		return false;
	}

	private bool IsSecondPageAvailable()
	{
		return false;
	}

	public void ForEditorLocalization()
	{
	}
}
