/// <summary>
/// 通过一个Checkbox在客户端全选WebGrid中的所有选项
/// </summary>
/// <param name="gridID">要全选的WebGrid的ID</param>
/// <param name="bChecked">要设置的选项的Key</param>
function CheckboxSelectAll(gridID,key)
{
	var allrows=igtbl_getGridById(gridID).Rows;
	for (var i=0;i<allrows.length;i++)
	{
		allrows.getRow(i).getCellFromKey(key).setValue(Form1.All.checked);
	}

}

