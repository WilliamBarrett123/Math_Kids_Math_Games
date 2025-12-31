using System;
using System.Collections.Generic;
using UnityEngine;

public class BaseQuestionGenerator : MonoBehaviour
{
	public static class DigitUtils
	{
		public static int GetOnesDigit(int number)
		{
			return 0;
		}

		public static int GetTensDigit(int number)
		{
			return 0;
		}

		public static bool IsTwoDigit(int number)
		{
			return false;
		}

		public static int GetCarry(int onesSum)
		{
			return 0;
		}

		public static int GetOnesPlaceAfterCarry(int onesSum)
		{
			return 0;
		}
	}

	public struct Question
	{
		public int Operand1;

		public int Operand2;

		public Question(int op1, int op2)
		{
			Operand1 = 0;
			Operand2 = 0;
		}

		public int GetResult()
		{
			return 0;
		}
	}

	public class AddQuestionGenerator : BaseQuestionGenerator
	{
		[Serializable]
		public struct AddQuestion
		{
			public int Addend1;

			public int Addend2;

			public int Sum => 0;

			public int OnesSum => 0;

			public int Carry => 0;

			public int TensSum => 0;

			public int OnesPlaceDigit => 0;

			public AddQuestion(int a, int b)
			{
				Addend1 = 0;
				Addend2 = 0;
			}
		}

		private readonly List<AddQuestion> fixedTutorialQuestions;

		public AddQuestion GetQuestionByLevel(int level, int questionIndex)
		{
			return default(AddQuestion);
		}

		private AddQuestion GenerateRandomValidAddQuestion()
		{
			return default(AddQuestion);
		}

		private bool IsValidAddQuestion(int a, int b)
		{
			return false;
		}
	}

	protected virtual bool IsTwoDigitResult(int result)
	{
		return false;
	}

	protected int GetOnes(int number)
	{
		return 0;
	}

	protected int GetTens(int number)
	{
		return 0;
	}
}
