<%@ Page language="c#" Codebehind="PermissionManagement.aspx.cs" AutoEventWireup="false" Inherits="LIMS.SystemManagement.PermissionManagement" %>
<%@ Register TagPrefix="igtxt" Namespace="Infragistics.WebUI.WebDataInput" Assembly="Infragistics.WebUI.WebDataInput.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igcmbo" Namespace="Infragistics.WebUI.WebCombo" Assembly="Infragistics.WebUI.WebCombo.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igtbl" Namespace="Infragistics.WebUI.UltraWebGrid" Assembly="Infragistics.WebUI.UltraWebGrid.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>PermissionManagement</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body XMLNS:igcmbo="http://schemas.infragistics.com/ASPNET/WebControls/WebCombo" MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">
				<igtbl:ultrawebgrid id=dgPermission runat="server" Width="700px" Height="400px" Browser="Xml" DataMember="权限模块" DataSource="<%# sm1 %>" ImageDirectory="/ig_common/Images/">
					<DisplayLayout AllowDeleteDefault="Yes" UseFixedHeaders="True" AllowAddNewDefault="Yes" AllowSortingDefault="OnClient"
						RowHeightDefault="21px" RowSizingDefault="Free" Version="3.00" SelectTypeRowDefault="Extended"
						AllowColumnMovingDefault="OnClient" HeaderClickActionDefault="SortSingle" BorderCollapseDefault="Separate"
						AllowColSizingDefault="Free" FixedHeaderIndicatorDefault="Button" Name="dgPermission" TableLayout="Fixed"
						CellClickActionDefault="Edit" NoDataMessage="没有数据" AllowUpdateDefault="Yes">
						<AddNewBox Hidden="False" Prompt="添加...">
							<Style BorderWidth="1px" BorderColor="InactiveCaption" BorderStyle="Solid" BackColor="Window">

<BorderDetails ColorTop="White" WidthLeft="1px" WidthTop="1px" ColorLeft="White">
</BorderDetails>

							</Style>
						</AddNewBox>
						<Pager PageSize="10" StyleMode="QuickPages">
							<Style BorderWidth="1px" BorderStyle="Solid" BackColor="LightGray">

