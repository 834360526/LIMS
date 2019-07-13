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
	/// RoleManagement 的摘要说明。
	/// </summary>
	public class RoleManagement : BaseForm
	{
		protected System.Data.SqlClient.SqlConnection cn;
		protected System.Data.SqlClient.SqlDataAdapter daRole;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected LIMS.SystemManagement.SM sm1;
		protected System.Web.UI.WebControls.CheckBoxList SelectPermission;
		protected Infragistics.WebUI.WebDataInput.WebImageButton ModifyPermission;
		protected System.Data.SqlClient.SqlDataAdapter daPermission;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		protected Infragistics.WebUI.UltraWebGrid.UltraWebGrid dgRole;
		protected Dallas.Core.SystemManagement mysm;
		protected System.Web.UI.WebControls.Panel PermissionPanel;
		protected System.Web.UI.WebControls.Label Selected;
		protected Infragistics.WebUI.WebDataInput.WebImageButton CancelPermission;
		protected Infragistics.WebUI.WebDataInput.WebImageButton ConfirmPermission;
		protected Infragistics.WebUI.WebDataInput.WebImageButton ConfirmRole;
		protected Infragistics.WebUI.WebDataInput.WebImageButton CancelRole;
		protected ArrayList permissions;
		private void Page_Load(object sender, System.EventArgs e)
		{
			cn.ConnectionString=cnStr;

			mysm=new Dallas.Core.SystemManagement();

			daRole.Fill(sm1.角色);

			if (!IsPostBack)
			{
				dgRole.DataBind();
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
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{    
			this.cn = new System.Data.SqlClient.SqlConnection();
			this.daRole = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sm1 = new LIMS.SystemManagement.SM();
			this.daPermission = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.sm1)).BeginInit();
			this.dgRole.UpdateCellBatch += new Infragistics.WebUI.UltraWebGrid.UpdateCellBatchEventHandler(this.dgRole_UpdateCellBatch);
			this.dgRole.DeleteRowBatch += new Infragistics.WebUI.UltraWebGrid.DeleteRowBatchEventHandler(this.dgRole_DeleteRowBatch);
			this.dgRole.AddRowBatch += new Infragistics.WebUI.UltraWebGrid.AddRowBatchEventHandler(this.dgRole_AddRowBatch);
			this.ConfirmRole.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.ConfirmRole_Click);
			this.CancelRole.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.CancelRole_Click);
			this.ModifyPermission.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.ModifyPermission_Click);
			this.ConfirmPermission.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.ConfirmPermission_Click);
			this.CancelPermission.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.CancelPermission_Click);
			// 
			// cn
			// 
			this.cn.ConnectionString = "workstation id=QDMT;packet size=4096;user id=sa;integrated security=SSPI;data sou" +
				"rce=\".\";persist security info=False;initial catalog=lims";
			// 
			// daRole
			// 
			this.daRole.DeleteCommand = this.sqlDeleteCommand1;
			this.daRole.InsertCommand = this.sqlInsertCommand1;
			this.daRole.SelectCommand = this.sqlSelectCommand1;
			this.daRole.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							 new System.Data.Common.DataTableMapping("Table", "角色", new System.Data.Common.DataColumnMapping[] {
																																																   new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																   new System.Data.Common.DataColumnMapping("角色名称", "角色名称"),
																																																   new System.Data.Common.DataColumnMapping("角色描述", "角色描述")})});
			this.daRole.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM 角色 WHERE (ID = @Original_ID) AND (角色名称 = @Original_角色名称 OR @Original_" +
				"角色名称 IS NULL AND 角色名称 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.cn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_角色名称", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "角色名称", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO 角色(角色名称, 角色描述) VALUES (@角色名称, @角色描述); SELECT ID, 角色名称, 角色描述 FROM 角色 W" +
				"HERE (ID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.cn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@角色名称", System.Data.SqlDbType.NVarChar, 50, "角色名称"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@角色描述", System.Data.SqlDbType.NVarChar, 1073741823, "角色描述"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ID, 角色名称, 角色描述 FROM 角色";
			this.sqlSelectCommand1.Connection = this.cn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE 角色 SET 角色名称 = @角色名称, 角色描述 = @角色描述 WHERE (ID = @Original_ID) AND (角色名称 = @O" +
				"riginal_角色名称 OR @Original_角色名称 IS NULL AND 角色名称 IS NULL); SELECT ID, 角色名称, 角色描述 " +
				"FROM 角色 WHERE (ID = @ID)";
			this.sqlUpdateCommand1.Connection = this.cn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@角色名称", System.Data.SqlDbType.NVarChar, 50, "角色名称"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@角色描述", System.Data.SqlDbType.NVarChar, 1073741823, "角色描述"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_角色名称", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "角色名称", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			// 
			// sm1
			// 
			this.sm1.DataSetName = "SM";
			this.sm1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// daPermission
			// 
			this.daPermission.DeleteCommand = this.sqlDeleteCommand2;
			this.daPermission.InsertCommand = this.sqlInsertCommand2;
			this.daPermission.SelectCommand = this.sqlSelectCommand2;
			this.daPermission.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								   new System.Data.Common.DataTableMapping("Table", "权限模块", new System.Data.Common.DataColumnMapping[] {
																																																		   new System.Data.Common.DataColumnMapping("权限模块名", "权限模块名"),
																																																		   new System.Data.Common.DataColumnMapping("ID", "ID")})});
			this.daPermission.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = "DELETE FROM 权限模块 WHERE (ID = @Original_ID) AND (权限模块名 = @Original_权限模块名)";
			this.sqlDeleteCommand2.Connection = this.cn;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_权限模块名", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "权限模块名", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = "INSERT INTO 权限模块(权限模块名) VALUES (@权限模块名); SELECT 权限模块名, ID FROM 权限模块 WHERE (ID = @" +
				"@IDENTITY)";
			this.sqlInsertCommand2.Connection = this.cn;
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@权限模块名", System.Data.SqlDbType.NVarChar, 50, "权限模块名"));
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT 权限模块名, ID FROM 权限模块";
			this.sqlSelectCommand2.Connection = this.cn;
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = "UPDATE 权限模块 SET 权限模块名 = @权限模块名 WHERE (ID = @Original_ID) AND (权限模块名 = @Original_权" +
				"限模块名); SELECT 权限模块名, ID FROM 权限模块 WHERE (ID = @ID)";
			this.sqlUpdateCommand2.Connection = this.cn;
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@权限模块名", System.Data.SqlDbType.NVarChar, 50, "权限模块名"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_权限模块名", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "权限模块名", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.sm1)).EndInit();

		}
		#endregion

		private void BindPermissions()
		{
			daPermission.Fill(sm1.权限模块);
			SelectPermission.DataBind();
		}
		private void ModifyPermission_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			
			//只能选择一行
			if (dgRole.DisplayLayout.SelectedRows.Count!=1)
				return;

			PermissionPanel.Visible=true;
			Selected.Text="您选择的是："+dgRole.DisplayLayout.SelectedRows[0].Cells[1].Value;
			//显示所有权限
			BindPermissions();

			//获取选择的行的ID
			int ID=Convert.ToInt32(dgRole.DisplayLayout.SelectedRows[0].Cells[0].Value);
