/// <summary>
/// ͨ��һ��Checkbox�ڿͻ���ȫѡWebGrid�е�����ѡ��
/// </summary>
/// <param name="gridID">Ҫȫѡ��WebGrid��ID</param>
/// <param name="bChecked">Ҫ���õ�ѡ���Key</param>
function CheckboxSelectAll(gridID,key)
{
	var allrows=igtbl_getGridById(gridID).Rows;
	for (var i=0;i<allrows.length;i++)
	{
		allrows.getRow(i).getCellFromKey(key).setValue(Form1.All.checked);
	}

}

