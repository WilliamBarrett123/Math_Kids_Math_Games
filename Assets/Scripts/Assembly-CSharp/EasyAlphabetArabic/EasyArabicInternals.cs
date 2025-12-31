using System.Collections.Generic;

namespace EasyAlphabetArabic
{
	internal static class EasyArabicInternals
	{
		internal struct ArabicChar
		{
			public char ch;

			public CASE chCase;
		}

		private static ushort[,] arabicCharsArray;

		private static ushort[] RJL;

		private static ushort[] isolatedCharsArray;

		private static ushort[,] LATIN_NUMS;

		private static char[] EnglishNums;

		private static char[] TashkeelChars;

		internal static string Correct(string inputStr, int numCase)
		{
			return null;
		}

		internal static string CorrectTashkeel(string input, Dictionary<int, char> l)
		{
			return null;
		}

		internal static string CorrectGlyphs(string input, int numCase)
		{
			return null;
		}

		internal static string MapLamAlef(string input)
		{
			return null;
		}

		internal static char MapChar(char unicodeCharacter, CASE currCharCase)
		{
			return '\0';
		}

		internal static char MapNum(char latinNum, _NumCase numCase)
		{
			return '\0';
		}

		internal static char RemapToLatin(char arabicNum)
		{
			return '\0';
		}

		internal static bool HasTashkeel(string input)
		{
			return false;
		}

		internal static bool HasLamalef(string input)
		{
			return false;
		}

		internal static bool _Exists(char[] arr, char character)
		{
			return false;
		}

		internal static bool _Exists(ushort[] arr, ushort character)
		{
			return false;
		}

		internal static bool IsIsolated(char character)
		{
			return false;
		}
	}
}
