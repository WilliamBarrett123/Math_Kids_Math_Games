using System.Collections.Generic;
using UnityEngine;

public class GridBlockData : MonoBehaviour
{
	public int BlockId;

	public int RowId;

	public int ColumnId;

	public string txtNo;

	public string digitOrder;

	public bool HasOperator;

	public bool isAnswerBlock;

	public string txtInputVal;

	public UsedAsDirection isUsedAsDirection;

	public List<GridInfo> lstDependBlocks_1;

	public List<GridInfo> lstDependBlocks_2;
}
