<%@ Register TagPrefix="igsch" Namespace="Infragistics.WebUI.WebSchedule" Assembly="Infragistics.WebUI.WebDateChooser.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Register TagPrefix="ignav" Namespace="Infragistics.WebUI.UltraWebNavigator" Assembly="Infragistics.WebUI.UltraWebNavigator.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<%@ Control Language="c#" AutoEventWireup="false" Codebehind="LeftMenu.ascx.cs" Inherits="LIMS.Control.LeftMenu" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<%@ Register TagPrefix="iglbar" Namespace="Infragistics.WebUI.UltraWebListbar" Assembly="Infragistics.WebUI.UltraWebListbar.v5.3, Version=5.3.20053.50, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" %>
<P><FONT id="FONT1" face="ËÎÌו"><iglbar:ultraweblistbar id="Menu" runat="server" BarWidth="100%" BorderStyle="Solid" MergeStyles="True"
			GroupSpacing="15px" Height="300px" Width="150px" ItemSelectionStyle="IconOnlySelection" BorderWidth="1px" BorderColor="Black"
			Font-Size="16px">
			<DefaultGroupStyle Cursor="Default" Height="100%" BackColor="WhiteSmoke"></DefaultGroupStyle>
			<DefaultItemStyle Cursor="Default" Font-Size="14px" Font-Names="Verdana">
				<Padding Left="5px"></Padding>
				<Margin Left="1px"></Margin>
			</DefaultItemStyle>
			<DefaultItemHoverStyle BorderWidth="1px" BorderStyle="Outset">
				<Margin Left="0px"></Margin>
			</DefaultItemHoverStyle>
			<DefaultGroupButtonSelectedStyle Cursor="Default" BorderWidth="1px" BorderStyle="Inset" ForeColor="Black" BackColor="Silver"></DefaultGroupButtonSelectedStyle>
			<DefaultItemSelectedStyle Cursor="Default" BorderWidth="1px" BorderStyle="Inset">
				<Margin Left="0px"></Margin>
			</DefaultItemSelectedStyle>
			<DefaultGroupButtonStyle Cursor="Default" Height="24px" BorderWidth="1px" Font-Size="14px" Font-Names="Verdana"
				Font-Bold="True" BorderStyle="Outset" BackgroundImage="grayexplorer.gif" BackColor="Menu">
				<Padding Left="3px"></Padding>
			</DefaultGroupButtonStyle>
			<DefaultGroupButtonHoverStyle Cursor="Default" BorderWidth="1px" BorderColor="Control" BorderStyle="Outset" BackgroundImage="orangeexplorer.gif"
				BackColor="Menu"></DefaultGroupButtonHoverStyle>
		</iglbar:ultraweblistbar></FONT></P>
