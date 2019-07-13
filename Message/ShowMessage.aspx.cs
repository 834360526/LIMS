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

namespace LIMS.Message
{
	/// <summary>
	/// ShowMessage ��ժҪ˵����
	/// </summary>
	public class ShowMessage : BaseForm
	{
		protected Infragistics.WebUI.WebDataInput.WebTextEdit Title;
		protected System.Web.UI.WebControls.TextBox Content;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit Sender;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Back;
		protected Infragistics.WebUI.WebDataInput.WebDateTimeEdit SendDate;
		protected int msgID;
		protected Hashtable message;
		protected System.Web.UI.WebControls.Button Open;
		protected System.Web.UI.WebControls.Label None;
		protected Dallas.Core.Message msg;
		private void Page_Load(object sender, System.EventArgs e)
		{
			
			
			msg=new Dallas.Core.Message();

			try
			{
				msgID=int.Parse(Request["ID"].ToString());
			}
			catch (NullReferenceException)
			{
				GotoDefault();
			}
			///ע�⣺IsReceiver������δʵ�֣�������
			///�ж��û��Ƿ���Ȩ�޲鿴����Ϣ
			if (!msg.IsReceiver(msgID,user.ID))
				GotoDefault();

			//������Ϣ���ݲ���ʾ����			
			message=msg.GetMessage(msgID);
			Title.Text=message["����"].ToString();
			Sender.Text=message["������"].ToString();
			SendDate.Text=message["����ʱ��"].ToString();
			Content.Text=message["����"].ToString();

			//�ж��Ƿ��и���
			if (message["����"].ToString()=="" ||message["����"].ToString()==null)
			{
				Open.Visible=false;
				None.Visible=true;
			}
			else
			{
				Open.Visible=true;
				None.Visible=false;
			}
			if (!IsPostBack)
			{
				//��������
				msg.UpdateRead(msgID);
			}

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
			this.Open.Click += new System.EventHandler(this.Open_Click);
			this.Back.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.Back_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Back_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			BackPage();
		}

		private void BackPage()
		{
			Response.Redirect("Inbox.aspx");
		}

		private void Open_Click(object sender, System.EventArgs e)
		{
			Response.Redirect(message["����"].ToString());
//			Response.Redirect(@"http://www.sina.com.cn");@"file://"

			
		}
	}
}
