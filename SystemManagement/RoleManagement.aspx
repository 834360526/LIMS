<%@ Register TagPrefix="igtbl" Namespace="Infragistics.WebUI.UltraWebGrid" Assembly="Infragistics.WebUI.UltraWebGrid.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igtxt" Namespace="Infragistics.WebUI.WebDataInput" Assembly="Infragistics.WebUI.WebDataInput.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Page language="c#" Codebehind="RoleManagement.aspx.cs" AutoEventWireup="false" Inherits="LIMS.SystemManagement.RoleManagement" smartNavigation="True"%>
<%@ Register TagPrefix="igmisc" Namespace="Infragistics.WebUI.Misc" Assembly="Infragistics.WebUI.Misc.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>RoleManagement</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">
				<igtbl:UltraWebGrid id="dgRole" runat="server" ImageDirectory="/ig_common/Images/" DataSource="<%# sm1 %>" DataMember="角色" Height="300px" Width="500px">
					<DisplayLayout AllowDeleteDefault="Yes" AllowAddNewDefault="Yes" AllowSortingDefault="OnClient"
						RowHeightDefault="21px" RowSizingDefault="Free" Version="3.00" SelectTypeRowDefault="Single"
						AllowColumnMovingDefault="OnServer" HeaderClickActionDefault="SortSingle" BorderCollapseDefault="Separate"
						AllowColSizingDefault="Free" Name="dgRole" TableLayout="Fixed" CellClickActionDefault="Edit"
						AllowUpdateDefault="Yes">
						<AddNewBox Hidden="False" Prompt="添加...">
							<Style BorderWidth="1px" BorderColor="InactiveCaption" BorderStyle="Solid" BackColor="Window">

<BorderDetails ColorTop="White" WidthLeft="1px" WidthTop="1px" ColorLeft="White">
</BorderDetails>

							</Style>
						</AddNewBox>
						<Pager>
							<Style BorderWidth="1px" BorderStyle="Solid" BackColor="LightGray">

