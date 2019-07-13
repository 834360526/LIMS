<%@ Page language="c#" Codebehind="WebForm4.aspx.cs" AutoEventWireup="false" Inherits="LIMS.WebForm4" smartNavigation="True"%>
<%@ Register TagPrefix="igtxt" Namespace="Infragistics.WebUI.WebDataInput" Assembly="Infragistics.WebUI.WebDataInput.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igtbl" Namespace="Infragistics.WebUI.UltraWebGrid" Assembly="Infragistics.WebUI.UltraWebGrid.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm4</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<style media="print">
			.Noprint { DISPLAY: none }
			.PageNext { PAGE-BREAK-AFTER: always }
		</style>
		<script language="javascript">
		var b="ad";
		
		b="<%=a%>";
		
		document.write(b);
//	window.self.open("default.htm");



		function WebImageButton1_Click(oButton, oEvent){
			Barcode.PrintLabel("a","b","c","4");
			
		}
		

		</script>
	</HEAD>
	<BODY>
		<OBJECT id="Barcode" classid="clsid:BE5B50A4-3803-4AF5-866D-A6E19E469D7B" VIEWASTEXT>
		</OBJECT>
		<form id="Form1" method="post" runat="server">
			<asp:RadioButtonList id="RadioButtonList1" runat="server" AutoPostBack="True">
				<asp:ListItem Value="a">a</asp:ListItem>
				<asp:ListItem Value="b">b</asp:ListItem>
				<asp:ListItem Value="c">c</asp:ListItem>
			</asp:RadioButtonList>
			<asp:Button id="Button1" runat="server" Text="Button"></asp:Button>
		</form>
		<p class="Noprint">
			<igtxt:WebImageButton id="WebImageButton1" runat="server" AutoSubmit="False">
				<ClientSideEvents Click="WebImageButton1_Click"></ClientSideEvents>
			</igtxt:WebImageButton>
		</p>
	</BODY>
</HTML>
