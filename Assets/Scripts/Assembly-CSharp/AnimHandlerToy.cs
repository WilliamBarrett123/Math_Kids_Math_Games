using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AnimHandlerToy : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSpawnHandler_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnimHandlerToy _003C_003E4__this;

		private IEnumerator _003C_003E7__wrap1;

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
		public _003CSpawnHandler_003Ed__11(int _003C_003E1__state)
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

	[SerializeField]
	public AudioClip stickerEntry;

	[SerializeField]
	public AudioClip stickerEntry_Long;

	[SerializeField]
	private AudioClip stickerClick;

	[SerializeField]
	private GameObject particleEffect;

	private List<Transform> _CompletedList;

	[SerializeField]
	public AnimationCurve curve;

	public static AnimHandlerToy Instance;

	private int childCountForSound;

	private float SpeedMultiplayer;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CSpawnHandler_003Ed__11))]
	private IEnumerator SpawnHandler()
	{
		return null;
	}

	public void OnClick(GameObject thisGameObject)
	{
	}

	private void OnDisable()
	{
	}
}
