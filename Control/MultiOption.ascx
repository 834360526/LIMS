<%@ Register TagPrefix="igtxt" Namespace="Infragistics.WebUI.WebDataInput" Assembly="Infragistics.WebUI.WebDataInput.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Control Language="c#" AutoEventWireup="false" Codebehind="MultiOption.ascx.cs" Inherits="LIMS.Control.MultiOption" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<FONT face="����">&nbsp;</FONT>
<asp:Label id="Selected" Font-Size="14px" runat="server"></asp:Label><BR>
<FONT face="����">&nbsp;</FONT>
<asp:CheckBoxList id=SelectPermission Font-Size="14px" runat="server" DataValueField="ID" DataTextField="Ȩ��ģ����" RepeatColumns="5" CellPadding="5" DataSource="<%# sm1 %>" DataMember="Ȩ��ģ��">
</asp:CheckBoxList><BR>
<FONT face="����">&nbsp;</FONT>&nbsp;
<igtxt:WebImageButton id="ConfirmPermission" runat="server" UseBrowserDefaults="False" Text="ȷ��" DESIGNTIMEDRAGDROP="794">
	<ROUNDEDCORNERS WidthOfRightEdge="2" PressedImageUrl="ig_butCRM2.gif" HeightOfBottomEdge="2" RenderingType="FileImages"
		HoverImageUrl="ig_butCRM2.gif" MaxWidth="400" ImageUrl="ig_butCRM1.gif" MaxHeight="40"></ROUNDEDCORNERS>
</igtxt:WebImageButton><FONT face="����">&nbsp; </FONT>
<igtxt:WebImageButton id="CancelPermission" runat="server" UseBrowserDefaults="False" Text="ȡ��">
	<ROUNDEDCORNERS WidthOfRightEdge="2" PressedImageUrl="ig_butCRM2.gif" HeightOfBottomEdge="2" RenderingType="FileImages"
		HoverImageUrl="ig_butCRM2.gif" MaxWidth="400" ImageUrl="ig_butCRM1.gif" MaxHeight="40"></ROUNDEDCORNERS>
</igtxt:WebImageButton><FONT face="����"><BR>
</FONT>
