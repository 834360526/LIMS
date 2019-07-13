namespace LIMS.Control
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using System.Collections;

	/// <summary>
	///		MultiOption 的摘要说明。
	/// </summary>
	public class MultiOption : System.Web.UI.UserControl
	{
		protected System.Web.UI.WebControls.CheckBoxList SelectPermission;
		protected Infragistics.WebUI.WebDataInput.WebImageButton ConfirmPermission;
		protected Infragistics.WebUI.WebDataInput.WebImageButton CancelPermission;
		protected System.Data.SqlClient.SqlConnection cn;
		protected System.Data.SqlClient.SqlDataAdapter da;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Web.UI.WebControls.Label Selected;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
		}

		public void ConfigureParameter(Hashtable parameter)
		{
			cn.ConnectionString=parameter["ConnectionString"].ToString();
			da.SelectCommand.CommandText=parameter["SelectCommandText"].ToString();

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
			this.cn = new System.Data.SqlClient.SqlConnection();
			this.da = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			// 
			// da
			// 
			this.da.SelectCommand = this.sqlSelectCommand1;
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT\r\nFROM\r\n";
			this.sqlSelectCommand1.Connection = this.cn;
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
