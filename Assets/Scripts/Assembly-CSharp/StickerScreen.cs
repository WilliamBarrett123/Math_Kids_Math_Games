using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

public class StickerScreen : Singleton<StickerScreen>, IDragHandler, IEventSystemHandler, IBeginDragHandler
{
	[CompilerGenerated]
	private sealed class _003CSetAnimation_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StickerScreen _003C_003E4__this;

		private int _003Cnum_003E5__2;

		private IEnumerator _003C_003E7__wrap2;

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
		public _003CSetAnimation_003Ed__19(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public string DefaultButtonOpen;

	[SerializeField]
	private GameObject BtnContainer;

	[SerializeField]
	private GameObject ScreenContainer;

	[SerializeField]
	private GameObject ScreenDotContainer;

	[SerializeField]
	private GameObject CertificateContainer;

	[SerializeField]
	private GameObject btnClose;

	[SerializeField]
	private GameObject Toybadge;

	[SerializeField]
	private GameObject Stickerbadge;

	[HideInInspector]
	public string selectedButton;

	private GameObject _SelectedScreen;

	private GameObject _SelectedScreenDotObj;

	private XElement[] StickerArray;

	private XElement[] ToyArray;

	private XElement[] StampArray;

	private Vector2 touchDownPos;

	private Vector2 SwipeMovePosition;

	private int direction;

	private float _defaultContainerWidth;

	private float _lastSwipePos;

	private void Start()
	{
	}

	public void autoScrollCertificates()
	{
	}

	public void onCloseButtonClick()
	{
	}

	public void onCategoryButtonClick(GameObject Btn)
	{
	}

	private void showOrHideStickerCategory(string btnName)
	{
	}

	[IteratorStateMachine(typeof(_003CSetAnimation_003Ed__19))]
	private IEnumerator SetAnimation()
	{
		return null;
	}

	private void CertificateBtnselectedSet()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnScreenStatusUpdatedEventFire(bool isStatus, string screenName)
	{
	}

	void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
	{
	}

	void IDragHandler.OnDrag(PointerEventData eventData)
	{
	}

	private void OnSwipe(int SwipeDirection)
	{
	}

	private void DisableDotScreen(string name, bool Value = false)
	{
	}

	private void StartAnimation()
	{
	}

	public void RefreshSelectableList()
	{
	}

	private void AddSelectableInListForNavigation()
	{
	}

	private void ClearSelectableList()
	{
	}

	private void AddExplicitNavigation(Transform TempTransform, string SelectedObj, int Index = 0, int TotalCount = 0)
	{
	}

	private void FindChildObject(Transform parentTransform, string ChildName, float TotalCount, float RowID)
	{
	}

	private void AddSelectScrollComponent(GameObject selectableGameobject, float TotalCount, float RowID)
	{
	}

	private void AddIntoSelectableList(GameObject selectableGameobject)
	{
	}
}
