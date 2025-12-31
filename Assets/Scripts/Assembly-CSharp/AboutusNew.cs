using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class AboutusNew : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGetScrollData_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AboutusNew _003C_003E4__this;

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
		public _003CGetScrollData_003Ed__33(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CSetInActive_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AboutusNew _003C_003E4__this;

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
		public _003CSetInActive_003Ed__14(int _003C_003E1__state)
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

	public static AboutusNew Instance;

	[SerializeField]
	private GameObject ShortContent_page1_up_txt;

	[SerializeField]
	private GameObject FullContent_page1_up_txt;

	[SerializeField]
	private GameObject content2;

	[SerializeField]
	private Transform FullContent;

	[SerializeField]
	private Transform ShortContent;

	[SerializeField]
	private GameObject BottomInSpireText;

	public bool isComeFromSetting;

	private int CurrentPage;

	[SerializeField]
	private GameObject page1_dot;

	[SerializeField]
	private GameObject page2_dot;

	[SerializeField]
	private GameObject page3_dot;

	[SerializeField]
	private GameObject page4_dot;

	[SerializeField]
	private GameObject handle;

	[SerializeField]
	private GameObject PageContent;

	[SerializeField]
	private GameObject page1_story_Behind;

	[SerializeField]
	private ScrollRect scroll;

	[SerializeField]
	public Scrollbar _scrollbarPoint;

	private bool allowScrollMove;

	private bool FromEnable;

	[Space(20f)]
	[Header("New Variables")]
	[SerializeField]
	private GameObject VideoContainer;

	[SerializeField]
	private GameObject InpiringContent;

	[SerializeField]
	private GameObject ForParentContent;

	[SerializeField]
	private GameObject OurStoryContent;

	[SerializeField]
	private GameObject ShareIconParent;

	[SerializeField]
	private GameObject shareButton;

	[SerializeField]
	private Transform ButtonOurStory;

	[SerializeField]
	private Transform ButtonForParents;

	[SerializeField]
	private Transform ButtonInspire;

	[SerializeField]
	private RectTransform InspiringHeader;

	[SerializeField]
	private RectTransform InspiringText;

	[SerializeField]
	private RectTransform ForParentHeader;

	[SerializeField]
	private RectTransform ForParentText;

	private bool AllowInput;

	[SerializeField]
	private RectTransform OurStoryHeader1;

	[SerializeField]
	private RectTransform OurStoryHeader2;

	[SerializeField]
	private RectTransform OurStoryHeader3;

	[SerializeField]
	private RectTransform OurStoryHeader4;

	public void ForEditorLocalization()
	{
	}

	private void OnEnable()
	{
	}

	private void CheckReviewConditions()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void SetTextArrangements()
	{
	}

	private void SetOurStoryScreen()
	{
	}

	[IteratorStateMachine(typeof(_003CSetInActive_003Ed__14))]
	private IEnumerator SetInActive()
	{
		return null;
	}

	public void OnVideoButtonClick(GameObject thisgameobject)
	{
	}

	public void OnBtnCloseClick(GameObject thisgameobject)
	{
	}

	public void OnShareButtonClick(GameObject thisgameobject)
	{
	}

	private void onNativeButtonPress()
	{
	}

	public void shareOurStory(Transform transform)
	{
	}

	public void OnCurrentValuechanged(int current)
	{
	}

	[IteratorStateMachine(typeof(_003CGetScrollData_003Ed__33))]
	private IEnumerator GetScrollData()
	{
		return null;
	}

	public void GetRect(Vector2 current)
	{
	}

	public void ForceCurserMove()
	{
	}

	public void PageAnimationMove(bool isdown)
	{
	}

	private void Awake()
	{
	}

	public void HeaderButtonClick(Transform transform)
	{
	}

	private void AdjustBottomPanelContent(Transform transform)
	{
	}

	private void AdjustTopPanel(Transform transform)
	{
	}

	private void CheckLanguageWiseAvailableSection()
	{
	}

	private void ManageVideoContainer()
	{
	}

	private void ModifyThirdContainer()
	{
	}

	private void ModifySecondContainer()
	{
	}

	public void ScaleAnimation(Transform thisTransform, Action<bool> callback = null)
	{
	}

	private void ScrollToRect(ScrollRect scrollRect, RectTransform target, RectTransform content)
	{
	}
}
