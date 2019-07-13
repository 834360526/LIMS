<%@ Control Language="c#" AutoEventWireup="false" Codebehind="IndividualTree.ascx.cs" Inherits="LIMS.Control.IndividualTree" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<%@ Register TagPrefix="ignav" Namespace="Infragistics.WebUI.UltraWebNavigator" Assembly="Infragistics.WebUI.UltraWebNavigator.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<script type="text/javascript" src="..\control\CheckAllNodes.js"></script>
<SCRIPT type="text/javascript"><!--

		function IndividualWebTree_NodeChecked(treeId, nodeId, bChecked){
			CheckAllNodes(igtree_getNodeById(nodeId).getChildNodes(),bChecked);
		}
--></SCRIPT>
<FONT face="ËÎÌו">
	<ignav:ultrawebtree id="IndividualWebTree" runat="server" ExpandImage="ig_treePlus.gif" Indentation="20"
		WebTreeTarget="ClassicTree" Cursor="Default" CollapseImage="ig_treeMinus.gif" CheckBoxes="True">
		<SelectedNodeStyle ForeColor="White" BackColor="Navy"></SelectedNodeStyle>
		<NodeStyle Font-Size="14px"></NodeStyle>
		<Levels>
			<ignav:Level LevelHoverClass="" LevelHiliteClass="" ColumnName="" TargetFrameName="" ImageColumnName=""
				LevelClass="" LevelImage="" Index="0" LevelKeyField="" RelationName="" CheckboxColumnName=""
				LevelIslandClass="" TargetUrlName=""></ignav:Level>
			<ignav:Level LevelHoverClass="" LevelHiliteClass="" ColumnName="" TargetFrameName="" ImageColumnName=""
				LevelClass="" LevelImage="" Index="1" LevelKeyField="" RelationName="" CheckboxColumnName=""
				LevelIslandClass="" TargetUrlName=""></ignav:Level>
		</Levels>
		<ClientSideEvents NodeChecked="IndividualWebTree_NodeChecked"></ClientSideEvents>
	</ignav:ultrawebtree></FONT>
