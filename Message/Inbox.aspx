<%@ Register TagPrefix="igtbl" Namespace="Infragistics.WebUI.UltraWebGrid" Assembly="Infragistics.WebUI.UltraWebGrid.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igtxt" Namespace="Infragistics.WebUI.WebDataInput" Assembly="Infragistics.WebUI.WebDataInput.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Page language="c#" Codebehind="Inbox.aspx.cs" AutoEventWireup="false" Inherits="LIMS.Message.Inbox" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Inbox</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" borderColor="silver" cellSpacing="0" cellPadding="0" width="300" border="1">
				<TR>
					<TD>
						<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="300" border="0">
							<TR>
								<TD><FONT face="宋体"><igtbl:ultrawebgrid id=Message runat="server" DataMember="收件箱" DataSource="<%# dsMessage1 %>" Browser="Xml" Width="700px" ImageDirectory="/ig_common/Images/">
											<DisplayLayout ColWidthDefault="" AllowSortingDefault="OnClient" Version="3.00" SelectTypeRowDefault="Single"
												HeaderClickActionDefault="SortMulti" BorderCollapseDefault="Separate" RowSelectorsDefault="No"
												Name="Message">
												<AddNewBox>
													<Style BorderWidth="1px" BorderStyle="Solid" BackColor="LightGray">

<BorderDetails ColorTop="White" WidthLeft="1px" WidthTop="1px" ColorLeft="White">
</BorderDetails>

													</Style>
												</AddNewBox>
												<Pager PageSize="10" AllowPaging="True">
													<Style BorderWidth="1px" BorderStyle="Solid" BackColor="LightGray">

