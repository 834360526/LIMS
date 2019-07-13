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
	/// WebForm3 ��ժҪ˵����
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
//			da.Fill(ds1.��У����);
//			ug.DataBind();
//			Dallas.Core.Tool t=new Dallas.Core.Tool();
//			Hashtable ht=new Hashtable();
//			ht.Add("��λ����","b");
//			ht.Add("��ַ","yy");
//			t.AdvancedUpdate(ht,"��λ����","�ͼ쵥λ");
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
			this.sqlSelectCommand1.CommandText = "SELECT ID, ��У�豸���, �춨����, У׼����, �������, �������, Ӧ������, ʵ������, �������� FROM ��У����";
			this.sqlSelectCommand1.Connection = this.cn;
			// 
			// cn
			// 
			this.cn.ConnectionString = "workstation id=QDMT;packet size=4096;user id=sa;integrated security=SSPI;data sou" +
				"rce=\".\";persist security info=False;initial catalog=lims";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO ��У����(��У�豸���, �춨����, У׼����, �������, �������, Ӧ������, ʵ������, ��������) VALUES (@��У�豸��" +
				"��, @�춨����, @У׼����, @�������, @�������, @Ӧ������, @ʵ������, @��������); SELECT ID, ��У�豸���, �춨����, У׼" +
				"����, �������, �������, Ӧ������, ʵ������, �������� FROM ��У���� WHERE (ID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.cn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��У�豸���", System.Data.SqlDbType.NVarChar, 50, "��У�豸���"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�춨����", System.Data.SqlDbType.Int, 4, "�춨����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@У׼����", System.Data.SqlDbType.Int, 4, "У׼����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�������", System.Data.SqlDbType.Int, 4, "�������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�������", System.Data.SqlDbType.Int, 4, "�������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӧ������", System.Data.SqlDbType.Int, 4, "Ӧ������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ʵ������", System.Data.SqlDbType.Int, 4, "ʵ������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.DateTime, 8, "��������"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE ��У���� SET ��У�豸��� = @��У�豸���, �춨���� = @�춨����, У׼���� = @У׼����, ������� = @�������, ������� = @�������, Ӧ������ = @Ӧ������, ʵ������ = @ʵ������, �������� = @�������� WHERE (ID = @Original_ID) AND (�������� = @Original_�������� OR @Original_�������� IS NULL AND �������� IS NULL) AND (������� = @Original_������� OR @Original_������� IS NULL AND ������� IS NULL) AND (ʵ������ = @Original_ʵ������ OR @Original_ʵ������ IS NULL AND ʵ������ IS NULL) AND (Ӧ������ = @Original_Ӧ������ OR @Original_Ӧ������ IS NULL AND Ӧ������ IS NULL) AND (У׼���� = @Original_У׼���� OR @Original_У׼���� IS NULL AND У׼���� IS NULL) AND (�춨���� = @Original_�춨���� OR @Original_�춨���� IS NULL AND �춨���� IS NULL) AND (��У�豸��� = @Original_��У�豸��� OR @Original_��У�豸��� IS NULL AND ��У�豸��� IS NULL) AND (������� = @Original_������� OR @Original_������� IS NULL AND ������� IS NULL); SELECT ID, ��У�豸���, �춨����, У׼����, �������, �������, Ӧ������, ʵ������, �������� FROM ��У���� WHERE (ID = @ID)";
			this.sqlUpdateCommand1.Connection = this.cn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��У�豸���", System.Data.SqlDbType.NVarChar, 50, "��У�豸���"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�춨����", System.Data.SqlDbType.Int, 4, "�춨����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@У׼����", System.Data.SqlDbType.Int, 4, "У׼����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�������", System.Data.SqlDbType.Int, 4, "�������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�������", System.Data.SqlDbType.Int, 4, "�������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӧ������", System.Data.SqlDbType.Int, 4, "Ӧ������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ʵ������", System.Data.SqlDbType.Int, 4, "ʵ������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.DateTime, 8, "��������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�������", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ʵ������", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ʵ������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӧ������", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ӧ������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_У׼����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "У׼����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�춨����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�춨����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��У�豸���", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��У�豸���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�������", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM ��У���� WHERE (ID = @Original_ID) AND (�������� = @Original_�������� OR @Original_�������� IS NULL AND �������� IS NULL) AND (������� = @Original_������� OR @Original_������� IS NULL AND ������� IS NULL) AND (ʵ������ = @Original_ʵ������ OR @Original_ʵ������ IS NULL AND ʵ������ IS NULL) AND (Ӧ������ = @Original_Ӧ������ OR @Original_Ӧ������ IS NULL AND Ӧ������ IS NULL) AND (У׼���� = @Original_У׼���� OR @Original_У׼���� IS NULL AND У׼���� IS NULL) AND (�춨���� = @Original_�춨���� OR @Original_�춨���� IS NULL AND �춨���� IS NULL) AND (��У�豸��� = @Original_��У�豸��� OR @Original_��У�豸��� IS NULL AND ��У�豸��� IS NULL) AND (������� = @Original_������� OR @Original_������� IS NULL AND ������� IS NULL)";
			this.sqlDeleteCommand1.Connection = this.cn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�������", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ʵ������", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ʵ������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӧ������", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ӧ������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_У׼����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "У׼����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�춨����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�춨����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��У�豸���", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��У�豸���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�������", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�������", System.Data.DataRowVersion.Original, null));
			// 
			// da
			// 
			this.da.DeleteCommand = this.sqlDeleteCommand1;
			this.da.InsertCommand = this.sqlInsertCommand1;
			this.da.SelectCommand = this.sqlSelectCommand1;
			this.da.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						 new System.Data.Common.DataTableMapping("Table", "��У����", new System.Data.Common.DataColumnMapping[] {
																																																 new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																 new System.Data.Common.DataColumnMapping("��У�豸���", "��У�豸���"),
																																																 new System.Data.Common.DataColumnMapping("�춨����", "�춨����"),
																																																 new System.Data.Common.DataColumnMapping("У׼����", "У׼����"),
																																																 new System.Data.Common.DataColumnMapping("�������", "�������"),
																																																 new System.Data.Common.DataColumnMapping("�������", "�������"),
																																																 new System.Data.Common.DataColumnMapping("Ӧ������", "Ӧ������"),
																																																 new System.Data.Common.DataColumnMapping("ʵ������", "ʵ������"),
																																																 new System.Data.Common.DataColumnMapping("��������", "��������")})});
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
