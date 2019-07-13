<%@ Register TagPrefix="igtxt" Namespace="Infragistics.WebUI.WebDataInput" Assembly="Infragistics.WebUI.WebDataInput.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Control Language="c#" AutoEventWireup="false" Codebehind="MultiOption.ascx.cs" Inherits="LIMS.Control.MultiOption" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<FONT face="宋体">&nbsp;</FONT>
<asp:Label id="Selected" Font-Size="14px" runat="server"></asp:Label><BR>
<FONT face="宋体">&nbsp;</FONT>
<asp:CheckBoxList id=SelectPermission Font-Size="14px" runat="server" DataValueField="ID" DataTextField="权限模块名" RepeatColumns="5" CellPadding="5" DataSource="<%# sm1 %>" DataMember="权限模块">
</asp:CheckBoxList><BR>
<FONT face="宋体">&nbsp;</FONT>&nbsp;
<igtxt:WebImageButton id="ConfirmPermission" runat="server" UseBrowserDefaults="False" Text="确定" DESIGNTIMEDRAGDROP="794">
	<ROUNDEDCORNERS WidthOfRightEdge="2" PressedImageUrl="ig_butCRM2.gif" HeightOfBottomEdge="2" RenderingType="FileImages"
		HoverImageUrl="ig_butCRM2.gif" MaxWidth="400" ImageUrl="ig_butCRM1.gif" MaxHeight="40"></ROUNDEDCORNERS>
</igtxt:WebImageButton><FONT face="宋体">&nbsp; </FONT>
<igtxt:WebImageButton id="CancelPermission" runat="server" UseBrowserDefaults="False" Text="取消">
	<ROUNDEDCORNERS WidthOfRightEdge="2" PressedImageUrl="ig_butCRM2.gif" HeightOfBottomEdge="2" RenderingType="FileImages"
		HoverImageUrl="ig_butCRM2.gif" MaxWidth="400" ImageUrl="ig_butCRM1.gif" MaxHeight="40"></ROUNDEDCORNERS>
</igtxt:WebImageButton><FONT face="宋体"><BR>
</FONT>
