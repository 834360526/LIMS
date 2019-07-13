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
	/// Left 的摘要说明。
	/// </summary>
	public class Left : BaseForm
	{
		protected Infragistics.WebUI.Misc.WebPanel Info;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
//			Name.Text=user.Name;
//			Offic.Text=user.Office;
			((Label)Info.FindControl("Name")).Text=user.Name;
			((Label)Info.FindControl("Office")).Text=user.Office;
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


	}
}
