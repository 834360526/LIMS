<%@ Register TagPrefix="igtxt" Namespace="Infragistics.WebUI.WebDataInput" Assembly="Infragistics.WebUI.WebDataInput.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igtbl" Namespace="Infragistics.WebUI.UltraWebGrid" Assembly="Infragistics.WebUI.UltraWebGrid.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Page language="c#" Codebehind="RoleOfUser.aspx.cs" AutoEventWireup="false" Inherits="LIMS.SystemManagement.RoleOfUser" smartNavigation="True"%>
<%@ Register TagPrefix="igcmbo" Namespace="Infragistics.WebUI.WebCombo" Assembly="Infragistics.WebUI.WebCombo.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>RoleOfUser</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="����">
				<P>
					<igtbl:ultrawebgrid id=dgRoleOfUser runat="server" ImageDirectory="/ig_common/Images/" DataSource="<%# sm1 %>" Height="300px" DataMember="�û���Ϣ" Width="600px">
						<DisplayLayout AllowDeleteDefault="Yes" AllowAddNewDefault="Yes" AllowSortingDefault="OnClient"
							RowHeightDefault="21px" RowSizingDefault="Free" Version="3.00" SelectTypeRowDefault="Single"
							ViewType="Hierarchical" AllowColumnMovingDefault="OnServer" HeaderClickActionDefault="SortSingle"
							BorderCollapseDefault="Separate" AllowColSizingDefault="Free" Name="dgRoleOfUser" TableLayout="Fixed"
							CellClickActionDefault="Edit" AllowUpdateDefault="Yes">
							<AddNewBox Hidden="False" Prompt="���...">
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
							<FrameStyle Width="600px" BorderWidth="1px" Font-Size="8pt" Font-Names="Verdana" BorderStyle="Solid"
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
							<igtbl:UltraGridBand SelectTypeCell="None" AddButtonCaption="�û���Ϣ" BaseTableName="�û���Ϣ" AllowUpdate="No"
								AllowAdd="No" SelectTypeRow="Single" Key="�û���Ϣ" AllowDelete="No" DataKeyField="ID">
								<Columns>
									<igtbl:UltraGridColumn HeaderText="�û���" Key="�û���" IsBound="True" BaseColumnName="�û���">
										<Footer Key="�û���"></Footer>
										<Header Key="�û���" Caption="�û���"></Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="����" Key="����" IsBound="True" BaseColumnName="����">
										<Footer Key="����">
											<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="����" Caption="����">
											<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="�Ա�" Key="�Ա�" IsBound="True" BaseColumnName="�Ա�">
										<Footer Key="�Ա�">
											<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="�Ա�" Caption="�Ա�">
											<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="����" Key="����" IsBound="True" BaseColumnName="����">
										<Footer Key="����">
											<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="����" Caption="����">
											<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="ID" Key="ID" IsBound="True" DataType="System.Int32" BaseColumnName="ID">
										<Footer Key="ID">
											<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="ID" Caption="ID">
											<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
								</Columns>
							</igtbl:UltraGridBand>
							<igtbl:UltraGridBand AddButtonCaption="�û���ɫ" BaseTableName="�û���ɫ" Key="�û���ɫ" DataKeyField="ID">
								<Columns>
									<igtbl:UltraGridColumn HeaderText="ID" Key="ID" IsBound="True" Hidden="True" DataType="System.Int32" BaseColumnName="ID">
										<Footer Key="ID"></Footer>
										<Header Key="ID" Caption="ID"></Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="�û�ID" Key="�û�ID" IsBound="True" Hidden="True" DataType="System.Int32"
										BaseColumnName="�û�ID">
										<Footer Key="�û�ID">
											<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="�û�ID" Caption="�û�ID">
											<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="�û���ɫ" Key="�û���ɫ" IsBound="True" EditorControlID="RoleCombo" Type="Custom"
										DataType="System.Int32" BaseColumnName="�û���ɫ">
										<Footer Key="�û���ɫ">
											<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="�û���ɫ" Caption="�û���ɫ">
											<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
								</Columns>
							</igtbl:UltraGridBand>
						</Bands>
					</igtbl:ultrawebgrid></P>
				<P>
					<igtxt:WebImageButton id="Confirm" runat="server" UseBrowserDefaults="False" Text="ȷ��" DESIGNTIMEDRAGDROP="810">
						<RoundedCorners MaxHeight="40" ImageUrl="ig_butCRM1.gif" MaxWidth="400" HoverImageUrl="ig_butCRM2.gif"
							RenderingType="FileImages" HeightOfBottomEdge="2" PressedImageUrl="ig_butCRM2.gif" WidthOfRightEdge="2"></RoundedCorners>
					</igtxt:WebImageButton>
					<igcmbo:WebCombo id=RoleCombo runat="server" DataMember="Role" Height="22px" DataSource="<%# sm1 %>" Version="3.00" BackColor="White" BorderStyle="Solid" BorderColor="LightGray" BorderWidth="1px" ForeColor="Black" Width="200px" SelBackColor="17, 69, 158" DropImageXP2="/ig_common/images/Office2003DropDownOrange.gif" DropImageXP1="/ig_common/images/Office2003DropDownBlue.gif" DropImage2="/ig_common/images/Office2003DropDownOrange.gif" DropImage1="/ig_common/images/Office2003DropDownBlue.gif" DataValueField="ID" DataTextField="role">
						<Columns>
							<igtbl:UltraGridColumn HeaderText="ID" Key="ID" IsBound="True" Hidden="True" DataType="System.Int32" BaseColumnName="ID">
								<Footer Key="ID"></Footer>
								<Header Key="ID" Caption="ID"></Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="��ɫ" Key="role" IsBound="True" BaseColumnName="role">
								<Footer Key="role">
									<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="role" Caption="��ɫ">
									<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="����" Key="description" IsBound="True" BaseColumnName="description">
								<Footer Key="description">
									<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="description" Caption="����">
									<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
						</Columns>
						<DropDownLayout DropdownWidth="" BorderCollapse="Separate" RowSelectors="No" RowHeightDefault="20px"
							HeaderClickAction="Select" DropdownHeight="">
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
					</igcmbo:WebCombo></P>
			</FONT>
		</form>
	</body>
</HTML>
