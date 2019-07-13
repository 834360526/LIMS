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
using Dallas.Core;

namespace LIMS.Base
{
	/// <summary>
	/// ����ҳ��Ļ���ҳ��
	/// </summary>
	public class BaseForm : System.Web.UI.Page,IPage
	{
		/// <summary>
		/// �û���ʵ��
		/// </summary>
		public Dallas.Core.User user;
		public string cnStr;
		private void Page_Load(object sender, System.EventArgs e)
		{
			
			
			///Test
			//user=new User(1);
//			System.Uri uri=Page.Request.Url;
//			string [] p=uri.Segments;
//			foreach (string s in p)
//				Response.Write("<br>"+s);
//			Response.Write("<br>"+uri.Segments+"<br>"+uri.Host+"<br>"+uri.Authority+"<br>"+uri.Fragment);
			
			
//			Response.Write(user.ID);
			
		}


		//��ʼ�����ݿ������ַ���
		//����½
		//���Ȩ��
		#region Web ������������ɵĴ��룬�����Ѿ��޸�InitializeComponent()����
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
			
			//��ʼ�����ݿ������ַ���
			cnStr=System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];

			///test����
			///5���� 11������ 1��
			Session["User"]=new Dallas.Core.User(11);
			///
			
			//����½
			IsLogin();

            user=(Dallas.Core.User)Session["User"];
	
			//���Ȩ��
			if (!user.ValidatePermission(Request.FilePath))
				GotoDefault();


//			try
//			{
//				//				Response.Write(user.ID);
//			}
//			catch (NullReferenceException)
//			{
//				Response.Redirect("../default.htm");
//			}

		}
		#endregion

		#region IPage ��Ա

		virtual public void ClearSession()
		{
			// TODO:  ��� BaseForm.ClearSession ʵ��
		}
		public void GotoDefault()
		{
			Response.Redirect(@"http://"+Request.Url.Host+@"/LIMS/default.htm");
			//			Response.Redirect(@"http://"+Request.Url.Host+@"/LIMS/webform4.aspx");

			//			Response.Write(@"<script language=javascript>window.navigate(""webform1.aspx"");</script>");
		}

		public void IsLogin()
		{
			if (Session["User"]==null)
				GotoDefault();

		}

		#endregion
	}
}
