using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

public class Friends_Character_Anim : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CMoveSpotLightToOthercharacter_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Friends_Character_Anim _003C_003E4__this;

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
		public _003CMoveSpotLightToOthercharacter_003Ed__24(int _003C_003E1__state)
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
	private sealed class _003CStartAnimation_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Friends_Character_Anim _003C_003E4__this;

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
		public _003CStartAnimation_003Ed__23(int _003C_003E1__state)
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

		public Friends_Character_Anim _003C_003E4__this;

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
	private RectTransform _brody;

	[SerializeField]
	private RectTransform _lilly;

	[SerializeField]
	private RectTransform _ruby;

	private Friends_Characters _charactertoPlay;

	private Animator currentAnimation;

	public SkeletonGraphic _ruby_spine_Animation;

	public SkeletonGraphic _broady_spine_Animation;

	public SkeletonGraphic _lilly_spine_animation;

	[SerializeField]
	private Lucas_Room _mainRoomScreen;

	[SerializeField]
	private AudioSource _src_audio;

	[SerializeField]
	private AudioClip _lightFocus;

	private int Rubycounter;

	private int BrodyCounrter;

	private int LillyCounter;

	[IteratorStateMachine(typeof(_003CStartLightAnimation_003Ed__12))]
	public IEnumerator StartLightAnimation()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void SetRubyHiAnimation()
	{
	}

	private void _ruby_spine_Animation_Anim_Complete_callbacks(TrackEntry trackEntry)
	{
	}

	private void _broady_spine_Animation_Anim_Complete_callbacks(TrackEntry trackEntry)
	{
	}

	private void _lilly_spine_animation_Anim_Complete_callbacks(TrackEntry trackEntry)
	{
	}

	public Vector2 GetSpotLightPosition()
	{
		return default(Vector2);
	}

	public void StartCharacterAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CStartAnimation_003Ed__23))]
	private IEnumerator StartAnimation()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CMoveSpotLightToOthercharacter_003Ed__24))]
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
