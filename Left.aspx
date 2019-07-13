<%@ Page language="c#" Codebehind="Left.aspx.cs" AutoEventWireup="false" Inherits="LIMS.Left" %>
<%@ Register TagPrefix="igmisc" Namespace="Infragistics.WebUI.Misc" Assembly="Infragistics.WebUI.Misc.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="uc1" TagName="LeftMenu" Src="Control/LeftMenu.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
		<title>Left</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
	<body MS_POSITIONING="FlowLayout" bottomMargin="0" rightMargin="0">
		<form id="Form1" method="post" runat="server">
			<igmisc:WebPanel id="Info" runat="server" Width="150px">
<PanelStyle BorderWidth="1px" BorderColor="#002D96" BorderStyle="Solid">

<Padding Bottom="1px" Left="1px" Top="1px" Right="1px">
</Padding>

<BorderDetails WidthTop="0px">
</BorderDetails>

</PanelStyle>

<Header Text="登录信息" TextAlignment="Left">

<ExpandedAppearance>

<Style BorderWidth="1px" Font-Size="10pt" Font-Names="Times New Roman" Font-Bold="True" BorderColor="#002D96" BorderStyle="Solid" ForeColor="White" BackgroundImage="igpnl_office2k3_drk.png">

<Padding Bottom="2px" Left="4px" Top="2px" Right="4px">
</Padding>

</Style>

</ExpandedAppearance>

<ExpansionIndicator Height="0px" Width="0px">
</ExpansionIndicator>

</Header>

<AutoPostBack ExpandedStateChanging="False" ExpandedStateChanged="False">
</AutoPostBack>

<Template>
<TABLE id=Table1 style="FONT-SIZE: 13px" cellSpacing=0 cellPadding=2 border=0 DESIGNTIMEDRAGDROP="861">
<TR>
<TD>
<asp:Label id=Name runat="server" Font-Bold="True"></asp:Label>&nbsp; 您好！</TD></TR>
<TR>
<TD>您的科室是：<br> 
<asp:Label id=Office runat="server" Font-Bold="True"></asp:Label></TD></TR></TABLE>
</Template>
			</igmisc:WebPanel>
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" border="0">
				<TR>
					<TD height="10"><FONT face="宋体"></FONT></TD>
				</TR>
				<TR>
					<TD>
						<uc1:LeftMenu id="LeftMenu1" runat="server"></uc1:LeftMenu></TD>
				</TR>
				<TR>
					<TD height="10"><FONT face="宋体"></FONT></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
