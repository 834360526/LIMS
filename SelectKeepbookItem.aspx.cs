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
using Dallas.Core;

namespace LIMS.Work
{
	/// <summary>
	/// SelectKeepbookItem 的摘要说明。
	/// </summary>
	public class SelectKeepbookItem : BaseForm
	{
		protected System.Data.SqlClient.SqlConnection cn;
		protected System.Data.SqlClient.SqlDataAdapter daFresh;
		protected LIMS.Work.KeepBook keepBook1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Refresh;
		protected Infragistics.WebUI.WebCombo.WebCombo Com;
		protected System.Data.SqlClient.SqlDataAdapter daCom;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected LIMS.Work.Work work1;
		protected Infragistics.WebUI.WebDataInput.WebNumericEdit ProxySN;
		protected Infragistics.WebUI.WebDataInput.WebImageButton btQuery;
		protected System.Web.UI.WebControls.Label Err;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Submit;
		protected Infragistics.WebUI.UltraWebGrid.UltraWebGrid FreshData;
		protected Tool tool;

		private void Page_Load(object sender, System.EventArgs e)
		{
			cn.ConnectionString=cnStr;

			tool=new Tool();

			if (!IsPostBack)
			{
//				if (Session["KeepbookType"]==null)
//					Response.Redirect("OthersKeepBooks.aspx");

				daFresh.Fill(keepBook1.检校任务);

				FreshData.DataBind();

				daCom.Fill(work1.送检单位);

				Com.DataBind();
			}
			
		}

