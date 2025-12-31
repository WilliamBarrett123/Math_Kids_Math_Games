using System.Collections.Generic;
using UnityEngine.UI;

namespace EasyAlphabetArabic
{
	public static class EasyArabicCore
	{
		private enum numCase
		{
			LATIN = 0,
			ARABIC = 1,
			PERSIAN = 2,
			URDU = 3
		}

		private static numCase NumCase;

		private static Dictionary<string, string> startEndTags;

		public static string CorrectString(string text, int numsFormat = 0)
		{
			return null;
		}

		public static string CorrectStringCustom(string text, int numsFormat = 0)
		{
			return null;
		}

		public static string CorrectWithLineWrapping(string text, Text textComponent, int numsFormat = 0)
		{
			return null;
		}

		public static string CorrectWithLineWrapping_hebrew(string text, Text textComponent, int numsFormat = 0)
		{
			return null;
		}

		public static string CorrectWithLineWrapping_Urdu(string text, Text textComponent, int numsFormat = 0)
		{
			return null;
		}

		public static string CorrectTextMeshPro(string text, int numsFormat = 0)
		{
			return null;
		}

		public static bool IsRTL(string txt)
		{
			return false;
		}

		public static string RemapNumsToLatin(string text)
		{
			return null;
		}

		private static List<string> ExtractStrings(string inputStr)
		{
			return null;
		}

		private static string CorrectText(List<string> inputStrings, bool TMPro = false)
		{
			return null;
		}

		private static string CorrectBetweenTags(string text, bool TMPro = false)
		{
			return null;
		}

		private static bool StartsWithTag(string s)
		{
			return false;
		}

		private static bool EndsWithTag(string s)
		{
			return false;
		}

		private static string ReverseArabic(string str)
		{
			return null;
		}
	}
}
