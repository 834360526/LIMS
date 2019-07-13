<%@ Register TagPrefix="iglbar" Namespace="Infragistics.WebUI.UltraWebListbar" Assembly="Infragistics.WebUI.UltraWebListbar.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igtbl" Namespace="Infragistics.WebUI.UltraWebGrid" Assembly="Infragistics.WebUI.UltraWebGrid.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="uc1" TagName="IndividualTree" Src="Control/IndividualTree.ascx" %>
<%@ Page language="c#" Codebehind="WebForm2.aspx.cs" AutoEventWireup="false" Inherits="LIMS.WebForm2" %>
<%@ Register TagPrefix="igcalc" Namespace="Infragistics.WebUI.UltraWebCalcManager" Assembly="Infragistics.WebUI.UltraWebCalcManager.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm2</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body XMLNS:igtbl="http://schemas.infragistics.com/ASPNET/WebControls/UltraWebGrid">
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">
				<asp:DataList id=dl runat="server" BorderColor="#999999" BorderStyle="None" BackColor="White" CellPadding="3" GridLines="Both" BorderWidth="1px" DataSource="<%# ds1 %>" DataMember="党群机关" DataKeyField="职位名称">
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#008A8C"></SelectedItemStyle>
					<HeaderTemplate>
						dd
					</HeaderTemplate>
					<AlternatingItemStyle BackColor="Gainsboro"></AlternatingItemStyle>
					<FooterStyle ForeColor="Black" BackColor="#CCCCCC"></FooterStyle>
					<FooterTemplate>
						dss
					</FooterTemplate>
					<ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
					<ItemTemplate>
						<%# DataBinder.Eval(Container, "DataItem.职位名称") %>
					</ItemTemplate>
					<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#000084"></HeaderStyle>
				</asp:DataList>
				<igcalc:UltraWebCalcManager id="UltraWebCalcManager1" runat="server"></igcalc:UltraWebCalcManager>
				<igtbl:UltraWebGrid id=ug runat="server" DataMember="党群机关" DataSource="<%# ds1 %>" ImageDirectory="/ig_common/Images/" Width="750px" Height="500px" >
					<DisplayLayout RowHeightDefault="21px" Version="3.00" BorderCollapseDefault="Separate" Name="ug"
						TableLayout="Fixed" ExpandableDefault="No">
						<AddNewBox>
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
						<HeaderStyleDefault Font-Size="X-Small" Font-Names="Arial" Font-Bold="True" BorderStyle="Solid" ForeColor="#EFEFF3"
							BackColor="#777697" CustomRules="background-image:url(/ig_common/images/Office2003SilverBG.png);background-repeat:repeat-x;">
							<BorderDetails ColorTop="211, 210, 223" WidthLeft="1px" WidthTop="1px" ColorLeft="211, 210, 223"></BorderDetails>
						</HeaderStyleDefault>
						<FrameStyle Width="750px" BorderWidth="1px" Font-Size="8pt" Font-Names="Verdana" BorderStyle="Solid"
							Height="500px"></FrameStyle>
						<FooterStyleDefault BorderWidth="1px" BorderStyle="Solid" BackColor="LightGray">
							<BorderDetails ColorTop="White" WidthLeft="1px" WidthTop="1px" ColorLeft="White"></BorderDetails>
						</FooterStyleDefault>
						<GroupByBox>
							<Style BorderColor="Window" BackColor="ActiveBorder"></Style>
						</GroupByBox>
						<EditCellStyleDefault BorderWidth="0px" BorderStyle="None"></EditCellStyleDefault>
						<SelectedRowStyleDefault ForeColor="White" BackColor="#F09D21" CustomRules="background-image:url(/ig_common/images/Office2003SelRow.png);background-repeat:repeat-x;"></SelectedRowStyleDefault>
						<RowStyleDefault BorderWidth="1px" BorderColor="Black" BorderStyle="Solid">
							<Padding Left="3px"></Padding>
							<BorderDetails WidthLeft="0px" WidthTop="0px"></BorderDetails>
						</RowStyleDefault>
					</DisplayLayout>
					<Bands>
						<igtbl:UltraGridBand AddButtonCaption="党群机关" BaseTableName="党群机关" Key="党群机关" DataKeyField="ID">
							<Columns>
								<igtbl:UltraGridColumn Key="DD" Type="CheckBox" BaseColumnName="" AllowUpdate="Yes">
									<Footer Key="DD"></Footer>
									<Header Key="DD"></Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="ID" Key="ID" IsBound="True" EditorControlID="" Format="" DataType="System.Int32"
									BaseColumnName="ID" FooterText="">
									<Footer Key="ID" Caption="">
										<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="ID" Caption="ID">
										<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="单位" Key="单位" IsBound="True" EditorControlID="" Format="" BaseColumnName="单位"
									FooterText="">
									<Footer Key="单位" Caption="">
										<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="单位" Caption="单位">
										<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="用人      司局" Key="用人      司局" IsBound="True" EditorControlID="" Format=""
									BaseColumnName="用人      司局" FooterText="">
									<Footer Key="用人      司局" Caption="">
										<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="用人      司局" Caption="用人      司局">
										<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="职位名称" Key="职位名称" IsBound="True" EditorControlID="" Type="HyperLink"
									Format="" BaseColumnName="职位名称" FooterText="">
									<Footer Key="职位名称" Caption="">
										<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="职位名称" Caption="职位名称">
										<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="职位简介" Key="职位简介" IsBound="True" EditorControlID="" Format="" BaseColumnName="职位简介"
									FooterText="">
									<Footer Key="职位简介" Caption="">
										<RowLayoutColumnInfo OriginX="5"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="职位简介" Caption="职位简介">
										<RowLayoutColumnInfo OriginX="5"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="职位编号" Key="职位编号" IsBound="True" EditorControlID="" Format="" DataType="System.Int32"
									BaseColumnName="职位编号" FooterText="">
									<Footer Key="职位编号" Caption="">
										<RowLayoutColumnInfo OriginX="6"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="职位编号" Caption="职位编号">
										<RowLayoutColumnInfo OriginX="6"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="考试类别" Key="考试类别" IsBound="True" EditorControlID="" Format="" BaseColumnName="考试类别"
									FooterText="">
									<Footer Key="考试类别" Caption="">
										<RowLayoutColumnInfo OriginX="7"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="考试类别" Caption="考试类别">
										<RowLayoutColumnInfo OriginX="7"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="招考人数" Key="招考人数" IsBound="True" EditorControlID="" Format="" DataType="System.Int32"
									BaseColumnName="招考人数" FooterText="">
									<Footer Key="招考人数" Caption="">
										<RowLayoutColumnInfo OriginX="8"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="招考人数" Caption="招考人数">
										<RowLayoutColumnInfo OriginX="8"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="专业" Key="专业" IsBound="True" EditorControlID="" Format="" BaseColumnName="专业"
									FooterText="">
									<Footer Key="专业" Caption="">
										<RowLayoutColumnInfo OriginX="9"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="专业" Caption="专业">
										<RowLayoutColumnInfo OriginX="9"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="学历" Key="学历" IsBound="True" EditorControlID="" Format="" BaseColumnName="学历"
									FooterText="">
									<Footer Key="学历" Caption="">
										<RowLayoutColumnInfo OriginX="10"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="学历" Caption="学历">
										<RowLayoutColumnInfo OriginX="10"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="政治面貌" Key="政治面貌" IsBound="True" EditorControlID="" Format="" BaseColumnName="政治面貌"
									FooterText="">
									<Footer Key="政治面貌" Caption="">
										<RowLayoutColumnInfo OriginX="11"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="政治面貌" Caption="政治面貌">
										<RowLayoutColumnInfo OriginX="11"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="是否要求具有2年以上基层工作经历" Key="是否要求具有2年以上基层工作经历" IsBound="True" EditorControlID=""
									Format="" BaseColumnName="是否要求具有2年以上基层工作经历" FooterText="">
									<Footer Key="是否要求具有2年以上基层工作经历" Caption="">
										<RowLayoutColumnInfo OriginX="12"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="是否要求具有2年以上基层工作经历" Caption="是否要求具有2年以上基层工作经历">
										<RowLayoutColumnInfo OriginX="12"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="其他条件" Key="其他条件" IsBound="True" EditorControlID="" Format="" BaseColumnName="其他条件"
									FooterText="">
									<Footer Key="其他条件" Caption="">
										<RowLayoutColumnInfo OriginX="13"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="其他条件" Caption="其他条件">
										<RowLayoutColumnInfo OriginX="13"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="备注" Key="备注" IsBound="True" EditorControlID="" Format="" BaseColumnName="备注"
									FooterText="">
									<Footer Key="备注" Caption="">
										<RowLayoutColumnInfo OriginX="14"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="备注" Caption="备注">
										<RowLayoutColumnInfo OriginX="14"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
							</Columns>
						</igtbl:UltraGridBand>
					</Bands>
				</igtbl:UltraWebGrid>
				<asp:Repeater id="Repeater1" runat="server"></asp:Repeater></FONT>
			<igtbl:UltraWebGrid id="UltraWebGrid2" runat="server" Width="100%" DataMember="党群机关" DataSource="<%# ds1 %>" ImageDirectory="/ig_common/Images/">
				<DisplayLayout RowHeightDefault="20px" Version="3.00" SelectTypeRowDefault="Single" BorderCollapseDefault="Separate"
					Name="UltraWebGrid2">
					<AddNewBox>
						<Style BorderWidth="1px" BorderStyle="Solid" BackColor="LightGray">

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
					<HeaderStyleDefault BorderStyle="Solid" HorizontalAlign="Left" ForeColor="Black" BackColor="#CBD6A6">
						<Padding Left="5px" Top="3px" Right="5px"></Padding>
						<BorderDetails ColorTop="White" WidthLeft="1px" WidthTop="1px" ColorLeft="White"></BorderDetails>
					</HeaderStyleDefault>
					<FrameStyle Width="100%" BorderWidth="1px" Font-Size="8pt" Font-Names="Verdana" BorderStyle="Solid"
						BackColor="#FAFCF1"></FrameStyle>
					<FooterStyleDefault BorderWidth="1px" BorderStyle="Solid" BackColor="LightGray">
						<BorderDetails ColorTop="White" WidthLeft="1px" WidthTop="1px" ColorLeft="White"></BorderDetails>
					</FooterStyleDefault>
					<ActivationObject BorderColor="170, 184, 131"></ActivationObject>
					<EditCellStyleDefault BorderWidth="0px" BorderStyle="None"></EditCellStyleDefault>
					<SelectedRowStyleDefault BackColor="#BECA98"></SelectedRowStyleDefault>
					<RowStyleDefault Width="500px" BorderWidth="1px" BorderColor="#AAB883" BorderStyle="Solid">
						<Padding Left="5px" Right="5px"></Padding>
						<BorderDetails WidthLeft="0px" WidthTop="0px"></BorderDetails>
					</RowStyleDefault>
				</DisplayLayout>
				<Bands>
					<igtbl:UltraGridBand AddButtonCaption="党群机关" BaseTableName="党群机关" Key="党群机关" DataKeyField="ID">
						<HeaderStyle Width="300px"></HeaderStyle>
						<EditCellStyle Font-Size="8pt" Font-Names="Verdana"></EditCellStyle>
						<Columns>
							<igtbl:UltraGridColumn HeaderText="ID" Key="ID" IsBound="True" DataType="System.Int32" BaseColumnName="ID">
								<Footer Key="ID"></Footer>
								<Header Key="ID" Caption="ID"></Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="单位" Key="单位" IsBound="True" BaseColumnName="单位">
								<Footer Key="单位">
									<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="单位" Caption="单位">
									<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="用人      司局" Key="用人      司局" IsBound="True" BaseColumnName="用人      司局">
								<Footer Key="用人      司局">
									<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="用人      司局" Caption="用人      司局">
									<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="职位名称" Key="职位名称" IsBound="True" Type="HyperLink" BaseColumnName="职位名称">
								<Footer Key="职位名称">
									<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="职位名称" Caption="职位名称">
									<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="职位简介" Key="职位简介" IsBound="True" BaseColumnName="职位简介">
								<Footer Key="职位简介">
									<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="职位简介" Caption="职位简介">
									<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="职位编号" Key="职位编号" IsBound="True" DataType="System.Int32" BaseColumnName="职位编号">
								<Footer Key="职位编号">
									<RowLayoutColumnInfo OriginX="5"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="职位编号" Caption="职位编号">
									<RowLayoutColumnInfo OriginX="5"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="考试类别" Key="考试类别" IsBound="True" BaseColumnName="考试类别">
								<Footer Key="考试类别">
									<RowLayoutColumnInfo OriginX="6"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="考试类别" Caption="考试类别">
									<RowLayoutColumnInfo OriginX="6"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="招考人数" Key="招考人数" IsBound="True" DataType="System.Int32" BaseColumnName="招考人数">
								<Footer Key="招考人数">
									<RowLayoutColumnInfo OriginX="7"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="招考人数" Caption="招考人数">
									<RowLayoutColumnInfo OriginX="7"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="专业" Key="专业" IsBound="True" BaseColumnName="专业">
								<Footer Key="专业">
									<RowLayoutColumnInfo OriginX="8"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="专业" Caption="专业">
									<RowLayoutColumnInfo OriginX="8"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="学历" Key="学历" IsBound="True" BaseColumnName="学历">
								<Footer Key="学历">
									<RowLayoutColumnInfo OriginX="9"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="学历" Caption="学历">
									<RowLayoutColumnInfo OriginX="9"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="政治面貌" Key="政治面貌" IsBound="True" BaseColumnName="政治面貌">
								<Footer Key="政治面貌">
									<RowLayoutColumnInfo OriginX="10"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="政治面貌" Caption="政治面貌">
									<RowLayoutColumnInfo OriginX="10"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="是否要求具有2年以上基层工作经历" Key="是否要求具有2年以上基层工作经历" IsBound="True" BaseColumnName="是否要求具有2年以上基层工作经历">
								<Footer Key="是否要求具有2年以上基层工作经历">
									<RowLayoutColumnInfo OriginX="11"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="是否要求具有2年以上基层工作经历" Caption="是否要求具有2年以上基层工作经历">
									<RowLayoutColumnInfo OriginX="11"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="其他条件" Key="其他条件" IsBound="True" BaseColumnName="其他条件">
								<Footer Key="其他条件">
									<RowLayoutColumnInfo OriginX="12"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="其他条件" Caption="其他条件">
									<RowLayoutColumnInfo OriginX="12"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="备注" Key="备注" IsBound="True" BaseColumnName="备注">
								<Footer Key="备注">
									<RowLayoutColumnInfo OriginX="13"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="备注" Caption="备注">
									<RowLayoutColumnInfo OriginX="13"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
						</Columns>
					</igtbl:UltraGridBand>
				</Bands>
			</igtbl:UltraWebGrid>
		</form>
	</body>
</HTML>
