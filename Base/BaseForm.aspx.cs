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
	/// 所有页面的基类页面
	/// </summary>
	public class BaseForm : System.Web.UI.Page,IPage
	{
		/// <summary>
		/// 用户的实例
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


		//初始化数据库连接字符串
		//检查登陆
		//检查权限
		#region Web 窗体设计器生成的代码，但是已经修改InitializeComponent()方法
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
			
			//初始化数据库连接字符串
			cnStr=System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];

			///test测试
			///5李丽 11宋述古 1我
			Session["User"]=new Dallas.Core.User(11);
			///
			
			//检查登陆
			IsLogin();

            user=(Dallas.Core.User)Session["User"];
	
			//检查权限
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

		#region IPage 成员

		virtual public void ClearSession()
		{
			// TODO:  添加 BaseForm.ClearSession 实现
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
