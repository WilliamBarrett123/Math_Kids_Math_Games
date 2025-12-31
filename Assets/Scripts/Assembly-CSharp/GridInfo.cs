using System;
using UnityEngine;

[Serializable]
public class GridInfo
{
	public int BlockId;

	public int RowId;

	public int ColumnId;

	public string txtNo;

	public string txtInputVal;

	public bool HasOperator;

	public bool isAnswerBlock;

	public Transform objBlock;

	public int retryCount;

	public int ansStatus;

	public string digitOrder;

	public UsedAsDirection isUsedAsDirection;

	public int numberOfTryAsRef;
}
