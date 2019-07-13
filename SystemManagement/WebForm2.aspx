<%@ Page language="c#" Codebehind="WebForm2.aspx.cs" AutoEventWireup="false" Inherits="LIMS.SystemManagement.WebForm2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm2</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<P>
				<FONT face="宋体">添加用户信息</FONT></P>
			<P><FONT face="宋体">
					<asp:Button id="Start" runat="server" Text="添加用户信息" DESIGNTIMEDRAGDROP="11"></asp:Button>&nbsp;
					<asp:Button id="AddHandler" runat="server" Text="添加处理人"></asp:Button></P>
			<P>
				<asp:DataGrid id=dg runat="server" DataSource="<%# dataSet1 %>">
				</asp:DataGrid></P>
			<P><FONT face="宋体"></P>
			</FONT></FONT>
		</form>
	</body>
</HTML>
