<%@ Register TagPrefix="igtab" Namespace="Infragistics.WebUI.UltraWebTab" Assembly="Infragistics.WebUI.UltraWebTab.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Page language="c#" Codebehind="WebForm5.aspx.cs" AutoEventWireup="false" Inherits="LIMS.WebForm5" %>
<%@ Register TagPrefix="igtbl" Namespace="Infragistics.WebUI.UltraWebGrid" Assembly="Infragistics.WebUI.UltraWebGrid.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm5</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<SCRIPT  language="javascript">
		
		function dd()
		{
		From1.
		}
	
--></SCRIPT>
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Button id="Button1" runat="server" Text="Button"></asp:Button>
			<igtbl:UltraWebGrid id="UltraWebGrid1" runat="server" ImageDirectory="/ig_common/Images/">
				<DisplayLayout Version="4.00" SelectTypeRowDefault="Single" Name="UltraWebGrid1">
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
					<HeaderStyleDefault BorderColor="Black" BorderStyle="Solid" ForeColor="White" BackColor="#2B64A7">
						<BorderDetails ColorTop="White" WidthLeft="1px" WidthTop="1px" ColorLeft="White"></BorderDetails>
					</HeaderStyleDefault>
					<FrameStyle Cursor="Default" BorderWidth="3px" BorderColor="#999999" BorderStyle="None"></FrameStyle>
					<ActivationObject BorderStyle="Dotted"></ActivationObject>
					<GroupByBox>
						<Style BorderColor="Window" BackColor="ActiveBorder">
						</Style>
					</GroupByBox>
					<SelectedRowStyleDefault ForeColor="White" BackColor="#0A75F0"></SelectedRowStyleDefault>
					<RowAlternateStyleDefault BackColor="#E9E9F7"></RowAlternateStyleDefault>
					<RowStyleDefault BorderWidth="1px" BorderColor="Gray" BorderStyle="Solid" BackColor="#C7D5E8">
						<BorderDetails ColorTop="Gray" WidthLeft="0px" WidthTop="0px" ColorLeft="Gray"></BorderDetails>
					</RowStyleDefault>
				</DisplayLayout>
				<Bands>
					<igtbl:UltraGridBand></igtbl:UltraGridBand>
				</Bands>
			</igtbl:UltraWebGrid>
			<TABLE id="Table1" cellspacing="0" cellpadding="0" rules="rows" bordercolor="black" border="1"
				style="BORDER-COLLAPSE:collapse" width="300">
				<TR>
					<TD><FONT face="宋体">r</FONT></TD>
					<TD><FONT face="宋体">e</FONT></TD>
					<TD><FONT face="宋体">3</FONT></TD>
				</TR>
				<TR>
					<TD><FONT face="宋体">f</FONT></TD>
					<TD><FONT face="宋体">d</FONT></TD>
					<TD><FONT face="宋体">2</FONT></TD>
				</TR>
				<TR>
					<TD><FONT face="宋体">a</FONT></TD>
					<TD><FONT face="宋体">g</FONT></TD>
					<TD><FONT face="宋体">12</FONT></TD>
				</TR>
			</TABLE>
			<OBJECT classid="clsid:E200EDC4-5AD7-47A6-9F89-E80AB9DD2A36" id="ie" name="ie" VIEWASTEXT>
				<PARAM NAME="Visible" VALUE="0">
				<PARAM NAME="AutoScroll" VALUE="0">
				<PARAM NAME="AutoSize" VALUE="0">
				<PARAM NAME="AxBorderStyle" VALUE="1">
				<PARAM NAME="Caption" VALUE="IEWord">
				<PARAM NAME="Color" VALUE="4278190095">
				<PARAM NAME="Font" VALUE="Arial">
				<PARAM NAME="KeyPreview" VALUE="0">
				<PARAM NAME="PixelsPerInch" VALUE="96">
				<PARAM NAME="PrintScale" VALUE="1">
				<PARAM NAME="Scaled" VALUE="-1">
				<PARAM NAME="DropTarget" VALUE="0">
				<PARAM NAME="HelpFile" VALUE="">
				<PARAM NAME="ScreenSnap" VALUE="0">
				<PARAM NAME="SnapBuffer" VALUE="10">
				<PARAM NAME="DoubleBuffered" VALUE="0">
				<PARAM NAME="Enabled" VALUE="-1">
				<PARAM NAME="WebUrl" VALUE="">
				<PARAM NAME="RecordID" VALUE="">
				<PARAM NAME="Template" VALUE="">
				<PARAM NAME="FileName" VALUE="">
				<PARAM NAME="EditType" VALUE="">
				<PARAM NAME="UserName" VALUE="">
				<PARAM NAME="ShowMenu" VALUE="0">
				<PARAM NAME="ExtParam" VALUE="">
				<PARAM NAME="ShowTitle" VALUE="-1">
			</OBJECT>
			<script language=javascript>
			Form1.ie.
						</script>
			<igtab:UltraWebTab id="UltraWebTab1" runat="server" BorderWidth="1px" BorderColor="Gray" BorderStyle="Solid"
				ThreeDEffect="False">
				<DefaultTabStyle Height="20px" BackColor="WhiteSmoke"></DefaultTabStyle>
				<RoundedImage SelectedImage="ig_tab_lightb2.gif" NormalImage="ig_tab_lightb1.gif" FillStyle="LeftMergedWithCenter"></RoundedImage>
				<Tabs>
					<igtab:Tab Text="New Tab">
						<ContentPane TargetUrl="WebForm4.aspx"></ContentPane>
					</igtab:Tab>
					<igtab:Tab Text="New Tab"></igtab:Tab>
				</Tabs>
			</igtab:UltraWebTab>
			<P><FONT face="宋体"></FONT>&nbsp;</P>
			<P>
				<asp:Table id="Table2" runat="server" BorderStyle="Solid" BorderColor="Black" BorderWidth="1px"
					GridLines="Horizontal" CellSpacing="0" CellPadding="0">
					<asp:TableRow>
						<asp:TableCell Text="a"></asp:TableCell>
						<asp:TableCell Text="b"></asp:TableCell>
					</asp:TableRow>
					<asp:TableRow>
						<asp:TableCell Text="c"></asp:TableCell>
						<asp:TableCell Text="d"></asp:TableCell>
					</asp:TableRow>
				</asp:Table></P>
		</form>
	</body>
</HTML>
