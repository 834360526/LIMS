using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using LIMS.Base;

namespace LIMS
{
	/// <summary>
	/// main 的摘要说明。
	/// </summary>
	public class main :BaseForm
	{
		private Dallas.Core.Tool tool;

		private void Page_Load(object sender, System.EventArgs e)
		{
			tool=new Dallas.Core.Tool();
			
			//用户有收件箱的权限
			if (user.HasPermission(15))
				ShowMessage();

			//用户有业务任务的权限
			if (user.HasPermission(6))
				ShowAssignment();
		}

		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ShowMessage()
		{
			int messageCount=tool.GetNotReadMessage(user.ID,user.OfficeID);
			if (messageCount==0)
				return;
			Response.Write("您有 "+messageCount+" 条 <a href=\"Message\\Inbox.aspx\">未读信息</a><br>");
		}

		private void ShowAssignment()
		{
			int assignmentCount=tool.GetUndealAssignmentCount(user.OfficeID);
			if (assignmentCount==0)
				return;
			Response.Write(assignmentCount+" 个 <a href=\"Work\\Works.aspx\">新任务</a><br>");

			assignmentCount=tool.GetUnaccomplishAssignmentCount(user.OfficeID);
			if (assignmentCount==0)
				return;
			Response.Write(assignmentCount+" 个 <a href=\"Work\\Works.aspx\">未完成任务</a><br>");

			
			
			assignmentCount=tool.Get7daysRemind(user.OfficeID);
			if (assignmentCount==0)
				return;
			Response.Write(assignmentCount+" 个 <a href=\"Work\\Works.aspx\">任务即将到期</a><br>");
		}

	}
}
