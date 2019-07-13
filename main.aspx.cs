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
	/// main ��ժҪ˵����
	/// </summary>
	public class main :BaseForm
	{
		private Dallas.Core.Tool tool;

		private void Page_Load(object sender, System.EventArgs e)
		{
			tool=new Dallas.Core.Tool();
			
			//�û����ռ����Ȩ��
			if (user.HasPermission(15))
				ShowMessage();

			//�û���ҵ�������Ȩ��
			if (user.HasPermission(6))
				ShowAssignment();
		}

		#region Web ������������ɵĴ���
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �õ����� ASP.NET Web ���������������ġ�
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
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
			Response.Write("���� "+messageCount+" �� <a href=\"Message\\Inbox.aspx\">δ����Ϣ</a><br>");
		}

		private void ShowAssignment()
		{
			int assignmentCount=tool.GetUndealAssignmentCount(user.OfficeID);
			if (assignmentCount==0)
				return;
			Response.Write(assignmentCount+" �� <a href=\"Work\\Works.aspx\">������</a><br>");

			assignmentCount=tool.GetUnaccomplishAssignmentCount(user.OfficeID);
			if (assignmentCount==0)
				return;
			Response.Write(assignmentCount+" �� <a href=\"Work\\Works.aspx\">δ�������</a><br>");

			
			
			assignmentCount=tool.Get7daysRemind(user.OfficeID);
			if (assignmentCount==0)
				return;
			Response.Write(assignmentCount+" �� <a href=\"Work\\Works.aspx\">���񼴽�����</a><br>");
		}

	}
}
