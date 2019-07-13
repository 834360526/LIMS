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
	/// ShowMessage 的摘要说明。
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
			///注意：IsReceiver函数并未实现！！！！
			///判断用户是否有权限查看此信息
			if (!msg.IsReceiver(msgID,user.ID))
				GotoDefault();

			//读出信息内容并显示出来			
			message=msg.GetMessage(msgID);
			Title.Text=message["标题"].ToString();
			Sender.Text=message["发件人"].ToString();
			SendDate.Text=message["发送时间"].ToString();
			Content.Text=message["内容"].ToString();

			//判断是否有附件
			if (message["附件"].ToString()=="" ||message["附件"].ToString()==null)
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
				//更新已阅
				msg.UpdateRead(msgID);
			}

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
			Response.Redirect(message["附件"].ToString());
//			Response.Redirect(@"http://www.sina.com.cn");@"file://"

			
		}
	}
}
