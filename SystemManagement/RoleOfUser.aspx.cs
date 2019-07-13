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
	/// RoleOfUser ��ժҪ˵����
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
			daUser.Fill(sm1.�û���Ϣ);
			daRoleOfUser.Fill(sm1.�û���ɫ);
			
			if (!IsPostBack)
				dgRoleOfUser.DataBind();

			daRole.Fill(sm1.Role);
			RoleCombo.DataBind();
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
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
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
																							 new System.Data.Common.DataTableMapping("Table", "�û���Ϣ", new System.Data.Common.DataColumnMapping[] {
																																																	 new System.Data.Common.DataColumnMapping("�û���", "�û���"),
																																																	 new System.Data.Common.DataColumnMapping("����", "����"),
																																																	 new System.Data.Common.DataColumnMapping("�Ա�", "�Ա�"),
																																																	 new System.Data.Common.DataColumnMapping("����", "����"),
																																																	 new System.Data.Common.DataColumnMapping("ID", "ID")})});
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO �û���Ϣ(�û���, ����, �Ա�, ����) VALUES (@�û���, @����, @�Ա�, @����); SELECT �û���, ����, ��" +
				"��, ����, ID FROM �û���Ϣ";
			this.sqlInsertCommand1.Connection = this.cn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�û���", System.Data.SqlDbType.NVarChar, 255, "�û���"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 10, "����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Ա�", System.Data.SqlDbType.NVarChar, 5, "�Ա�"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 50, "����"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT �û���, ����, �Ա�, ����, ID FROM �û���Ϣ";
			this.sqlSelectCommand1.Connection = this.cn;
			// 
			// daRoleOfUser
			// 
			this.daRoleOfUser.DeleteCommand = this.sqlDeleteCommand1;
			this.daRoleOfUser.InsertCommand = this.sqlInsertCommand2;
			this.daRoleOfUser.SelectCommand = this.sqlSelectCommand2;
			this.daRoleOfUser.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								   new System.Data.Common.DataTableMapping("Table", "�û���ɫ", new System.Data.Common.DataColumnMapping[] {
																																																		   new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																		   new System.Data.Common.DataColumnMapping("�û�ID", "�û�ID"),
																																																		   new System.Data.Common.DataColumnMapping("�û���ɫ", "�û���ɫ")})});
			this.daRoleOfUser.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM �û���ɫ WHERE (ID = @Original_ID) AND (�û�ID = @Original_�û�ID OR @Origina" +
				"l_�û�ID IS NULL AND �û�ID IS NULL) AND (��ɫID = @Original_�û���ɫ)";
			this.sqlDeleteCommand1.Connection = this.cn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�û�ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�û�ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�û���ɫ", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�û���ɫ", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = "INSERT INTO �û���ɫ(�û�ID, ��ɫID) VALUES (@�û�ID, @��ɫID); SELECT ID, �û�ID, ��ɫID AS �û���ɫ" +
				" FROM �û���ɫ WHERE (ID = @@IDENTITY)";
			this.sqlInsertCommand2.Connection = this.cn;
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�û�ID", System.Data.SqlDbType.Int, 4, "�û�ID"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ɫID", System.Data.SqlDbType.Int, 4, "�û���ɫ"));
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT ID, �û�ID, ��ɫID AS �û���ɫ FROM �û���ɫ";
			this.sqlSelectCommand2.Connection = this.cn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE �û���ɫ SET �û�ID = @�û�ID, ��ɫID = @��ɫID WHERE (ID = @Original_ID) AND (�û�ID = " +
				"@Original_�û�ID OR @Original_�û�ID IS NULL AND �û�ID IS NULL) AND (��ɫID = @Original" +
				"_�û���ɫ); SELECT ID, �û�ID, ��ɫID AS �û���ɫ FROM �û���ɫ WHERE (ID = @ID)";
			this.sqlUpdateCommand1.Connection = this.cn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�û�ID", System.Data.SqlDbType.Int, 4, "�û�ID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ɫID", System.Data.SqlDbType.Int, 4, "�û���ɫ"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�û�ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�û�ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�û���ɫ", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�û���ɫ", System.Data.DataRowVersion.Original, null));
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
																							 new System.Data.Common.DataTableMapping("Table", "��ɫ", new System.Data.Common.DataColumnMapping[] {
																																																   new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																   new System.Data.Common.DataColumnMapping("role", "role"),
																																																   new System.Data.Common.DataColumnMapping("description", "description")})});
			this.daRole.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = "DELETE FROM ��ɫ WHERE (ID = @Original_ID) AND (��ɫ���� = @Original_role OR @Original_" +
				"role IS NULL AND ��ɫ���� IS NULL)";
			this.sqlDeleteCommand2.Connection = this.cn;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_role", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "role", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand3
			// 
			this.sqlInsertCommand3.CommandText = "INSERT INTO ��ɫ(��ɫ����, ��ɫ����) VALUES (@��ɫ����, @��ɫ����); SELECT ID, ��ɫ���� AS role, ��ɫ���� A" +
				"S description FROM ��ɫ WHERE (ID = @@IDENTITY)";
			this.sqlInsertCommand3.Connection = this.cn;
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ɫ����", System.Data.SqlDbType.NVarChar, 50, "role"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ɫ����", System.Data.SqlDbType.NVarChar, 1073741823, "description"));
			// 
			// sqlSelectCommand3
			// 
			this.sqlSelectCommand3.CommandText = "SELECT ID, ��ɫ���� AS role, ��ɫ���� AS description FROM ��ɫ";
			this.sqlSelectCommand3.Connection = this.cn;
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = "UPDATE ��ɫ SET ��ɫ���� = @��ɫ����, ��ɫ���� = @��ɫ���� WHERE (ID = @Original_ID) AND (��ɫ���� = @O" +
				"riginal_role OR @Original_role IS NULL AND ��ɫ���� IS NULL); SELECT ID, ��ɫ���� AS rol" +
				"e, ��ɫ���� AS description FROM ��ɫ WHERE (ID = @ID)";
			this.sqlUpdateCommand2.Connection = this.cn;
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ɫ����", System.Data.SqlDbType.NVarChar, 50, "role"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ɫ����", System.Data.SqlDbType.NVarChar, 1073741823, "description"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_role", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "role", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.sm1)).EndInit();

		}
		#endregion

		private void BindGrid()
		{
			sm1.�û���ɫ.Clear();
			sm1.�û���Ϣ.Clear();
			daUser.Fill(sm1.�û���Ϣ);
			daRoleOfUser.Fill(sm1.�û���ɫ);
			
			dgRoleOfUser.DataBind();
		}

		private void dgRoleOfUser_AddRowBatch(object sender, Infragistics.WebUI.UltraWebGrid.RowEventArgs e)
		{
			string tableName=e.Row.Band.BaseTableName;

			//ֻ�����ӱ�ĸ���
			if (sm1.Tables[tableName].ParentRelations.Count>0)
			{
				//�����µ��û���ɫ�����
				SM.�û���ɫRow dr=sm1.�û���ɫ.New�û���ɫRow();

				//��DataSet���������е��û�ID��Ԫ��ֵΪ�����е�ID��Ԫ���ֵ
				dr["�û�ID"]=e.Row.ParentRow.Cells.FromKey("ID").Value;
				//����UltraWebGrid�������������е��û�ID��Ԫ��ֵ��ʹ֮��DataSet������һ��
				e.Row.Cells.FromKey("�û�ID").Value=dr["�û�ID"];

				//�������ɵ��м��뵽DataSet sm1��
				sm1.�û���ɫ.Add�û���ɫRow(dr);

				e.Row.DataKey=dr[sm1.�û���ɫ.PrimaryKey[0]];
				e.Row.Cells.FromKey(sm1.�û���ɫ.PrimaryKey[0].ColumnName).Value=e.Row.DataKey;	
			}

			
		}

		private void dgRoleOfUser_UpdateCellBatch(object sender, Infragistics.WebUI.UltraWebGrid.CellEventArgs e)
		{
			sm1.�û���ɫ.Rows.Find(e.Cell.Row.DataKey)[e.Cell.Column.Key]=e.Cell.Value;
		}

		private void dgRoleOfUser_DeleteRowBatch(object sender, Infragistics.WebUI.UltraWebGrid.RowEventArgs e)
		{
			sm1.�û���ɫ.Rows.Find(e.Row.DataKey).Delete();
//			BindGrid();
		}

		private void Confirm_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			daRoleOfUser.Update(sm1.�û���ɫ);
			BindGrid();
		}


		
	}
}