		public override void ClearSession()
		{
			base.ClearSession ();
			Session["KeepbookType"]=null;
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
			this.cn = new System.Data.SqlClient.SqlConnection();
			this.daFresh = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.keepBook1 = new LIMS.Work.KeepBook();
			this.daCom = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.work1 = new LIMS.Work.Work();
			((System.ComponentModel.ISupportInitialize)(this.keepBook1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.work1)).BeginInit();
			this.btQuery.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.btQuery_Click);
			this.Refresh.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.Refresh_Click);
			this.Submit.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.Submit_Click);
			// 
			// cn
			// 
			this.cn.ConnectionString = "workstation id=QDMT;packet size=4096;user id=sa;integrated security=SSPI;data sou" +
				"rce=\".\";persist security info=False;initial catalog=lims";
			// 
			// daFresh
			// 
			this.daFresh.InsertCommand = this.sqlInsertCommand1;
			this.daFresh.SelectCommand = this.sqlSelectCommand1;
			this.daFresh.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							  new System.Data.Common.DataTableMapping("Table", "检校任务", new System.Data.Common.DataColumnMapping[] {
																																																	  new System.Data.Common.DataColumnMapping("编号", "编号"),
																																																	  new System.Data.Common.DataColumnMapping("器具名称", "器具名称"),
																																																	  new System.Data.Common.DataColumnMapping("器具数量", "器具数量"),
																																																	  new System.Data.Common.DataColumnMapping("型号规格", "型号规格"),
																																																	  new System.Data.Common.DataColumnMapping("出厂编号", "出厂编号"),
																																																	  new System.Data.Common.DataColumnMapping("送检单位", "送检单位"),
																																																	  new System.Data.Common.DataColumnMapping("检定科室", "检定科室"),
																																																	  new System.Data.Common.DataColumnMapping("检校类别", "检校类别"),
																																																	  new System.Data.Common.DataColumnMapping("送检日期", "送检日期"),
																																																	  new System.Data.Common.DataColumnMapping("检定费用", "检定费用"),
																																																	  new System.Data.Common.DataColumnMapping("校准费用", "校准费用"),
																																																	  new System.Data.Common.DataColumnMapping("修理费用", "修理费用"),
																																																	  new System.Data.Common.DataColumnMapping("配件费用", "配件费用"),
																																																	  new System.Data.Common.DataColumnMapping("应交费用", "应交费用"),
																																																	  new System.Data.Common.DataColumnMapping("实交费用", "实交费用"),
																																																	  new System.Data.Common.DataColumnMapping("交费日期", "交费日期"),
																																																	  new System.Data.Common.DataColumnMapping("完成日期", "完成日期"),
																																																	  new System.Data.Common.DataColumnMapping("检校方式", "检校方式"),
																																																	  new System.Data.Common.DataColumnMapping("备注", "备注"),
																																																	  new System.Data.Common.DataColumnMapping("送检单位地址", "送检单位地址"),
																																																	  new System.Data.Common.DataColumnMapping("邮政编码", "邮政编码"),
																																																	  new System.Data.Common.DataColumnMapping("委托人", "委托人"),
																																																	  new System.Data.Common.DataColumnMapping("电话", "电话"),
																																																	  new System.Data.Common.DataColumnMapping("传真号", "传真号")})});
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO 检校任务(编号, 器具名称, 器具数量, 型号规格, 出厂编号, 送检单位, 检定科室, 检校类别, 送检日期, 检定费用, 校准费用, 修理费用, 配件费用, 应交费用, 实交费用, 交费日期, 完成日期, 检校方式, 备注, 送检单位地址, 邮政编码, 委托人, 电话, 传真号) VALUES (@编号, @器具名称, @器具数量, @型号规格, @出厂编号, @送检单位, @检定科室, @检校类别, @送检日期, @检定费用, @校准费用, @修理费用, @配件费用, @应交费用, @实交费用, @交费日期, @完成日期, @检校方式, @备注, @送检单位地址, @邮政编码, @委托人, @电话, @传真号); SELECT 编号, 器具名称, 器具数量, 型号规格, 出厂编号, 送检单位, 检定科室, 检校类别, 送检日期, 检定费用, 校准费用, 修理费用, 配件费用, 应交费用, 实交费用, 交费日期, 完成日期, 检校方式, 备注, 送检单位地址, 邮政编码, 委托人, 电话, 传真号 FROM 检校任务";
			this.sqlInsertCommand1.Connection = this.cn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@编号", System.Data.SqlDbType.NVarChar, 50, "编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@器具名称", System.Data.SqlDbType.NVarChar, 255, "器具名称"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@器具数量", System.Data.SqlDbType.Int, 4, "器具数量"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@型号规格", System.Data.SqlDbType.NVarChar, 255, "型号规格"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@出厂编号", System.Data.SqlDbType.NVarChar, 255, "出厂编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@送检单位", System.Data.SqlDbType.NVarChar, 255, "送检单位"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@检定科室", System.Data.SqlDbType.NVarChar, 50, "检定科室"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@检校类别", System.Data.SqlDbType.NVarChar, 50, "检校类别"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@送检日期", System.Data.SqlDbType.DateTime, 8, "送检日期"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@检定费用", System.Data.SqlDbType.Money, 8, "检定费用"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@校准费用", System.Data.SqlDbType.Money, 8, "校准费用"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@修理费用", System.Data.SqlDbType.Money, 8, "修理费用"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@配件费用", System.Data.SqlDbType.Money, 8, "配件费用"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@应交费用", System.Data.SqlDbType.Money, 8, "应交费用"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@实交费用", System.Data.SqlDbType.Money, 8, "实交费用"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@交费日期", System.Data.SqlDbType.DateTime, 8, "交费日期"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@完成日期", System.Data.SqlDbType.DateTime, 8, "完成日期"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@检校方式", System.Data.SqlDbType.NVarChar, 20, "检校方式"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.NVarChar, 1073741823, "备注"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@送检单位地址", System.Data.SqlDbType.NVarChar, 255, "送检单位地址"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@邮政编码", System.Data.SqlDbType.NVarChar, 20, "邮政编码"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@委托人", System.Data.SqlDbType.NVarChar, 50, "委托人"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@电话", System.Data.SqlDbType.NVarChar, 30, "电话"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@传真号", System.Data.SqlDbType.NVarChar, 30, "传真号"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT top 20 编号, 器具名称, 器具数量, 型号规格, 出厂编号, 送检单位, 检定科室, 检校类别, 送检日期, 检定费用, 校准费用, 修理费" +
				"用, 配件费用, 应交费用, 实交费用, 交费日期, 完成日期, 检校方式, 备注, 送检单位地址, 邮政编码, 委托人, 电话, 传真号 FROM 检校任务 " +
				"where 编号 like \'QJ%\'order by 编号 desc";
			this.sqlSelectCommand1.Connection = this.cn;
			// 
			// keepBook1
			// 
			this.keepBook1.DataSetName = "KeepBook";
			this.keepBook1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// daCom
			// 
			this.daCom.DeleteCommand = this.sqlDeleteCommand2;
			this.daCom.InsertCommand = this.sqlInsertCommand2;
			this.daCom.SelectCommand = this.sqlSelectCommand2;
			this.daCom.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							new System.Data.Common.DataTableMapping("Table", "送检单位", new System.Data.Common.DataColumnMapping[] {
																																																	new System.Data.Common.DataColumnMapping("单位名称", "单位名称"),
																																																	new System.Data.Common.DataColumnMapping("地址", "地址"),
																																																	new System.Data.Common.DataColumnMapping("电话", "电话"),
																																																	new System.Data.Common.DataColumnMapping("邮编", "邮编"),
																																																	new System.Data.Common.DataColumnMapping("传真号", "传真号"),
																																																	new System.Data.Common.DataColumnMapping("联系人", "联系人"),
																																																	new System.Data.Common.DataColumnMapping("ID", "ID")})});
			this.daCom.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = @"DELETE FROM 送检单位 WHERE (ID = @Original_ID) AND (传真号 = @Original_传真号 OR @Original_传真号 IS NULL AND 传真号 IS NULL) AND (单位名称 = @Original_单位名称 OR @Original_单位名称 IS NULL AND 单位名称 IS NULL) AND (地址 = @Original_地址 OR @Original_地址 IS NULL AND 地址 IS NULL) AND (电话 = @Original_电话 OR @Original_电话 IS NULL AND 电话 IS NULL) AND (联系人 = @Original_联系人 OR @Original_联系人 IS NULL AND 联系人 IS NULL) AND (邮编 = @Original_邮编 OR @Original_邮编 IS NULL AND 邮编 IS NULL)";
			this.sqlDeleteCommand2.Connection = this.cn;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_传真号", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "传真号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_单位名称", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "单位名称", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_地址", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "地址", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_电话", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电话", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_联系人", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "联系人", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_邮编", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "邮编", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = "INSERT INTO 送检单位(单位名称, 地址, 电话, 邮编, 传真号, 联系人) VALUES (@单位名称, @地址, @电话, @邮编, @传真号, " +
				"@联系人); SELECT 单位名称, 地址, 电话, 邮编, 传真号, 联系人, ID FROM 送检单位 WHERE (ID = @@IDENTITY)";
			this.sqlInsertCommand2.Connection = this.cn;
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@单位名称", System.Data.SqlDbType.NVarChar, 255, "单位名称"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@地址", System.Data.SqlDbType.NVarChar, 255, "地址"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@电话", System.Data.SqlDbType.NVarChar, 50, "电话"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@邮编", System.Data.SqlDbType.NVarChar, 20, "邮编"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@传真号", System.Data.SqlDbType.NVarChar, 20, "传真号"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@联系人", System.Data.SqlDbType.NVarChar, 50, "联系人"));
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT 单位名称, 地址, 电话, 邮编, 传真号, 联系人, ID FROM 送检单位";
			this.sqlSelectCommand2.Connection = this.cn;
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = @"UPDATE 送检单位 SET 单位名称 = @单位名称, 地址 = @地址, 电话 = @电话, 邮编 = @邮编, 传真号 = @传真号, 联系人 = @联系人 WHERE (ID = @Original_ID) AND (传真号 = @Original_传真号 OR @Original_传真号 IS NULL AND 传真号 IS NULL) AND (单位名称 = @Original_单位名称 OR @Original_单位名称 IS NULL AND 单位名称 IS NULL) AND (地址 = @Original_地址 OR @Original_地址 IS NULL AND 地址 IS NULL) AND (电话 = @Original_电话 OR @Original_电话 IS NULL AND 电话 IS NULL) AND (联系人 = @Original_联系人 OR @Original_联系人 IS NULL AND 联系人 IS NULL) AND (邮编 = @Original_邮编 OR @Original_邮编 IS NULL AND 邮编 IS NULL); SELECT 单位名称, 地址, 电话, 邮编, 传真号, 联系人, ID FROM 送检单位 WHERE (ID = @ID)";
			this.sqlUpdateCommand2.Connection = this.cn;
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@单位名称", System.Data.SqlDbType.NVarChar, 255, "单位名称"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@地址", System.Data.SqlDbType.NVarChar, 255, "地址"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@电话", System.Data.SqlDbType.NVarChar, 50, "电话"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@邮编", System.Data.SqlDbType.NVarChar, 20, "邮编"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@传真号", System.Data.SqlDbType.NVarChar, 20, "传真号"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@联系人", System.Data.SqlDbType.NVarChar, 50, "联系人"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_传真号", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "传真号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_单位名称", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "单位名称", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_地址", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "地址", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_电话", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电话", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_联系人", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "联系人", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_邮编", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "邮编", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			// 
			// work1
			// 
			this.work1.DataSetName = "Work";
			this.work1.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.keepBook1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.work1)).EndInit();

		}
		#endregion


		private void Refresh_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			daFresh.Fill(keepBook1.检校任务);

			FreshData.DataBind();
		}

		private void btQuery_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			if (Tool.IsNull(Com.DataValue) && Tool.IsNull(ProxySN.Text))
			{
				Err.Text="您未选择查询条件";
				return;
			}
			
			daFresh.SelectCommand.CommandText="SELECT 编号, 器具名称, 器具数量, 型号规格, 出厂编号, 送检单位, 检定科室, 检校类别, 送检日期, 检定费用, 校准费用, 修理费用, 配件费用, 应交费用, 实交费用, 交费日期, 完成日期, 检校方式, 备注, 送检单位地址, 邮政编码, 委托人, 电话, 传真号 FROM 检校任务 where ";

			if (!Tool.IsNull(Com.DataValue))
				daFresh.SelectCommand.CommandText+="送检单位='"+Com.DataValue+"' and ";
			
			if (!Tool.IsNull(ProxySN.Text))
				daFresh.SelectCommand.CommandText+="委托单号="+ProxySN.Text;

			//最后有可能多出一个and
			if (daFresh.SelectCommand.CommandText.Substring(daFresh.SelectCommand.CommandText.Length-4-1,4).Trim()=="and")
				daFresh.SelectCommand.CommandText=daFresh.SelectCommand.CommandText.TrimEnd().Remove(daFresh.SelectCommand.CommandText.Length-3-1,3);

			daFresh.Fill(keepBook1.检校任务);
			FreshData.DataBind();

		}

		private void Submit_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			ArrayList selected=tool.GetSelected(FreshData,0,1);
			foreach (String s in selected)
				Response.Write(s+"<br>");
		}

	}
}
