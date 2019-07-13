<%@ Register TagPrefix="igtxt" Namespace="Infragistics.WebUI.WebDataInput" Assembly="Infragistics.WebUI.WebDataInput.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Page language="c#" Codebehind="AddStandardImplement.aspx.cs" AutoEventWireup="false" Inherits="LIMS.StandardImplement.AddStandardImplement" %>
<%@ Register TagPrefix="igcmbo" Namespace="Infragistics.WebUI.WebCombo" Assembly="Infragistics.WebUI.WebCombo.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igtbl" Namespace="Infragistics.WebUI.UltraWebGrid" Assembly="Infragistics.WebUI.UltraWebGrid.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>AddStandardImplement</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">
				<TABLE id="Table1" style="FONT-SIZE: 14px" cellSpacing="1" cellPadding="4" border="0" bgColor="gainsboro">
					<TR>
						<TD bgcolor="white" width="100">名&nbsp;&nbsp;&nbsp; 称：</TD>
						<TD bgcolor="white" width="140">
							<igtxt:webtextedit id="StandardImplementName" runat="server" BorderStyle="Solid" BorderWidth="1px"
								BorderColor="#7B9EBD" Font-Size="8pt" Font-Names="Tahoma">
								<ButtonsAppearance>
									<ButtonStyle Width="13px"></ButtonStyle>
								</ButtonsAppearance>
							</igtxt:webtextedit>
							<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" DESIGNTIMEDRAGDROP="2008" ErrorMessage="*"
								ControlToValidate="StandardImplementName"></asp:RequiredFieldValidator></TD>
						<TD bgcolor="white" width="100">制造厂商：</TD>
						<TD bgcolor="white" width="140">
							<igtxt:webtextedit id="Manufactory" runat="server" DESIGNTIMEDRAGDROP="1599" BorderStyle="Solid" BorderWidth="1px"
								BorderColor="#7B9EBD" Font-Size="8pt" Font-Names="Tahoma">
								<ButtonsAppearance>
									<ButtonStyle Width="13px"></ButtonStyle>
								</ButtonsAppearance>
							</igtxt:webtextedit></TD>
					</TR>
					<TR>
						<TD bgcolor="white">型号规格：</TD>
						<TD bgcolor="white">
							<igtxt:webtextedit id="Model" runat="server" DESIGNTIMEDRAGDROP="1652" BorderStyle="Solid" BorderWidth="1px"
								BorderColor="#7B9EBD" Font-Size="8pt" Font-Names="Tahoma">
								<ButtonsAppearance>
									<ButtonStyle Width="13px"></ButtonStyle>
								</ButtonsAppearance>
							</igtxt:webtextedit></TD>
						<TD bgcolor="white">出场编号：</TD>
						<TD bgcolor="white">
							<igtxt:webtextedit id="SN" runat="server" DESIGNTIMEDRAGDROP="1651" BorderStyle="Solid" BorderWidth="1px"
								BorderColor="#7B9EBD" Font-Size="8pt" Font-Names="Tahoma">
								<ButtonsAppearance>
									<ButtonStyle Width="13px"></ButtonStyle>
								</ButtonsAppearance>
							</igtxt:webtextedit></TD>
					</TR>
					<TR>
						<TD bgcolor="white">类&nbsp;&nbsp;&nbsp; 型：</TD>
						<TD bgcolor="white">
							<igcmbo:webcombo id=Type runat="server" BorderStyle="Solid" BorderWidth="1px" BorderColor="LightGray" BackColor="White" ForeColor="Black" Width="120px" Height="8px" Version="3.00" DataSource="<%# standardImplement1 %>" DataMember="标准器类型" DropImage1="/ig_common/images/Office2003DropDownBlue.gif" DropImage2="/ig_common/images/Office2003DropDownOrange.gif" DropImageXP1="/ig_common/images/Office2003DropDownBlue.gif" DropImageXP2="/ig_common/images/Office2003DropDownOrange.gif" SelBackColor="17, 69, 158" DataValueField="ID" DataTextField="Type">
								<Columns>
									<igtbl:UltraGridColumn HeaderText="Type" Key="Type" IsBound="True" BaseColumnName="Type">
										<Footer Key="Type"></Footer>
										<Header Key="Type" Caption="Type"></Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="ID" Key="ID" IsBound="True" Hidden="True" DataType="System.Int32" BaseColumnName="ID">
										<Footer Key="ID">
											<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="ID" Caption="ID">
											<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
								</Columns>
								<ClientSideEvents AfterSelectChange="Offic_AfterSelectChange"></ClientSideEvents>
								<DropDownLayout DropdownWidth="" BorderCollapse="Separate" RowSelectors="No" AllowColSizing="Free"
									RowHeightDefault="20px" HeaderClickAction="Select" AllowSorting="OnClient" DropdownHeight=""
									ColHeadersVisible="No" ColWidthDefault="">
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
										BackColor="Silver">
										<BorderDetails ColorTop="Black" ColorLeft="Black"></BorderDetails>
									</FrameStyle>
								</DropDownLayout>
								<ExpandEffects ShadowColor="LightGray"></ExpandEffects>
							</igcmbo:webcombo></TD>
						<TD bgcolor="white">价&nbsp;&nbsp;&nbsp; 格：</TD>
						<TD bgcolor="white">
							<igtxt:WebCurrencyEdit id="Price" runat="server" BorderStyle="Solid" BorderWidth="1px" BorderColor="#7B9EBD"
								Font-Size="8pt" Font-Names="Tahoma"></igtxt:WebCurrencyEdit></TD>
					</TR>
					<TR>
						<TD bgcolor="white">准确度等级:</TD>
						<TD bgcolor="white">
							<igtxt:webtextedit id="AccuracyLevel" runat="server" DESIGNTIMEDRAGDROP="1654" BorderStyle="Solid"
								BorderWidth="1px" BorderColor="#7B9EBD" Font-Size="8pt" Font-Names="Tahoma">
								<ButtonsAppearance>
									<ButtonStyle Width="13px"></ButtonStyle>
								</ButtonsAppearance>
							</igtxt:webtextedit></TD>
						<TD bgcolor="white">测量范围:</TD>
						<TD bgcolor="white">
							<igtxt:webtextedit id="MeasureRange" runat="server" BorderStyle="Solid" BorderWidth="1px" BorderColor="#7B9EBD"
								Font-Size="8pt" Font-Names="Tahoma">
								<ButtonsAppearance>
									<ButtonStyle Width="13px"></ButtonStyle>
								</ButtonsAppearance>
							</igtxt:webtextedit></TD>
					</TR>
					<TR>
						<TD bgcolor="white">购买日期：</TD>
						<TD bgcolor="white">
							<igtxt:webdatetimeedit id="PurchaseDate" runat="server" BorderStyle="Solid" BorderWidth="1px" BorderColor="#7B9EBD"
								Font-Size="8pt" Font-Names="Tahoma" MinValue="1900-01-01"></igtxt:webdatetimeedit></TD>
						<TD bgcolor="white">检定周期：</TD>
						<TD bgcolor="white">
							<igtxt:WebNumericEdit id="TestCyc" runat="server" BorderStyle="Solid" BorderWidth="1px" BorderColor="#7B9EBD"
								Font-Size="8pt" Font-Names="Tahoma" Width="90px" DataMode="Int"></igtxt:WebNumericEdit>个月
							<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="TestCyc"></asp:RequiredFieldValidator></TD>
					</TR>
					<TR>
						<TD bgcolor="white">上次检定日期：</TD>
						<TD bgcolor="white">
							<igtxt:webdatetimeedit id="LastTestDate" runat="server" BorderStyle="Solid" BorderWidth="1px" BorderColor="#7B9EBD"
								Font-Size="8pt" Font-Names="Tahoma" MinValue="1900-01-01"></igtxt:webdatetimeedit></TD>
						<TD bgcolor="white"></TD>
						<TD bgcolor="white"></TD>
					</TR>
					<TR>
						<TD bgcolor="white" vAlign="top"><BR>
							备&nbsp;&nbsp;&nbsp; 注：</TD>
						<TD bgcolor="white" colspan="5">
							<asp:textbox id="Remark" runat="server" BorderWidth="1px" BorderColor="#7F9DB9" Width="376px"
								TextMode="MultiLine" Height="80px"></asp:textbox></TD>
					</TR>
				</TABLE>
			</FONT><FONT face="宋体">
				<BR>
			</FONT>
			<igtxt:webimagebutton id="Submit" runat="server" UseBrowserDefaults="False" Text="提交">
				<RoundedCorners MaxHeight="40" ImageUrl="ig_butCRM1.gif" MaxWidth="400" HoverImageUrl="ig_butCRM2.gif"
					RenderingType="FileImages" HeightOfBottomEdge="2" PressedImageUrl="ig_butCRM2.gif" WidthOfRightEdge="2"></RoundedCorners>
			</igtxt:webimagebutton>
		</form>
		<FONT face="宋体"></FONT>
	</body>
</HTML>
