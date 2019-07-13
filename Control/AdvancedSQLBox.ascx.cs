namespace LIMS.Control
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using System.ComponentModel;
	/// <summary>
	///		AdvancedSQLBox 的摘要说明。
	/// </summary>
	public class AdvancedSQLBox : System.Web.UI.UserControl
	{
		protected char SingleWildcard;
		protected char MultiWildcard;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit ValueText;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		string Sql;
	

		/// <summary>
		/// 设置文本框的内容或获取生成的SQL语句
		/// </summary>
		public string Value
		{
			get
			{
				Sql="'"+ValueText.Text+"'";
				//如果输入的值中不包括通配符
				if (Sql.IndexOf(SingleWildcard)==-1 && Sql.IndexOf(MultiWildcard)==-1)
				{
					//则条件为“＝”
					Sql="="+Sql;
				}
				else
				{
					//包括通配符，则替换通配符为
					Sql=Sql.Replace(SingleWildcard,'_');
					Sql=Sql.Replace(MultiWildcard,'%');

					Sql=" like "+Sql;

				}
				
				return Sql;
			}
			set
			{
				//设置文本框内容
				ValueText.Text=value;
			}
		}
		private void Page_Load(object sender, System.EventArgs e)
		{
			//读出通配符
			SingleWildcard=System.Configuration.ConfigurationSettings.AppSettings["SingleWildcard"][0];
			MultiWildcard=System.Configuration.ConfigurationSettings.AppSettings["MultiWildcard"][0];
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
	}
}
