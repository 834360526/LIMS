/// <summary>
/// �ݹ�ѡ��ȡ���������еĽڵ�
/// </summary>
/// <param name="nodes">Ҫѡ��ȡ�����Ľڵ㼯��</param>
/// <param name="bChecked">Ҫ���õ�״̬</param>
function CheckAllNodes(nodes,bChecked)
{
	for(var i=0;i<nodes.length;i++)
	{
		//�жϵ�ǰ�����Ľڵ��Ƿ����ӽڵ�
		if (nodes[i].hasChildren())
			CheckAllNodes(nodes[i].getChildNodes(),bChecked)
		
		nodes[i].setChecked(bChecked);
	}
	
}
