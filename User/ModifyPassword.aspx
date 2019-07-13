<%@ Register TagPrefix="igtxt" Namespace="Infragistics.WebUI.WebDataInput" Assembly="Infragistics.WebUI.WebDataInput.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Page language="c#" Codebehind="ModifyPassword.aspx.cs" AutoEventWireup="false" Inherits="LIMS.User.ModifyPassword" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML xmlns:igtbl>
	<HEAD>
		<title>ModifyPassword</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">
				<TABLE id="Table3" style="BORDER-RIGHT: black 1px; BORDER-TOP: black 1px; FONT-SIZE: 14px; BORDER-LEFT: black 1px; COLOR: white; BORDER-BOTTOM: black 1px"
					cellSpacing="2" cellPadding="4" width="92" border="0">
					<TR>
						<TD align="center" bgColor="appworkspace">修改密码</TD>
					</TR>
				</TABLE>
				<TABLE id="Table1" style="FONT-SIZE: 14px; COLOR: #006699" cellSpacing="1" cellPadding="5"
					width="600" bgColor="#eeeeee" border="0" DESIGNTIMEDRAGDROP="26">
					<TR>
						<TD style="WIDTH: 80px" bgColor="#f6f6f6">旧 密 码：</TD>
						<TD style="WIDTH: 189px" bgColor="#ffffff">
							<igtxt:webtextedit id="OldPassword" runat="server" DESIGNTIMEDRAGDROP="293" Width="150px" BorderColor="#7B9EBD"
								BorderWidth="1px" BorderStyle="Solid" Font-Size="8pt" Font-Names="Tahoma" PasswordMode="True">
								<ButtonsAppearance>
									<ButtonStyle Width="13px"></ButtonStyle>
								</ButtonsAppearance>
							</igtxt:webtextedit>
							<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ControlToValidate="OldPassword" ErrorMessage="RequiredFieldValidator"
								Display="Dynamic">*</asp:RequiredFieldValidator>
							<asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" ValidationExpression="^\w{6}\w*"
								ControlToValidate="OldPassword" ErrorMessage="RegularExpressionValidator" Display="Dynamic">*</asp:RegularExpressionValidator></TD>
						<TD bgColor="white">中文、英文或数字组成，至少3个字符</TD>
					</TR>
					<TR>
						<TD style="WIDTH: 80px" bgColor="#f6f6f6">新 密 码：</TD>
						<TD style="WIDTH: 189px" bgColor="#ffffff">
							<igtxt:webtextedit id="NewPassword" runat="server" DESIGNTIMEDRAGDROP="317" Width="150px" BorderColor="#7B9EBD"
								BorderWidth="1px" BorderStyle="Solid" Font-Size="8pt" Font-Names="Tahoma" PasswordMode="True">
								<ButtonsAppearance>
									<ButtonStyle Width="13px"></ButtonStyle>
								</ButtonsAppearance>
							</igtxt:webtextedit>
							<asp:RegularExpressionValidator id="RegularExpressionValidator2" runat="server" DESIGNTIMEDRAGDROP="139" ValidationExpression="^\w{6}\w*"
								ControlToValidate="NewPassword" ErrorMessage="RegularExpressionValidator" Display="Dynamic">*</asp:RegularExpressionValidator>
							<asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" ControlToValidate="NewPassword" ErrorMessage="RequiredFieldValidator"
								Display="Dynamic">*</asp:RequiredFieldValidator></TD>
						<TD bgColor="white">至少6个字符</TD>
					</TR>
					<TR>
						<TD style="WIDTH: 80px" bgColor="#f6f6f6">再次确认<BR>
							新密码：</TD>
						<TD style="WIDTH: 189px" bgColor="#ffffff">
							<igtxt:webtextedit id="ConfirmPassword" runat="server" Width="150px" BorderColor="#7B9EBD" BorderWidth="1px"
								BorderStyle="Solid" Font-Size="8pt" Font-Names="Tahoma" PasswordMode="True">
								<ButtonsAppearance>
									<ButtonStyle Width="13px"></ButtonStyle>
								</ButtonsAppearance>
							</igtxt:webtextedit>
							<asp:CompareValidator id="CompareValidator1" runat="server" ControlToValidate="ConfirmPassword" ErrorMessage="CompareValidator"
								ControlToCompare="NewPassword">*</asp:CompareValidator></TD>
						<TD bgColor="white">重复输入上面密码</TD>
					</TR>
				</TABLE>
			</FONT>
			<BR>
			<igtxt:WebImageButton id="Confirm" runat="server" Text="确定" UseBrowserDefaults="False">
				<RoundedCorners MaxHeight="40" ImageUrl="ig_butCRM1.gif" MaxWidth="400" HoverImageUrl="ig_butCRM2.gif"
					RenderingType="FileImages" HeightOfBottomEdge="2" PressedImageUrl="ig_butCRM2.gif" WidthOfRightEdge="2"></RoundedCorners>
			</igtxt:WebImageButton><FONT face="宋体">&nbsp;</FONT>
			<asp:Label id="Notice" runat="server" ForeColor="Red"></asp:Label>
		</form>
	</body>
</HTML>