//			permissions=mysm.GetPermissionOfRole(ID);

			//设置选择角色的权限
			SelectPermission=mysm.CheckedOption(ID,SelectPermission);

			//将选择的角色ID存于会话状态中
			Session["SelectedRoleID"]=ID;
//			foreach (string s in permissions)
//			{
//				ListItem li=SelectPermission.Items.FindByValue(s);
//				if (li!=null)
//					li.Selected=true;
//			}
//			SelectPermission.Items.

		}

		private void dgRole_AddRowBatch(object sender, Infragistics.WebUI.UltraWebGrid.RowEventArgs e)
		{
			SM.角色Row dr=sm1.角色.New角色Row();

			sm1.角色.Add角色Row(dr);
			e.Row.DataKey=dr[sm1.角色.PrimaryKey[0]];
			e.Row.Cells.FromKey(sm1.角色.PrimaryKey[0].ColumnName).Value=e.Row.DataKey;	
		}

		private void dgRole_DeleteRowBatch(object sender, Infragistics.WebUI.UltraWebGrid.RowEventArgs e)
		{
			sm1.角色.Rows.Find(e.Row.DataKey).Delete();
		}

		private void dgRole_UpdateCellBatch(object sender, Infragistics.WebUI.UltraWebGrid.CellEventArgs e)
		{
			sm1.角色.Rows.Find(e.Cell.Row.DataKey)[e.Cell.Column.Key]=e.Cell.Value;
		}

		private void CancelPermission_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			PermissionPanel.Visible=false;
		}

		private void ConfirmPermission_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			if (Session["SelectedRoleID"]==null)
				return;

			int ID=Convert.ToInt32(Session["SelectedRoleID"]);

			//获取选择的行的IDting();
			mysm.UpdatePermission(SelectPermission,ID);
			//设置选择角色的权限
			SelectPermission=mysm.CheckedOption(ID,SelectPermission);

			//将用完的会话清空
			Session["SelectedRoleID"]=null;

			PermissionPanel.Visible=false;

		}

		private void ConfirmRole_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			daRole.Update(sm1.角色);
			daRole.Fill(sm1.角色);
			dgRole.DataBind();
		}

		private void CancelRole_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			sm1.角色.RejectChanges();
			dgRole.DataBind();
		}

	}
}