<BorderDetails ColorTop="White" WidthLeft="1px" WidthTop="1px" ColorLeft="White">
</BorderDetails>

							</Style>
						</Pager>
						<HeaderStyleDefault Font-Size="X-Small" Font-Names="Arial" Font-Bold="True" BorderStyle="Solid" ForeColor="#E1E8F5"
							BackColor="#11459E" CustomRules="background-image:url(/ig_common/images/Office2003BlueBG.png);background-repeat:repeat-x;">
							<BorderDetails ColorTop="173, 197, 235" WidthLeft="1px" WidthTop="1px" ColorLeft="173, 197, 235"></BorderDetails>
						</HeaderStyleDefault>
						<FrameStyle Width="700px" BorderWidth="1px" Font-Size="8pt" Font-Names="Verdana" BorderStyle="Solid"
							Height="400px"></FrameStyle>
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
						<igtbl:UltraGridBand AddButtonCaption="权限模块" BaseTableName="权限模块" Key="权限模块" DataKeyField="ID">
							<Columns>
								<igtbl:UltraGridColumn HeaderText="ID" Key="ID" IsBound="True" Hidden="True" DataType="System.Int32" BaseColumnName="ID">
									<Footer Key="ID"></Footer>
									<Header Key="ID" Caption="ID"></Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="权限模块名称" Key="权限模块名" IsBound="True" Width="150px" BaseColumnName="权限模块名">
									<Footer Key="权限模块名">
										<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="权限模块名" Caption="权限模块名称">
										<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="类别" Key="类别" IsBound="True" EditorControlID="PermissionTypeCombo" Type="Custom"
									DataType="System.Int32" BaseColumnName="类别">
									<Footer Key="类别">
										<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="类别" Caption="类别">
										<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="菜单级别" Key="菜单级别" IsBound="True" DataType="System.Int32" BaseColumnName="菜单级别">
									<Footer Key="菜单级别">
										<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="菜单级别" Caption="菜单级别">
										<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="菜单项目" Key="菜单项目ID" IsBound="True" EditorControlID="MenuCombo" Width="100px"
									Type="Custom" DataType="System.Int32" BaseColumnName="菜单项目ID">
									<Footer Key="菜单项目ID">
										<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="菜单项目ID" Caption="菜单项目">
										<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="链接地址" Key="链接地址" IsBound="True" BaseColumnName="链接地址">
									<Footer Key="链接地址">
										<RowLayoutColumnInfo OriginX="5"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="链接地址" Caption="链接地址">
										<RowLayoutColumnInfo OriginX="5"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="备注" Key="备注" IsBound="True" BaseColumnName="备注" CellMultiline="Yes">
									<Footer Key="备注">
										<RowLayoutColumnInfo OriginX="6"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="备注" Caption="备注">
										<RowLayoutColumnInfo OriginX="6"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
							</Columns>
						</igtbl:UltraGridBand>
					</Bands>
				</igtbl:ultrawebgrid><igcmbo:webcombo id=PermissionTypeCombo runat="server" Width="200px" Height="22px" DataMember="权限类别" DataSource="<%# sm1 %>" DESIGNTIMEDRAGDROP="18" Version="3.00" BackColor="White" BorderStyle="Solid" BorderColor="LightGray" BorderWidth="1px" ForeColor="Black" DropImage1="/ig_common/images/Office2003DropDownBlue.gif" DropImage2="/ig_common/images/Office2003DropDownOrange.gif" DropImageXP1="/ig_common/images/Office2003DropDownBlue.gif" DropImageXP2="/ig_common/images/Office2003DropDownOrange.gif" SelBackColor="17, 69, 158" DataTextField="Type" DataValueField="ID">
					<Columns>
						<igtbl:UltraGridColumn HeaderText="ID" Key="ID" IsBound="True" Hidden="True" DataType="System.Int32" BaseColumnName="ID">
							<Footer Key="ID"></Footer>
							<Header Key="ID" Caption="ID"></Header>
						</igtbl:UltraGridColumn>
						<igtbl:UltraGridColumn HeaderText="Type" Key="Type" IsBound="True" BaseColumnName="Type">
							<Footer Key="Type">
								<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
							</Footer>
							<Header Key="Type" Caption="Type">
								<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
							</Header>
						</igtbl:UltraGridColumn>
					</Columns>
					<DropDownLayout DropdownWidth="" BorderCollapse="Separate" RowSelectors="No" RowHeightDefault="20px"
						HeaderClickAction="Select" DropdownHeight="" ColHeadersVisible="No">
						<RowStyle BorderWidth="1px" BorderColor="Black" BorderStyle="Solid">
							<Padding Left="3px"></Padding>
							<BorderDetails WidthLeft="0px" WidthTop="0px"></BorderDetails>
						</RowStyle>
						<SelectedRowStyle ForeColor="White" BackColor="#F09D21" CustomRules="background-image:url(/ig_common/images/Office2003SelRow.png);background-repeat:repeat-x;"></SelectedRowStyle>
						<HeaderStyle Font-Size="X-Small" Font-Names="Arial" Font-Bold="True" BorderStyle="Solid" ForeColor="#E1E8F5"
							BackColor="#11459E" CustomRules="background-image:url(/ig_common/images/Office2003BlueBG.png);background-repeat:repeat-x;">
							<BorderDetails ColorTop="173, 197, 235" WidthLeft="1px" WidthTop="1px" ColorLeft="173, 197, 235"></BorderDetails>
						</HeaderStyle>
						<FrameStyle Cursor="Default" BorderWidth="1px" Font-Size="8pt" Font-Names="Verdana" BorderStyle="Solid"
							BackColor="Silver"></FrameStyle>
					</DropDownLayout>
					<ExpandEffects ShadowColor="LightGray"></ExpandEffects>
				</igcmbo:webcombo><igcmbo:webcombo id=MenuCombo runat="server" Width="200px" Height="22px" DataMember="菜单" DataSource="<%# sm1 %>" Version="3.00" BackColor="White" BorderStyle="Solid" BorderColor="LightGray" BorderWidth="1px" ForeColor="Black" DropImage1="/ig_common/images/Office2003DropDownBlue.gif" DropImage2="/ig_common/images/Office2003DropDownOrange.gif" DropImageXP1="/ig_common/images/Office2003DropDownBlue.gif" DropImageXP2="/ig_common/images/Office2003DropDownOrange.gif" SelBackColor="17, 69, 158" DataTextField="item" DataValueField="ID">
					<Columns>
						<igtbl:UltraGridColumn HeaderText="ID" Key="ID" IsBound="True" Hidden="True" DataType="System.Int32" BaseColumnName="ID">
							<Footer Key="ID"></Footer>
							<Header Key="ID" Caption="ID"></Header>
						</igtbl:UltraGridColumn>
						<igtbl:UltraGridColumn HeaderText="item" Key="item" IsBound="True" BaseColumnName="item">
							<Footer Key="item">
								<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
							</Footer>
							<Header Key="item" Caption="item">
								<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
							</Header>
						</igtbl:UltraGridColumn>
					</Columns>
					<DropDownLayout DropdownWidth="" BorderCollapse="Separate" RowSelectors="No" RowHeightDefault="20px"
						HeaderClickAction="Select" DropdownHeight="" ColHeadersVisible="No">
						<RowStyle BorderWidth="1px" BorderColor="Black" BorderStyle="Solid">
							<Padding Left="3px"></Padding>
							<BorderDetails WidthLeft="0px" WidthTop="0px"></BorderDetails>
						</RowStyle>
						<SelectedRowStyle ForeColor="White" BackColor="#F09D21" CustomRules="background-image:url(/ig_common/images/Office2003SelRow.png);background-repeat:repeat-x;"></SelectedRowStyle>
						<HeaderStyle Font-Size="X-Small" Font-Names="Arial" Font-Bold="True" BorderStyle="Solid" ForeColor="#E1E8F5"
							BackColor="#11459E" CustomRules="background-image:url(/ig_common/images/Office2003BlueBG.png);background-repeat:repeat-x;">
							<BorderDetails ColorTop="173, 197, 235" WidthLeft="1px" WidthTop="1px" ColorLeft="173, 197, 235"></BorderDetails>
						</HeaderStyle>
						<FrameStyle Cursor="Default" BorderWidth="1px" Font-Size="8pt" Font-Names="Verdana" BorderStyle="Solid"
							BackColor="Silver"></FrameStyle>
					</DropDownLayout>
					<ExpandEffects ShadowColor="LightGray"></ExpandEffects>
				</igcmbo:webcombo><BR>
				<BR>
				<igtxt:webimagebutton id="Sumbit" runat="server" DESIGNTIMEDRAGDROP="299" Text="提交" UseBrowserDefaults="False">
					<RoundedCorners MaxHeight="40" ImageUrl="ig_butCRM1.gif" MaxWidth="400" HoverImageUrl="ig_butCRM2.gif"
						RenderingType="FileImages" HeightOfBottomEdge="2" PressedImageUrl="ig_butCRM2.gif" WidthOfRightEdge="2"></RoundedCorners>
				</igtxt:webimagebutton>&nbsp;
				<igtxt:webimagebutton id="Cancel" runat="server" Text="取消" UseBrowserDefaults="False">
					<RoundedCorners MaxHeight="40" ImageUrl="ig_butCRM1.gif" MaxWidth="400" HoverImageUrl="ig_butCRM2.gif"
						RenderingType="FileImages" HeightOfBottomEdge="2" PressedImageUrl="ig_butCRM2.gif" WidthOfRightEdge="2"></RoundedCorners>
				</igtxt:webimagebutton></FONT></form>
	</body>
</HTML>
