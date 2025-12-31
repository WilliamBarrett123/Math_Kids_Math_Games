using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableReward", menuName = "Rewards", order = 1)]
public class ImageNameScriptable : ScriptableObject
{
	public List<Reward> ImageIndexList;
}
