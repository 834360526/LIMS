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

namespace LIMS.User
{
	/// <summary>
	/// ModifyPassword 的摘要说明。
	/// </summary>
	public class ModifyPassword : BaseForm
	{
		protected System.Web.UI.WebControls.CompareValidator CompareValidator1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator3;
		protected System.Web.UI.WebControls.RegularExpressionValidator RegularExpressionValidator2;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit OldPassword;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit NewPassword;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit ConfirmPassword;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Confirm;
		protected System.Web.UI.WebControls.Label Notice;
		protected System.Web.UI.WebControls.RegularExpressionValidator RegularExpressionValidator1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator2;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
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
			this.Confirm.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.Confirm_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Confirm_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			if (user.ModifyPassword(OldPassword.Text,NewPassword.Text))
				Notice.Text="密码修改成功";
			else
				Notice.Text="旧密码不正确";
		}
	}
}
