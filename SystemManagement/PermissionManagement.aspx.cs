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

namespace LIMS.SystemManagement
{
	/// <summary>
	/// PermissionManagement 的摘要说明。
	/// </summary>
	public class PermissionManagement : BaseForm
	{
		protected System.Data.SqlClient.SqlDataAdapter daPermission;
		protected LIMS.SystemManagement.SM sm1;
		protected Infragistics.WebUI.UltraWebGrid.UltraWebGrid dgPermission;
		protected System.Data.SqlClient.SqlDataAdapter daPermissionType;
		protected Infragistics.WebUI.WebCombo.WebCombo PermissionTypeCombo;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		protected System.Data.SqlClient.SqlDataAdapter daMenu;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand3;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
		protected Infragistics.WebUI.WebCombo.WebCombo MenuCombo;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Sumbit;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Cancel;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection cn;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			cn.ConnectionString=this.cnStr;

			PopulateDataSet();
			if (!IsPostBack)
				BindGrid();
		}

		private void BindGrid()
		{
			dgPermission.DataBind();
			
			PermissionTypeCombo.DataBind();
			
			MenuCombo.DataBind();
		}


		private void PopulateDataSet()
		{
			daPermission.Fill(sm1.权限模块);
			daPermissionType.Fill(sm1.权限类别);
			daMenu.Fill(sm1.菜单);
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
			this.daPermission = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sm1 = new LIMS.SystemManagement.SM();
			this.daPermissionType = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.daMenu = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.sm1)).BeginInit();
			this.dgPermission.UpdateCellBatch += new Infragistics.WebUI.UltraWebGrid.UpdateCellBatchEventHandler(this.dgPermission_UpdateCellBatch);
			this.dgPermission.DeleteRowBatch += new Infragistics.WebUI.UltraWebGrid.DeleteRowBatchEventHandler(this.dgPermission_DeleteRowBatch);
			this.dgPermission.AddRowBatch += new Infragistics.WebUI.UltraWebGrid.AddRowBatchEventHandler(this.dgPermission_AddRowBatch);
			this.Sumbit.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.Sumbit_Click);
			this.Cancel.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.Cancel_Click);
			// 
			// cn
			// 
			this.cn.ConnectionString = "workstation id=QDMT;packet size=4096;user id=sa;integrated security=SSPI;data sou" +
				"rce=\".\";persist security info=False;initial catalog=lims";
			// 
			// daPermission
			// 
			this.daPermission.DeleteCommand = this.sqlDeleteCommand1;
			this.daPermission.InsertCommand = this.sqlInsertCommand1;
			this.daPermission.SelectCommand = this.sqlSelectCommand1;
			this.daPermission.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								   new System.Data.Common.DataTableMapping("Table", "权限模块", new System.Data.Common.DataColumnMapping[] {
																																																		   new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																		   new System.Data.Common.DataColumnMapping("权限模块名", "权限模块名"),
																																																		   new System.Data.Common.DataColumnMapping("类别", "类别"),
																																																		   new System.Data.Common.DataColumnMapping("菜单级别", "菜单级别"),
																																																		   new System.Data.Common.DataColumnMapping("菜单项目ID", "菜单项目ID"),
																																																		   new System.Data.Common.DataColumnMapping("链接地址", "链接地址"),
																																																		   new System.Data.Common.DataColumnMapping("备注", "备注")})});
			this.daPermission.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM 权限模块 WHERE (ID = @Original_ID) AND (权限模块名 = @Original_权限模块名) AND (类别 = @Original_类别) AND (菜单级别 = @Original_菜单级别 OR @Original_菜单级别 IS NULL AND 菜单级别 IS NULL) AND (菜单项目ID = @Original_菜单项目ID OR @Original_菜单项目ID IS NULL AND 菜单项目ID IS NULL) AND (链接地址 = @Original_链接地址 OR @Original_链接地址 IS NULL AND 链接地址 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.cn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_权限模块名", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "权限模块名", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_类别", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "类别", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_菜单级别", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "菜单级别", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_菜单项目ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "菜单项目ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_链接地址", System.Data.SqlDbType.NVarChar, 1000, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "链接地址", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO 权限模块(权限模块名, 类别, 菜单级别, 菜单项目ID, 链接地址, 备注) VALUES (@权限模块名, @类别, @菜单级别, @" +
				"菜单项目ID, @链接地址, @备注); SELECT ID, 权限模块名, 类别, 菜单级别, 菜单项目ID, 链接地址, 备注 FROM 权限模块 WHER" +
				"E (ID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.cn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@权限模块名", System.Data.SqlDbType.NVarChar, 50, "权限模块名"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@类别", System.Data.SqlDbType.Int, 4, "类别"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@菜单级别", System.Data.SqlDbType.Int, 4, "菜单级别"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@菜单项目ID", System.Data.SqlDbType.Int, 4, "菜单项目ID"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@链接地址", System.Data.SqlDbType.NVarChar, 1000, "链接地址"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.NVarChar, 1073741823, "备注"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ID, 权限模块名, 类别, 菜单级别, 菜单项目ID, 链接地址, 备注 FROM 权限模块";
			this.sqlSelectCommand1.Connection = this.cn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE 权限模块 SET 权限模块名 = @权限模块名, 类别 = @类别, 菜单级别 = @菜单级别, 菜单项目ID = @菜单项目ID, 链接地址 = @链接地址, 备注 = @备注 WHERE (ID = @Original_ID) AND (权限模块名 = @Original_权限模块名) AND (类别 = @Original_类别) AND (菜单级别 = @Original_菜单级别 OR @Original_菜单级别 IS NULL AND 菜单级别 IS NULL) AND (菜单项目ID = @Original_菜单项目ID OR @Original_菜单项目ID IS NULL AND 菜单项目ID IS NULL) AND (链接地址 = @Original_链接地址 OR @Original_链接地址 IS NULL AND 链接地址 IS NULL); SELECT ID, 权限模块名, 类别, 菜单级别, 菜单项目ID, 链接地址, 备注 FROM 权限模块 WHERE (ID = @ID)";
			this.sqlUpdateCommand1.Connection = this.cn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@权限模块名", System.Data.SqlDbType.NVarChar, 50, "权限模块名"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@类别", System.Data.SqlDbType.Int, 4, "类别"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@菜单级别", System.Data.SqlDbType.Int, 4, "菜单级别"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@菜单项目ID", System.Data.SqlDbType.Int, 4, "菜单项目ID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@链接地址", System.Data.SqlDbType.NVarChar, 1000, "链接地址"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.NVarChar, 1073741823, "备注"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_权限模块名", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "权限模块名", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_类别", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "类别", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_菜单级别", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "菜单级别", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_菜单项目ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "菜单项目ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_链接地址", System.Data.SqlDbType.NVarChar, 1000, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "链接地址", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			// 
			// sm1
			// 
			this.sm1.DataSetName = "SM";
			this.sm1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// daPermissionType
			// 
			this.daPermissionType.DeleteCommand = this.sqlDeleteCommand2;
			this.daPermissionType.InsertCommand = this.sqlInsertCommand2;
			this.daPermissionType.SelectCommand = this.sqlSelectCommand2;
			this.daPermissionType.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									   new System.Data.Common.DataTableMapping("Table", "权限类别", new System.Data.Common.DataColumnMapping[] {
																																																			   new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																			   new System.Data.Common.DataColumnMapping("Type", "Type")})});
			this.daPermissionType.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = "DELETE FROM 权限类别 WHERE (ID = @Original_ID) AND (类别 = @Original_Type OR @Original_" +
				"Type IS NULL AND 类别 IS NULL)";
			this.sqlDeleteCommand2.Connection = this.cn;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = "INSERT INTO 权限类别(类别) VALUES (@类别); SELECT ID, 类别 AS Type FROM 权限类别 WHERE (ID = @@" +
				"IDENTITY)";
			this.sqlInsertCommand2.Connection = this.cn;
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@类别", System.Data.SqlDbType.NVarChar, 50, "Type"));
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT ID, 类别 AS Type FROM 权限类别";
			this.sqlSelectCommand2.Connection = this.cn;
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = "UPDATE 权限类别 SET 类别 = @类别 WHERE (ID = @Original_ID) AND (类别 = @Original_Type OR @O" +
				"riginal_Type IS NULL AND 类别 IS NULL); SELECT ID, 类别 AS Type FROM 权限类别 WHERE (ID " +
				"= @ID)";
			this.sqlUpdateCommand2.Connection = this.cn;
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@类别", System.Data.SqlDbType.NVarChar, 50, "Type"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			// 
			// daMenu
			// 
			this.daMenu.DeleteCommand = this.sqlDeleteCommand3;
			this.daMenu.InsertCommand = this.sqlInsertCommand3;
			this.daMenu.SelectCommand = this.sqlSelectCommand3;
			this.daMenu.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							 new System.Data.Common.DataTableMapping("Table", "菜单", new System.Data.Common.DataColumnMapping[] {
																																																   new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																   new System.Data.Common.DataColumnMapping("item", "item")})});
			this.daMenu.UpdateCommand = this.sqlUpdateCommand3;
			// 
			// sqlDeleteCommand3
			// 
			this.sqlDeleteCommand3.CommandText = "DELETE FROM 菜单 WHERE (ID = @Original_ID) AND (菜单项目名 = @Original_item OR @Original" +
				"_item IS NULL AND 菜单项目名 IS NULL)";
			this.sqlDeleteCommand3.Connection = this.cn;
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_item", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "item", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand3
			// 
			this.sqlInsertCommand3.CommandText = "INSERT INTO 菜单(菜单项目名) VALUES (@菜单项目名); SELECT ID, 菜单项目名 AS item FROM 菜单 WHERE (ID" +
				" = @@IDENTITY)";
			this.sqlInsertCommand3.Connection = this.cn;
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@菜单项目名", System.Data.SqlDbType.NVarChar, 50, "item"));
			// 
			// sqlSelectCommand3
			// 
			this.sqlSelectCommand3.CommandText = "SELECT ID, 菜单项目名 AS item FROM 菜单";
			this.sqlSelectCommand3.Connection = this.cn;
			// 
			// sqlUpdateCommand3
			// 
			this.sqlUpdateCommand3.CommandText = "UPDATE 菜单 SET 菜单项目名 = @菜单项目名 WHERE (ID = @Original_ID) AND (菜单项目名 = @Original_ite" +
				"m OR @Original_item IS NULL AND 菜单项目名 IS NULL); SELECT ID, 菜单项目名 AS item FROM 菜单" +
				" WHERE (ID = @ID)";
			this.sqlUpdateCommand3.Connection = this.cn;
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@菜单项目名", System.Data.SqlDbType.NVarChar, 50, "item"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_item", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "item", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.sm1)).EndInit();

		}
		#endregion

		private void Cancel_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			sm1.权限模块.RejectChanges();
			dgPermission.DataBind();
		}

		private void Sumbit_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			daPermission.Update(sm1.权限模块);
			PopulateDataSet();
			BindGrid();
//			BindGrid();
		}

		private void dgPermission_UpdateCellBatch(object sender, Infragistics.WebUI.UltraWebGrid.CellEventArgs e)
		{
			sm1.权限模块.Rows.Find(e.Cell.Row.DataKey)[e.Cell.Column.Key]=e.Cell.Value;			
		}

		private void dgPermission_AddRowBatch(object sender, Infragistics.WebUI.UltraWebGrid.RowEventArgs e)
		{

			SM.权限模块Row dr=sm1.权限模块.New权限模块Row();

			sm1.权限模块.Add权限模块Row(dr);
			e.Row.DataKey=dr[sm1.权限模块.PrimaryKey[0]];
			e.Row.Cells.FromKey(sm1.权限模块.PrimaryKey[0].ColumnName).Value=e.Row.DataKey;	
		}

		private void dgPermission_DeleteRowBatch(object sender, Infragistics.WebUI.UltraWebGrid.RowEventArgs e)
		{
			sm1.权限模块.Rows.Find(e.Row.DataKey).Delete();
		}
	}
}
