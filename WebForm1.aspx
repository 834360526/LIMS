<%@ Register TagPrefix="igtbl" Namespace="Infragistics.WebUI.UltraWebGrid" Assembly="Infragistics.WebUI.UltraWebGrid.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igtbar" Namespace="Infragistics.WebUI.UltraWebToolbar" Assembly="Infragistics.WebUI.UltraWebToolbar.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igchartprop" Namespace="Infragistics.UltraChart.Resources.Appearance" Assembly="Infragistics.WebUI.UltraWebChart.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igchartdata" Namespace="Infragistics.UltraChart.Data" Assembly="Infragistics.WebUI.UltraWebChart.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="ignav" Namespace="Infragistics.WebUI.UltraWebNavigator" Assembly="Infragistics.WebUI.UltraWebNavigator.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igchart" Namespace="Infragistics.WebUI.UltraWebChart" Assembly="Infragistics.WebUI.UltraWebChart.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="iglbar" Namespace="Infragistics.WebUI.UltraWebListbar" Assembly="Infragistics.WebUI.UltraWebListbar.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="ignavbar" Namespace="Infragistics.WebUI.WebNavBar" Assembly="Infragistics.WebUI.WebNavBar.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="ig_sched" Namespace="Infragistics.WebUI.WebSchedule" Assembly="Infragistics.WebUI.WebSchedule.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="ig_scheduledata" Namespace="Infragistics.WebUI.Data" Assembly="Infragistics.WebUI.WebScheduleDataProvider.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Page language="c#" Codebehind="WebForm1.aspx.cs" AutoEventWireup="false" Inherits="LIMS.WebForm1" %>
<%@ Register TagPrefix="uc1" TagName="AdvancedSQLBox" Src="Control/AdvancedSQLBox.ascx" %>
<%@ Register TagPrefix="uc1" TagName="OfficTree" Src="Control/OfficTree.ascx" %>
<%@ Register TagPrefix="igsch" Namespace="Infragistics.WebUI.WebSchedule" Assembly="Infragistics.WebUI.WebDateChooser.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igmisc" Namespace="Infragistics.WebUI.Misc" Assembly="Infragistics.WebUI.Misc.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="uc1" TagName="LeftMenu" Src="Control/LeftMenu.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<FONT face="ËÎÌו">
				<P><iglbar:ultraweblistbar id="UltraWebListbar1" runat="server" ItemSelectionStyle="IconOnlySelection" MergeStyles="True"
						BorderStyle="None" Width="124px" BarWidth="100%" Height="200px">
						<DefaultGroupStyle Cursor="Default" Height="100%" BackColor="WhiteSmoke"></DefaultGroupStyle>
						<DefaultItemStyle Cursor="Default" Font-Size="8pt" Font-Names="Verdana">
							<Padding Left="5px"></Padding>
							<Margin Left="1px"></Margin>
						</DefaultItemStyle>
						<DefaultItemHoverStyle BorderWidth="1px" BorderStyle="Outset">
							<Margin Left="0px"></Margin>
						</DefaultItemHoverStyle>
						<DefaultGroupButtonSelectedStyle Cursor="Default" ForeColor="Black" BackColor="Silver"></DefaultGroupButtonSelectedStyle>
						<Groups>
							<iglbar:Group TextAlign="Left" Tag="" Text="Group" UserControlUrl="">
								<Items>
									<iglbar:Item Tag="" Key="" Text="Item"></iglbar:Item>
									<iglbar:Item Tag="" Key="" Text="Item"></iglbar:Item>
								</Items>
							</iglbar:Group>
							<iglbar:Group TextAlign="Left" Tag="" Text="Group" UserControlUrl="">
								<Items>
									<iglbar:Item Tag="" Key="" Text="Item"></iglbar:Item>
									<iglbar:Item Tag="" Key="" Text="Item"></iglbar:Item>
								</Items>
							</iglbar:Group>
						</Groups>
						<DefaultItemSelectedStyle Cursor="Default" BorderWidth="1px" BorderStyle="Inset">
							<Margin Left="0px"></Margin>
						</DefaultItemSelectedStyle>
						<DefaultGroupButtonStyle Cursor="Default" Height="24px" Font-Size="10pt" Font-Names="Verdana" BackgroundImage="blueExplorer.gif">
							<Padding Left="3px"></Padding>
						</DefaultGroupButtonStyle>
						<DefaultGroupButtonHoverStyle BackgroundImage="orangeexplorer.gif"></DefaultGroupButtonHoverStyle>
					</iglbar:ultraweblistbar><ignav:ultrawebtree id="UltraWebTree1" runat="server" CollapseImage="ig_treeMinus.gif" WebTreeTarget="HierarchicalTree"
						Indentation="20" ExpandImage="ig_treePlus.gif" Cursor="Default">
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
						<SelectedNodeStyle ForeColor="White" BackColor="Navy"></SelectedNodeStyle>
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
					<uc1:AdvancedSQLBox id="asb" runat="server"></uc1:AdvancedSQLBox></P>
				<P>
					<uc1:OfficTree id="OfficTree1" runat="server"></uc1:OfficTree>
					<asp:Button id="Button1" runat="server" Text="Button"></asp:Button></P>
			</FONT>
		</form>
	</body>
</HTML>
