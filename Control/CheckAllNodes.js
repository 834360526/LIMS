/// <summary>
/// 递归选择（取消）索所有的节点
/// </summary>
/// <param name="nodes">要选择（取消）的节点集合</param>
/// <param name="bChecked">要设置的状态</param>
function CheckAllNodes(nodes,bChecked)
{
	for(var i=0;i<nodes.length;i++)
	{
		//判断当前单击的节点是否有子节点
		if (nodes[i].hasChildren())
			CheckAllNodes(nodes[i].getChildNodes(),bChecked)
		
		nodes[i].setChecked(bChecked);
	}
	
}
