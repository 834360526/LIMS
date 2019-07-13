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
	/// WebForm1 ��ժҪ˵����
	/// </summary>
	public class WebForm1 : System.Web.UI.Page
	{
		protected Infragistics.WebUI.UltraWebNavigator.UltraWebTree UltraWebTree1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection cn;
		protected System.Data.SqlClient.SqlDataAdapter da;
		protected LIMS.ds ds1;
		protected Infragistics.WebUI.UltraWebListbar.UltraWebListbar UltraWebListbar1;
		protected System.Web.UI.WebControls.Button Button1;
		protected Infragistics.WebUI.WebSchedule.WebDateChooser WebDateChooser1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
//			Dallas.Core.Menu menu=new Dallas.Core.Menu();
//			uwg.DataSource=menu.ds;
//			uwg.DataBind();
//			string [][] a=new string[3];
//			ArrayList al=new ArrayList();
//			al.Add("ss");
//			al.Add("bb");
//			Response.Write(al.Contains("dd")+"<br>"+al.Contains("ss")+"<Br>");
//			Dallas.Core.Tool t=new Dallas.Core.Tool();
//			t.
//			da.Fill(ds1);
//			Dallas.Core.Work work=new Dallas.Core.Work();
//			Response.Write(work.GetSN(true));
//			Dallas.Core.Work df=new Dallas.Core.Work();
//			Response.Write(work.GetSN(false));

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
			this.sqlSelectCommand1.CommandText = "SELECT ID, ��λ, [����      ˾��], ְλ����, ְλ���, ְλ���, �������, �п�����, רҵ, ѧ��, ������ò, �Ƿ�Ҫ�����2��" +
				"���ϻ��㹤������, ��������, ��ע FROM ��Ⱥ����";
			this.sqlSelectCommand1.Connection = this.cn;
			// 
			// cn
			// 
			this.cn.ConnectionString = "workstation id=QDMT;packet size=4096;integrated security=SSPI;data source=\".\";per" +
				"sist security info=False;initial catalog=official";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO ��Ⱥ����(��λ, [����      ˾��], ְλ����, ְλ���, ְλ���, �������, �п�����, רҵ, ѧ��, ������ò, �Ƿ�Ҫ�����2�����ϻ��㹤������, ��������, ��ע) VALUES (@��λ, @Param1, @ְλ����, @ְλ���, @ְλ���, @�������, @�п�����, @רҵ, @ѧ��, @������ò, @�Ƿ�Ҫ�����2�����ϻ��㹤������, @��������, @��ע); SELECT ID, ��λ, [����      ˾��], ְλ����, ְλ���, ְλ���, �������, �п�����, רҵ, ѧ��, ������ò, �Ƿ�Ҫ�����2�����ϻ��㹤������, ��������, ��ע FROM ��Ⱥ���� WHERE (ID = @@IDENTITY)";
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
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE ��Ⱥ���� SET ��λ = @��λ, [����      ˾��] = @Param2, ְλ���� = @ְλ����, ְλ��� = @ְλ���, ְλ��� = @ְλ���, ������� = @�������, �п����� = @�п�����, רҵ = @רҵ, ѧ�� = @ѧ��, ������ò = @������ò, �Ƿ�Ҫ�����2�����ϻ��㹤������ = @�Ƿ�Ҫ�����2�����ϻ��㹤������, �������� = @��������, ��ע = @��ע WHERE (ID = @Original_ID) AND (רҵ = @Original_רҵ OR @Original_רҵ IS NULL AND רҵ IS NULL) AND (�������� = @Original_�������� OR @Original_�������� IS NULL AND �������� IS NULL) AND (��λ = @Original_��λ OR @Original_��λ IS NULL AND ��λ IS NULL) AND (��ע = @Original_��ע OR @Original_��ע IS NULL AND ��ע IS NULL) AND (ѧ�� = @Original_ѧ�� OR @Original_ѧ�� IS NULL AND ѧ�� IS NULL) AND (�п����� = @Original_�п����� OR @Original_�п����� IS NULL AND �п����� IS NULL) AND (������ò = @Original_������ò OR @Original_������ò IS NULL AND ������ò IS NULL) AND (�Ƿ�Ҫ�����2�����ϻ��㹤������ = @Original_�Ƿ�Ҫ�����2�����ϻ��㹤������ OR @Original_�Ƿ�Ҫ�����2�����ϻ��㹤������ IS NULL AND �Ƿ�Ҫ�����2�����ϻ��㹤������ IS NULL) AND ([����      ˾��] = @Original_����______˾�� OR @Original_����______˾�� IS NULL AND [����      ˾��] IS NULL) AND (������� = @Original_������� OR @Original_������� IS NULL AND ������� IS NULL) AND (ְλ���� = @Original_ְλ���� OR @Original_ְλ���� IS NULL AND ְλ���� IS NULL) AND (ְλ��� = @Original_ְλ��� OR @Original_ְλ��� IS NULL AND ְλ��� IS NULL) AND (ְλ��� = @Original_ְλ��� OR @Original_ְλ��� IS NULL AND ְλ��� IS NULL); SELECT ID, ��λ, [����      ˾��], ְλ����, ְλ���, ְλ���, �������, �п�����, רҵ, ѧ��, ������ò, �Ƿ�Ҫ�����2�����ϻ��㹤������, ��������, ��ע FROM ��Ⱥ���� WHERE (ID = @ID)";
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
			// ds1
			// 
			this.ds1.DataSetName = "ds";
			this.ds1.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			
		}
	}
}
