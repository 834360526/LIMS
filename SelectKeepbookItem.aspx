<%@ Register TagPrefix="igtbl" Namespace="Infragistics.WebUI.UltraWebGrid" Assembly="Infragistics.WebUI.UltraWebGrid.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="cc1" Namespace="Infragistics.WebUI.UltraWebGrid.ExcelExport" Assembly="Infragistics.WebUI.UltraWebGrid.ExcelExport.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igtxt" Namespace="Infragistics.WebUI.WebDataInput" Assembly="Infragistics.WebUI.WebDataInput.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Page language="c#" Codebehind="SelectKeepbookItem.aspx.cs" AutoEventWireup="false" Inherits="LIMS.Work.SelectKeepbookItem" %>
<%@ Register TagPrefix="igcmbo" Namespace="Infragistics.WebUI.WebCombo" Assembly="Infragistics.WebUI.WebCombo.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>SelectKeepbookItem</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="����">
				<P><BR>
					<TABLE id="Table1" cellSpacing="0" cellPadding="4" border="0">
						<TR>
							<TD style="FONT-SIZE: 14px">�ͼ쵥λ��</TD>
							<TD>
								<igcmbo:webcombo id=Com runat="server" Height="8px" Width="250px" Version="3.00" BackColor="White" BorderStyle="Solid" BorderColor="LightGray" BorderWidth="1px" ForeColor="Black" DataSource="<%# work1 %>" DataMember="�ͼ쵥λ" SelBackColor="17, 69, 158" DropImageXP2="/ig_common/images/Office2003DropDownOrange.gif" DropImageXP1="/ig_common/images/Office2003DropDownBlue.gif" DropImage2="/ig_common/images/Office2003DropDownOrange.gif" DropImage1="/ig_common/images/Office2003DropDownBlue.gif" DataValueField="��λ����">
									<Columns>
										<igtbl:UltraGridColumn HeaderText="��λ����" Key="��λ����" IsBound="True" BaseColumnName="��λ����">
											<Footer Key="��λ����"></Footer>
											<Header Key="��λ����" Caption="��λ����"></Header>
										</igtbl:UltraGridColumn>
										<igtbl:UltraGridColumn HeaderText="��ַ" Key="��ַ" IsBound="True" BaseColumnName="��ַ">
											<Footer Key="��ַ">
												<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
											</Footer>
											<Header Key="��ַ" Caption="��ַ">
												<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
											</Header>
										</igtbl:UltraGridColumn>
										<igtbl:UltraGridColumn HeaderText="�绰" Key="�绰" IsBound="True" BaseColumnName="�绰">
											<Footer Key="�绰">
												<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
											</Footer>
											<Header Key="�绰" Caption="�绰">
												<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
											</Header>
										</igtbl:UltraGridColumn>
										<igtbl:UltraGridColumn HeaderText="�ʱ�" Key="�ʱ�" IsBound="True" BaseColumnName="�ʱ�">
											<Footer Key="�ʱ�">
												<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
											</Footer>
											<Header Key="�ʱ�" Caption="�ʱ�">
												<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
											</Header>
										</igtbl:UltraGridColumn>
										<igtbl:UltraGridColumn HeaderText="�����" Key="�����" IsBound="True" BaseColumnName="�����">
											<Footer Key="�����">
												<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
											</Footer>
											<Header Key="�����" Caption="�����">
												<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
											</Header>
										</igtbl:UltraGridColumn>
										<igtbl:UltraGridColumn HeaderText="��ϵ��" Key="��ϵ��" IsBound="True" BaseColumnName="��ϵ��">
											<Footer Key="��ϵ��">
												<RowLayoutColumnInfo OriginX="5"></RowLayoutColumnInfo>
											</Footer>
											<Header Key="��ϵ��" Caption="��ϵ��">
												<RowLayoutColumnInfo OriginX="5"></RowLayoutColumnInfo>
											</Header>
										</igtbl:UltraGridColumn>
										<igtbl:UltraGridColumn HeaderText="ID" Key="ID" IsBound="True" Hidden="True" DataType="System.Int32" BaseColumnName="ID">
											<Footer Key="ID">
												<RowLayoutColumnInfo OriginX="6"></RowLayoutColumnInfo>
											</Footer>
											<Header Key="ID" Caption="ID">
												<RowLayoutColumnInfo OriginX="6"></RowLayoutColumnInfo>
											</Header>
										</igtbl:UltraGridColumn>
									</Columns>
									<ClientSideEvents AfterSelectChange="Offic_AfterSelectChange"></ClientSideEvents>
									<DropDownLayout DropdownWidth="" BorderCollapse="Separate" AllowColSizing="Free" RowHeightDefault="20px"
										HeaderClickAction="Select" AllowSorting="OnClient" RowSizing="Free" DropdownHeight="150px" ColWidthDefault=""
										AllowRowSizing="Free">
										<RowStyle BorderWidth="1px" Font-Size="12px" Font-Names="Tahoma" BorderColor="Black" BorderStyle="Solid">
											<Padding Left="3px"></Padding>
											<BorderDetails WidthLeft="0px" WidthTop="0px"></BorderDetails>
										</RowStyle>
										<SelectedRowStyle ForeColor="White" BackColor="#F09D21" CustomRules="background-image:url(/ig_common/images/Office2003SelRow.png);background-repeat:repeat-x;"></SelectedRowStyle>
										<HeaderStyle Font-Size="X-Small" Font-Names="Arial" Font-Bold="True" BorderStyle="Solid" ForeColor="#E1E8F5"
											BackColor="#11459E" CustomRules="background-image:url(/ig_common/images/Office2003BlueBG.png);background-repeat:repeat-x;">
											<BorderDetails ColorTop="173, 197, 235" WidthLeft="1px" WidthTop="1px" ColorLeft="173, 197, 235"></BorderDetails>
										</HeaderStyle>
										<FrameStyle Cursor="Default" BorderWidth="1px" Font-Size="8pt" Font-Names="Verdana" BorderStyle="Solid"
											BackColor="Silver" Height="150px">
											<BorderDetails ColorTop="Black" ColorLeft="Black"></BorderDetails>
										</FrameStyle>
									</DropDownLayout>
									<ExpandEffects ShadowColor="LightGray"></ExpandEffects>
								</igcmbo:webcombo></TD>
							<TD></TD>
						</TR>
						<TR>
							<TD style="FONT-SIZE: 14px">ί�е��ţ�</TD>
							<TD>
								<igtxt:WebNumericEdit id="ProxySN" runat="server" Width="250px" BorderStyle="Solid" BorderColor="#7B9EBD"
									BorderWidth="1px" Font-Names="Tahoma" Font-Size="8pt" MinValue="0" DataMode="Int"></igtxt:WebNumericEdit></TD>
							<TD></TD>
						</TR>
						<TR>
							<TD colspan="2">
								<asp:Label id="Err" runat="server" ForeColor="Red" Font-Size="14px"></asp:Label></TD>
							<TD></TD>
						</TR>
					</TABLE>
					<TABLE id="Table2" cellSpacing="0" cellPadding="2" border="0">
						<TR>
							<TD>
								<igtxt:webimagebutton id="btQuery" runat="server" UseBrowserDefaults="False" Text="��ѯ">
									<RoundedCorners MaxHeight="40" ImageUrl="ig_butCRM1.gif" MaxWidth="400" HoverImageUrl="ig_butCRM2.gif"
										RenderingType="FileImages" HeightOfBottomEdge="2" PressedImageUrl="ig_butCRM2.gif" WidthOfRightEdge="2"></RoundedCorners>
								</igtxt:webimagebutton></TD>
							<TD></TD>
							<TD>
								<igtxt:webimagebutton id="Refresh" runat="server" UseBrowserDefaults="False" Text="ˢ��">
									<RoundedCorners MaxHeight="40" ImageUrl="ig_butCRM1.gif" MaxWidth="400" HoverImageUrl="ig_butCRM2.gif"
										RenderingType="FileImages" HeightOfBottomEdge="2" PressedImageUrl="ig_butCRM2.gif" WidthOfRightEdge="2"></RoundedCorners>
								</igtxt:webimagebutton></TD>
						</TR>
					</TABLE>
					<BR>
					<igtbl:ultrawebgrid id=FreshData runat="server" ImageDirectory="/ig_common/Images/" Height="250px" Width="700px" Browser="Xml" DataSource="<%# keepBook1 %>" DataMember="��У����">
						<DisplayLayout UseFixedHeaders="True" AllowSortingDefault="OnClient" RowHeightDefault="21px" Version="3.00"
							SelectTypeRowDefault="Single" AllowColumnMovingDefault="OnClient" BorderCollapseDefault="Separate"
							FixedHeaderIndicatorDefault="Button" Name="FreshData" TableLayout="Fixed" CellClickActionDefault="Edit">
							<AddNewBox>
								<Style BorderWidth="1px" BorderColor="InactiveCaption" BorderStyle="Solid" BackColor="Window">

