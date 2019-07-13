<%@ Page language="c#" Codebehind="ShowMessage.aspx.cs" AutoEventWireup="false" Inherits="LIMS.Message.ShowMessage" validateRequest=false %>
<%@ Register TagPrefix="igtxt" Namespace="Infragistics.WebUI.WebDataInput" Assembly="Infragistics.WebUI.WebDataInput.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igmisc" Namespace="Infragistics.WebUI.Misc" Assembly="Infragistics.WebUI.Misc.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igsch" Namespace="Infragistics.WebUI.WebSchedule" Assembly="Infragistics.WebUI.WebDateChooser.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ShowMessage</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">
				<TABLE id="Table1" cellSpacing="1" cellPadding="8" width="500" border="0" bgColor="#000000"
					style="FONT-SIZE: 14px">
					<TR>
						<TD bgColor="#ffffcc">标 &nbsp;题：
							<igtxt:webtextedit id="Title" runat="server" CellSpacing="1" BorderColor="#7F9DB9" BorderWidth="1px"
								UseBrowserDefaults="False" BorderStyle="Solid" DESIGNTIMEDRAGDROP="11" ReadOnly="True" Width="400px">
								<ButtonsAppearance CustomButtonDefaultTriangleImages="Arrow">
									<ButtonPressedStyle BackColor="#83A6F4"></ButtonPressedStyle>
									<ButtonDisabledStyle BorderColor="#D7D7D7" ForeColor="#BEBEBE" BackColor="#E1E1DD"></ButtonDisabledStyle>
									<ButtonStyle Width="13px" BorderWidth="1px" BorderColor="#ABC1F4" BorderStyle="Solid" ForeColor="#506080"
										BackColor="#C5D5FC"></ButtonStyle>
									<ButtonHoverStyle BackColor="#DCEDFD"></ButtonHoverStyle>
								</ButtonsAppearance>
							</igtxt:webtextedit></TD>
					</TR>
					<TR>
						<TD bgColor="#ffffcc">
							<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0" style="FONT-SIZE: 14px">
								<TR>
									<TD>发件人：
										<igtxt:webtextedit id="Sender" runat="server" CellSpacing="1" BorderColor="#7F9DB9" BorderWidth="1px"
											UseBrowserDefaults="False" BorderStyle="Solid" ReadOnly="True" Width="100px">
											<ButtonsAppearance CustomButtonDefaultTriangleImages="Arrow">
												<ButtonPressedStyle BackColor="#83A6F4"></ButtonPressedStyle>
												<ButtonDisabledStyle BorderColor="#D7D7D7" ForeColor="#BEBEBE" BackColor="#E1E1DD"></ButtonDisabledStyle>
												<ButtonStyle Width="13px" BorderWidth="1px" BorderColor="#ABC1F4" BorderStyle="Solid" ForeColor="#506080"
													BackColor="#C5D5FC"></ButtonStyle>
												<ButtonHoverStyle BackColor="#DCEDFD"></ButtonHoverStyle>
											</ButtonsAppearance>
										</igtxt:webtextedit></TD>
									<TD></TD>
									<TD>发送日期：
										<igtxt:WebDateTimeEdit id="SendDate" runat="server" CellSpacing="1" BorderColor="#7F9DB9" BorderWidth="1px"
											UseBrowserDefaults="False" BorderStyle="Solid" ReadOnly="True">
											<ButtonsAppearance CustomButtonDefaultTriangleImages="Arrow">
												<ButtonPressedStyle BackColor="#83A6F4"></ButtonPressedStyle>
												<ButtonDisabledStyle BorderColor="#D7D7D7" ForeColor="#BEBEBE" BackColor="#E1E1DD"></ButtonDisabledStyle>
												<ButtonStyle Width="13px" BorderWidth="1px" BorderColor="#ABC1F4" BorderStyle="Solid" ForeColor="#506080"
													BackColor="#C5D5FC"></ButtonStyle>
												<ButtonHoverStyle BackColor="#DCEDFD"></ButtonHoverStyle>
											</ButtonsAppearance>
											<SpinButtons DefaultTriangleImages="ArrowSmall" Width="15px"></SpinButtons>
										</igtxt:WebDateTimeEdit></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
					<TR>
						<TD vAlign="top" height="200" bgColor="#ffffcc"><asp:textbox id="Content" runat="server" Height="200px" Width="500px" TextMode="MultiLine" BorderWidth="1px"
								BorderColor="#7F9DB9" ReadOnly="True"></asp:textbox></TD>
					</TR>
					<TR>
						<TD vAlign="top" bgColor="#ffffcc">附件：
							<asp:Button id="Open" runat="server" Text="打开"></asp:Button>
							<asp:Label id="None" runat="server">无</asp:Label></TD>
					</TR>
					<TR>
						<TD vAlign="top" bgColor="#ffffcc">
							<igtxt:WebImageButton id="Back" runat="server" UseBrowserDefaults="False" Height="23px" Text="返回">
								<Alignments VerticalAll="Bottom"></Alignments>
								<RoundedCorners MaxHeight="80" ImageUrl="ig_butXP1wh.gif" MaxWidth="400" HoverImageUrl="ig_butXP2wh.gif"
									RenderingType="FileImages" PressedImageUrl="ig_butXP4wh.gif" DisabledImageUrl="ig_butXP5wh.gif"
									FocusImageUrl="ig_butXP3wh.gif"></RoundedCorners>
							</igtxt:WebImageButton></TD>
					</TR>
				</TABLE>
		</form>
		</FONT>
	</body>
</HTML>