<BorderDetails ColorTop="White" WidthLeft="1px" WidthTop="1px" ColorLeft="White">
</BorderDetails>

													</Style>
												</Pager>
												<HeaderStyleDefault BorderColor="Black" BorderStyle="Solid" ForeColor="White" BackColor="#2B64A7">
													<BorderDetails ColorTop="White" WidthLeft="1px" WidthTop="1px" ColorLeft="White"></BorderDetails>
												</HeaderStyleDefault>
												<FrameStyle Width="700px" Cursor="Default" BorderWidth="3px" BorderColor="#999999" BorderStyle="None"></FrameStyle>
												<ActivationObject BorderStyle="Dotted"></ActivationObject>
												<GroupByBox>
													<Style BackColor="#B5CFF7">
													</Style>
													<BandLabelStyle ForeColor="White" BackColor="#6372D4"></BandLabelStyle>
												</GroupByBox>
												<SelectedRowStyleDefault ForeColor="White" BackColor="#0A75F0"></SelectedRowStyleDefault>
												<RowAlternateStyleDefault BackColor="#E9E9F7"></RowAlternateStyleDefault>
												<RowStyleDefault BorderWidth="1px" BorderColor="Gray" BorderStyle="Solid" BackColor="#C7D5E8">
													<BorderDetails ColorTop="Gray" WidthLeft="0px" WidthTop="0px" ColorLeft="Gray"></BorderDetails>
												</RowStyleDefault>
											</DisplayLayout>
											<Bands>
												<igtbl:UltraGridBand AddButtonCaption="收件箱" BaseTableName="收件箱" Key="收件箱">
													<RowAlternateStyle Height="25px"></RowAlternateStyle>
													<Columns>
														<igtbl:UltraGridColumn HeaderText="" Key="selected" EditorControlID="" FormulaErrorValue="" Width="20px"
															Type="CheckBox" Format="" Formula="" BaseColumnName="" AllowUpdate="Yes" FooterText="">
															<Footer Formula="" Key="selected" Caption="" Title=""></Footer>
															<Header Key="selected" Caption="" Title=""></Header>
														</igtbl:UltraGridColumn>
														<igtbl:UltraGridColumn HeaderText="ID" Key="ID" IsBound="True" EditorControlID="" FormulaErrorValue=""
															Hidden="True" Format="" DataType="System.Int32" Formula="" BaseColumnName="ID" FooterText="">
															<Footer Formula="" Key="ID" Caption="" Title="">
																<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
															</Footer>
															<Header Key="ID" Caption="ID" Title="">
																<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
															</Header>
														</igtbl:UltraGridColumn>
														<igtbl:UltraGridColumn HeaderText="标题" Key="标题" IsBound="True" EditorControlID="" FormulaErrorValue=""
															Type="HyperLink" Format="" Formula="" BaseColumnName="标题" FooterText="">
															<Footer Formula="" Key="标题" Caption="" Title="">
																<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
															</Footer>
															<Header Key="标题" Caption="标题" Title="">
																<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
															</Header>
														</igtbl:UltraGridColumn>
														<igtbl:UltraGridColumn HeaderText="发件人" Key="发件人" IsBound="True" EditorControlID="" FormulaErrorValue=""
															Width="100px" Format="" Formula="" BaseColumnName="发件人" FooterText="">
															<Footer Formula="" Key="发件人" Caption="" Title="">
																<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
															</Footer>
															<Header Key="发件人" Caption="发件人" Title="">
																<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
															</Header>
														</igtbl:UltraGridColumn>
														<igtbl:UltraGridColumn HeaderText="日期" Key="日期" IsBound="True" EditorControlID="" FormulaErrorValue=""
															Width="150px" Format="yyyy年MM月dd日" DataType="System.DateTime" Formula="" BaseColumnName="日期" FooterText="">
															<Footer Formula="" Key="日期" Caption="" Title="">
																<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
															</Footer>
															<Header Key="日期" Caption="日期" Title="">
																<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
															</Header>
														</igtbl:UltraGridColumn>
														<igtbl:UltraGridColumn HeaderText="收件人ID" Key="收件人ID" IsBound="True" EditorControlID="" FormulaErrorValue=""
															Hidden="True" Format="" DataType="System.Int32" Formula="" BaseColumnName="收件人ID" FooterText="">
															<Footer Formula="" Key="收件人ID" Caption="" Title="">
																<RowLayoutColumnInfo OriginX="5"></RowLayoutColumnInfo>
															</Footer>
															<Header Key="收件人ID" Caption="收件人ID" Title="">
																<RowLayoutColumnInfo OriginX="5"></RowLayoutColumnInfo>
															</Header>
														</igtbl:UltraGridColumn>
														<igtbl:UltraGridColumn HeaderText="已阅" Key="已阅" IsBound="True" EditorControlID="" FormulaErrorValue=""
															Hidden="True" Type="CheckBox" Format="" DataType="System.Boolean" Formula="" BaseColumnName="已阅" FooterText="">
															<Footer Formula="" Key="已阅" Caption="" Title="">
																<RowLayoutColumnInfo OriginX="6"></RowLayoutColumnInfo>
															</Footer>
															<Header Key="已阅" Caption="已阅" Title="">
																<RowLayoutColumnInfo OriginX="6"></RowLayoutColumnInfo>
															</Header>
														</igtbl:UltraGridColumn>
													</Columns>
													<RowStyle Height="25px"></RowStyle>
													<SelectedRowStyle BackColor="#CAD3E4"></SelectedRowStyle>
												</igtbl:UltraGridBand>
											</Bands>
										</igtbl:ultrawebgrid></FONT></TD>
							</TR>
							<TR>
								<TD><FONT face="宋体">
										<TABLE id="Table2" cellSpacing="0" cellPadding="0" border="0">
											<TR>
												<TD><igtxt:webimagebutton id="Del" runat="server" Text="删除" UseBrowserDefaults="False" DESIGNTIMEDRAGDROP="38">
														<RoundedCorners MaxHeight="40" ImageUrl="ig_butCRM1.gif" MaxWidth="400" HoverImageUrl="ig_butCRM2.gif"
															RenderingType="FileImages" HeightOfBottomEdge="2" PressedImageUrl="ig_butCRM2.gif" WidthOfRightEdge="2"></RoundedCorners>
													</igtxt:webimagebutton></TD>
												<TD style="WIDTH: 20px"></TD>
												<TD></TD>
												<TD style="WIDTH: 20px"></TD>
												<TD></TD>
												<TD></TD>
											</TR>
										</TABLE>
									</FONT>
								</TD>
							</TR>
							<TR>
								<TD><FONT face="宋体"></FONT></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
