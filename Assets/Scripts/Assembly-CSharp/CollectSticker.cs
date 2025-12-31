using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CollectSticker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBottomBoardUp_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CollectSticker _003C_003E4__this;

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
		public _003CBottomBoardUp_003Ed__41(int _003C_003E1__state)
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
	private sealed class _003CStart_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CollectSticker _003C_003E4__this;

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
		public _003CStart_003Ed__26(int _003C_003E1__state)
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
	private sealed class _003CStickerCompleteParticle_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject target;

		public CollectSticker _003C_003E4__this;

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
		public _003CStickerCompleteParticle_003Ed__35(int _003C_003E1__state)
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

	private Transform lastChild;

	private Transform stickerTrail;

	private Transform PreviosStickerParticles;

	private GameObject target;

	private GameObject stickerHint;

	private bool isMouseDrag;

	private Vector3 offset;

	private bool TriggerEnter;

	private GameObject ButterFly;

	[Header("Sound - Sticker :")]
	public AudioClip StickerPickSound;

	public AudioClip DropRightSound;

	[SerializeField]
	private Transform ParentObj;

	[SerializeField]
	private Transform stickerParent;

	[SerializeField]
	private Transform cloneObjBottom;

	[SerializeField]
	private Button btnNext;

	[SerializeField]
	private Button btnPrevious;

	public static CollectSticker Instance;

	[SerializeField]
	private GameObject Logo;

	private WaitForSeconds TwoSecDelay;

	private WaitForSeconds ThreeSecDelay;

	private WaitForSeconds FiveSecDelay;

	private float scrollContentSize;

	private int Counter;

	private bool isBoardUp;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}

	private void AnimateLogo()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__26))]
	private IEnumerator Start()
	{
		return null;
	}

	private void SetStickersData()
	{
	}

	private bool IsSpecialSticker(string stickerName)
	{
		return false;
	}

	private void DisableLayoutAfterDelay()
	{
	}

	private void OnApplicationPause()
	{
	}

	private void OnApplicationFocus()
	{
	}

	private void FOCUS()
	{
	}

	[IteratorStateMachine(typeof(_003CStickerCompleteParticle_003Ed__35))]
	private IEnumerator StickerCompleteParticle(GameObject target)
	{
		return null;
	}

	public void OnNextButtonClick(Transform thisTransform)
	{
	}

	public void OnPreviousButtonClick(Transform thisTransform)
	{
	}

	private void setButtonVisibility()
	{
	}

	private void OnResultSuccessfully(GameObject objDrag, GameObject objDropOn, bool isAutoMove = false)
	{
	}

	[IteratorStateMachine(typeof(_003CBottomBoardUp_003Ed__41))]
	private IEnumerator BottomBoardUp()
	{
		return null;
	}

	public void HandHelpControl()
	{
	}

	private void OnObjectTouchStartEndEvent(GameObject objDrag, bool isStart, bool isPlaceOnWrong)
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 Pos)
	{
	}
}
