<%@ Register TagPrefix="ignav" Namespace="Infragistics.WebUI.UltraWebNavigator" Assembly="Infragistics.WebUI.UltraWebNavigator.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Control Language="c#" AutoEventWireup="false" Codebehind="OfficeTree.ascx.cs" Inherits="LIMS.Control.OfficeTree" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<script type="text/javascript" src="..\control\CheckAllNodes.js"></script>
<SCRIPT type="text/javascript"><!--

		function OfficeWebTree_NodeChecked(treeId, nodeId, bChecked){
			CheckAllNodes(igtree_getNodeById(nodeId).getChildNodes(),bChecked);
		}

--></SCRIPT>
<ignav:ultrawebtree id="OfficeWebTree" CheckBoxes="True" CollapseImage="ig_treeMinus.gif" Cursor="Default"
	WebTreeTarget="ClassicTree" Indentation="20" ExpandImage="ig_treePlus.gif" runat="server">
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
	<ClientSideEvents NodeChecked="OfficeWebTree_NodeChecked"></ClientSideEvents>
</ignav:ultrawebtree>
