<%@ Register TagPrefix="igtxt" Namespace="Infragistics.WebUI.WebDataInput" Assembly="Infragistics.WebUI.WebDataInput.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igtbl" Namespace="Infragistics.WebUI.UltraWebGrid" Assembly="Infragistics.WebUI.UltraWebGrid.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Control Language="c#" AutoEventWireup="false" Codebehind="NewAssignments.ascx.cs" Inherits="LIMS.Control.NewAssignments" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<FONT face="宋体">
	<igtbl:ultrawebgrid id=UndealGrid Browser="Xml" Height="180px" Width="700px" DataMember="检校任务" DataSource="<%# work1 %>" ImageDirectory="/ig_common/Images/" runat="server">
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
			<igtbl:UltraGridBand DataKeyField="ID" Key="检校任务" BaseTableName="检校任务" AddButtonCaption="检校任务">
				<COLUMNS>
					<igtbl:UltraGridColumn Width="25px" Key="" FooterText="" AllowUpdate="Yes" BaseColumnName="" DataType="System.Boolean"
						Format="" Type="CheckBox" AllowGroupBy="No" EditorControlID="" HeaderText="">
						<FOOTER Key="" Caption=""></FOOTER>
						<HEADER Key="" Caption=""></HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Width="120px" Key="编号" BaseColumnName="编号" HeaderText="编号" IsBound="True">
						<FOOTER Key="编号">
							<ROWLAYOUTCOLUMNINFO OriginX="1"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="编号" Caption="编号">
							<ROWLAYOUTCOLUMNINFO OriginX="1"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="器具名称" BaseColumnName="器具名称" HeaderText="器具名称" IsBound="True">
						<FOOTER Key="器具名称">
							<ROWLAYOUTCOLUMNINFO OriginX="2"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="器具名称" Caption="器具名称">
							<ROWLAYOUTCOLUMNINFO OriginX="2"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="器具数量" BaseColumnName="器具数量" DataType="System.Int32" HeaderText="器具数量" IsBound="True">
						<FOOTER Key="器具数量">
							<ROWLAYOUTCOLUMNINFO OriginX="3"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="器具数量" Caption="器具数量">
							<ROWLAYOUTCOLUMNINFO OriginX="3"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="型号规格" BaseColumnName="型号规格" HeaderText="型号规格" IsBound="True">
						<FOOTER Key="型号规格">
							<ROWLAYOUTCOLUMNINFO OriginX="4"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="型号规格" Caption="型号规格">
							<ROWLAYOUTCOLUMNINFO OriginX="4"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="出厂编号" BaseColumnName="出厂编号" HeaderText="出厂编号" IsBound="True">
						<FOOTER Key="出厂编号">
							<ROWLAYOUTCOLUMNINFO OriginX="5"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="出厂编号" Caption="出厂编号">
							<ROWLAYOUTCOLUMNINFO OriginX="5"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="送检单位" BaseColumnName="送检单位" HeaderText="送检单位" IsBound="True">
						<FOOTER Key="送检单位">
							<ROWLAYOUTCOLUMNINFO OriginX="6"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="送检单位" Caption="送检单位">
							<ROWLAYOUTCOLUMNINFO OriginX="6"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="送检单位地址" BaseColumnName="送检单位地址" HeaderText="送检单位地址" IsBound="True">
						<FOOTER Key="送检单位地址">
							<ROWLAYOUTCOLUMNINFO OriginX="7"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="送检单位地址" Caption="送检单位地址">
							<ROWLAYOUTCOLUMNINFO OriginX="7"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="邮政编码" BaseColumnName="邮政编码" HeaderText="邮政编码" IsBound="True">
						<FOOTER Key="邮政编码">
							<ROWLAYOUTCOLUMNINFO OriginX="8"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="邮政编码" Caption="邮政编码">
							<ROWLAYOUTCOLUMNINFO OriginX="8"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="委托人" BaseColumnName="委托人" HeaderText="委托人" IsBound="True">
						<FOOTER Key="委托人">
							<ROWLAYOUTCOLUMNINFO OriginX="9"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="委托人" Caption="委托人">
							<ROWLAYOUTCOLUMNINFO OriginX="9"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="电话" BaseColumnName="电话" HeaderText="电话" IsBound="True">
						<FOOTER Key="电话">
							<ROWLAYOUTCOLUMNINFO OriginX="10"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="电话" Caption="电话">
							<ROWLAYOUTCOLUMNINFO OriginX="10"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="传真号" BaseColumnName="传真号" HeaderText="传真号" IsBound="True">
						<FOOTER Key="传真号">
							<ROWLAYOUTCOLUMNINFO OriginX="11"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="传真号" Caption="传真号">
							<ROWLAYOUTCOLUMNINFO OriginX="11"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="送检日期" BaseColumnName="送检日期" DataType="System.DateTime" Format="yyyy-MM-dd"
						HeaderText="送检日期" IsBound="True">
						<FOOTER Key="送检日期">
							<ROWLAYOUTCOLUMNINFO OriginX="12"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="送检日期" Caption="送检日期">
							<ROWLAYOUTCOLUMNINFO OriginX="12"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="检校方式" BaseColumnName="检校方式" HeaderText="检校方式" IsBound="True">
						<FOOTER Key="检校方式">
							<ROWLAYOUTCOLUMNINFO OriginX="13"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="检校方式" Caption="检校方式">
							<ROWLAYOUTCOLUMNINFO OriginX="13"></ROWLAYOUTCOLUMNINFO>
						</HEADER>
					</igtbl:UltraGridColumn>
					<igtbl:UltraGridColumn Key="备注" BaseColumnName="备注" HeaderText="备注" IsBound="True" CellMultiline="Yes">
						<FOOTER Key="备注">
							<ROWLAYOUTCOLUMNINFO OriginX="14"></ROWLAYOUTCOLUMNINFO>
						</FOOTER>
						<HEADER Key="备注" Caption="备注">
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
				<igtxt:webimagebutton id="Accept" runat="server" Text="接收" UseBrowserDefaults="False" DESIGNTIMEDRAGDROP="38">
					<ROUNDEDCORNERS WidthOfRightEdge="2" PressedImageUrl="ig_butCRM2.gif" HeightOfBottomEdge="2" RenderingType="FileImages"
						HoverImageUrl="ig_butCRM2.gif" MaxWidth="400" ImageUrl="ig_butCRM1.gif" MaxHeight="40"></ROUNDEDCORNERS>
				</igtxt:webimagebutton></TD>
			<TD style="WIDTH: 20px"></TD>
			<TD>
				<igtxt:webimagebutton id="Cancel" runat="server" Text="退回" UseBrowserDefaults="False">
					<ROUNDEDCORNERS WidthOfRightEdge="2" PressedImageUrl="ig_butCRM2.gif" HeightOfBottomEdge="2" RenderingType="FileImages"
						HoverImageUrl="ig_butCRM2.gif" MaxWidth="400" ImageUrl="ig_butCRM1.gif" MaxHeight="40"></ROUNDEDCORNERS>
				</igtxt:webimagebutton></TD>
			<TD style="WIDTH: 20px"></TD>
			<TD>
				<asp:label id="UndealError" Width="150px" runat="server" ForeColor="Red"></asp:label></TD>
		</TR>
	</TABLE>
</FONT>
