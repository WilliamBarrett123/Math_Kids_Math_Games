using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ShopPopUp : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CYoutubeVideoLink_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShopPopUp _003C_003E4__this;

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
		public _003CYoutubeVideoLink_003Ed__27(int _003C_003E1__state)
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

	private string SelectedGame;

	public static ShopPopUp Instance;

	[SerializeField]
	private Selectable _babyPhone2;

	[SerializeField]
	private Selectable _btnLearnTotal;

	[SerializeField]
	private Selectable __btn_ShopBook;

	[SerializeField]
	private Selectable _BabyGames;

	[SerializeField]
	private Selectable _musicGames;

	[SerializeField]
	private RectTransform GamesPage1;

	[SerializeField]
	private RectTransform LucasFriend;

	private string _currentToyName;

	private bool _isToyAvailable;

	[SerializeField]
	private GameObject _commonText;

	[SerializeField]
	private GameObject _WoodenText;

	[SerializeField]
	private GameObject _woodenToyPage2;

	[SerializeField]
	private GameObject TopPanel;

	[SerializeField]
	private GameObject _woodenToyAmazon;

	private Transform ButtonToEnable;

	private string CurrentVideoName;

	[SerializeField]
	private GameObject _kidsAppsPages;

	[SerializeField]
	private GameObject ShopContent;

	[SerializeField]
	private GameObject YoutubeContent;

	[SerializeField]
	private GameObject AppsContent;

	[SerializeField]
	private GameObject WoodenToyContent;

	[SerializeField]
	private Transform ButtonApps;

	[SerializeField]
	private Transform ButtonYoutube;

	[SerializeField]
	private Transform ButtonShop;

	[SerializeField]
	private Transform ButtonWoodenToys;

	private bool isFirstTime;

	private bool AllowInput;

	public string WoodenToysURLLink => null;

	public void onGameIconButtonClick(GameObject thisGameObject)
	{
	}

	public void OpenApplication()
	{
	}

	public void OnShopButtonClick(Transform thisGameObject)
	{
	}

	public void OnItemsButtonClick(Transform thisGameObject)
	{
	}

	private string GetUrlOfTheItem(string itemName)
	{
		return null;
	}

	private void OnApplicationPause(bool Pause)
	{
	}

	private void EnableButtonInteractable()
	{
	}

	public void OnVideosButtonClick(Transform thisGameObject)
	{
	}

	public void OpenYoutube()
	{
	}

	[IteratorStateMachine(typeof(_003CYoutubeVideoLink_003Ed__27))]
	public IEnumerator YoutubeVideoLink()
	{
		return null;
	}

	public void OnVisitButtonClick(GameObject thisGameObject)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 obj)
	{
	}

	private void Start()
	{
	}

	private void Awake()
	{
	}

	public void OnBtnCloseClick(GameObject thisgameobject)
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

	private void FadeWoodenToys()
	{
	}

	public void ScaleAnimation(Transform thisTransform, Action<bool> callback = null)
	{
	}

	public void OnToysButtonClick(Transform thisGameObject)
	{
	}

	private void WillOpenParentSectionPopUpOrNot(GameObject currentGameObject)
	{
	}

	private void FixPagesContents()
	{
	}
}
