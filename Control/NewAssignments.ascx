<%@ Register TagPrefix="igtxt" Namespace="Infragistics.WebUI.WebDataInput" Assembly="Infragistics.WebUI.WebDataInput.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igtbl" Namespace="Infragistics.WebUI.UltraWebGrid" Assembly="Infragistics.WebUI.UltraWebGrid.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Control Language="c#" AutoEventWireup="false" Codebehind="NewAssignments.ascx.cs" Inherits="LIMS.Control.NewAssignments" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<FONT face="����">
	<igtbl:ultrawebgrid id=UndealGrid Browser="Xml" Height="180px" Width="700px" DataMember="��У����" DataSource="<%# work1 %>" ImageDirectory="/ig_common/Images/" runat="server">
		<DISPLAYLAYOUT TableLayout="Fixed" Name="UndealGrid" FixedHeaderIndicatorDefault="Button" AllowColSizingDefault="Free"
			BorderCollapseDefault="Separate" AllowColumnMovingDefault="OnClient" SelectTypeRowDefault="Single"
			Version="3.00" RowSizingDefault="Free" RowHeightDefault="21px" UseFixedHeaders="True">
			<ADDNEWBOX>
				<STYLE BackColor="Window" BorderStyle="Solid" BorderColor="InactiveCaption" BorderWidth="1px"></STYLE>
			</ADDNEWBOX>
			<PAGER PageSize="6">
				<STYLE BackColor="LightGray" BorderStyle="Solid" BorderWidth="1px"></STYLE>
			</PAGER>
			<HEADERSTYLEDEFAULT BackColor="#777697" BorderStyle="Solid" CustomRules="background-image:url(/ig_common/images/Office2003SilverBG.png);background-repeat:repeat-x;"
				ForeColor="#EFEFF3" Font-Bold="True" Font-Names="Arial" Font-Size="X-Small">
				<BORDERDETAILS ColorLeft="211, 210, 223" WidthTop="1px" WidthLeft="1px" ColorTop="211, 210, 223"></BORDERDETAILS>
			</HEADERSTYLEDEFAULT>
			<FRAMESTYLE Height="180px" Width="700px" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana"
				Font-Size="8pt"></FRAMESTYLE>
			<FOOTERSTYLEDEFAULT BackColor="LightGray" BorderStyle="Solid" BorderWidth="1px">
				<BORDERDETAILS ColorLeft="White" WidthTop="1px" WidthLeft="1px" ColorTop="White"></BORDERDETAILS>
			</FOOTERSTYLEDEFAULT>
			<GROUPBYBOX>
				<STYLE BackColor="ActiveBorder" BorderColor="Window"></STYLE>
			</GROUPBYBOX>
			<EDITCELLSTYLEDEFAULT BorderStyle="None" BorderWidth="0px"></EDITCELLSTYLEDEFAULT>
			<SELECTEDROWSTYLEDEFAULT BackColor="#F09D21" CustomRules="background-image:url(/ig_common/images/Office2003SelRow.png);background-repeat:repeat-x;"
				ForeColor="White"></SELECTEDROWSTYLEDEFAULT>
			<ROWSTYLEDEFAULT BorderStyle="Solid" BorderColor="Black" BorderWidth="1px">
				<PADDING Left="3px"></PADDING>
				<BORDERDETAILS WidthTop="0px" WidthLeft="0px"></BORDERDETAILS>
			</ROWSTYLEDEFAULT>
		</DISPLAYLAYOUT>
		<BANDS>
			<igtbl:UltraGridBand DataKeyField="ID" Key="��У����" BaseTableName="��У����" AddButtonCaption="��У����">
				<COLUMNS>
					<igtbl:UltraGridColumn Width="25px" Key="" FooterText="" AllowUpdate="Yes" BaseColumnName="" DataType="System.Boolean"
						Format="" Type="CheckBox" AllowGroupBy="No" EditorControlID="" HeaderText="">
						<FOOTER Key="" Caption=""></FOOTER>
						<HEADER Key="" Caption=""></HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Width="120px" Key="���" BaseColumnName="���" HeaderText="���" IsBound="True">
						<FOOTER Key="���">
							<ROWLAYOUTCOLUMNINFO OriginX="1"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="���" Caption="���">
							<ROWLAYOUTCOLUMNINFO OriginX="1"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="��������" BaseColumnName="��������" HeaderText="��������" IsBound="True">
						<FOOTER Key="��������">
							<ROWLAYOUTCOLUMNINFO OriginX="2"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="��������" Caption="��������">
							<ROWLAYOUTCOLUMNINFO OriginX="2"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="��������" BaseColumnName="��������" DataType="System.Int32" HeaderText="��������" IsBound="True">
						<FOOTER Key="��������">
							<ROWLAYOUTCOLUMNINFO OriginX="3"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="��������" Caption="��������">
							<ROWLAYOUTCOLUMNINFO OriginX="3"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="�ͺŹ��" BaseColumnName="�ͺŹ��" HeaderText="�ͺŹ��" IsBound="True">
						<FOOTER Key="�ͺŹ��">
							<ROWLAYOUTCOLUMNINFO OriginX="4"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="�ͺŹ��" Caption="�ͺŹ��">
							<ROWLAYOUTCOLUMNINFO OriginX="4"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="�������" BaseColumnName="�������" HeaderText="�������" IsBound="True">
						<FOOTER Key="�������">
							<ROWLAYOUTCOLUMNINFO OriginX="5"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="�������" Caption="�������">
							<ROWLAYOUTCOLUMNINFO OriginX="5"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="�ͼ쵥λ" BaseColumnName="�ͼ쵥λ" HeaderText="�ͼ쵥λ" IsBound="True">
						<FOOTER Key="�ͼ쵥λ">
							<ROWLAYOUTCOLUMNINFO OriginX="6"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="�ͼ쵥λ" Caption="�ͼ쵥λ">
							<ROWLAYOUTCOLUMNINFO OriginX="6"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="�ͼ쵥λ��ַ" BaseColumnName="�ͼ쵥λ��ַ" HeaderText="�ͼ쵥λ��ַ" IsBound="True">
						<FOOTER Key="�ͼ쵥λ��ַ">
							<ROWLAYOUTCOLUMNINFO OriginX="7"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="�ͼ쵥λ��ַ" Caption="�ͼ쵥λ��ַ">
							<ROWLAYOUTCOLUMNINFO OriginX="7"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="��������" BaseColumnName="��������" HeaderText="��������" IsBound="True">
						<FOOTER Key="��������">
							<ROWLAYOUTCOLUMNINFO OriginX="8"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="��������" Caption="��������">
							<ROWLAYOUTCOLUMNINFO OriginX="8"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="ί����" BaseColumnName="ί����" HeaderText="ί����" IsBound="True">
						<FOOTER Key="ί����">
							<ROWLAYOUTCOLUMNINFO OriginX="9"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="ί����" Caption="ί����">
							<ROWLAYOUTCOLUMNINFO OriginX="9"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="�绰" BaseColumnName="�绰" HeaderText="�绰" IsBound="True">
						<FOOTER Key="�绰">
							<ROWLAYOUTCOLUMNINFO OriginX="10"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="�绰" Caption="�绰">
							<ROWLAYOUTCOLUMNINFO OriginX="10"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="�����" BaseColumnName="�����" HeaderText="�����" IsBound="True">
						<FOOTER Key="�����">
							<ROWLAYOUTCOLUMNINFO OriginX="11"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="�����" Caption="�����">
							<ROWLAYOUTCOLUMNINFO OriginX="11"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="�ͼ�����" BaseColumnName="�ͼ�����" DataType="System.DateTime" Format="yyyy-MM-dd"
						HeaderText="�ͼ�����" IsBound="True">
						<FOOTER Key="�ͼ�����">
							<ROWLAYOUTCOLUMNINFO OriginX="12"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="�ͼ�����" Caption="�ͼ�����">
							<ROWLAYOUTCOLUMNINFO OriginX="12"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="��У��ʽ" BaseColumnName="��У��ʽ" HeaderText="��У��ʽ" IsBound="True">
						<FOOTER Key="��У��ʽ">
							<ROWLAYOUTCOLUMNINFO OriginX="13"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="��У��ʽ" Caption="��У��ʽ">
							<ROWLAYOUTCOLUMNINFO OriginX="13"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="��ע" BaseColumnName="��ע" HeaderText="��ע" IsBound="True" CellMultiline="Yes">
						<FOOTER Key="��ע">
							<ROWLAYOUTCOLUMNINFO OriginX="14"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="��ע" Caption="��ע">
							<ROWLAYOUTCOLUMNINFO OriginX="14"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
				</COLUMNS>
			</igtbl:UltraGridBand>
		</BANDS>
	</igtbl:ultrawebgrid><BR>
	<TABLE id="Table1" cellSpacing="0" cellPadding="0" border="0">
		<TR>
			<TD>
				<igtxt:webimagebutton id="Accept" runat="server" Text="����" UseBrowserDefaults="False" DESIGNTIMEDRAGDROP="38">
					<ROUNDEDCORNERS WidthOfRightEdge="2" PressedImageUrl="ig_butCRM2.gif" HeightOfBottomEdge="2" RenderingType="FileImages"
						HoverImageUrl="ig_butCRM2.gif" MaxWidth="400" ImageUrl="ig_butCRM1.gif" MaxHeight="40"></ROUNDEDCORNERS>
				</igtxt:webimagebutton></TD>
			<TD style="WIDTH: 20px"></TD>
			<TD>
				<igtxt:webimagebutton id="Cancel" runat="server" Text="�˻�" UseBrowserDefaults="False">
					<ROUNDEDCORNERS WidthOfRightEdge="2" PressedImageUrl="ig_butCRM2.gif" HeightOfBottomEdge="2" RenderingType="FileImages"
						HoverImageUrl="ig_butCRM2.gif" MaxWidth="400" ImageUrl="ig_butCRM1.gif" MaxHeight="40"></ROUNDEDCORNERS>
				</igtxt:webimagebutton></TD>
			<TD style="WIDTH: 20px"></TD>
			<TD>
				<asp:label id="UndealError" Width="150px" runat="server" ForeColor="Red"></asp:label></TD>
		</TR>
	</TABLE>
</FONT>
