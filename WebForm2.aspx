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
			<FONT face="����">
				<asp:DataList id=dl runat="server" BorderColor="#999999" BorderStyle="None" BackColor="White" CellPadding="3" GridLines="Both" BorderWidth="1px" DataSource="<%# ds1 %>" DataMember="��Ⱥ����" DataKeyField="ְλ����">
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
						<%# DataBinder.Eval(Container, "DataItem.ְλ����") %>
					</ItemTemplate>
					<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#000084"></HeaderStyle>
				</asp:DataList>
				<igcalc:UltraWebCalcManager id="UltraWebCalcManager1" runat="server"></igcalc:UltraWebCalcManager>
				<igtbl:UltraWebGrid id=ug runat="server" DataMember="��Ⱥ����" DataSource="<%# ds1 %>" ImageDirectory="/ig_common/Images/" Width="750px" Height="500px" >
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
						<igtbl:UltraGridBand AddButtonCaption="��Ⱥ����" BaseTableName="��Ⱥ����" Key="��Ⱥ����" DataKeyField="ID">
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
								<igtbl:UltraGridColumn HeaderText="��λ" Key="��λ" IsBound="True" EditorControlID="" Format="" BaseColumnName="��λ"
									FooterText="">
									<Footer Key="��λ" Caption="">
										<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="��λ" Caption="��λ">
										<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="����      ˾��" Key="����      ˾��" IsBound="True" EditorControlID="" Format=""
									BaseColumnName="����      ˾��" FooterText="">
									<Footer Key="����      ˾��" Caption="">
										<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="����      ˾��" Caption="����      ˾��">
										<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="ְλ����" Key="ְλ����" IsBound="True" EditorControlID="" Type="HyperLink"
									Format="" BaseColumnName="ְλ����" FooterText="">
									<Footer Key="ְλ����" Caption="">
										<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="ְλ����" Caption="ְλ����">
										<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="ְλ���" Key="ְλ���" IsBound="True" EditorControlID="" Format="" BaseColumnName="ְλ���"
									FooterText="">
									<Footer Key="ְλ���" Caption="">
										<RowLayoutColumnInfo OriginX="5"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="ְλ���" Caption="ְλ���">
										<RowLayoutColumnInfo OriginX="5"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="ְλ���" Key="ְλ���" IsBound="True" EditorControlID="" Format="" DataType="System.Int32"
									BaseColumnName="ְλ���" FooterText="">
									<Footer Key="ְλ���" Caption="">
										<RowLayoutColumnInfo OriginX="6"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="ְλ���" Caption="ְλ���">
										<RowLayoutColumnInfo OriginX="6"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="�������" Key="�������" IsBound="True" EditorControlID="" Format="" BaseColumnName="�������"
									FooterText="">
									<Footer Key="�������" Caption="">
										<RowLayoutColumnInfo OriginX="7"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="�������" Caption="�������">
										<RowLayoutColumnInfo OriginX="7"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="�п�����" Key="�п�����" IsBound="True" EditorControlID="" Format="" DataType="System.Int32"
									BaseColumnName="�п�����" FooterText="">
									<Footer Key="�п�����" Caption="">
										<RowLayoutColumnInfo OriginX="8"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="�п�����" Caption="�п�����">
										<RowLayoutColumnInfo OriginX="8"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="רҵ" Key="רҵ" IsBound="True" EditorControlID="" Format="" BaseColumnName="רҵ"
									FooterText="">
									<Footer Key="רҵ" Caption="">
										<RowLayoutColumnInfo OriginX="9"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="רҵ" Caption="רҵ">
										<RowLayoutColumnInfo OriginX="9"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="ѧ��" Key="ѧ��" IsBound="True" EditorControlID="" Format="" BaseColumnName="ѧ��"
									FooterText="">
									<Footer Key="ѧ��" Caption="">
										<RowLayoutColumnInfo OriginX="10"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="ѧ��" Caption="ѧ��">
										<RowLayoutColumnInfo OriginX="10"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="������ò" Key="������ò" IsBound="True" EditorControlID="" Format="" BaseColumnName="������ò"
									FooterText="">
									<Footer Key="������ò" Caption="">
										<RowLayoutColumnInfo OriginX="11"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="������ò" Caption="������ò">
										<RowLayoutColumnInfo OriginX="11"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="�Ƿ�Ҫ�����2�����ϻ��㹤������" Key="�Ƿ�Ҫ�����2�����ϻ��㹤������" IsBound="True" EditorControlID=""
									Format="" BaseColumnName="�Ƿ�Ҫ�����2�����ϻ��㹤������" FooterText="">
									<Footer Key="�Ƿ�Ҫ�����2�����ϻ��㹤������" Caption="">
										<RowLayoutColumnInfo OriginX="12"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="�Ƿ�Ҫ�����2�����ϻ��㹤������" Caption="�Ƿ�Ҫ�����2�����ϻ��㹤������">
										<RowLayoutColumnInfo OriginX="12"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="��������" Key="��������" IsBound="True" EditorControlID="" Format="" BaseColumnName="��������"
									FooterText="">
									<Footer Key="��������" Caption="">
										<RowLayoutColumnInfo OriginX="13"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="��������" Caption="��������">
										<RowLayoutColumnInfo OriginX="13"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
								<igtbl:UltraGridColumn HeaderText="��ע" Key="��ע" IsBound="True" EditorControlID="" Format="" BaseColumnName="��ע"
									FooterText="">
									<Footer Key="��ע" Caption="">
										<RowLayoutColumnInfo OriginX="14"></RowLayoutColumnInfo>
									</Footer>
									<Header Key="��ע" Caption="��ע">
										<RowLayoutColumnInfo OriginX="14"></RowLayoutColumnInfo>
									</Header>
								</igtbl:UltraGridColumn>
							</Columns>
						</igtbl:UltraGridBand>
					</Bands>
				</igtbl:UltraWebGrid>
				<asp:Repeater id="Repeater1" runat="server"></asp:Repeater></FONT>
			<igtbl:UltraWebGrid id="UltraWebGrid2" runat="server" Width="100%" DataMember="��Ⱥ����" DataSource="<%# ds1 %>" ImageDirectory="/ig_common/Images/">
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
					<igtbl:UltraGridBand AddButtonCaption="��Ⱥ����" BaseTableName="��Ⱥ����" Key="��Ⱥ����" DataKeyField="ID">
						<HeaderStyle Width="300px"></HeaderStyle>
						<EditCellStyle Font-Size="8pt" Font-Names="Verdana"></EditCellStyle>
						<Columns>
							<igtbl:UltraGridColumn HeaderText="ID" Key="ID" IsBound="True" DataType="System.Int32" BaseColumnName="ID">
								<Footer Key="ID"></Footer>
								<Header Key="ID" Caption="ID"></Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="��λ" Key="��λ" IsBound="True" BaseColumnName="��λ">
								<Footer Key="��λ">
									<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="��λ" Caption="��λ">
									<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="����      ˾��" Key="����      ˾��" IsBound="True" BaseColumnName="����      ˾��">
								<Footer Key="����      ˾��">
									<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="����      ˾��" Caption="����      ˾��">
									<RowLayoutColumnInfo OriginX="2"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="ְλ����" Key="ְλ����" IsBound="True" Type="HyperLink" BaseColumnName="ְλ����">
								<Footer Key="ְλ����">
									<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="ְλ����" Caption="ְλ����">
									<RowLayoutColumnInfo OriginX="3"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="ְλ���" Key="ְλ���" IsBound="True" BaseColumnName="ְλ���">
								<Footer Key="ְλ���">
									<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="ְλ���" Caption="ְλ���">
									<RowLayoutColumnInfo OriginX="4"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="ְλ���" Key="ְλ���" IsBound="True" DataType="System.Int32" BaseColumnName="ְλ���">
								<Footer Key="ְλ���">
									<RowLayoutColumnInfo OriginX="5"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="ְλ���" Caption="ְλ���">
									<RowLayoutColumnInfo OriginX="5"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="�������" Key="�������" IsBound="True" BaseColumnName="�������">
								<Footer Key="�������">
									<RowLayoutColumnInfo OriginX="6"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="�������" Caption="�������">
									<RowLayoutColumnInfo OriginX="6"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="�п�����" Key="�п�����" IsBound="True" DataType="System.Int32" BaseColumnName="�п�����">
								<Footer Key="�п�����">
									<RowLayoutColumnInfo OriginX="7"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="�п�����" Caption="�п�����">
									<RowLayoutColumnInfo OriginX="7"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="רҵ" Key="רҵ" IsBound="True" BaseColumnName="רҵ">
								<Footer Key="רҵ">
									<RowLayoutColumnInfo OriginX="8"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="רҵ" Caption="רҵ">
									<RowLayoutColumnInfo OriginX="8"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="ѧ��" Key="ѧ��" IsBound="True" BaseColumnName="ѧ��">
								<Footer Key="ѧ��">
									<RowLayoutColumnInfo OriginX="9"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="ѧ��" Caption="ѧ��">
									<RowLayoutColumnInfo OriginX="9"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="������ò" Key="������ò" IsBound="True" BaseColumnName="������ò">
								<Footer Key="������ò">
									<RowLayoutColumnInfo OriginX="10"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="������ò" Caption="������ò">
									<RowLayoutColumnInfo OriginX="10"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="�Ƿ�Ҫ�����2�����ϻ��㹤������" Key="�Ƿ�Ҫ�����2�����ϻ��㹤������" IsBound="True" BaseColumnName="�Ƿ�Ҫ�����2�����ϻ��㹤������">
								<Footer Key="�Ƿ�Ҫ�����2�����ϻ��㹤������">
									<RowLayoutColumnInfo OriginX="11"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="�Ƿ�Ҫ�����2�����ϻ��㹤������" Caption="�Ƿ�Ҫ�����2�����ϻ��㹤������">
									<RowLayoutColumnInfo OriginX="11"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="��������" Key="��������" IsBound="True" BaseColumnName="��������">
								<Footer Key="��������">
									<RowLayoutColumnInfo OriginX="12"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="��������" Caption="��������">
									<RowLayoutColumnInfo OriginX="12"></RowLayoutColumnInfo>
								</Header>
							</igtbl:UltraGridColumn>
							<igtbl:UltraGridColumn HeaderText="��ע" Key="��ע" IsBound="True" BaseColumnName="��ע">
								<Footer Key="��ע">
									<RowLayoutColumnInfo OriginX="13"></RowLayoutColumnInfo>
								</Footer>
								<Header Key="��ע" Caption="��ע">
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
