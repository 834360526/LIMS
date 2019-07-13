namespace LIMS.Control
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	/// <summary>
	///		Login 的摘要说明。
	/// </summary>
	public class Login : System.Web.UI.UserControl
	{
		protected Infragistics.WebUI.WebDataInput.WebTextEdit Password;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit UserName;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Confirm;
		protected System.Web.UI.WebControls.Label Err;
		protected Dallas.Core.User user;
		private void Page_Load(object sender, System.EventArgs e)
		{
			user=new Dallas.Core.User();
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
		///		设计器支持所需的方法 - 不要使用代码编辑器
		///		修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.Confirm.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.Confirm_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Confirm_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			if (UserName.Text=="" || UserName.Text==null)
				return;
			int ID=user.Login(UserName.Text,Password.Text);
			if (ID==0)
				Err.Text="用户名或密码错误";
			else
			{
				Session["User"]=new Dallas.Core.User(ID);

				//更新主框架内容
				Response.Write(@"<script   language=javascript>window.parent.main.location.href='../main.aspx'</script>");

				//更新左边框架内容
				Response.Write(@"<script   language=javascript>window.parent.contents.location.href='../Left.aspx'</script>");
//				Response.Redirect(@"\LIMS\Left.aspx",false);
				
			}
		}
	}
}
