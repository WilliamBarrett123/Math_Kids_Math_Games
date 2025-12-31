using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Family_Character_Anim : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CMoveSpotLightToOthercharacter_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Family_Character_Anim _003C_003E4__this;

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
		public _003CMoveSpotLightToOthercharacter_003Ed__16(int _003C_003E1__state)
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
	private sealed class _003CStartAnimation_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Family_Character_Anim _003C_003E4__this;

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
		public _003CStartAnimation_003Ed__15(int _003C_003E1__state)
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
	private sealed class _003CStartLightAnimation_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Family_Character_Anim _003C_003E4__this;

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
		public _003CStartLightAnimation_003Ed__12(int _003C_003E1__state)
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

	[SerializeField]
	private Transform _SpotLight;

	[SerializeField]
	private RectTransform _father;

	[SerializeField]
	private RectTransform _mother;

	[SerializeField]
	private RectTransform _grandpa;

	[SerializeField]
	private RectTransform _granny;

	[SerializeField]
	private RectTransform _babylucas;

	private Family_Characters _charactertoPlay;

	private Animator currentAnimation;

	[SerializeField]
	private Lucas_Room _mainRoomScreen;

	[SerializeField]
	private AudioSource _src_audio;

	[SerializeField]
	private AudioClip _lightFocus;

	public void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CStartLightAnimation_003Ed__12))]
	public IEnumerator StartLightAnimation()
	{
		return null;
	}

	public Vector2 GetSpotLightPosition()
	{
		return default(Vector2);
	}

	public void StartCharacterAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CStartAnimation_003Ed__15))]
	private IEnumerator StartAnimation()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CMoveSpotLightToOthercharacter_003Ed__16))]
	private IEnumerator MoveSpotLightToOthercharacter()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	public void resetSpotLight()
	{
	}
}
