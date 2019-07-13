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

namespace LIMS
{
	/// <summary>
	/// WebForm2 的摘要说明。
	/// </summary>
	public class WebForm2 : System.Web.UI.Page
	{
		protected System.Data.SqlClient.SqlConnection cn;
		protected System.Data.SqlClient.SqlDataAdapter da;
		protected System.Web.UI.WebControls.DataList dl;
		protected System.Web.UI.WebControls.Repeater Repeater1;
		protected Infragistics.WebUI.UltraWebGrid.UltraWebGrid ug;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected Infragistics.WebUI.UltraWebGrid.UltraWebGrid UltraWebGrid2;
		protected Infragistics.WebUI.UltraWebCalcManager.UltraWebCalcManager UltraWebCalcManager1;
		protected LIMS.ds ds1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
//			Tool tool=new Tool();
//			Response.Write(tool.GetSN(true));
			da.Fill(ds1);
			ug.DataBind();
			UltraWebGrid2.DataBind();
//			dl.DataBind();
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
			this.da = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.ds1 = new LIMS.ds();
			((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
			// 
			// cn
			// 
			this.cn.ConnectionString = "workstation id=QDMT;packet size=4096;integrated security=SSPI;data source=\".\";per" +
				"sist security info=False;initial catalog=official";
			// 
			// da
			// 
			this.da.DeleteCommand = this.sqlDeleteCommand1;
			this.da.InsertCommand = this.sqlInsertCommand1;
			this.da.SelectCommand = this.sqlSelectCommand1;
			this.da.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						 new System.Data.Common.DataTableMapping("Table", "党群机关", new System.Data.Common.DataColumnMapping[] {
																																																 new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																 new System.Data.Common.DataColumnMapping("单位", "单位"),
																																																 new System.Data.Common.DataColumnMapping("用人      司局", "用人      司局"),
																																																 new System.Data.Common.DataColumnMapping("职位名称", "职位名称"),
																																																 new System.Data.Common.DataColumnMapping("职位简介", "职位简介"),
																																																 new System.Data.Common.DataColumnMapping("职位编号", "职位编号"),
																																																 new System.Data.Common.DataColumnMapping("考试类别", "考试类别"),
																																																 new System.Data.Common.DataColumnMapping("招考人数", "招考人数"),
																																																 new System.Data.Common.DataColumnMapping("专业", "专业"),
																																																 new System.Data.Common.DataColumnMapping("学历", "学历"),
																																																 new System.Data.Common.DataColumnMapping("政治面貌", "政治面貌"),
																																																 new System.Data.Common.DataColumnMapping("是否要求具有2年以上基层工作经历", "是否要求具有2年以上基层工作经历"),
																																																 new System.Data.Common.DataColumnMapping("其他条件", "其他条件"),
																																																 new System.Data.Common.DataColumnMapping("备注", "备注")})});
			this.da.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM 党群机关 WHERE (ID = @Original_ID) AND (专业 = @Original_专业 OR @Original_专业 IS NULL AND 专业 IS NULL) AND (其他条件 = @Original_其他条件 OR @Original_其他条件 IS NULL AND 其他条件 IS NULL) AND (单位 = @Original_单位 OR @Original_单位 IS NULL AND 单位 IS NULL) AND (备注 = @Original_备注 OR @Original_备注 IS NULL AND 备注 IS NULL) AND (学历 = @Original_学历 OR @Original_学历 IS NULL AND 学历 IS NULL) AND (招考人数 = @Original_招考人数 OR @Original_招考人数 IS NULL AND 招考人数 IS NULL) AND (政治面貌 = @Original_政治面貌 OR @Original_政治面貌 IS NULL AND 政治面貌 IS NULL) AND (是否要求具有2年以上基层工作经历 = @Original_是否要求具有2年以上基层工作经历 OR @Original_是否要求具有2年以上基层工作经历 IS NULL AND 是否要求具有2年以上基层工作经历 IS NULL) AND ([用人      司局] = @Original_用人______司局 OR @Original_用人______司局 IS NULL AND [用人      司局] IS NULL) AND (考试类别 = @Original_考试类别 OR @Original_考试类别 IS NULL AND 考试类别 IS NULL) AND (职位名称 = @Original_职位名称 OR @Original_职位名称 IS NULL AND 职位名称 IS NULL) AND (职位简介 = @Original_职位简介 OR @Original_职位简介 IS NULL AND 职位简介 IS NULL) AND (职位编号 = @Original_职位编号 OR @Original_职位编号 IS NULL AND 职位编号 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.cn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_专业", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "专业", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_其他条件", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "其他条件", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_单位", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "单位", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "备注", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_学历", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "学历", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_招考人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "招考人数", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_政治面貌", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "政治面貌", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_是否要求具有2年以上基层工作经历", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "是否要求具有2年以上基层工作经历", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_用人______司局", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "用人      司局", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_考试类别", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "考试类别", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_职位名称", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "职位名称", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_职位简介", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "职位简介", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_职位编号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "职位编号", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO 党群机关(单位, [用人      司局], 职位名称, 职位简介, 职位编号, 考试类别, 招考人数, 专业, 学历, 政治面貌, 是否要求具有2年以上基层工作经历, 其他条件, 备注) VALUES (@单位, @Param1, @职位名称, @职位简介, @职位编号, @考试类别, @招考人数, @专业, @学历, @政治面貌, @是否要求具有2年以上基层工作经历, @其他条件, @备注); SELECT TOP 100 ID, 单位, [用人      司局], 职位名称, 职位简介, 职位编号, 考试类别, 招考人数, 专业, 学历, 政治面貌, 是否要求具有2年以上基层工作经历, 其他条件, 备注 FROM 党群机关 WHERE (ID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.cn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@单位", System.Data.SqlDbType.NVarChar, 255, "单位"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Param1", System.Data.SqlDbType.NVarChar, 255, "用人      司局"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@职位名称", System.Data.SqlDbType.NVarChar, 255, "职位名称"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@职位简介", System.Data.SqlDbType.NVarChar, 255, "职位简介"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@职位编号", System.Data.SqlDbType.Int, 4, "职位编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@考试类别", System.Data.SqlDbType.NVarChar, 255, "考试类别"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@招考人数", System.Data.SqlDbType.Int, 4, "招考人数"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@专业", System.Data.SqlDbType.NVarChar, 255, "专业"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@学历", System.Data.SqlDbType.NVarChar, 255, "学历"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@政治面貌", System.Data.SqlDbType.NVarChar, 255, "政治面貌"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@是否要求具有2年以上基层工作经历", System.Data.SqlDbType.NVarChar, 255, "是否要求具有2年以上基层工作经历"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@其他条件", System.Data.SqlDbType.NVarChar, 255, "其他条件"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.NVarChar, 255, "备注"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT TOP 100 ID, 单位, [用人      司局], 职位名称, 职位简介, 职位编号, 考试类别, 招考人数, 专业, 学历, 政治面貌, " +
				"是否要求具有2年以上基层工作经历, 其他条件, 备注 FROM 党群机关";
			this.sqlSelectCommand1.Connection = this.cn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE 党群机关 SET 单位 = @单位, [用人      司局] = @Param2, 职位名称 = @职位名称, 职位简介 = @职位简介, 职位编号 = @职位编号, 考试类别 = @考试类别, 招考人数 = @招考人数, 专业 = @专业, 学历 = @学历, 政治面貌 = @政治面貌, 是否要求具有2年以上基层工作经历 = @是否要求具有2年以上基层工作经历, 其他条件 = @其他条件, 备注 = @备注 WHERE (ID = @Original_ID) AND (专业 = @Original_专业 OR @Original_专业 IS NULL AND 专业 IS NULL) AND (其他条件 = @Original_其他条件 OR @Original_其他条件 IS NULL AND 其他条件 IS NULL) AND (单位 = @Original_单位 OR @Original_单位 IS NULL AND 单位 IS NULL) AND (备注 = @Original_备注 OR @Original_备注 IS NULL AND 备注 IS NULL) AND (学历 = @Original_学历 OR @Original_学历 IS NULL AND 学历 IS NULL) AND (招考人数 = @Original_招考人数 OR @Original_招考人数 IS NULL AND 招考人数 IS NULL) AND (政治面貌 = @Original_政治面貌 OR @Original_政治面貌 IS NULL AND 政治面貌 IS NULL) AND (是否要求具有2年以上基层工作经历 = @Original_是否要求具有2年以上基层工作经历 OR @Original_是否要求具有2年以上基层工作经历 IS NULL AND 是否要求具有2年以上基层工作经历 IS NULL) AND ([用人      司局] = @Original_用人______司局 OR @Original_用人______司局 IS NULL AND [用人      司局] IS NULL) AND (考试类别 = @Original_考试类别 OR @Original_考试类别 IS NULL AND 考试类别 IS NULL) AND (职位名称 = @Original_职位名称 OR @Original_职位名称 IS NULL AND 职位名称 IS NULL) AND (职位简介 = @Original_职位简介 OR @Original_职位简介 IS NULL AND 职位简介 IS NULL) AND (职位编号 = @Original_职位编号 OR @Original_职位编号 IS NULL AND 职位编号 IS NULL); SELECT TOP 100 ID, 单位, [用人      司局], 职位名称, 职位简介, 职位编号, 考试类别, 招考人数, 专业, 学历, 政治面貌, 是否要求具有2年以上基层工作经历, 其他条件, 备注 FROM 党群机关 WHERE (ID = @ID)";
			this.sqlUpdateCommand1.Connection = this.cn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@单位", System.Data.SqlDbType.NVarChar, 255, "单位"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Param2", System.Data.SqlDbType.NVarChar, 255, "用人      司局"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@职位名称", System.Data.SqlDbType.NVarChar, 255, "职位名称"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@职位简介", System.Data.SqlDbType.NVarChar, 255, "职位简介"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@职位编号", System.Data.SqlDbType.Int, 4, "职位编号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@考试类别", System.Data.SqlDbType.NVarChar, 255, "考试类别"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@招考人数", System.Data.SqlDbType.Int, 4, "招考人数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@专业", System.Data.SqlDbType.NVarChar, 255, "专业"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@学历", System.Data.SqlDbType.NVarChar, 255, "学历"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@政治面貌", System.Data.SqlDbType.NVarChar, 255, "政治面貌"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@是否要求具有2年以上基层工作经历", System.Data.SqlDbType.NVarChar, 255, "是否要求具有2年以上基层工作经历"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@其他条件", System.Data.SqlDbType.NVarChar, 255, "其他条件"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.NVarChar, 255, "备注"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_专业", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "专业", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_其他条件", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "其他条件", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_单位", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "单位", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "备注", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_学历", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "学历", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_招考人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "招考人数", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_政治面貌", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "政治面貌", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_是否要求具有2年以上基层工作经历", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "是否要求具有2年以上基层工作经历", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_用人______司局", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "用人      司局", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_考试类别", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "考试类别", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_职位名称", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "职位名称", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_职位简介", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "职位简介", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_职位编号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "职位编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			// 
			// ds1
			// 
			this.ds1.DataSetName = "ds";
			this.ds1.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();

		}
		#endregion
	}
}
