using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using UnityEngine;

public class StampCollection : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDropStamp_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StampCollection _003C_003E4__this;

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
		public _003CDropStamp_003Ed__23(int _003C_003E1__state)
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

	public static StampCollection Instance;

	public AudioClip StampSound;

	public AudioClip StickerDropSound;

	private bool IsStempCollect;

	private int targetFingerId;

	private GameObject MainPanel;

	private GameObject SelectedStampObject;

	private GameObject TopMainPanel;

	private GameObject StampHelp;

	private Transform StampParticles;

	private Sprite StampTopPicture;

	private Sprite StampPicture;

	private XElement[] StampArray;

	private List<GameObject> ListOfStampObject;

	[SerializeField]
	private GameObject Logo;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void AnimateLogo()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTouchStart(Vector3 position, int fingerid)
	{
	}

	private GameObject ReturnClickedObjects(RaycastHit2D hit, Vector2 _touch, int fingerId)
	{
		return null;
	}

	private void OnDragObjectEnd(int fingerId)
	{
	}

	[IteratorStateMachine(typeof(_003CDropStamp_003Ed__23))]
	private IEnumerator DropStamp()
	{
		return null;
	}
}
