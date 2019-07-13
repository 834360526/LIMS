<%@ Register TagPrefix="ignav" Namespace="Infragistics.WebUI.UltraWebNavigator" Assembly="Infragistics.WebUI.UltraWebNavigator.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Page language="c#" Codebehind="WebForm3.aspx.cs" AutoEventWireup="false" Inherits="LIMS.WebForm3" %>
<%@ Register TagPrefix="uc1" TagName="IndividualTree" Src="Control/IndividualTree.ascx" %>
<%@ Register TagPrefix="uc1" TagName="OfficTree" Src="Control/OfficTree.ascx" %>
<%@ Register TagPrefix="igtbl" Namespace="Infragistics.WebUI.UltraWebGrid" Assembly="Infragistics.WebUI.UltraWebGrid.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm3</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<SCRIPT type="text/javascript"><!--

		
		function ug_AfterCellUpdateHandler(gridName, cellId){
			lb.innerText=igtbl_getGridById("ug").getActiveRow().getCell(3).getValue();
		}
--></SCRIPT>
	</HEAD>
	<body MS_POSITIONING="FlowLayout" XMLNS:ignav="http://schemas.infragistics.com/ASPNET/WebControls/WebTree">
		<form id="Form1" method="post" runat="server">
			<FONT face="ËÎÌו">
				<P>
					<uc1:OfficTree id="OfficTree1" runat="server"></uc1:OfficTree></P>
				<P>&nbsp;</P>
				<P>
				</P>
				<DIV id="lb" style="DISPLAY: inline; WIDTH: 70px; HEIGHT: 15px" ms_positioning="FlowLayout">Label</DIV>
				<P>
					<ignav:ultrawebtree id="Ultrawebtree3" runat="server" CollapseImage="ig_treeXPMinus.gif" WebTreeTarget="HierarchicalTree"
						Indentation="20" ExpandImage="ig_treeXPPlus.gif" Cursor="Default" DefaultSelectedImage="ig_treeOfficeFolder.gif"
						DefaultImage="ig_treeOfficeFolder.gif" Font-Size="8pt" Font-Names="Microsoft Sans Serif">
						<Nodes>
							<ignav:Node CheckBox="True" Text="Root Node">
								<Nodes>
									<ignav:Node CheckBox="True" Text="Child Node"></ignav:Node>
									<ignav:Node CheckBox="True" Text="Child Node">
										<Nodes>
											<ignav:Node CheckBox="True" Text="Child Node"></ignav:Node>
											<ignav:Node Text="Child Node"></ignav:Node>
										</Nodes>
									</ignav:Node>
								</Nodes>
							</ignav:Node>
							<ignav:Node Text="Root Node">
								<Nodes>
									<ignav:Node Text="Child Node"></ignav:Node>
								</Nodes>
							</ignav:Node>
						</Nodes>
						<SelectedNodeStyle ForeColor="White" BackColor="#316AC5">
							<Padding Bottom="2px" Left="2px" Top="2px" Right="2px"></Padding>
						</SelectedNodeStyle>
						<NodeStyle>
							<Padding Bottom="2px" Left="2px" Top="2px" Right="2px"></Padding>
						</NodeStyle>
						<Levels>
							<ignav:Level LevelHoverClass="" LevelHiliteClass="" ColumnName="" TargetFrameName="" ImageColumnName=""
								LevelClass="" LevelImage="" Index="0" LevelKeyField="" RelationName="" CheckboxColumnName=""
								LevelIslandClass="" TargetUrlName=""></ignav:Level>
							<ignav:Level LevelHoverClass="" LevelHiliteClass="" ColumnName="" TargetFrameName="" ImageColumnName=""
								LevelClass="" LevelImage="" Index="1" LevelKeyField="" RelationName="" CheckboxColumnName=""
								LevelIslandClass="" TargetUrlName=""></ignav:Level>
							<ignav:Level Index="2"></ignav:Level>
						</Levels>
					</ignav:ultrawebtree>
					<uc1:IndividualTree id="IndividualTree1" runat="server"></uc1:IndividualTree></P>
			</FONT>
		</form>
	</body>
</HTML>
