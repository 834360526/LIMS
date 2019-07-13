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
			<FONT face="宋体">
				<P><BR>
					<TABLE id="Table1" cellSpacing="0" cellPadding="4" border="0">
						<TR>
							<TD style="FONT-SIZE: 14px">送检单位：</TD>
							<TD>
								<igcmbo:webcombo id=Com runat="server" Height="8px" Width="250px" Version="3.00" BackColor="White" BorderStyle="Solid" BorderColor="LightGray" BorderWidth="1px" ForeColor="Black" DataSource="<%# work1 %>" DataMember="送检单位" SelBackColor="17, 69, 158" DropImageXP2="/ig_common/images/Office2003DropDownOrange.gif" DropImageXP1="/ig_common/images/Office2003DropDownBlue.gif" DropImage2="/ig_common/images/Office2003DropDownOrange.gif" DropImage1="/ig_common/images/Office2003DropDownBlue.gif" DataValueField="单位名称">
									<Columns>
										<igtbl:UltraGridColumn HeaderText="单位名称" Key="单位名称" IsBound="True" BaseColumnName="单位名称">
											<Footer Key="单位名称"></Footer>
											<Header Key="单位名称" Caption="单位名称"></Header>
										</igtbl:UltraGridColumn>
										<igtbl:UltraGridColumn HeaderText="地址" Key="地址" IsBound="True" BaseColumnName="地址">
											<Footer Key="地址">
												<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
											</Footer>
											<Header Key="地址" Caption="地址">
												<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
											</Header>
										</igtbl:UltraGridColumn>
										<igtbl:UltraGridColumn HeaderText="电话" Key="电话" IsBound="True" BaseColumnName="电话">
											<Footer Key="电话">
												<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
											</Footer>
											<Header Key="电话" Caption="电话">
												<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
											</Header>
										</igtbl:UltraGridColumn>
										<igtbl:UltraGridColumn HeaderText="邮编" Key="邮编" IsBound="True" BaseColumnName="邮编">
											<Footer Key="邮编">
												<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
											</Footer>
											<Header Key="邮编" Caption="邮编">
												<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
											</Header>
										</igtbl:UltraGridColumn>
										<igtbl:UltraGridColumn HeaderText="传真号" Key="传真号" IsBound="True" BaseColumnName="传真号">
											<Footer Key="传真号">
												<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
											</Footer>
											<Header Key="传真号" Caption="传真号">
												<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
											</Header>
										</igtbl:UltraGridColumn>
										<igtbl:UltraGridColumn HeaderText="联系人" Key="联系人" IsBound="True" BaseColumnName="联系人">
											<Footer Key="联系人">
												<RowLayoutColumnInfo OriginX="5"></RowLayoutColumnInfo>
											</Footer>
											<Header Key="联系人" Caption="联系人">
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
							<TD style="FONT-SIZE: 14px">委托单号：</TD>
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
								<igtxt:webimagebutton id="btQuery" runat="server" UseBrowserDefaults="False" Text="查询">
									<RoundedCorners MaxHeight="40" ImageUrl="ig_butCRM1.gif" MaxWidth="400" HoverImageUrl="ig_butCRM2.gif"
										RenderingType="FileImages" HeightOfBottomEdge="2" PressedImageUrl="ig_butCRM2.gif" WidthOfRightEdge="2"></RoundedCorners>
								</igtxt:webimagebutton></TD>
							<TD></TD>
							<TD>
								<igtxt:webimagebutton id="Refresh" runat="server" UseBrowserDefaults="False" Text="刷新">
									<RoundedCorners MaxHeight="40" ImageUrl="ig_butCRM1.gif" MaxWidth="400" HoverImageUrl="ig_butCRM2.gif"
										RenderingType="FileImages" HeightOfBottomEdge="2" PressedImageUrl="ig_butCRM2.gif" WidthOfRightEdge="2"></RoundedCorners>
								</igtxt:webimagebutton></TD>
						</TR>
					</TABLE>
					<BR>
					<igtbl:ultrawebgrid id=FreshData runat="server" ImageDirectory="/ig_common/Images/" Height="250px" Width="700px" Browser="Xml" DataSource="<%# keepBook1 %>" DataMember="检校任务">
						<DisplayLayout UseFixedHeaders="True" AllowSortingDefault="OnClient" RowHeightDefault="21px" Version="3.00"
							SelectTypeRowDefault="Single" AllowColumnMovingDefault="OnClient" BorderCollapseDefault="Separate"
							FixedHeaderIndicatorDefault="Button" Name="FreshData" TableLayout="Fixed" CellClickActionDefault="Edit">
							<AddNewBox>
								<Style BorderWidth="1px" BorderColor="InactiveCaption" BorderStyle="Solid" BackColor="Window">

