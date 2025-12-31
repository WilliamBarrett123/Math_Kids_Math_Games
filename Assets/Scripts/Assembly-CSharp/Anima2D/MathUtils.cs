using UnityEngine;

namespace Anima2D
{
	public static class MathUtils
	{
		public static float SignedAngle(Vector3 a, Vector3 b, Vector3 forward)
		{
			return 0f;
		}

		public static float Fmod(float value, float mod)
		{
			return 0f;
		}

		public static float SegmentDistance(Vector3 point, Vector3 a, Vector3 b)
		{
			return 0f;
		}

		public static float SegmentSqrtDistance(Vector3 point, Vector3 a, Vector3 b)
		{
			return 0f;
		}

		public static float LineDistance(Vector3 point, Vector3 a, Vector3 b)
		{
			return 0f;
		}

		public static float SqrtLineDistance(Vector3 point, Vector3 a, Vector3 b)
		{
			return 0f;
		}

		public static void WorldFromMatrix4x4(this Transform transform, Matrix4x4 matrix)
		{
		}

		public static void LocalFromMatrix4x4(this Transform transform, Matrix4x4 matrix)
		{
		}

		public static Quaternion GetRotation(this Matrix4x4 matrix)
		{
			return default(Quaternion);
		}

		public static Vector3 GetPosition(this Matrix4x4 matrix)
		{
			return default(Vector3);
		}

		public static Vector3 GetScale(this Matrix4x4 m)
		{
			return default(Vector3);
		}

		public static Rect ClampRect(Rect rect, Rect frame)
		{
			return default(Rect);
		}

		public static Vector2 ClampPositionInRect(Vector2 position, Rect frame)
		{
			return default(Vector2);
		}

		public static Rect OrderMinMax(Rect rect)
		{
			return default(Rect);
		}

		public static float RoundToMultipleOf(float value, float roundingValue)
		{
			return 0f;
		}

		public static float GetClosestPowerOfTen(float positiveNumber)
		{
			return 0f;
		}

		public static float RoundBasedOnMinimumDifference(float valueToRound, float minDifference)
		{
			return 0f;
		}

		public static float DiscardLeastSignificantDecimal(float v)
		{
			return 0f;
		}

		public static int GetNumberOfDecimalsForMinimumDifference(float minDifference)
		{
			return 0;
		}

		public static Vector3 Unskin(Vector3 skinedPosition, Matrix4x4 localToWorld, BoneWeight boneWeight, Matrix4x4[] bindposes, Transform[] bones)
		{
			return default(Vector3);
		}
	}
}
