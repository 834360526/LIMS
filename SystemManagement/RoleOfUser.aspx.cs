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
using System.Data.SqlClient;

namespace LIMS.SystemManagement
{
	/// <summary>
	/// RoleOfUser 的摘要说明。
	/// </summary>
	public class RoleOfUser : BaseForm
	{
		protected System.Data.SqlClient.SqlConnection cn;
		protected System.Data.SqlClient.SqlDataAdapter daUser;
		protected System.Data.SqlClient.SqlDataAdapter daRoleOfUser;
		protected LIMS.SystemManagement.SM sm1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected Infragistics.WebUI.UltraWebGrid.UltraWebGrid dgRoleOfUser;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected Infragistics.WebUI.UltraWebGrid.UltraWebGrid UltraWebGrid1;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Confirm;
		protected System.Data.SqlClient.SqlDataAdapter daRole;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand3;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		protected Infragistics.WebUI.WebCombo.WebCombo WebCombo1;
		protected Infragistics.WebUI.WebCombo.WebCombo RoleCombo;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			cn.ConnectionString=this.cnStr;
			daUser.Fill(sm1.用户信息);
			daRoleOfUser.Fill(sm1.用户角色);
			
			if (!IsPostBack)
				dgRoleOfUser.DataBind();

			daRole.Fill(sm1.Role);
			RoleCombo.DataBind();
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
			this.daUser = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.daRoleOfUser = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sm1 = new LIMS.SystemManagement.SM();
			this.daRole = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.sm1)).BeginInit();
			this.dgRoleOfUser.UpdateCellBatch += new Infragistics.WebUI.UltraWebGrid.UpdateCellBatchEventHandler(this.dgRoleOfUser_UpdateCellBatch);
			this.dgRoleOfUser.DeleteRowBatch += new Infragistics.WebUI.UltraWebGrid.DeleteRowBatchEventHandler(this.dgRoleOfUser_DeleteRowBatch);
			this.dgRoleOfUser.AddRowBatch += new Infragistics.WebUI.UltraWebGrid.AddRowBatchEventHandler(this.dgRoleOfUser_AddRowBatch);
			this.Confirm.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.Confirm_Click);
			// 
			// cn
			// 
			this.cn.ConnectionString = "workstation id=QDMT;packet size=4096;user id=sa;integrated security=SSPI;data sou" +
				"rce=\".\";persist security info=False;initial catalog=lims";
			// 
			// daUser
			// 
			this.daUser.InsertCommand = this.sqlInsertCommand1;
			this.daUser.SelectCommand = this.sqlSelectCommand1;
			this.daUser.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							 new System.Data.Common.DataTableMapping("Table", "用户信息", new System.Data.Common.DataColumnMapping[] {
																																																	 new System.Data.Common.DataColumnMapping("用户名", "用户名"),
																																																	 new System.Data.Common.DataColumnMapping("姓名", "姓名"),
																																																	 new System.Data.Common.DataColumnMapping("性别", "性别"),
																																																	 new System.Data.Common.DataColumnMapping("科室", "科室"),
																																																	 new System.Data.Common.DataColumnMapping("ID", "ID")})});
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO 用户信息(用户名, 姓名, 性别, 科室) VALUES (@用户名, @姓名, @性别, @科室); SELECT 用户名, 姓名, 性" +
				"别, 科室, ID FROM 用户信息";
			this.sqlInsertCommand1.Connection = this.cn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@用户名", System.Data.SqlDbType.NVarChar, 255, "用户名"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@姓名", System.Data.SqlDbType.NVarChar, 10, "姓名"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@性别", System.Data.SqlDbType.NVarChar, 5, "性别"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@科室", System.Data.SqlDbType.NVarChar, 50, "科室"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 用户名, 姓名, 性别, 科室, ID FROM 用户信息";
			this.sqlSelectCommand1.Connection = this.cn;
			// 
			// daRoleOfUser
			// 
			this.daRoleOfUser.DeleteCommand = this.sqlDeleteCommand1;
			this.daRoleOfUser.InsertCommand = this.sqlInsertCommand2;
			this.daRoleOfUser.SelectCommand = this.sqlSelectCommand2;
			this.daRoleOfUser.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								   new System.Data.Common.DataTableMapping("Table", "用户角色", new System.Data.Common.DataColumnMapping[] {
																																																		   new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																		   new System.Data.Common.DataColumnMapping("用户ID", "用户ID"),
																																																		   new System.Data.Common.DataColumnMapping("用户角色", "用户角色")})});
			this.daRoleOfUser.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM 用户角色 WHERE (ID = @Original_ID) AND (用户ID = @Original_用户ID OR @Origina" +
				"l_用户ID IS NULL AND 用户ID IS NULL) AND (角色ID = @Original_用户角色)";
			this.sqlDeleteCommand1.Connection = this.cn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_用户ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "用户ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_用户角色", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "用户角色", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = "INSERT INTO 用户角色(用户ID, 角色ID) VALUES (@用户ID, @角色ID); SELECT ID, 用户ID, 角色ID AS 用户角色" +
				" FROM 用户角色 WHERE (ID = @@IDENTITY)";
			this.sqlInsertCommand2.Connection = this.cn;
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@用户ID", System.Data.SqlDbType.Int, 4, "用户ID"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@角色ID", System.Data.SqlDbType.Int, 4, "用户角色"));
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT ID, 用户ID, 角色ID AS 用户角色 FROM 用户角色";
			this.sqlSelectCommand2.Connection = this.cn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE 用户角色 SET 用户ID = @用户ID, 角色ID = @角色ID WHERE (ID = @Original_ID) AND (用户ID = " +
				"@Original_用户ID OR @Original_用户ID IS NULL AND 用户ID IS NULL) AND (角色ID = @Original" +
				"_用户角色); SELECT ID, 用户ID, 角色ID AS 用户角色 FROM 用户角色 WHERE (ID = @ID)";
			this.sqlUpdateCommand1.Connection = this.cn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@用户ID", System.Data.SqlDbType.Int, 4, "用户ID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@角色ID", System.Data.SqlDbType.Int, 4, "用户角色"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_用户ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "用户ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_用户角色", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "用户角色", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			// 
			// sm1
			// 
			this.sm1.DataSetName = "SM";
			this.sm1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// daRole
			// 
			this.daRole.DeleteCommand = this.sqlDeleteCommand2;
			this.daRole.InsertCommand = this.sqlInsertCommand3;
			this.daRole.SelectCommand = this.sqlSelectCommand3;
			this.daRole.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							 new System.Data.Common.DataTableMapping("Table", "角色", new System.Data.Common.DataColumnMapping[] {
																																																   new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																   new System.Data.Common.DataColumnMapping("role", "role"),
																																																   new System.Data.Common.DataColumnMapping("description", "description")})});
			this.daRole.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = "DELETE FROM 角色 WHERE (ID = @Original_ID) AND (角色名称 = @Original_role OR @Original_" +
				"role IS NULL AND 角色名称 IS NULL)";
			this.sqlDeleteCommand2.Connection = this.cn;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_role", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "role", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand3
			// 
			this.sqlInsertCommand3.CommandText = "INSERT INTO 角色(角色名称, 角色描述) VALUES (@角色名称, @角色描述); SELECT ID, 角色名称 AS role, 角色描述 A" +
				"S description FROM 角色 WHERE (ID = @@IDENTITY)";
			this.sqlInsertCommand3.Connection = this.cn;
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@角色名称", System.Data.SqlDbType.NVarChar, 50, "role"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@角色描述", System.Data.SqlDbType.NVarChar, 1073741823, "description"));
			// 
			// sqlSelectCommand3
			// 
			this.sqlSelectCommand3.CommandText = "SELECT ID, 角色名称 AS role, 角色描述 AS description FROM 角色";
			this.sqlSelectCommand3.Connection = this.cn;
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = "UPDATE 角色 SET 角色名称 = @角色名称, 角色描述 = @角色描述 WHERE (ID = @Original_ID) AND (角色名称 = @O" +
				"riginal_role OR @Original_role IS NULL AND 角色名称 IS NULL); SELECT ID, 角色名称 AS rol" +
				"e, 角色描述 AS description FROM 角色 WHERE (ID = @ID)";
			this.sqlUpdateCommand2.Connection = this.cn;
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@角色名称", System.Data.SqlDbType.NVarChar, 50, "role"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@角色描述", System.Data.SqlDbType.NVarChar, 1073741823, "description"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_role", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "role", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.sm1)).EndInit();

		}
		#endregion

		private void BindGrid()
		{
			sm1.用户角色.Clear();
			sm1.用户信息.Clear();
			daUser.Fill(sm1.用户信息);
			daRoleOfUser.Fill(sm1.用户角色);
			
			dgRoleOfUser.DataBind();
		}

		private void dgRoleOfUser_AddRowBatch(object sender, Infragistics.WebUI.UltraWebGrid.RowEventArgs e)
		{
			string tableName=e.Row.Band.BaseTableName;

			//只处理子表的更新
			if (sm1.Tables[tableName].ParentRelations.Count>0)
			{
				//生成新的用户角色表的行
				SM.用户角色Row dr=sm1.用户角色.New用户角色Row();

				//将DataSet中新生成行的用户ID单元格赋值为父表中的ID单元格的值
				dr["用户ID"]=e.Row.ParentRow.Cells.FromKey("ID").Value;
				//更新UltraWebGrid对象中新生成行的用户ID单元格值，使之与DataSet中数据一致
				e.Row.Cells.FromKey("用户ID").Value=dr["用户ID"];

				//将新生成的行加入到DataSet sm1中
				sm1.用户角色.Add用户角色Row(dr);

				e.Row.DataKey=dr[sm1.用户角色.PrimaryKey[0]];
				e.Row.Cells.FromKey(sm1.用户角色.PrimaryKey[0].ColumnName).Value=e.Row.DataKey;	
			}

			
		}

		private void dgRoleOfUser_UpdateCellBatch(object sender, Infragistics.WebUI.UltraWebGrid.CellEventArgs e)
		{
			sm1.用户角色.Rows.Find(e.Cell.Row.DataKey)[e.Cell.Column.Key]=e.Cell.Value;
		}

		private void dgRoleOfUser_DeleteRowBatch(object sender, Infragistics.WebUI.UltraWebGrid.RowEventArgs e)
		{
			sm1.用户角色.Rows.Find(e.Row.DataKey).Delete();
//			BindGrid();
		}

		private void Confirm_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			daRoleOfUser.Update(sm1.用户角色);
			BindGrid();
		}


		
	}
}
