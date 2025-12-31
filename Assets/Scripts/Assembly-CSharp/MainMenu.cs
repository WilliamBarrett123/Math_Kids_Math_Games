using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : Singleton<MainMenu>
{
	public enum ModeName
	{
		AdditionModes = 0,
		SubstractionModes = 1,
		FunMode = 2,
		None = 3
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass223_0
	{
		public Transform displayTextTransform;

		public Vector3 pointZero;

		public TweenCallback _003C_003E9__0;

		internal void _003CDisplayChangeLanguageCount_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CButterflyAnimation_003Ed__118 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CButterflyAnimation_003Ed__118(int _003C_003E1__state)
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
	private sealed class _003CDelayOpenApplication_003Ed__218 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string URL;

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
		public _003CDelayOpenApplication_003Ed__218(int _003C_003E1__state)
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
	private sealed class _003CDisplayChangeLanguageCount_003Ed__223 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

		private _003C_003Ec__DisplayClass223_0 _003C_003E8__1;

		private Text _003CdisplayNumber_003E5__2;

		private Vector3 _003CpointOne_003E5__3;

		private int _003Ci_003E5__4;

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
		public _003CDisplayChangeLanguageCount_003Ed__223(int _003C_003E1__state)
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
	private sealed class _003CEnableButtonClick_003Ed__103 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CEnableButtonClick_003Ed__103(int _003C_003E1__state)
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
	private sealed class _003CLoadAddExamMode_003Ed__193 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CLoadAddExamMode_003Ed__193(int _003C_003E1__state)
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
	private sealed class _003CLoadAddItUpMode_003Ed__195 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CLoadAddItUpMode_003Ed__195(int _003C_003E1__state)
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
	private sealed class _003CLoadAddLearning_003Ed__191 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CLoadAddLearning_003Ed__191(int _003C_003E1__state)
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
	private sealed class _003CLoadAddSubUFOMode_003Ed__197 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CLoadAddSubUFOMode_003Ed__197(int _003C_003E1__state)
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
	private sealed class _003CLoadAdditionPuzzleMode_003Ed__183 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CLoadAdditionPuzzleMode_003Ed__183(int _003C_003E1__state)
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
	private sealed class _003CLoadAdditionPyramidMode_003Ed__203 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CLoadAdditionPyramidMode_003Ed__203(int _003C_003E1__state)
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
	private sealed class _003CLoadCarMode_003Ed__188 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CLoadCarMode_003Ed__188(int _003C_003E1__state)
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
	private sealed class _003CLoadCarryForwardAdditionMode_003Ed__201 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CLoadCarryForwardAdditionMode_003Ed__201(int _003C_003E1__state)
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
	private sealed class _003CLoadCrossMath_003Ed__181 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CLoadCrossMath_003Ed__181(int _003C_003E1__state)
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
	private sealed class _003CLoadDualPlayerMode_003Ed__194 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CLoadDualPlayerMode_003Ed__194(int _003C_003E1__state)
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
	private sealed class _003CLoadFishingMode_003Ed__186 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CLoadFishingMode_003Ed__186(int _003C_003E1__state)
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
	private sealed class _003CLoadFunSnowMode_003Ed__187 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CLoadFunSnowMode_003Ed__187(int _003C_003E1__state)
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
	private sealed class _003CLoadMatchObjectMode_003Ed__182 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CLoadMatchObjectMode_003Ed__182(int _003C_003E1__state)
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
	private sealed class _003CLoadMinMaxMode_003Ed__189 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CLoadMinMaxMode_003Ed__189(int _003C_003E1__state)
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
	private sealed class _003CLoadSubExamMode_003Ed__190 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CLoadSubExamMode_003Ed__190(int _003C_003E1__state)
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
	private sealed class _003CLoadSubLearnMode_003Ed__192 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CLoadSubLearnMode_003Ed__192(int _003C_003E1__state)
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
	private sealed class _003CLoadSubtractionPuzzleMode_003Ed__184 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CLoadSubtractionPuzzleMode_003Ed__184(int _003C_003E1__state)
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
	private sealed class _003CLoadSudokuMode_003Ed__196 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CLoadSudokuMode_003Ed__196(int _003C_003E1__state)
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
	private sealed class _003CLoadVendingMachineMode_003Ed__185 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CLoadVendingMachineMode_003Ed__185(int _003C_003E1__state)
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
	private sealed class _003CLoadWordProblemMode_003Ed__199 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CLoadWordProblemMode_003Ed__199(int _003C_003E1__state)
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
	private sealed class _003COnStartLogoAndTitleCalledFromLanguagePopUpClose_003Ed__116 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003COnStartLogoAndTitleCalledFromLanguagePopUpClose_003Ed__116(int _003C_003E1__state)
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
	private sealed class _003CPlayDoubleDigitGame_003Ed__235 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CPlayDoubleDigitGame_003Ed__235(int _003C_003E1__state)
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
	private sealed class _003CPlayLucasRoomLightAnimation_003Ed__244 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CPlayLucasRoomLightAnimation_003Ed__244(int _003C_003E1__state)
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
	private sealed class _003CPlayPracticeGame_003Ed__231 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CPlayPracticeGame_003Ed__231(int _003C_003E1__state)
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
	private sealed class _003CShowLanguageDownloadedScreen_003Ed__215 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CShowLanguageDownloadedScreen_003Ed__215(int _003C_003E1__state)
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

	public GameObject FunSnowMode;

	public GameObject CrossMathMode;

	public GameObject MatchMode;

	public GameObject MinMaxMode;

	public GameObject AddPuzzleMode;

	public GameObject AddExamMode;

	public GameObject AddLearningMode;

	public GameObject SubPuzzleMode;

	public GameObject SubExamMode;

	public GameObject SubLearningMode;

	public GameObject AddPractice;

	public GameObject SubPractice;

	public GameObject DoubleDigitAdd;

	public GameObject DoubleDigitSub;

	public GameObject VenderMachine;

	public GameObject Fishing;

	public GameObject FunCarMode;

	public GameObject DualPlayerMode;

	public GameObject AddItUpMode;

	public GameObject SudokuMode;

	public GameObject AddSubUFOMode;

	public GameObject WordProblemAdditionMode;

	public GameObject CarryForwardAdditionMode;

	public GameObject WordProblemsSubtractionMode;

	public GameObject AdditionPyramidMode;

	public GameObject ShowCaseBtn;

	public GameObject Loading1;

	public GameObject Loading2;

	public GameObject BlackBG;

	public GameObject MainBg;

	public GameObject Logo;

	public GameObject btnWorksheet;

	public GameObject LucasFriendBtn;

	public GameObject btn_MoreApps;

	public GameObject btn_OurStory;

	public GameObject MoreLanguageBtn;

	public GameObject WhyItsFreeBtn;

	public GameObject LucasRoomBtn;

	public GameObject settingBtn;

	public GameObject SettingScreenHandClick;

	public string TypeOfselection;

	public GameObject NumberTypeSelect;

	public GameObject EnNum;

	public GameObject ARNum;

	public GameObject EnObjUnselect;

	public GameObject ARObjUnselect;

	public GameObject WindLeaf;

	private GameObject rightButterfly;

	private static bool IsLogoLoaded;

	[Header("Sounds:")]
	public AudioClip LogoSound;

	public Transform FirstModesList;

	public static string CountryCode;

	public Text HoldForsecond;

	public Text WhyItsFreeBtnText;

	public GameObject UserNameLogo;

	private Vector3 IdoleAnimPLusPos;

	private Vector3 IdoleAnimMinusPos;

	public bool IsSelectPreferedCalled;

	[SerializeField]
	private GameObject HelpButton;

	[SerializeField]
	private GameObject MainMenuParent;

	private int SessionCount;

	public CanvasGroup _maincanvasgroup;

	public bool isDusterAnimationRuning;

	[SerializeField]
	private CanvasGroup _safeareaCanvasGroup;

	public bool isOpen;

	public string txtCurrentGameMode;

	[SerializeField]
	private GameObject ModesButton;

	[SerializeField]
	private GameObject LeftButtonGroup;

	[SerializeField]
	private GameObject RightButtonGroup;

	[SerializeField]
	private List<Transform> lstAllButtons;

	public GameObject DownloadIconLucasRoom;

	public GameObject AlertIConLucasRoom;

	public GameObject ProgressIconLucasRoom;

	private bool isFirstTime;

	[SerializeField]
	private GameObject _alertVendingMode;

	[SerializeField]
	private GameObject _alertFishMode;

	[SerializeField]
	private GameObject _alertCarMode;

	[SerializeField]
	public GameObject NewShopButton;

	[SerializeField]
	private GameObject _moreAppBtn;

	[SerializeField]
	private GameObject _additionBanner;

	[SerializeField]
	private GameObject _subStarctionBanner;

	[SerializeField]
	private GameObject _funGamesBanner;

	[SerializeField]
	private GameObject _newUIButtonPanel;

	[SerializeField]
	private GameObject _homeButton;

	private bool isManuallyCalledScreenStatus;

	[Header("Easter GameObject")]
	[Space(20f)]
	public Animator _easterBunny;

	public AudioSource _easterEggSound;

	public bool isCallNavigationUpdate;

	[SerializeField]
	private GameObject FishingDownloadIcon;

	[SerializeField]
	private GameObject FishingDownloadingIcon;

	[SerializeField]
	private GameObject SnowDownloadIcon;

	[SerializeField]
	private GameObject SnowDownloadingIcon;

	[SerializeField]
	private GameObject CarModeDownloadIcon;

	[SerializeField]
	private GameObject CarModeDownloadingIcon;

	[SerializeField]
	private GameObject AddItUpModeDownloadIcon;

	[SerializeField]
	private GameObject AddItUpModeDownloadingIcon;

	[SerializeField]
	private GameObject SudokuModeDownloadIcon;

	[SerializeField]
	private GameObject SudokuModeDownloadingIcon;

	[SerializeField]
	private GameObject AddSubUFOModeDownloadIcon;

	[SerializeField]
	private GameObject AddSubUFOModeDownloadingIcon;

	[SerializeField]
	private GameObject WordProblemAdditionModeDownloadIcon;

	[SerializeField]
	private GameObject WordProblemAdditionModeDownloadingIcon;

	[SerializeField]
	private GameObject CarryForwardAdditionModeDownloadIcon;

	[SerializeField]
	private GameObject CarryForwardAdditionModeDownloadingIcon;

	[SerializeField]
	private GameObject WordProblemsSubtractionModeDownloadIcon;

	[SerializeField]
	private GameObject WordProblemsSubtractionModeDownloadingIcon;

	[SerializeField]
	private GameObject AdditionPyramidModeDownloadIcon;

	[SerializeField]
	private GameObject AdditionPyramidModeDownloadingIcon;

	public int totalVisibleCount;

	private float _yPosForbanner;

	private bool IsLoadWordProblemAdditionModeFromStreamingAssets;

	private bool IsLoadCarryForwardAdditionModeFromResources;

	private bool IsLoadAdditionPyramidModeFromResources;

	private bool isLoadForEditorUpdates;

	[SerializeField]
	private GameObject _light2;

	public ModeName CurrentModeName;

	[SerializeField]
	private Transform _row1TransForm;

	[SerializeField]
	private Transform _row2TransForm;

	[SerializeField]
	private Transform _row3Transform;

	[SerializeField]
	private Transform _additionButton;

	[SerializeField]
	private Transform _funModeButton;

	[SerializeField]
	private Transform _subtractionButton;

	private void Awake()
	{
	}

	private void OnEditUserDetails(string newName, string Oldname)
	{
	}

	private void OnEnable()
	{
	}

	public void ResolutionDetector_OnResolutionChangedEvent(Vector2 obj)
	{
	}

	private void OpenStoreEventScreen()
	{
	}

	public void CallNumberHelp()
	{
	}

	public void Addacanvas(GameObject obj, bool pixel, bool sorting)
	{
	}

	public void UpdateMoreappbuttonPos()
	{
	}

	public void BalgBGOff()
	{
	}

	private void onLocaleChangeEvent(Locale currentLocale)
	{
	}

	public void ActiveForNumberType()
	{
	}

	public void CheckForNumType()
	{
	}

	public void OnNumTypeBtn()
	{
	}

	public void showlocalizationhelp()
	{
	}

	public void EnableChracterIntroFlow()
	{
	}

	private void showHandAnim()
	{
	}

	private void DisableSettingScreenHandClick()
	{
	}

	private void OnChangeUser(string UserName, bool CanPlayBG = false)
	{
	}

	public void CheckUserMorethankOneUser()
	{
	}

	[IteratorStateMachine(typeof(_003CEnableButtonClick_003Ed__103))]
	private IEnumerator EnableButtonClick()
	{
		return null;
	}

	private void spawnSelectLanguage()
	{
	}

	private void Start()
	{
	}

	private void ShowWaytoSupportUs()
	{
	}

	private void DisableWayToSupportUs()
	{
	}

	public void OnScreenStatusUpdatedEventFire(bool isStatus, string screenName)
	{
	}

	private void ShowWorksheetHelp()
	{
	}

	public void showCertificateUnlockPopup()
	{
	}

	private void onShowCertificateGetPopup()
	{
	}

	public void OnLanguagePopupClose()
	{
	}

	[IteratorStateMachine(typeof(_003COnStartLogoAndTitleCalledFromLanguagePopUpClose_003Ed__116))]
	private IEnumerator OnStartLogoAndTitleCalledFromLanguagePopUpClose()
	{
		return null;
	}

	private void onSetformattedText()
	{
	}

	[IteratorStateMachine(typeof(_003CButterflyAnimation_003Ed__118))]
	private IEnumerator ButterflyAnimation()
	{
		return null;
	}

	public void CheckVisibility(bool mode1, bool mode2, bool mode3, bool mode4, bool mode5, bool mode6, bool mode7, bool mode8, bool mode9, bool mode10, bool mode11, bool mode12, bool mode13, bool mode14, bool mode15, bool mode16, bool mode17, bool mode18, bool mode19, bool mode20, bool mode21, bool mode22, bool mode23, bool mode24, bool mode25)
	{
	}

	public void FishingModeIcons(bool _download, bool _downloading)
	{
	}

	public void SnowModeIcons(bool _download, bool _downloading)
	{
	}

	public void CarModeIcons(bool _download, bool _downloading)
	{
	}

	public void AddItUpModeIcons(bool _download, bool _downloading)
	{
	}

	public void SudokuModeIcons(bool _download, bool _downloading)
	{
	}

	public void AddSubUFOModeIcons(bool _download, bool _downloading)
	{
	}

	public void WordProblemAdditionModeIcons(bool _download, bool _downloading)
	{
	}

	public void CarryForwardAdditionModeIcons(bool _download, bool _downloading)
	{
	}

	public void AdditionPyramidModeIcons(bool _download, bool _downloading)
	{
	}

	public void WordProblemsSubtractionModeIcons(bool _download, bool _downloading)
	{
	}

	private void ReOrederButtonPositions()
	{
	}

	private void OnDisable()
	{
	}

	private void OnLoadUser()
	{
	}

	private void SetValueOnLoadUser()
	{
	}

	private void ShopButtonSelection()
	{
	}

	private void OnDownloadAssetBundle(string bundlename)
	{
	}

	public void StartMusic()
	{
	}

	public void OnMinMaxPressed(GameObject BtnObject)
	{
	}

	public void OnSubLearningPressed(GameObject BtnObject)
	{
	}

	public void OnAdditionLearninPress(GameObject BtnObject)
	{
	}

	public void OnAddExamPressed(GameObject BtnObject)
	{
	}

	public void OnSubExamPressed(GameObject BtnObject)
	{
	}

	public void OnMatchObjectPressed(GameObject BtnObject)
	{
	}

	public void onAddtionPuzzle(GameObject BtnObject)
	{
	}

	public void onSubtractionPuzzle(GameObject BtnObject)
	{
	}

	public void onVendingMachineModeClick(GameObject BtnObject)
	{
	}

	public void onDualPlayerModeClick(GameObject BtnObject)
	{
	}

	public void OnCrossMathPress(GameObject BtnObject)
	{
	}

	public void onFishingModeClick(GameObject BtnObject)
	{
	}

	public void onFunSnowModeClick(GameObject BtnObject)
	{
	}

	public void OnCarModeClick(GameObject BtnObject)
	{
	}

	public void OnAdditUpModeClick(GameObject BtnObject)
	{
	}

	public void OnSudokuModeClick(GameObject BtnObject)
	{
	}

	public void OnAddSubUFOModeClick(GameObject BtnObject)
	{
	}

	public void OnWordProblemAdditionModeClick(GameObject BtnObject)
	{
	}

	public void OnWordProblemsSubtractionModeClick(GameObject BtnObject)
	{
	}

	public void OnCarryForwardAdditionModeClick(GameObject BtnObject)
	{
	}

	public void OnAdditionPyramidModeClick(GameObject BtnObject)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadCrossMath_003Ed__181))]
	private IEnumerator LoadCrossMath()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadMatchObjectMode_003Ed__182))]
	private IEnumerator LoadMatchObjectMode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadAdditionPuzzleMode_003Ed__183))]
	private IEnumerator LoadAdditionPuzzleMode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadSubtractionPuzzleMode_003Ed__184))]
	private IEnumerator LoadSubtractionPuzzleMode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadVendingMachineMode_003Ed__185))]
	private IEnumerator LoadVendingMachineMode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadFishingMode_003Ed__186))]
	private IEnumerator LoadFishingMode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadFunSnowMode_003Ed__187))]
	private IEnumerator LoadFunSnowMode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadCarMode_003Ed__188))]
	private IEnumerator LoadCarMode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadMinMaxMode_003Ed__189))]
	private IEnumerator LoadMinMaxMode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadSubExamMode_003Ed__190))]
	private IEnumerator LoadSubExamMode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadAddLearning_003Ed__191))]
	private IEnumerator LoadAddLearning()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadSubLearnMode_003Ed__192))]
	private IEnumerator LoadSubLearnMode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadAddExamMode_003Ed__193))]
	private IEnumerator LoadAddExamMode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadDualPlayerMode_003Ed__194))]
	public IEnumerator LoadDualPlayerMode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadAddItUpMode_003Ed__195))]
	private IEnumerator LoadAddItUpMode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadSudokuMode_003Ed__196))]
	private IEnumerator LoadSudokuMode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadAddSubUFOMode_003Ed__197))]
	private IEnumerator LoadAddSubUFOMode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadWordProblemMode_003Ed__199))]
	private IEnumerator LoadWordProblemMode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadCarryForwardAdditionMode_003Ed__201))]
	private IEnumerator LoadCarryForwardAdditionMode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadAdditionPyramidMode_003Ed__203))]
	private IEnumerator LoadAdditionPyramidMode()
	{
		return null;
	}

	public void OnSettingsButtonPressed(GameObject thisGameObject)
	{
	}

	private void onSetting()
	{
	}

	public void onLucasFriendsBtnPressed(GameObject thisGameObject)
	{
	}

	public void onWifiButtonPressed(Transform Thisbtn)
	{
	}

	public void onWhyFreeButtonPressed(Transform Thisbtn)
	{
	}

	public void OnWorksheetButtonClick()
	{
	}

	public void onYoutubePressed(GameObject thisGameObject)
	{
	}

	private void onSettingForYoutube()
	{
	}

	public void ShowWorksheetScreen()
	{
	}

	public GameObject UpdateResolution()
	{
		return null;
	}

	public void OnShowcaseButtonPressed(Transform Thisbtn)
	{
	}

	[IteratorStateMachine(typeof(_003CShowLanguageDownloadedScreen_003Ed__215))]
	private IEnumerator ShowLanguageDownloadedScreen()
	{
		return null;
	}

	public bool IsShowLanguageReadyPopup()
	{
		return false;
	}

	public void OpenShop(string URL)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayOpenApplication_003Ed__218))]
	private IEnumerator DelayOpenApplication(string URL)
	{
		return null;
	}

	public void characterBehindTree(GameObject characterObject, string AnimationPlaceName)
	{
	}

	public void OnSelectLanguageButtonClick(Transform btnObj)
	{
	}

	private void callParentPop()
	{
	}

	public void OnSelectLanguageOpen()
	{
	}

	[IteratorStateMachine(typeof(_003CDisplayChangeLanguageCount_003Ed__223))]
	private IEnumerator DisplayChangeLanguageCount()
	{
		return null;
	}

	public void disablebadgeAnim()
	{
	}

	public void enableOrDisableMainScreenBackground(bool isShow)
	{
	}

	public void adjustmainmenualpha(float alpha, bool isShow)
	{
	}

	private void SettingTextID()
	{
	}

	public void onAddPracticeGameMode(GameObject BtnObject)
	{
	}

	public void onSubPracticeGameMode(GameObject BtnObject)
	{
	}

	public void StartPracticeGamePlay()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayPracticeGame_003Ed__231))]
	private IEnumerator PlayPracticeGame()
	{
		return null;
	}

	public void onDoubleDigitAddGameMode(GameObject BtnObject)
	{
	}

	public void onDoubleDigitSubGameMode(GameObject BtnObject)
	{
	}

	public void StartDoubleDigitGamePlay()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayDoubleDigitGame_003Ed__235))]
	private IEnumerator PlayDoubleDigitGame()
	{
		return null;
	}

	public void certificateBadgeShowCheck()
	{
	}

	public void showCertificateAfterZoomPopup()
	{
	}

	private void showCertificateScren()
	{
	}

	public void OnLucasRoombuttonPressed(GameObject thisgameObject)
	{
	}

	public void OpenLucasRoomRewampOnGardenClose()
	{
	}

	public void OnDummyLucasRoomButtonClick(GameObject thisgameObject)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayLucasRoomLightAnimation_003Ed__244))]
	public IEnumerator PlayLucasRoomLightAnimation()
	{
		return null;
	}

	public void OnNewModeButtonClick(Transform selectedMode)
	{
	}

	private void SetNavigation(bool isClikcedOnHomeButton)
	{
	}

	public void OnHomeButtonClick(GameObject homeBtn)
	{
	}
}
