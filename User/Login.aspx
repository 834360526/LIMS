<%@ Register TagPrefix="igmisc" Namespace="Infragistics.WebUI.Misc" Assembly="Infragistics.WebUI.Misc.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Page language="c#" Codebehind="Login.aspx.cs" AutoEventWireup="false" Inherits="LIMS.User.Login" %>
<%@ Register TagPrefix="uc1" TagName="Login" Src="../Control/Login.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title></title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="borders.css" type="text/css" rel="stylesheet">
		<style type="text/css">.STYLE1 { FONT-SIZE: 14px }
		</style>
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<uc1:Login id="Login1" runat="server"></uc1:Login>
		</form>
	</body>
</HTML>
