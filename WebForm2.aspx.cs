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
	/// WebForm2 ��ժҪ˵����
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
																						 new System.Data.Common.DataTableMapping("Table", "��Ⱥ����", new System.Data.Common.DataColumnMapping[] {
																																																 new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																 new System.Data.Common.DataColumnMapping("��λ", "��λ"),
																																																 new System.Data.Common.DataColumnMapping("����      ˾��", "����      ˾��"),
																																																 new System.Data.Common.DataColumnMapping("ְλ����", "ְλ����"),
																																																 new System.Data.Common.DataColumnMapping("ְλ���", "ְλ���"),
																																																 new System.Data.Common.DataColumnMapping("ְλ���", "ְλ���"),
																																																 new System.Data.Common.DataColumnMapping("�������", "�������"),
																																																 new System.Data.Common.DataColumnMapping("�п�����", "�п�����"),
																																																 new System.Data.Common.DataColumnMapping("רҵ", "רҵ"),
																																																 new System.Data.Common.DataColumnMapping("ѧ��", "ѧ��"),
																																																 new System.Data.Common.DataColumnMapping("������ò", "������ò"),
																																																 new System.Data.Common.DataColumnMapping("�Ƿ�Ҫ�����2�����ϻ��㹤������", "�Ƿ�Ҫ�����2�����ϻ��㹤������"),
																																																 new System.Data.Common.DataColumnMapping("��������", "��������"),
																																																 new System.Data.Common.DataColumnMapping("��ע", "��ע")})});
			this.da.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM ��Ⱥ���� WHERE (ID = @Original_ID) AND (רҵ = @Original_רҵ OR @Original_רҵ IS NULL AND רҵ IS NULL) AND (�������� = @Original_�������� OR @Original_�������� IS NULL AND �������� IS NULL) AND (��λ = @Original_��λ OR @Original_��λ IS NULL AND ��λ IS NULL) AND (��ע = @Original_��ע OR @Original_��ע IS NULL AND ��ע IS NULL) AND (ѧ�� = @Original_ѧ�� OR @Original_ѧ�� IS NULL AND ѧ�� IS NULL) AND (�п����� = @Original_�п����� OR @Original_�п����� IS NULL AND �п����� IS NULL) AND (������ò = @Original_������ò OR @Original_������ò IS NULL AND ������ò IS NULL) AND (�Ƿ�Ҫ�����2�����ϻ��㹤������ = @Original_�Ƿ�Ҫ�����2�����ϻ��㹤������ OR @Original_�Ƿ�Ҫ�����2�����ϻ��㹤������ IS NULL AND �Ƿ�Ҫ�����2�����ϻ��㹤������ IS NULL) AND ([����      ˾��] = @Original_����______˾�� OR @Original_����______˾�� IS NULL AND [����      ˾��] IS NULL) AND (������� = @Original_������� OR @Original_������� IS NULL AND ������� IS NULL) AND (ְλ���� = @Original_ְλ���� OR @Original_ְλ���� IS NULL AND ְλ���� IS NULL) AND (ְλ��� = @Original_ְλ��� OR @Original_ְλ��� IS NULL AND ְλ��� IS NULL) AND (ְλ��� = @Original_ְλ��� OR @Original_ְλ��� IS NULL AND ְλ��� IS NULL)";
			this.sqlDeleteCommand1.Connection = this.cn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_רҵ", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "רҵ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��λ", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��λ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ע", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ѧ��", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ѧ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�п�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�п�����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_������ò", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "������ò", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�Ƿ�Ҫ�����2�����ϻ��㹤������", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�Ƿ�Ҫ�����2�����ϻ��㹤������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����______˾��", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����      ˾��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�������", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ְλ����", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ְλ����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ְλ���", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ְλ���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ְλ���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ְλ���", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO ��Ⱥ����(��λ, [����      ˾��], ְλ����, ְλ���, ְλ���, �������, �п�����, רҵ, ѧ��, ������ò, �Ƿ�Ҫ�����2�����ϻ��㹤������, ��������, ��ע) VALUES (@��λ, @Param1, @ְλ����, @ְλ���, @ְλ���, @�������, @�п�����, @רҵ, @ѧ��, @������ò, @�Ƿ�Ҫ�����2�����ϻ��㹤������, @��������, @��ע); SELECT TOP 100 ID, ��λ, [����      ˾��], ְλ����, ְλ���, ְλ���, �������, �п�����, רҵ, ѧ��, ������ò, �Ƿ�Ҫ�����2�����ϻ��㹤������, ��������, ��ע FROM ��Ⱥ���� WHERE (ID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.cn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��λ", System.Data.SqlDbType.NVarChar, 255, "��λ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Param1", System.Data.SqlDbType.NVarChar, 255, "����      ˾��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ְλ����", System.Data.SqlDbType.NVarChar, 255, "ְλ����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ְλ���", System.Data.SqlDbType.NVarChar, 255, "ְλ���"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ְλ���", System.Data.SqlDbType.Int, 4, "ְλ���"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�������", System.Data.SqlDbType.NVarChar, 255, "�������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�п�����", System.Data.SqlDbType.Int, 4, "�п�����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@רҵ", System.Data.SqlDbType.NVarChar, 255, "רҵ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ѧ��", System.Data.SqlDbType.NVarChar, 255, "ѧ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������ò", System.Data.SqlDbType.NVarChar, 255, "������ò"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Ƿ�Ҫ�����2�����ϻ��㹤������", System.Data.SqlDbType.NVarChar, 255, "�Ƿ�Ҫ�����2�����ϻ��㹤������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.NVarChar, 255, "��������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.NVarChar, 255, "��ע"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT TOP 100 ID, ��λ, [����      ˾��], ְλ����, ְλ���, ְλ���, �������, �п�����, רҵ, ѧ��, ������ò, " +
				"�Ƿ�Ҫ�����2�����ϻ��㹤������, ��������, ��ע FROM ��Ⱥ����";
			this.sqlSelectCommand1.Connection = this.cn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE ��Ⱥ���� SET ��λ = @��λ, [����      ˾��] = @Param2, ְλ���� = @ְλ����, ְλ��� = @ְλ���, ְλ��� = @ְλ���, ������� = @�������, �п����� = @�п�����, רҵ = @רҵ, ѧ�� = @ѧ��, ������ò = @������ò, �Ƿ�Ҫ�����2�����ϻ��㹤������ = @�Ƿ�Ҫ�����2�����ϻ��㹤������, �������� = @��������, ��ע = @��ע WHERE (ID = @Original_ID) AND (רҵ = @Original_רҵ OR @Original_רҵ IS NULL AND רҵ IS NULL) AND (�������� = @Original_�������� OR @Original_�������� IS NULL AND �������� IS NULL) AND (��λ = @Original_��λ OR @Original_��λ IS NULL AND ��λ IS NULL) AND (��ע = @Original_��ע OR @Original_��ע IS NULL AND ��ע IS NULL) AND (ѧ�� = @Original_ѧ�� OR @Original_ѧ�� IS NULL AND ѧ�� IS NULL) AND (�п����� = @Original_�п����� OR @Original_�п����� IS NULL AND �п����� IS NULL) AND (������ò = @Original_������ò OR @Original_������ò IS NULL AND ������ò IS NULL) AND (�Ƿ�Ҫ�����2�����ϻ��㹤������ = @Original_�Ƿ�Ҫ�����2�����ϻ��㹤������ OR @Original_�Ƿ�Ҫ�����2�����ϻ��㹤������ IS NULL AND �Ƿ�Ҫ�����2�����ϻ��㹤������ IS NULL) AND ([����      ˾��] = @Original_����______˾�� OR @Original_����______˾�� IS NULL AND [����      ˾��] IS NULL) AND (������� = @Original_������� OR @Original_������� IS NULL AND ������� IS NULL) AND (ְλ���� = @Original_ְλ���� OR @Original_ְλ���� IS NULL AND ְλ���� IS NULL) AND (ְλ��� = @Original_ְλ��� OR @Original_ְλ��� IS NULL AND ְλ��� IS NULL) AND (ְλ��� = @Original_ְλ��� OR @Original_ְλ��� IS NULL AND ְλ��� IS NULL); SELECT TOP 100 ID, ��λ, [����      ˾��], ְλ����, ְλ���, ְλ���, �������, �п�����, רҵ, ѧ��, ������ò, �Ƿ�Ҫ�����2�����ϻ��㹤������, ��������, ��ע FROM ��Ⱥ���� WHERE (ID = @ID)";
			this.sqlUpdateCommand1.Connection = this.cn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��λ", System.Data.SqlDbType.NVarChar, 255, "��λ"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Param2", System.Data.SqlDbType.NVarChar, 255, "����      ˾��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ְλ����", System.Data.SqlDbType.NVarChar, 255, "ְλ����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ְλ���", System.Data.SqlDbType.NVarChar, 255, "ְλ���"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ְλ���", System.Data.SqlDbType.Int, 4, "ְλ���"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�������", System.Data.SqlDbType.NVarChar, 255, "�������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�п�����", System.Data.SqlDbType.Int, 4, "�п�����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@רҵ", System.Data.SqlDbType.NVarChar, 255, "רҵ"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ѧ��", System.Data.SqlDbType.NVarChar, 255, "ѧ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������ò", System.Data.SqlDbType.NVarChar, 255, "������ò"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Ƿ�Ҫ�����2�����ϻ��㹤������", System.Data.SqlDbType.NVarChar, 255, "�Ƿ�Ҫ�����2�����ϻ��㹤������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.NVarChar, 255, "��������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.NVarChar, 255, "��ע"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_רҵ", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "רҵ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��λ", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��λ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ע", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ѧ��", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ѧ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�п�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�п�����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_������ò", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "������ò", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�Ƿ�Ҫ�����2�����ϻ��㹤������", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�Ƿ�Ҫ�����2�����ϻ��㹤������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����______˾��", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����      ˾��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�������", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ְλ����", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ְλ����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ְλ���", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ְλ���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ְλ���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ְλ���", System.Data.DataRowVersion.Original, null));
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
