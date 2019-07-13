namespace LIMS.Control
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	/// <summary>
	///		NewAssignments 的摘要说明。
	/// </summary>
	public class NewAssignments : System.Web.UI.UserControl
	{
		protected Infragistics.WebUI.UltraWebGrid.UltraWebGrid UndealGrid;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Accept;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Cancel;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlConnection cn;
		protected LIMS.Work.Work work1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlDataAdapter daAssignment;
		protected System.Web.UI.WebControls.Label UndealError;

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
		///		设计器支持所需的方法 - 不要使用代码编辑器
		///		修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.cn = new System.Data.SqlClient.SqlConnection();
			this.work1 = new LIMS.Work.Work();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.daAssignment = new System.Data.SqlClient.SqlDataAdapter();
			((System.ComponentModel.ISupportInitialize)(this.work1)).BeginInit();
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = @"INSERT INTO 检校任务(编号, 器具名称, 器具数量, 型号规格, 出厂编号, 送检单位, 送检单位地址, 邮政编码, 委托人, 电话, 传真号, 检校类别, 送检日期, 备注, 检校方式, 检定费用, 校准费用, 修理费用, 配件费用, 应交费用) VALUES (@编号, @器具名称, @器具数量, @型号规格, @出厂编号, @送检单位, @送检单位地址, @邮政编码, @委托人, @电话, @传真号, @检校类别, @送检日期, @备注, @检校方式, @检定费用, @校准费用, @修理费用, @配件费用, @应交费用); SELECT 编号, 器具名称, 器具数量, 型号规格, 出厂编号, 送检单位, 送检单位地址, 邮政编码, 委托人, 电话, 传真号, 检校类别, 送检日期, 备注, 检校方式, 检定费用, 校准费用, 修理费用, 配件费用, 应交费用 FROM 检校任务";
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@编号", System.Data.SqlDbType.NVarChar, 50, "编号"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@器具名称", System.Data.SqlDbType.NVarChar, 255, "器具名称"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@器具数量", System.Data.SqlDbType.Int, 4, "器具数量"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@型号规格", System.Data.SqlDbType.NVarChar, 255, "型号规格"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@出厂编号", System.Data.SqlDbType.NVarChar, 255, "出厂编号"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@送检单位", System.Data.SqlDbType.NVarChar, 255, "送检单位"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@送检单位地址", System.Data.SqlDbType.NVarChar, 255, "送检单位地址"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@邮政编码", System.Data.SqlDbType.NVarChar, 20, "邮政编码"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@委托人", System.Data.SqlDbType.NVarChar, 50, "委托人"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@电话", System.Data.SqlDbType.NVarChar, 30, "电话"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@传真号", System.Data.SqlDbType.NVarChar, 30, "传真号"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@检校类别", System.Data.SqlDbType.NVarChar, 50, "检校类别"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@送检日期", System.Data.SqlDbType.DateTime, 8, "送检日期"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.NVarChar, 1073741823, "备注"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@检校方式", System.Data.SqlDbType.TinyInt, 1, "检校方式"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@检定费用", System.Data.SqlDbType.Money, 8, "检定费用"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@校准费用", System.Data.SqlDbType.Money, 8, "校准费用"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@修理费用", System.Data.SqlDbType.Money, 8, "修理费用"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@配件费用", System.Data.SqlDbType.Money, 8, "配件费用"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@应交费用", System.Data.SqlDbType.Money, 8, "应交费用"));
			// 
			// cn
			// 
			this.cn.ConnectionString = "workstation id=QDMT;packet size=4096;user id=sa;integrated security=SSPI;data sou" +
				"rce=\".\";persist security info=False;initial catalog=lims";
			// 
			// work1
			// 
			this.work1.DataSetName = "Work";
			this.work1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT 编号, 器具名称, 器具数量, 型号规格, 出厂编号, 送检单位, 送检单位地址, 邮政编码, 委托人, 电话, 传真号, 检校类别, 送检日期, " +
				"备注, 检校方式, 检定费用, 校准费用, 修理费用, 配件费用, 应交费用 FROM 检校任务";
			this.sqlSelectCommand2.Connection = this.cn;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO 检校任务(编号, 器具名称, 器具数量, 型号规格, 出厂编号, 送检单位, 送检单位地址, 邮政编码, 委托人, 电话, 传真号, 检校类别, 送检日期, 备注, 检校方式) VALUES (@编号, @器具名称, @器具数量, @型号规格, @出厂编号, @送检单位, @送检单位地址, @邮政编码, @委托人, @电话, @传真号, @检校类别, @送检日期, @备注, @检校方式); SELECT 编号, 器具名称, 器具数量, 型号规格, 出厂编号, 送检单位, 送检单位地址, 邮政编码, 委托人, 电话, 传真号, 检校类别, 送检日期, 备注, 检校方式 FROM 检校任务";
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@编号", System.Data.SqlDbType.NVarChar, 50, "编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@器具名称", System.Data.SqlDbType.NVarChar, 255, "器具名称"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@器具数量", System.Data.SqlDbType.Int, 4, "器具数量"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@型号规格", System.Data.SqlDbType.NVarChar, 255, "型号规格"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@出厂编号", System.Data.SqlDbType.NVarChar, 255, "出厂编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@送检单位", System.Data.SqlDbType.NVarChar, 255, "送检单位"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@送检单位地址", System.Data.SqlDbType.NVarChar, 255, "送检单位地址"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@邮政编码", System.Data.SqlDbType.NVarChar, 20, "邮政编码"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@委托人", System.Data.SqlDbType.NVarChar, 50, "委托人"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@电话", System.Data.SqlDbType.NVarChar, 30, "电话"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@传真号", System.Data.SqlDbType.NVarChar, 30, "传真号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@检校类别", System.Data.SqlDbType.NVarChar, 50, "检校类别"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@送检日期", System.Data.SqlDbType.DateTime, 8, "送检日期"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.NVarChar, 1073741823, "备注"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@检校方式", System.Data.SqlDbType.TinyInt, 1, "检校方式"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 编号, 器具名称, 器具数量, 型号规格, 出厂编号, 送检单位, 送检单位地址, 邮政编码, 委托人, 电话, 传真号, 送检日期, 备注, 检校" +
				"方式 FROM 检校任务";
			this.sqlSelectCommand1.Connection = this.cn;
			// 
			// daAssignment
			// 
			this.daAssignment.InsertCommand = this.sqlInsertCommand1;
			this.daAssignment.SelectCommand = this.sqlSelectCommand1;
			this.daAssignment.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								   new System.Data.Common.DataTableMapping("Table", "检校任务", new System.Data.Common.DataColumnMapping[] {
																																																		   new System.Data.Common.DataColumnMapping("编号", "编号"),
																																																		   new System.Data.Common.DataColumnMapping("器具名称", "器具名称"),
																																																		   new System.Data.Common.DataColumnMapping("器具数量", "器具数量"),
																																																		   new System.Data.Common.DataColumnMapping("型号规格", "型号规格"),
																																																		   new System.Data.Common.DataColumnMapping("出厂编号", "出厂编号"),
																																																		   new System.Data.Common.DataColumnMapping("送检单位", "送检单位"),
																																																		   new System.Data.Common.DataColumnMapping("送检单位地址", "送检单位地址"),
																																																		   new System.Data.Common.DataColumnMapping("邮政编码", "邮政编码"),
																																																		   new System.Data.Common.DataColumnMapping("委托人", "委托人"),
																																																		   new System.Data.Common.DataColumnMapping("电话", "电话"),
																																																		   new System.Data.Common.DataColumnMapping("传真号", "传真号"),
																																																		   new System.Data.Common.DataColumnMapping("检校类别", "检校类别"),
																																																		   new System.Data.Common.DataColumnMapping("送检日期", "送检日期"),
																																																		   new System.Data.Common.DataColumnMapping("备注", "备注"),
																																																		   new System.Data.Common.DataColumnMapping("检校方式", "检校方式")})});
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.work1)).EndInit();

		}
		#endregion
	}
}