<BorderDetails ColorTop="White" WidthLeft="1px" WidthTop="1px" ColorLeft="White">
</BorderDetails>

								</Style>
							</AddNewBox>
							<Pager PrevText="上一页" NextText="下一页" PageSize="20" AllowPaging="True">
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
							<igtbl:UltraGridBand AddButtonCaption="检校任务" BaseTableName="检校任务" Key="检校任务">
								<Columns>
									<igtbl:UltraGridColumn HeaderText="选择" Key="选择" Width="40px" Type="CheckBox" BaseColumnName="" AllowUpdate="Yes">
										<Footer Key="选择"></Footer>
										<Header Key="选择" Caption="选择"></Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="编号" Key="编号" IsBound="True" BaseColumnName="编号">
										<Footer Key="编号">
											<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="编号" Caption="编号">
											<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="器具名称" Key="器具名称" IsBound="True" BaseColumnName="器具名称">
										<Footer Key="器具名称">
											<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="器具名称" Caption="器具名称">
											<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="器具数量" Key="器具数量" IsBound="True" DataType="System.Int32" BaseColumnName="器具数量">
										<Footer Key="器具数量">
											<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="器具数量" Caption="器具数量">
											<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="型号规格" Key="型号规格" IsBound="True" BaseColumnName="型号规格">
										<Footer Key="型号规格">
											<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="型号规格" Caption="型号规格">
											<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="出厂编号" Key="出厂编号" IsBound="True" BaseColumnName="出厂编号">
										<Footer Key="出厂编号">
											<RowLayoutColumnInfo OriginX="5"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="出厂编号" Caption="出厂编号">
											<RowLayoutColumnInfo OriginX="5"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="送检单位" Key="送检单位" IsBound="True" BaseColumnName="送检单位">
										<Footer Key="送检单位">
											<RowLayoutColumnInfo OriginX="6"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="送检单位" Caption="送检单位">
											<RowLayoutColumnInfo OriginX="6"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="检定科室" Key="检定科室" IsBound="True" BaseColumnName="检定科室">
										<Footer Key="检定科室">
											<RowLayoutColumnInfo OriginX="7"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="检定科室" Caption="检定科室">
											<RowLayoutColumnInfo OriginX="7"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="检校类别" Key="检校类别" IsBound="True" BaseColumnName="检校类别">
										<Footer Key="检校类别">
											<RowLayoutColumnInfo OriginX="8"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="检校类别" Caption="检校类别">
											<RowLayoutColumnInfo OriginX="8"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="送检日期" Key="送检日期" IsBound="True" DataType="System.DateTime" BaseColumnName="送检日期">
										<Footer Key="送检日期">
											<RowLayoutColumnInfo OriginX="9"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="送检日期" Caption="送检日期">
											<RowLayoutColumnInfo OriginX="9"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="检定费用" Key="检定费用" IsBound="True" DataType="System.Decimal" BaseColumnName="检定费用">
										<Footer Key="检定费用">
											<RowLayoutColumnInfo OriginX="10"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="检定费用" Caption="检定费用">
											<RowLayoutColumnInfo OriginX="10"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="校准费用" Key="校准费用" IsBound="True" DataType="System.Decimal" BaseColumnName="校准费用">
										<Footer Key="校准费用">
											<RowLayoutColumnInfo OriginX="11"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="校准费用" Caption="校准费用">
											<RowLayoutColumnInfo OriginX="11"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="修理费用" Key="修理费用" IsBound="True" DataType="System.Decimal" BaseColumnName="修理费用">
										<Footer Key="修理费用">
											<RowLayoutColumnInfo OriginX="12"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="修理费用" Caption="修理费用">
											<RowLayoutColumnInfo OriginX="12"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="配件费用" Key="配件费用" IsBound="True" DataType="System.Decimal" BaseColumnName="配件费用">
										<Footer Key="配件费用">
											<RowLayoutColumnInfo OriginX="13"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="配件费用" Caption="配件费用">
											<RowLayoutColumnInfo OriginX="13"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="应交费用" Key="应交费用" IsBound="True" DataType="System.Decimal" BaseColumnName="应交费用">
										<Footer Key="应交费用">
											<RowLayoutColumnInfo OriginX="14"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="应交费用" Caption="应交费用">
											<RowLayoutColumnInfo OriginX="14"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="实交费用" Key="实交费用" IsBound="True" DataType="System.Decimal" BaseColumnName="实交费用">
										<Footer Key="实交费用">
											<RowLayoutColumnInfo OriginX="15"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="实交费用" Caption="实交费用">
											<RowLayoutColumnInfo OriginX="15"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="交费日期" Key="交费日期" IsBound="True" DataType="System.DateTime" BaseColumnName="交费日期">
										<Footer Key="交费日期">
											<RowLayoutColumnInfo OriginX="16"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="交费日期" Caption="交费日期">
											<RowLayoutColumnInfo OriginX="16"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="完成日期" Key="完成日期" IsBound="True" DataType="System.DateTime" BaseColumnName="完成日期">
										<Footer Key="完成日期">
											<RowLayoutColumnInfo OriginX="17"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="完成日期" Caption="完成日期">
											<RowLayoutColumnInfo OriginX="17"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="检校方式" Key="检校方式" IsBound="True" BaseColumnName="检校方式">
										<Footer Key="检校方式">
											<RowLayoutColumnInfo OriginX="18"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="检校方式" Caption="检校方式">
											<RowLayoutColumnInfo OriginX="18"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="备注" Key="备注" IsBound="True" BaseColumnName="备注">
										<Footer Key="备注">
											<RowLayoutColumnInfo OriginX="19"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="备注" Caption="备注">
											<RowLayoutColumnInfo OriginX="19"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="送检单位地址" Key="送检单位地址" IsBound="True" BaseColumnName="送检单位地址">
										<Footer Key="送检单位地址">
											<RowLayoutColumnInfo OriginX="20"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="送检单位地址" Caption="送检单位地址">
											<RowLayoutColumnInfo OriginX="20"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="邮政编码" Key="邮政编码" IsBound="True" BaseColumnName="邮政编码">
										<Footer Key="邮政编码">
											<RowLayoutColumnInfo OriginX="21"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="邮政编码" Caption="邮政编码">
											<RowLayoutColumnInfo OriginX="21"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="委托人" Key="委托人" IsBound="True" BaseColumnName="委托人">
										<Footer Key="委托人">
											<RowLayoutColumnInfo OriginX="22"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="委托人" Caption="委托人">
											<RowLayoutColumnInfo OriginX="22"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="电话" Key="电话" IsBound="True" BaseColumnName="电话">
										<Footer Key="电话">
											<RowLayoutColumnInfo OriginX="23"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="电话" Caption="电话">
											<RowLayoutColumnInfo OriginX="23"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="传真号" Key="传真号" IsBound="True" BaseColumnName="传真号">
										<Footer Key="传真号">
											<RowLayoutColumnInfo OriginX="24"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="传真号" Caption="传真号">
											<RowLayoutColumnInfo OriginX="24"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
								</Columns>
							</igtbl:UltraGridBand>
						</Bands>
					</igtbl:ultrawebgrid><BR>
					<BR>
					<igtxt:webimagebutton id="Submit" runat="server" DESIGNTIMEDRAGDROP="189" UseBrowserDefaults="False" Text="提交">
						<RoundedCorners MaxHeight="40" ImageUrl="ig_butCRM1.gif" MaxWidth="400" HoverImageUrl="ig_butCRM2.gif"
							RenderingType="FileImages" HeightOfBottomEdge="2" PressedImageUrl="ig_butCRM2.gif" WidthOfRightEdge="2"></RoundedCorners>
					</igtxt:webimagebutton></P>
			</FONT>
		</form>
	</body>
</HTML>
