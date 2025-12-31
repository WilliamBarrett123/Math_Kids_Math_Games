using System;
using System.Collections.Generic;

[Serializable]
public class EquationDetail
{
	public float FirstNumber;

	public float SecondNumber;

	public float ThirdNumber;

	public float Ans;

	public int CompleteCount;

	public bool isCorrectAns;

	public bool isWrongAns;

	public bool isSkippedAns;

	public float enterAns;

	public string operatorType;

	public string subModeName;

	public int sortPriority;

	public string strTemplate;

	public List<string> lstMatched;

	public List<string> lstNotMatched;

	public List<GridInfo> lstCrossMathGrids;

	public EquationDetail(float firstNum, float SecondNum, float ThirdNum, float AnsObj, int CompleteCountNum = 0, bool CorrectAns = false, bool wrongAns = false, bool SkippedAns = false, float enterAnsVal = -1f, string operatortype = "+", string _subModeName = "", int _sortPriority = 10, string _strTemplate = "")
	{
	}

	public EquationDetail()
	{
	}
}
