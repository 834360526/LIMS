<%@ Page language="c#" Codebehind="Outbox.aspx.cs" AutoEventWireup="false" Inherits="LIMS.Message.Outbox" smartNavigation="True"%>
<%@ Register TagPrefix="igmisc" Namespace="Infragistics.WebUI.Misc" Assembly="Infragistics.WebUI.Misc.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igtxt" Namespace="Infragistics.WebUI.WebDataInput" Assembly="Infragistics.WebUI.WebDataInput.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igtab" Namespace="Infragistics.WebUI.UltraWebTab" Assembly="Infragistics.WebUI.UltraWebTab.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Outbox</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="javascript" type="text/javascript">
		function ChangIndex()
		{
			document.writeln("xxxx");
		}
		</script>
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" style="FONT-SIZE: 14px" method="post" runat="server">
			<FONT face="宋体"></FONT>
			<TABLE id="Table1" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; FONT-SIZE: 14px; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid"
				borderColor="black" cellSpacing="0" cellPadding="8" width="500" bgColor="#ffffcc" border="0">
				<TR>
					<TD style="PADDING-RIGHT: 0px; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; MARGIN: 0px; PADDING-TOP: 0px"
						align="center" height="3"><FONT face="宋体"></FONT></TD>
				</TR>
				<TR>
					<TD style="PADDING-RIGHT: 0px; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; MARGIN: 0px; PADDING-TOP: 0px"
						align="center" height="3"><FONT face="宋体">标 &nbsp;题：
							<igtxt:webtextedit id="Title" runat="server" CellSpacing="1" BorderColor="#7F9DB9" BorderWidth="1px"
								UseBrowserDefaults="False" BorderStyle="Solid" Width="400px">
								<ButtonsAppearance CustomButtonDefaultTriangleImages="Arrow">
									<ButtonPressedStyle BackColor="#83A6F4"></ButtonPressedStyle>
									<ButtonDisabledStyle BorderColor="#D7D7D7" ForeColor="#BEBEBE" BackColor="#E1E1DD"></ButtonDisabledStyle>
									<ButtonStyle Width="13px" BorderWidth="1px" BorderColor="#ABC1F4" BorderStyle="Solid" ForeColor="#506080"
										BackColor="#C5D5FC"></ButtonStyle>
									<ButtonHoverStyle BackColor="#DCEDFD"></ButtonHoverStyle>
								</ButtonsAppearance>
							</igtxt:webtextedit><asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="Title"></asp:requiredfieldvalidator></FONT></TD>
				</TR>
				<TR>
					<TD style="PADDING-RIGHT: 0px; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; MARGIN: 0px; PADDING-TOP: 0px"
						vAlign="bottom" align="center" height="5"><FONT face="宋体">
							<TABLE id="Table4" height="1" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD bgColor="#000000"></TD>
								</TR>
							</TABLE>
						</FONT>
					</TD>
				</TR>
				<TR>
					<TD style="PADDING-RIGHT: 0px; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; MARGIN: 0px; PADDING-TOP: 0px">
						<TABLE id="Table2" style="FONT-SIZE: 14px" height="190" cellSpacing="0" cellPadding="0"
							width="100%" border="0">
							<TR>
								<TD vAlign="top"><BR>
									&nbsp; 信息类型：
									<BR>
									<asp:radiobuttonlist id="MessageType" runat="server" Width="60px" AutoPostBack="True" Font-Size="14px">
										<asp:ListItem Value="2" Selected="True">个人</asp:ListItem>
										<asp:ListItem Value="3">科室</asp:ListItem>
										<asp:ListItem Value="4">公告</asp:ListItem>
									</asp:radiobuttonlist></TD>
								<TD style="BORDER-LEFT: black 1px solid" vAlign="top" align="center" width="70"><BR>
									收件人：</TD>
								<TD><igtab:ultrawebtab id="Addressee" runat="server" BorderColor="#949C9C" BorderWidth="1px" BorderStyle="Solid"
										Width="200px" ThreeDEffect="False" Height="170px" DisplayMode="MultiRow">
										<DefaultTabStyle Height="22px" Font-Size="8pt" Font-Names="Microsoft Sans Serif" ForeColor="Black"
											BackColor="GhostWhite">
											<Padding Top="2px"></Padding>
										</DefaultTabStyle>
										<RoundedImage LeftSideWidth="7" RightSideWidth="6" ShiftOfImages="2" SelectedImage="ig_tab_winXPs1.gif"
											NormalImage="ig_tab_winXPs3.gif" HoverImage="ig_tab_winXPs2.gif" FillStyle="LeftMergedWithCenter"></RoundedImage>
										<SelectedTabStyle>
											<Padding Bottom="2px"></Padding>
										</SelectedTabStyle>
										<Tabs>
											<igtab:Tab Text="个人">
												<ContentPane UserControlUrl="..\control\IndividualTree.ascx" Scrollable="Auto"></ContentPane>
											</igtab:Tab>
											<igtab:Tab Text="科室">
												<ContentPane UserControlUrl="..\control\officetree.ascx" Scrollable="Auto"></ContentPane>
											</igtab:Tab>
										</Tabs>
									</igtab:ultrawebtab></TD>
							</TR>
						</TABLE>
						<TABLE id="Table3" height="1" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD bgColor="#000000"></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD vAlign="top" height="200"><asp:textbox id="Content" runat="server" BorderColor="#7F9DB9" BorderWidth="1px" Width="500px"
							Height="200px" TextMode="MultiLine"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="PADDING-RIGHT: 0px; PADDING-LEFT: 0px; MARGIN-LEFT: 0px; MARGIN-RIGHT: 0px"
						vAlign="top" align="center">附 件：<INPUT id="File1" type="file" size="57" name="file" runat="server">
						<BR>
						<BR>
						<TABLE id="Table5" height="1" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD bgColor="#000000"></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD vAlign="top"><igtxt:webimagebutton id="Send" runat="server" UseBrowserDefaults="False" Height="23px" Text="发送">
							<Alignments VerticalAll="Bottom"></Alignments>
							<RoundedCorners MaxHeight="80" ImageUrl="ig_butXP1wh.gif" MaxWidth="400" HoverImageUrl="ig_butXP2wh.gif"
								RenderingType="FileImages" PressedImageUrl="ig_butXP4wh.gif" DisabledImageUrl="ig_butXP5wh.gif"
								FocusImageUrl="ig_butXP3wh.gif"></RoundedCorners>
						</igtxt:webimagebutton><asp:label id="Err" runat="server" ForeColor="Red"></asp:label></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
