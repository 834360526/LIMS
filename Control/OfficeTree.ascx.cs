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
	///		OfficeTree 的摘要说明。
	/// </summary>
	public class OfficeTree : System.Web.UI.UserControl
	{
		protected Infragistics.WebUI.UltraWebNavigator.UltraWebTree OfficeWebTree;
		protected Dallas.Core.Message msg;

		/// <summary>
		/// 返回所有科室的ID
		/// </summary>
		public ArrayList SelectedNodes
		{
			get
			{
				return msg.GetSelectedNodes(OfficeWebTree,1);
			}
		}
		private void Page_Load(object sender, System.EventArgs e)
		{
			msg=new Dallas.Core.Message();
			if (!IsPostBack)
			{
				msg.AddOfficeNodes(ref OfficeWebTree);
				OfficeWebTree.ExpandAll();
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
		///		设计器支持所需的方法 - 不要使用代码编辑器
		///		修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			ArrayList SelectedNodes=msg.GetSelectedNodes(OfficeWebTree,1);
			foreach(string[] s in SelectedNodes)
				Response.Write(s[0]+"---"+s[1]+"<br>");
		}
	}
}