<BorderDetails ColorTop="White" WidthLeft="1px" WidthTop="1px" ColorLeft="White">
</BorderDetails>

							</Style>
						</Pager>
						<HeaderStyleDefault Font-Size="X-Small" Font-Names="Arial" Font-Bold="True" BorderStyle="Solid" ForeColor="#E1E8F5"
							BackColor="#11459E" CustomRules="background-image:url(/ig_common/images/Office2003BlueBG.png);background-repeat:repeat-x;">
							<BorderDetails ColorTop="173, 197, 235" WidthLeft="1px" WidthTop="1px" ColorLeft="173, 197, 235"></BorderDetails>
						</HeaderStyleDefault>
						<FrameStyle Width="500px" BorderWidth="1px" Font-Size="8pt" Font-Names="Verdana" BorderStyle="Solid"
							Height="300px"></FrameStyle>
						<FooterStyleDefault BorderWidth="1px" BorderStyle="Solid" BackColor="LightGray">
							<BorderDetails ColorTop="White" WidthLeft="1px" WidthTop="1px" ColorLeft="White"></BorderDetails>
						</FooterStyleDefault>
						<GroupByBox>
							<Style BorderColor="Window" BackColor="ActiveBorder">
							</Style>
						</GroupByBox>
						<EditCellStyleDefault BorderWidth="0px" BorderStyle="None"></EditCellStyleDefault>
						<SelectedRowStyleDefault ForeColor="White" BackColor="#F09D21" CustomRules="background-image:url(/ig_common/images/Office2003SelRow.png);background-repeat:repeat-x;"></SelectedRowStyleDefault>
						<RowStyleDefault BorderWidth="1px" BorderColor="Black" BorderStyle="Solid">
							<Padding Left="3px"></Padding>
							<BorderDetails WidthLeft="0px" WidthTop="0px"></BorderDetails>
						</RowStyleDefault>
					</DisplayLayout>
					<Bands>
						<igtbl:UltraGridBand AddButtonCaption="角色" BaseTableName="角色" Key="角色" DataKeyField="ID">
							<Columns>
								<igtbl:UltraGridColumn HeaderText="ID" Key="ID" IsBound="True" Hidden="True" DataType="System.Int32" BaseColumnName="ID">
									<Footer Key="ID"></Footer>
									<Header Key="ID" Caption="ID"></Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="角色名称" Key="角色名称" IsBound="True" Width="150px" BaseColumnName="角色名称">
									<Footer Key="角色名称">
										<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="角色名称" Caption="角色名称">
										<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="角色描述" Key="角色描述" IsBound="True" Width="250px" BaseColumnName="角色描述">
									<Footer Key="角色描述">
										<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="角色描述" Caption="角色描述">
										<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
							</Columns>
						</igtbl:UltraGridBand>
					</Bands>
				</igtbl:UltraWebGrid><BR>
				<igtxt:WebImageButton id="ConfirmRole" runat="server" UseBrowserDefaults="False" Text="确定" DESIGNTIMEDRAGDROP="810">
					<RoundedCorners MaxHeight="40" ImageUrl="ig_butCRM1.gif" MaxWidth="400" HoverImageUrl="ig_butCRM2.gif"
						RenderingType="FileImages" HeightOfBottomEdge="2" PressedImageUrl="ig_butCRM2.gif" WidthOfRightEdge="2"></RoundedCorners>
				</igtxt:WebImageButton>&nbsp;
				<igtxt:WebImageButton id="CancelRole" runat="server" UseBrowserDefaults="False" Text="取消">
					<RoundedCorners MaxHeight="40" ImageUrl="ig_butCRM1.gif" MaxWidth="400" HoverImageUrl="ig_butCRM2.gif"
						RenderingType="FileImages" HeightOfBottomEdge="2" PressedImageUrl="ig_butCRM2.gif" WidthOfRightEdge="2"></RoundedCorners>
				</igtxt:WebImageButton>&nbsp;
				<igtxt:WebImageButton id="ModifyPermission" runat="server" UseBrowserDefaults="False" Text="修改权限" DESIGNTIMEDRAGDROP="781">
					<RoundedCorners MaxHeight="40" ImageUrl="ig_butCRM1.gif" MaxWidth="400" HoverImageUrl="ig_butCRM2.gif"
						RenderingType="FileImages" HeightOfBottomEdge="2" PressedImageUrl="ig_butCRM2.gif" WidthOfRightEdge="2"></RoundedCorners>
				</igtxt:WebImageButton><BR>
				<BR>
			</FONT>
			<asp:Panel id="PermissionPanel" runat="server" BorderColor="LightGray" BorderWidth="1px" Width="600px"
				Visible="False">
				<FONT face="宋体"></FONT>
				<BR>
				<FONT face="宋体">&nbsp;</FONT>
				<asp:Label id="Selected" runat="server" Font-Size="14px"></asp:Label>
				<BR>
				<FONT face="宋体">&nbsp;</FONT>
				<asp:CheckBoxList id=SelectPermission runat="server" DataMember="权限模块" DataSource="<%# sm1 %>" Font-Size="14px" CellPadding="5" RepeatColumns="5" DataTextField="权限模块名" DataValueField="ID">
				</asp:CheckBoxList>
				<BR>
				<FONT face="宋体">&nbsp;</FONT>
				<igtxt:WebImageButton id="ConfirmPermission" runat="server" DESIGNTIMEDRAGDROP="794" Text="确定" UseBrowserDefaults="False">
					<RoundedCorners MaxHeight="40" ImageUrl="ig_butCRM1.gif" MaxWidth="400" HoverImageUrl="ig_butCRM2.gif"
						RenderingType="FileImages" HeightOfBottomEdge="2" PressedImageUrl="ig_butCRM2.gif" WidthOfRightEdge="2"></RoundedCorners>
				</igtxt:WebImageButton>
				<FONT face="宋体">&nbsp; </FONT>
				<igtxt:WebImageButton id="CancelPermission" runat="server" Text="取消" UseBrowserDefaults="False">
					<RoundedCorners MaxHeight="40" ImageUrl="ig_butCRM1.gif" MaxWidth="400" HoverImageUrl="ig_butCRM2.gif"
						RenderingType="FileImages" HeightOfBottomEdge="2" PressedImageUrl="ig_butCRM2.gif" WidthOfRightEdge="2"></RoundedCorners>
				</igtxt:WebImageButton>
				<FONT face="宋体">
					<BR>
				</FONT>
			</asp:Panel>
		</form>
	</body>
</HTML>
