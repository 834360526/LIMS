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

namespace LIMS
{
	/// <summary>
	/// WebForm3 的摘要说明。
	/// </summary>
	public class WebForm3 : System.Web.UI.Page
	{
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection cn;
		protected System.Data.SqlClient.SqlDataAdapter da;
		protected Infragistics.WebUI.UltraWebGrid.UltraWebGrid ug;
		protected System.Web.UI.WebControls.DataList dl;
		protected Infragistics.WebUI.UltraWebNavigator.UltraWebTree Ultrawebtree3;
		protected LIMS.ds ds1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
//			da.Fill(ds1.检校费用);
//			ug.DataBind();
//			Dallas.Core.Tool t=new Dallas.Core.Tool();
//			Hashtable ht=new Hashtable();
//			ht.Add("单位名称","b");
//			ht.Add("地址","yy");
//			t.AdvancedUpdate(ht,"单位名称","送检单位");
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
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.cn = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.da = new System.Data.SqlClient.SqlDataAdapter();
			this.ds1 = new LIMS.ds();
			((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ID, 检校设备编号, 检定费用, 校准费用, 修理费用, 配件费用, 应交费用, 实交费用, 交费日期 FROM 检校费用";
			this.sqlSelectCommand1.Connection = this.cn;
			// 
			// cn
			// 
			this.cn.ConnectionString = "workstation id=QDMT;packet size=4096;user id=sa;integrated security=SSPI;data sou" +
				"rce=\".\";persist security info=False;initial catalog=lims";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO 检校费用(检校设备编号, 检定费用, 校准费用, 修理费用, 配件费用, 应交费用, 实交费用, 交费日期) VALUES (@检校设备编" +
				"号, @检定费用, @校准费用, @修理费用, @配件费用, @应交费用, @实交费用, @交费日期); SELECT ID, 检校设备编号, 检定费用, 校准" +
				"费用, 修理费用, 配件费用, 应交费用, 实交费用, 交费日期 FROM 检校费用 WHERE (ID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.cn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@检校设备编号", System.Data.SqlDbType.NVarChar, 50, "检校设备编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@检定费用", System.Data.SqlDbType.Int, 4, "检定费用"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@校准费用", System.Data.SqlDbType.Int, 4, "校准费用"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@修理费用", System.Data.SqlDbType.Int, 4, "修理费用"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@配件费用", System.Data.SqlDbType.Int, 4, "配件费用"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@应交费用", System.Data.SqlDbType.Int, 4, "应交费用"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@实交费用", System.Data.SqlDbType.Int, 4, "实交费用"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@交费日期", System.Data.SqlDbType.DateTime, 8, "交费日期"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE 检校费用 SET 检校设备编号 = @检校设备编号, 检定费用 = @检定费用, 校准费用 = @校准费用, 修理费用 = @修理费用, 配件费用 = @配件费用, 应交费用 = @应交费用, 实交费用 = @实交费用, 交费日期 = @交费日期 WHERE (ID = @Original_ID) AND (交费日期 = @Original_交费日期 OR @Original_交费日期 IS NULL AND 交费日期 IS NULL) AND (修理费用 = @Original_修理费用 OR @Original_修理费用 IS NULL AND 修理费用 IS NULL) AND (实交费用 = @Original_实交费用 OR @Original_实交费用 IS NULL AND 实交费用 IS NULL) AND (应交费用 = @Original_应交费用 OR @Original_应交费用 IS NULL AND 应交费用 IS NULL) AND (校准费用 = @Original_校准费用 OR @Original_校准费用 IS NULL AND 校准费用 IS NULL) AND (检定费用 = @Original_检定费用 OR @Original_检定费用 IS NULL AND 检定费用 IS NULL) AND (检校设备编号 = @Original_检校设备编号 OR @Original_检校设备编号 IS NULL AND 检校设备编号 IS NULL) AND (配件费用 = @Original_配件费用 OR @Original_配件费用 IS NULL AND 配件费用 IS NULL); SELECT ID, 检校设备编号, 检定费用, 校准费用, 修理费用, 配件费用, 应交费用, 实交费用, 交费日期 FROM 检校费用 WHERE (ID = @ID)";
			this.sqlUpdateCommand1.Connection = this.cn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@检校设备编号", System.Data.SqlDbType.NVarChar, 50, "检校设备编号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@检定费用", System.Data.SqlDbType.Int, 4, "检定费用"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@校准费用", System.Data.SqlDbType.Int, 4, "校准费用"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@修理费用", System.Data.SqlDbType.Int, 4, "修理费用"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@配件费用", System.Data.SqlDbType.Int, 4, "配件费用"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@应交费用", System.Data.SqlDbType.Int, 4, "应交费用"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@实交费用", System.Data.SqlDbType.Int, 4, "实交费用"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@交费日期", System.Data.SqlDbType.DateTime, 8, "交费日期"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_交费日期", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "交费日期", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_修理费用", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "修理费用", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_实交费用", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "实交费用", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_应交费用", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "应交费用", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_校准费用", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "校准费用", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_检定费用", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "检定费用", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_检校设备编号", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "检校设备编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_配件费用", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "配件费用", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM 检校费用 WHERE (ID = @Original_ID) AND (交费日期 = @Original_交费日期 OR @Original_交费日期 IS NULL AND 交费日期 IS NULL) AND (修理费用 = @Original_修理费用 OR @Original_修理费用 IS NULL AND 修理费用 IS NULL) AND (实交费用 = @Original_实交费用 OR @Original_实交费用 IS NULL AND 实交费用 IS NULL) AND (应交费用 = @Original_应交费用 OR @Original_应交费用 IS NULL AND 应交费用 IS NULL) AND (校准费用 = @Original_校准费用 OR @Original_校准费用 IS NULL AND 校准费用 IS NULL) AND (检定费用 = @Original_检定费用 OR @Original_检定费用 IS NULL AND 检定费用 IS NULL) AND (检校设备编号 = @Original_检校设备编号 OR @Original_检校设备编号 IS NULL AND 检校设备编号 IS NULL) AND (配件费用 = @Original_配件费用 OR @Original_配件费用 IS NULL AND 配件费用 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.cn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_交费日期", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "交费日期", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_修理费用", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "修理费用", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_实交费用", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "实交费用", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_应交费用", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "应交费用", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_校准费用", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "校准费用", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_检定费用", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "检定费用", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_检校设备编号", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "检校设备编号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_配件费用", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "配件费用", System.Data.DataRowVersion.Original, null));
			// 
			// da
			// 
			this.da.DeleteCommand = this.sqlDeleteCommand1;
			this.da.InsertCommand = this.sqlInsertCommand1;
			this.da.SelectCommand = this.sqlSelectCommand1;
			this.da.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						 new System.Data.Common.DataTableMapping("Table", "检校费用", new System.Data.Common.DataColumnMapping[] {
																																																 new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																 new System.Data.Common.DataColumnMapping("检校设备编号", "检校设备编号"),
																																																 new System.Data.Common.DataColumnMapping("检定费用", "检定费用"),
																																																 new System.Data.Common.DataColumnMapping("校准费用", "校准费用"),
																																																 new System.Data.Common.DataColumnMapping("修理费用", "修理费用"),
																																																 new System.Data.Common.DataColumnMapping("配件费用", "配件费用"),
																																																 new System.Data.Common.DataColumnMapping("应交费用", "应交费用"),
																																																 new System.Data.Common.DataColumnMapping("实交费用", "实交费用"),
																																																 new System.Data.Common.DataColumnMapping("交费日期", "交费日期")})});
			this.da.UpdateCommand = this.sqlUpdateCommand1;
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
