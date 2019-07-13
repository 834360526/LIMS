<%@ Register TagPrefix="igtxt" Namespace="Infragistics.WebUI.WebDataInput" Assembly="Infragistics.WebUI.WebDataInput.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Login.ascx.cs" Inherits="LIMS.Control.Login" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<FONT face="宋体"></FONT>
<TABLE class="borders" id="Table5" height="200" cellSpacing="0" cellPadding="0" width="200"
	border="0">
	<TR>
		<TD height="23">
			<TABLE id="Table6" cellSpacing="0" cellPadding="3" width="100%" border="0">
				<TR>
					<TD>
						<TABLE id="Table7" height="20" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR bgColor="#6891d2">
								<TD class="wtitle" vAlign="middle" noWrap><FONT color="white">&nbsp;<SPAN class="STYLE1">用户登录</SPAN></FONT></TD>
							</TR>
							<TR>
								<TD bgColor="#0f5892"><SPACER type="block" height="1" /></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
			<TABLE id="Table8" height="1" cellSpacing="0" cellPadding="0" width="100%" bgColor="#cccccc"
				border="0">
				<TR>
					<TD><FONT face="宋体"></FONT></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD style="FONT-SIZE: 14px" vAlign="middle" align="center">用户名：<igtxt:WebTextEdit id="UserName" Width="120px" runat="server" UseBrowserDefaults="False" BorderStyle="Solid"
				BorderWidth="1px" BorderColor="#7F9DB9" CellSpacing="1">
				<ButtonsAppearance CustomButtonDefaultTriangleImages="Arrow">
					<ButtonPressedStyle BackColor="#83A6F4"></ButtonPressedStyle>
					<ButtonDisabledStyle BorderColor="#D7D7D7" ForeColor="#BEBEBE" BackColor="#E1E1DD"></ButtonDisabledStyle>
					<ButtonStyle Width="13px" BorderWidth="1px" BorderColor="#ABC1F4" BorderStyle="Solid" ForeColor="#506080"
						BackColor="#C5D5FC"></ButtonStyle>
					<ButtonHoverStyle BackColor="#DCEDFD"></ButtonHoverStyle>
				</ButtonsAppearance>
			</igtxt:WebTextEdit><BR>
			<BR>
			密&nbsp;&nbsp;&nbsp; 码：<igtxt:WebTextEdit id="Password" Width="120px" runat="server" UseBrowserDefaults="False" BorderStyle="Solid"
				BorderWidth="1px" BorderColor="#7F9DB9" CellSpacing="1" PasswordMode="True">
				<ButtonsAppearance CustomButtonDefaultTriangleImages="Arrow">
					<ButtonPressedStyle BackColor="#83A6F4"></ButtonPressedStyle>
					<ButtonDisabledStyle BorderColor="#D7D7D7" ForeColor="#BEBEBE" BackColor="#E1E1DD"></ButtonDisabledStyle>
					<ButtonStyle Width="13px" BorderWidth="1px" BorderColor="#ABC1F4" BorderStyle="Solid" ForeColor="#506080"
						BackColor="#C5D5FC"></ButtonStyle>
					<ButtonHoverStyle BackColor="#DCEDFD"></ButtonHoverStyle>
				</ButtonsAppearance>
			</igtxt:WebTextEdit>
		</TD>
	</TR>
	<TR>
		<TD style="FONT-SIZE: 14px" vAlign="middle" align="right">
			<asp:Label id="Err" runat="server" Font-Size="14px" ForeColor="Red"></asp:Label><FONT face="宋体">&nbsp;&nbsp;
			</FONT>
		</TD>
	</TR>
	<TR>
		<TD style="FONT-SIZE: 14px" vAlign="middle" align="right" background=" ">
			<igtxt:WebImageButton id="Confirm" runat="server" Text="确定" UseBrowserDefaults="False">
				<RoundedCorners MaxHeight="40" ImageUrl="ig_butCRM1.gif" MaxWidth="400" HoverImageUrl="ig_butCRM2.gif"
					RenderingType="FileImages" HeightOfBottomEdge="2" PressedImageUrl="ig_butCRM2.gif" WidthOfRightEdge="2"></RoundedCorners>
			</igtxt:WebImageButton><FONT face="宋体">&nbsp;</FONT></TD>
	</TR>
	<TR>
		<TD style="FONT-SIZE: 14px" vAlign="middle" align="center"><FONT face="宋体"> <a href="/LIMS/User/Register.aspx" target="main">
					注册</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;忘记密码</FONT></TD>
	</TR>
</TABLE>