<BorderDetails ColorTop="White" WidthLeft="1px" WidthTop="1px" ColorLeft="White">
</BorderDetails>

								</Style>
							</AddNewBox>
							<Pager PrevText="��һҳ" NextText="��һҳ" PageSize="20" AllowPaging="True">
								<Style BorderWidth="1px" BorderStyle="Solid" BackColor="LightGray">

<BorderDetails ColorTop="White" WidthLeft="1px" WidthTop="1px" ColorLeft="White">
</BorderDetails>

								</Style>
							</Pager>
							<HeaderStyleDefault Font-Size="X-Small" Font-Names="Arial" Font-Bold="True" BorderStyle="Solid" ForeColor="#EFEFF3"
								BackColor="#777697" CustomRules="background-image:url(/ig_common/images/Office2003SilverBG.png);background-repeat:repeat-x;">
								<BorderDetails ColorTop="211, 210, 223" WidthLeft="1px" WidthTop="1px" ColorLeft="211, 210, 223"></BorderDetails>
							</HeaderStyleDefault>
							<FrameStyle Width="700px" BorderWidth="1px" Font-Size="8pt" Font-Names="Verdana" BorderStyle="Solid"
								Height="250px"></FrameStyle>
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
							<igtbl:UltraGridBand AddButtonCaption="��У����" BaseTableName="��У����" Key="��У����">
								<Columns>
									<igtbl:UltraGridColumn HeaderText="ѡ��" Key="ѡ��" Width="40px" Type="CheckBox" BaseColumnName="" AllowUpdate="Yes">
										<Footer Key="ѡ��"></Footer>
										<Header Key="ѡ��" Caption="ѡ��"></Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="���" Key="���" IsBound="True" BaseColumnName="���">
										<Footer Key="���">
											<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="���" Caption="���">
											<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="��������" Key="��������" IsBound="True" BaseColumnName="��������">
										<Footer Key="��������">
											<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="��������" Caption="��������">
											<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="��������" Key="��������" IsBound="True" DataType="System.Int32" BaseColumnName="��������">
										<Footer Key="��������">
											<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="��������" Caption="��������">
											<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="�ͺŹ��" Key="�ͺŹ��" IsBound="True" BaseColumnName="�ͺŹ��">
										<Footer Key="�ͺŹ��">
											<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="�ͺŹ��" Caption="�ͺŹ��">
											<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="�������" Key="�������" IsBound="True" BaseColumnName="�������">
										<Footer Key="�������">
											<RowLayoutColumnInfo OriginX="5"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="�������" Caption="�������">
											<RowLayoutColumnInfo OriginX="5"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="�ͼ쵥λ" Key="�ͼ쵥λ" IsBound="True" BaseColumnName="�ͼ쵥λ">
										<Footer Key="�ͼ쵥λ">
											<RowLayoutColumnInfo OriginX="6"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="�ͼ쵥λ" Caption="�ͼ쵥λ">
											<RowLayoutColumnInfo OriginX="6"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="�춨����" Key="�춨����" IsBound="True" BaseColumnName="�춨����">
										<Footer Key="�춨����">
											<RowLayoutColumnInfo OriginX="7"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="�춨����" Caption="�춨����">
											<RowLayoutColumnInfo OriginX="7"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="��У���" Key="��У���" IsBound="True" BaseColumnName="��У���">
										<Footer Key="��У���">
											<RowLayoutColumnInfo OriginX="8"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="��У���" Caption="��У���">
											<RowLayoutColumnInfo OriginX="8"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="�ͼ�����" Key="�ͼ�����" IsBound="True" DataType="System.DateTime" BaseColumnName="�ͼ�����">
										<Footer Key="�ͼ�����">
											<RowLayoutColumnInfo OriginX="9"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="�ͼ�����" Caption="�ͼ�����">
											<RowLayoutColumnInfo OriginX="9"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="�춨����" Key="�춨����" IsBound="True" DataType="System.Decimal" BaseColumnName="�춨����">
										<Footer Key="�춨����">
											<RowLayoutColumnInfo OriginX="10"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="�춨����" Caption="�춨����">
											<RowLayoutColumnInfo OriginX="10"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="У׼����" Key="У׼����" IsBound="True" DataType="System.Decimal" BaseColumnName="У׼����">
										<Footer Key="У׼����">
											<RowLayoutColumnInfo OriginX="11"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="У׼����" Caption="У׼����">
											<RowLayoutColumnInfo OriginX="11"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="�������" Key="�������" IsBound="True" DataType="System.Decimal" BaseColumnName="�������">
										<Footer Key="�������">
											<RowLayoutColumnInfo OriginX="12"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="�������" Caption="�������">
											<RowLayoutColumnInfo OriginX="12"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="�������" Key="�������" IsBound="True" DataType="System.Decimal" BaseColumnName="�������">
										<Footer Key="�������">
											<RowLayoutColumnInfo OriginX="13"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="�������" Caption="�������">
											<RowLayoutColumnInfo OriginX="13"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="Ӧ������" Key="Ӧ������" IsBound="True" DataType="System.Decimal" BaseColumnName="Ӧ������">
										<Footer Key="Ӧ������">
											<RowLayoutColumnInfo OriginX="14"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="Ӧ������" Caption="Ӧ������">
											<RowLayoutColumnInfo OriginX="14"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="ʵ������" Key="ʵ������" IsBound="True" DataType="System.Decimal" BaseColumnName="ʵ������">
										<Footer Key="ʵ������">
											<RowLayoutColumnInfo OriginX="15"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="ʵ������" Caption="ʵ������">
											<RowLayoutColumnInfo OriginX="15"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="��������" Key="��������" IsBound="True" DataType="System.DateTime" BaseColumnName="��������">
										<Footer Key="��������">
											<RowLayoutColumnInfo OriginX="16"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="��������" Caption="��������">
											<RowLayoutColumnInfo OriginX="16"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="�������" Key="�������" IsBound="True" DataType="System.DateTime" BaseColumnName="�������">
										<Footer Key="�������">
											<RowLayoutColumnInfo OriginX="17"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="�������" Caption="�������">
											<RowLayoutColumnInfo OriginX="17"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="��У��ʽ" Key="��У��ʽ" IsBound="True" BaseColumnName="��У��ʽ">
										<Footer Key="��У��ʽ">
											<RowLayoutColumnInfo OriginX="18"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="��У��ʽ" Caption="��У��ʽ">
											<RowLayoutColumnInfo OriginX="18"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="��ע" Key="��ע" IsBound="True" BaseColumnName="��ע">
										<Footer Key="��ע">
											<RowLayoutColumnInfo OriginX="19"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="��ע" Caption="��ע">
											<RowLayoutColumnInfo OriginX="19"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="�ͼ쵥λ��ַ" Key="�ͼ쵥λ��ַ" IsBound="True" BaseColumnName="�ͼ쵥λ��ַ">
										<Footer Key="�ͼ쵥λ��ַ">
											<RowLayoutColumnInfo OriginX="20"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="�ͼ쵥λ��ַ" Caption="�ͼ쵥λ��ַ">
											<RowLayoutColumnInfo OriginX="20"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="��������" Key="��������" IsBound="True" BaseColumnName="��������">
										<Footer Key="��������">
											<RowLayoutColumnInfo OriginX="21"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="��������" Caption="��������">
											<RowLayoutColumnInfo OriginX="21"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="ί����" Key="ί����" IsBound="True" BaseColumnName="ί����">
										<Footer Key="ί����">
											<RowLayoutColumnInfo OriginX="22"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="ί����" Caption="ί����">
											<RowLayoutColumnInfo OriginX="22"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="�绰" Key="�绰" IsBound="True" BaseColumnName="�绰">
										<Footer Key="�绰">
											<RowLayoutColumnInfo OriginX="23"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="�绰" Caption="�绰">
											<RowLayoutColumnInfo OriginX="23"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="�����" Key="�����" IsBound="True" BaseColumnName="�����">
										<Footer Key="�����">
											<RowLayoutColumnInfo OriginX="24"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="�����" Caption="�����">
											<RowLayoutColumnInfo OriginX="24"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
								</Columns>
							</igtbl:UltraGridBand>
						</Bands>
					</igtbl:ultrawebgrid><BR>
					<BR>
					<igtxt:webimagebutton id="Submit" runat="server" DESIGNTIMEDRAGDROP="189" UseBrowserDefaults="False" Text="�ύ">
						<RoundedCorners MaxHeight="40" ImageUrl="ig_butCRM1.gif" MaxWidth="400" HoverImageUrl="ig_butCRM2.gif"
							RenderingType="FileImages" HeightOfBottomEdge="2" PressedImageUrl="ig_butCRM2.gif" WidthOfRightEdge="2"></RoundedCorners>
					</igtxt:webimagebutton></P>
			</FONT>
		</form>
	</body>
</HTML>
