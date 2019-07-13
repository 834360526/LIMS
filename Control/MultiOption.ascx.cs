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
	///		MultiOption ��ժҪ˵����
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
			// �ڴ˴������û������Գ�ʼ��ҳ��
		}

		public void ConfigureParameter(Hashtable parameter)
		{
			cn.ConnectionString=parameter["ConnectionString"].ToString();
			da.SelectCommand.CommandText=parameter["SelectCommandText"].ToString();

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
		///		�����֧������ķ��� - ��Ҫʹ�ô���༭��
		///		�޸Ĵ˷��������ݡ�
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
