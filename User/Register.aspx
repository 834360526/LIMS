<%@ Register TagPrefix="igtbl" Namespace="Infragistics.WebUI.UltraWebGrid" Assembly="Infragistics.WebUI.UltraWebGrid.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igtxt" Namespace="Infragistics.WebUI.WebDataInput" Assembly="Infragistics.WebUI.WebDataInput.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="igcmbo" Namespace="Infragistics.WebUI.WebCombo" Assembly="Infragistics.WebUI.WebCombo.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Page language="c#" Codebehind="Register.aspx.cs" AutoEventWireup="false" Inherits="LIMS.User.Register" %>
<%@ Register TagPrefix="igsch" Namespace="Infragistics.WebUI.WebSchedule" Assembly="Infragistics.WebUI.WebDateChooser.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Register</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="����">
				<TABLE id="Table3" style="BORDER-RIGHT: black 1px; BORDER-TOP: black 1px; FONT-SIZE: 14px; BORDER-LEFT: black 1px; COLOR: white; BORDER-BOTTOM: black 1px"
					cellSpacing="2" cellPadding="4" width="92" border="0">
					<TR>
						<TD align="center" bgColor="appworkspace">������Ϣ</TD>
					</TR>
				</TABLE>
				<TABLE id="Table1" style="FONT-SIZE: 14px; COLOR: #006699" cellSpacing="1" cellPadding="5"
					width="600" bgColor="#eeeeee" border="0" DESIGNTIMEDRAGDROP="26">
					<TR>
						<TD style="WIDTH: 80px" bgColor="#f6f6f6">�� �� ����</TD>
						<TD style="WIDTH: 189px" bgColor="#ffffff">
							<igtxt:webtextedit id="UserName" runat="server" DESIGNTIMEDRAGDROP="293" Width="150px" BorderColor="#7B9EBD"
								BorderWidth="1px" BorderStyle="Solid" Font-Size="8pt" Font-Names="Tahoma">
								<ButtonsAppearance>
									<ButtonStyle Width="13px"></ButtonStyle>
								</ButtonsAppearance>
							</igtxt:webtextedit>
							<asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" DESIGNTIMEDRAGDROP="16" ValidationExpression="^\w..+"
								ControlToValidate="UserName" ErrorMessage="RegularExpressionValidator" Display="Dynamic" Enabled="False">*</asp:RegularExpressionValidator>
							<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ControlToValidate="UserName" ErrorMessage="RequiredFieldValidator"
								Display="Dynamic">*</asp:RequiredFieldValidator></TD>
						<TD bgColor="white">���ġ�Ӣ�Ļ�������ɣ�����3���ַ�</TD>
					</TR>
					<TR>
						<TD style="WIDTH: 80px" bgColor="#f6f6f6">��&nbsp;&nbsp; &nbsp;�룺</TD>
						<TD style="WIDTH: 189px" bgColor="#ffffff">
							<igtxt:webtextedit id="Password" runat="server" DESIGNTIMEDRAGDROP="317" Font-Names="Tahoma" Font-Size="8pt"
								BorderStyle="Solid" BorderWidth="1px" BorderColor="#7B9EBD" Width="150px" PasswordMode="True">
								<ButtonsAppearance>
									<ButtonStyle Width="13px"></ButtonStyle>
								</ButtonsAppearance>
							</igtxt:webtextedit>
							<asp:RegularExpressionValidator id="RegularExpressionValidator2" runat="server" ValidationExpression="^\w{6}\w*"
								ControlToValidate="Password" ErrorMessage="RegularExpressionValidator" Display="Dynamic">*</asp:RegularExpressionValidator>
							<asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" ControlToValidate="Password" ErrorMessage="RequiredFieldValidator"
								Display="Dynamic">*</asp:RequiredFieldValidator></TD>
						<TD bgColor="white">����6���ַ�</TD>
					</TR>
					<TR>
						<TD style="WIDTH: 80px" bgColor="#f6f6f6">����ȷ�ϣ�</TD>
						<TD style="WIDTH: 189px" bgColor="#ffffff"><igtxt:webtextedit id="ValidatePassword" runat="server" BorderStyle="Solid" BorderWidth="1px" BorderColor="#7B9EBD"
								Width="150px" Font-Size="8pt" Font-Names="Tahoma" PasswordMode="True">
								<ButtonsAppearance>
									<ButtonStyle Width="13px"></ButtonStyle>
								</ButtonsAppearance>
							</igtxt:webtextedit>
							<asp:CompareValidator id="CompareValidator1" runat="server" ErrorMessage="CompareValidator" ControlToCompare="Password"
								ControlToValidate="ValidatePassword">*</asp:CompareValidator></TD>
						<TD bgColor="white">�ظ�������������</TD>
					</TR>
					<TR>
						<TD style="WIDTH: 80px" bgColor="#f6f6f6">��&nbsp;&nbsp; &nbsp;����</TD>
						<TD style="WIDTH: 189px" bgColor="#ffffff"><igtxt:webtextedit id="Name" runat="server" BorderStyle="Solid" BorderWidth="1px" BorderColor="#7B9EBD"
								Width="150px" Font-Size="8pt" Font-Names="Tahoma">
								<ButtonsAppearance>
									<ButtonStyle Width="13px"></ButtonStyle>
								</ButtonsAppearance>
							</igtxt:webtextedit>
							<asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server" ControlToValidate="Name" ErrorMessage="RequiredFieldValidator"
								Display="Dynamic">*</asp:RequiredFieldValidator></TD>
						<TD bgColor="#ffffff">��ʵ����</TD>
					</TR>
					<TR>
						<TD style="WIDTH: 80px" bgColor="#f6f6f6">��&nbsp;&nbsp; &nbsp;��</TD>
						<TD style="WIDTH: 189px" bgColor="#ffffff">
							<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD style="WIDTH: 152px">
										<asp:RadioButtonList id="Sex" runat="server" Font-Size="14px" ForeColor="#006699" RepeatDirection="Horizontal">
											<asp:ListItem Value="��">��</asp:ListItem>
											<asp:ListItem Value="Ů">Ů</asp:ListItem>
										</asp:RadioButtonList></TD>
									<TD>
										<asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server" ControlToValidate="Sex" ErrorMessage="RequiredFieldValidator"
											Display="Dynamic">*</asp:RequiredFieldValidator></TD>
								</TR>
							</TABLE>
						</TD>
						<TD bgColor="#ffffff"></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 80px" bgColor="#f6f6f6">��&nbsp;&nbsp;&nbsp; ��</TD>
						<TD style="WIDTH: 189px" bgColor="#ffffff">
							<igcmbo:webcombo id=Offic runat="server" DESIGNTIMEDRAGDROP="2048" Width="90px" BorderColor="LightGray" BorderWidth="1px" BorderStyle="Solid" ForeColor="Black" BackColor="White" Height="8px" Version="3.00" DataTextField="Offic" DataValueField="ID" DataSource="<%# user1 %>" DataMember="����" DropImage1="/ig_common/images/Office2003DropDownBlue.gif" DropImage2="/ig_common/images/Office2003DropDownOrange.gif" DropImageXP1="/ig_common/images/Office2003DropDownBlue.gif" DropImageXP2="/ig_common/images/Office2003DropDownOrange.gif" SelBackColor="17, 69, 158" >
								<Columns>
									<igtbl:UltraGridColumn HeaderText="Offic" Key="Offic" IsBound="True" BaseColumnName="Offic">
										<Footer Key="Offic"></Footer>
										<Header Key="Offic" Caption="Offic"></Header>
									</igtbl:UltraGridColumn>
									<igtbl:UltraGridColumn HeaderText="ID" Key="ID" IsBound="True" Hidden="True" DataType="System.Int32" BaseColumnName="ID">
										<Footer Key="ID">
											<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
										</Footer>
										<Header Key="ID" Caption="ID">
											<RowLayoutColumnInfo OriginX="1"></RowLayoutColumnInfo>
										</Header>
									</igtbl:UltraGridColumn>
								</Columns>
								<DropDownLayout DropdownWidth="" BorderCollapse="Separate" RowSelectors="No" AllowColSizing="Free"
									RowHeightDefault="20px" HeaderClickAction="Select" RowSizing="Free" DropdownHeight="" ColHeadersVisible="No"
									ColWidthDefault="" AllowRowSizing="Free">
									<RowStyle BorderWidth="1px" Font-Size="12px" Font-Names="Tahoma" BorderColor="Black" BorderStyle="Solid">
										<Padding Left="3px"></Padding>
										<BorderDetails WidthLeft="0px" WidthTop="0px"></BorderDetails>
									</RowStyle>
									<SelectedRowStyle ForeColor="White" BackColor="#F09D21" CustomRules="background-image:url(/ig_common/images/Office2003SelRow.png);background-repeat:repeat-x;"></SelectedRowStyle>
									<HeaderStyle Font-Size="X-Small" Font-Names="Arial" Font-Bold="True" BorderStyle="Solid" ForeColor="#E1E8F5"
										BackColor="#11459E" CustomRules="background-image:url(/ig_common/images/Office2003BlueBG.png);background-repeat:repeat-x;">
										<BorderDetails ColorTop="173, 197, 235" WidthLeft="1px" WidthTop="1px" ColorLeft="173, 197, 235"></BorderDetails>
									</HeaderStyle>
									<FrameStyle Cursor="Default" BorderWidth="1px" Font-Size="8pt" Font-Names="Verdana" BorderStyle="Solid"
										BackColor="Silver">
										<BorderDetails ColorTop="Black" WidthLeft="1px" WidthTop="1px" ColorLeft="Black"></BorderDetails>
									</FrameStyle>
								</DropDownLayout>
								<ExpandEffects ShadowColor="LightGray"></ExpandEffects>
							</igcmbo:webcombo></TD>
						<TD bgColor="#ffffff"></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 80px" bgColor="#f6f6f6">�������ڣ�</TD>
						<TD style="WIDTH: 189px" bgColor="#ffffff">
							<igtxt:WebDateTimeEdit id="BirthDate" runat="server" Font-Names="Tahoma" Font-Size="8pt" BorderStyle="Solid"
								BorderWidth="1px" BorderColor="#7B9EBD" Width="150px"></igtxt:WebDateTimeEdit>
							<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"
								ControlToValidate="BirthDate">*</asp:RequiredFieldValidator></TD>
						<TD bgColor="#ffffff"></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 80px" bgColor="#f6f6f6"></TD>
						<TD style="WIDTH: 189px" bgColor="#ffffff"></TD>
						<TD bgColor="#ffffff"></TD>
					</TR>
				</TABLE>
				<BR>
				<TABLE id="Table5" style="BORDER-RIGHT: black 1px; BORDER-TOP: black 1px; FONT-SIZE: 14px; BORDER-LEFT: black 1px; COLOR: white; BORDER-BOTTOM: black 1px"
					cellSpacing="2" cellPadding="4" width="92" border="0">
					<TR>
						<TD align="center" bgColor="appworkspace">ѡ����Ϣ</TD>
					</TR>
				</TABLE>
				<table id="table4" style="FONT-SIZE: 14px; COLOR: #006699" cellSpacing="1" cellPadding="5"
					width="600" bgColor="#eeeeee" border="0">
					<TR>
						<TD style="WIDTH: 80px" bgColor="#f6f6f6">�������⣺</TD>
						<TD style="WIDTH: 189px" bgColor="#ffffff">
							<igtxt:webtextedit id="PasswordQuestion" runat="server" DESIGNTIMEDRAGDROP="370" Width="150px" BorderColor="#7B9EBD"
								BorderWidth="1px" BorderStyle="Solid" Font-Size="8pt" Font-Names="Tahoma">
								<ButtonsAppearance>
									<ButtonStyle Width="13px"></ButtonStyle>
								</ButtonsAppearance>
							</igtxt:webtextedit></TD>
						<TD bgColor="#ffffff">������������ʱ��</TD>
					</TR>
					<TR>
						<TD style="WIDTH: 80px" bgColor="#f6f6f6">����𰸣�</TD>
						<TD style="WIDTH: 189px" bgColor="#ffffff">
							<igtxt:webtextedit id="PasswordAnswer" runat="server" Width="150px" BorderColor="#7B9EBD" BorderWidth="1px"
								BorderStyle="Solid" Font-Size="8pt" Font-Names="Tahoma">
								<ButtonsAppearance>
									<ButtonStyle Width="13px"></ButtonStyle>
								</ButtonsAppearance>
							</igtxt:webtextedit></TD>
						<TD bgColor="#ffffff">����ͨ����������ʹ�����ѯ��</TD>
					</TR>
				</table>
			</FONT><FONT face="����">
				<BR>
			</FONT>
			<igtxt:WebImageButton id="Confirm" runat="server" Text="ע��" UseBrowserDefaults="False">
				<RoundedCorners MaxHeight="40" ImageUrl="ig_butCRM1.gif" MaxWidth="400" HoverImageUrl="ig_butCRM2.gif"
					RenderingType="FileImages" HeightOfBottomEdge="2" PressedImageUrl="ig_butCRM2.gif" WidthOfRightEdge="2"></RoundedCorners>
			</igtxt:WebImageButton>
		</form>
	</body>
</HTML>
