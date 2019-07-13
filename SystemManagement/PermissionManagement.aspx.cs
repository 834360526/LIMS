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
	/// PermissionManagement ��ժҪ˵����
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
			daPermission.Fill(sm1.Ȩ��ģ��);
			daPermissionType.Fill(sm1.Ȩ�����);
			daMenu.Fill(sm1.�˵�);
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
																								   new System.Data.Common.DataTableMapping("Table", "Ȩ��ģ��", new System.Data.Common.DataColumnMapping[] {
																																																		   new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																		   new System.Data.Common.DataColumnMapping("Ȩ��ģ����", "Ȩ��ģ����"),
																																																		   new System.Data.Common.DataColumnMapping("���", "���"),
																																																		   new System.Data.Common.DataColumnMapping("�˵�����", "�˵�����"),
																																																		   new System.Data.Common.DataColumnMapping("�˵���ĿID", "�˵���ĿID"),
																																																		   new System.Data.Common.DataColumnMapping("���ӵ�ַ", "���ӵ�ַ"),
																																																		   new System.Data.Common.DataColumnMapping("��ע", "��ע")})});
			this.daPermission.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM Ȩ��ģ�� WHERE (ID = @Original_ID) AND (Ȩ��ģ���� = @Original_Ȩ��ģ����) AND (��� = @Original_���) AND (�˵����� = @Original_�˵����� OR @Original_�˵����� IS NULL AND �˵����� IS NULL) AND (�˵���ĿID = @Original_�˵���ĿID OR @Original_�˵���ĿID IS NULL AND �˵���ĿID IS NULL) AND (���ӵ�ַ = @Original_���ӵ�ַ OR @Original_���ӵ�ַ IS NULL AND ���ӵ�ַ IS NULL)";
			this.sqlDeleteCommand1.Connection = this.cn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ȩ��ģ����", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ȩ��ģ����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�˵�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�˵�����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�˵���ĿID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�˵���ĿID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ӵ�ַ", System.Data.SqlDbType.NVarChar, 1000, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���ӵ�ַ", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO Ȩ��ģ��(Ȩ��ģ����, ���, �˵�����, �˵���ĿID, ���ӵ�ַ, ��ע) VALUES (@Ȩ��ģ����, @���, @�˵�����, @" +
				"�˵���ĿID, @���ӵ�ַ, @��ע); SELECT ID, Ȩ��ģ����, ���, �˵�����, �˵���ĿID, ���ӵ�ַ, ��ע FROM Ȩ��ģ�� WHER" +
				"E (ID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.cn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ȩ��ģ����", System.Data.SqlDbType.NVarChar, 50, "Ȩ��ģ����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Int, 4, "���"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�˵�����", System.Data.SqlDbType.Int, 4, "�˵�����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�˵���ĿID", System.Data.SqlDbType.Int, 4, "�˵���ĿID"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ӵ�ַ", System.Data.SqlDbType.NVarChar, 1000, "���ӵ�ַ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.NVarChar, 1073741823, "��ע"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ID, Ȩ��ģ����, ���, �˵�����, �˵���ĿID, ���ӵ�ַ, ��ע FROM Ȩ��ģ��";
			this.sqlSelectCommand1.Connection = this.cn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE Ȩ��ģ�� SET Ȩ��ģ���� = @Ȩ��ģ����, ��� = @���, �˵����� = @�˵�����, �˵���ĿID = @�˵���ĿID, ���ӵ�ַ = @���ӵ�ַ, ��ע = @��ע WHERE (ID = @Original_ID) AND (Ȩ��ģ���� = @Original_Ȩ��ģ����) AND (��� = @Original_���) AND (�˵����� = @Original_�˵����� OR @Original_�˵����� IS NULL AND �˵����� IS NULL) AND (�˵���ĿID = @Original_�˵���ĿID OR @Original_�˵���ĿID IS NULL AND �˵���ĿID IS NULL) AND (���ӵ�ַ = @Original_���ӵ�ַ OR @Original_���ӵ�ַ IS NULL AND ���ӵ�ַ IS NULL); SELECT ID, Ȩ��ģ����, ���, �˵�����, �˵���ĿID, ���ӵ�ַ, ��ע FROM Ȩ��ģ�� WHERE (ID = @ID)";
			this.sqlUpdateCommand1.Connection = this.cn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ȩ��ģ����", System.Data.SqlDbType.NVarChar, 50, "Ȩ��ģ����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Int, 4, "���"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�˵�����", System.Data.SqlDbType.Int, 4, "�˵�����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�˵���ĿID", System.Data.SqlDbType.Int, 4, "�˵���ĿID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ӵ�ַ", System.Data.SqlDbType.NVarChar, 1000, "���ӵ�ַ"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.NVarChar, 1073741823, "��ע"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ȩ��ģ����", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ȩ��ģ����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�˵�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�˵�����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�˵���ĿID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�˵���ĿID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ӵ�ַ", System.Data.SqlDbType.NVarChar, 1000, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���ӵ�ַ", System.Data.DataRowVersion.Original, null));
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
																									   new System.Data.Common.DataTableMapping("Table", "Ȩ�����", new System.Data.Common.DataColumnMapping[] {
																																																			   new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																			   new System.Data.Common.DataColumnMapping("Type", "Type")})});
			this.daPermissionType.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = "DELETE FROM Ȩ����� WHERE (ID = @Original_ID) AND (��� = @Original_Type OR @Original_" +
				"Type IS NULL AND ��� IS NULL)";
			this.sqlDeleteCommand2.Connection = this.cn;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = "INSERT INTO Ȩ�����(���) VALUES (@���); SELECT ID, ��� AS Type FROM Ȩ����� WHERE (ID = @@" +
				"IDENTITY)";
			this.sqlInsertCommand2.Connection = this.cn;
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.NVarChar, 50, "Type"));
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT ID, ��� AS Type FROM Ȩ�����";
			this.sqlSelectCommand2.Connection = this.cn;
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = "UPDATE Ȩ����� SET ��� = @��� WHERE (ID = @Original_ID) AND (��� = @Original_Type OR @O" +
				"riginal_Type IS NULL AND ��� IS NULL); SELECT ID, ��� AS Type FROM Ȩ����� WHERE (ID " +
				"= @ID)";
			this.sqlUpdateCommand2.Connection = this.cn;
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.NVarChar, 50, "Type"));
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
																							 new System.Data.Common.DataTableMapping("Table", "�˵�", new System.Data.Common.DataColumnMapping[] {
																																																   new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																   new System.Data.Common.DataColumnMapping("item", "item")})});
			this.daMenu.UpdateCommand = this.sqlUpdateCommand3;
			// 
			// sqlDeleteCommand3
			// 
			this.sqlDeleteCommand3.CommandText = "DELETE FROM �˵� WHERE (ID = @Original_ID) AND (�˵���Ŀ�� = @Original_item OR @Original" +
				"_item IS NULL AND �˵���Ŀ�� IS NULL)";
			this.sqlDeleteCommand3.Connection = this.cn;
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_item", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "item", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand3
			// 
			this.sqlInsertCommand3.CommandText = "INSERT INTO �˵�(�˵���Ŀ��) VALUES (@�˵���Ŀ��); SELECT ID, �˵���Ŀ�� AS item FROM �˵� WHERE (ID" +
				" = @@IDENTITY)";
			this.sqlInsertCommand3.Connection = this.cn;
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�˵���Ŀ��", System.Data.SqlDbType.NVarChar, 50, "item"));
			// 
			// sqlSelectCommand3
			// 
			this.sqlSelectCommand3.CommandText = "SELECT ID, �˵���Ŀ�� AS item FROM �˵�";
			this.sqlSelectCommand3.Connection = this.cn;
			// 
			// sqlUpdateCommand3
			// 
			this.sqlUpdateCommand3.CommandText = "UPDATE �˵� SET �˵���Ŀ�� = @�˵���Ŀ�� WHERE (ID = @Original_ID) AND (�˵���Ŀ�� = @Original_ite" +
				"m OR @Original_item IS NULL AND �˵���Ŀ�� IS NULL); SELECT ID, �˵���Ŀ�� AS item FROM �˵�" +
				" WHERE (ID = @ID)";
			this.sqlUpdateCommand3.Connection = this.cn;
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�˵���Ŀ��", System.Data.SqlDbType.NVarChar, 50, "item"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_item", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "item", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.sm1)).EndInit();

		}
		#endregion

		private void Cancel_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			sm1.Ȩ��ģ��.RejectChanges();
			dgPermission.DataBind();
		}

		private void Sumbit_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			daPermission.Update(sm1.Ȩ��ģ��);
			PopulateDataSet();
			BindGrid();
//			BindGrid();
		}

		private void dgPermission_UpdateCellBatch(object sender, Infragistics.WebUI.UltraWebGrid.CellEventArgs e)
		{
			sm1.Ȩ��ģ��.Rows.Find(e.Cell.Row.DataKey)[e.Cell.Column.Key]=e.Cell.Value;			
		}

		private void dgPermission_AddRowBatch(object sender, Infragistics.WebUI.UltraWebGrid.RowEventArgs e)
		{

			SM.Ȩ��ģ��Row dr=sm1.Ȩ��ģ��.NewȨ��ģ��Row();

			sm1.Ȩ��ģ��.AddȨ��ģ��Row(dr);
			e.Row.DataKey=dr[sm1.Ȩ��ģ��.PrimaryKey[0]];
			e.Row.Cells.FromKey(sm1.Ȩ��ģ��.PrimaryKey[0].ColumnName).Value=e.Row.DataKey;	
		}

		private void dgPermission_DeleteRowBatch(object sender, Infragistics.WebUI.UltraWebGrid.RowEventArgs e)
		{
			sm1.Ȩ��ģ��.Rows.Find(e.Row.DataKey).Delete();
		}
	}
}
