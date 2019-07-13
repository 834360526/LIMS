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
using System.Windows.Forms;
namespace LIMS
{
	/// <summary>
	/// WebForm4 ��ժҪ˵����
	/// </summary>
	public class WebForm4 : System.Web.UI.Page
	{
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter2;
		protected LIMS.ds ds1;
		protected System.Web.UI.WebControls.RadioButtonList RadioButtonList1;
		protected Infragistics.WebUI.WebDataInput.WebImageButton WebImageButton1;
		protected System.Web.UI.WebControls.Button Button1;
		protected string a;
		private void Page_Load(object sender, System.EventArgs e)
		{
			a="xx";
//			string s=@"http://localhost/LIMS/Work/Certificate/��ſ�/[�־��][QJ2006-000000022]У?׼?֤?����(1).doc";
//			Response.Write(Server.u);
//			ArrayList al=new ArrayList();
//			al.Add(3);
//			al.Add(4);
//			Response.Write(al[0]);

//			sqlDataAdapter2.Fill(ds1.Ȩ��ģ��);
//			sqlDataAdapter1.Fill(ds1.��ɫȨ��);
//			
//			UltraWebGrid1.DataBind();
//			string pp="d:\\2.doc";
//			Editor1.LoadRTF(pp);
			if (!IsPostBack)
				ViewState["a"]=1;
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
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
			this.ds1 = new LIMS.ds();
			((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
			this.RadioButtonList1.SelectedIndexChanged += new System.EventHandler(this.RadioButtonList1_SelectedIndexChanged);
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ID, ��ɫID, Ȩ��ID FROM ��ɫȨ��";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=QDMT;packet size=4096;user id=sa;integrated security=SSPI;data sou" +
				"rce=\".\";persist security info=False;initial catalog=lims";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO ��ɫȨ��(��ɫID, Ȩ��ID) VALUES (@��ɫID, @Ȩ��ID); SELECT ID, ��ɫID, Ȩ��ID FROM ��ɫ" +
				"Ȩ�� WHERE (ID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ɫID", System.Data.SqlDbType.Int, 4, "��ɫID"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ȩ��ID", System.Data.SqlDbType.Int, 4, "Ȩ��ID"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE ��ɫȨ�� SET ��ɫID = @��ɫID, Ȩ��ID = @Ȩ��ID WHERE (ID = @Original_ID) AND (Ȩ��ID = " +
				"@Original_Ȩ��ID) AND (��ɫID = @Original_��ɫID); SELECT ID, ��ɫID, Ȩ��ID FROM ��ɫȨ�� WHE" +
				"RE (ID = @ID)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ɫID", System.Data.SqlDbType.Int, 4, "��ɫID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ȩ��ID", System.Data.SqlDbType.Int, 4, "Ȩ��ID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ȩ��ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ȩ��ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ɫID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ɫID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM ��ɫȨ�� WHERE (ID = @Original_ID) AND (Ȩ��ID = @Original_Ȩ��ID) AND (��ɫID " +
				"= @Original_��ɫID)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ȩ��ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ȩ��ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ɫID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ɫID", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "��ɫȨ��", new System.Data.Common.DataColumnMapping[] {
																																																			  new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																			  new System.Data.Common.DataColumnMapping("��ɫID", "��ɫID"),
																																																			  new System.Data.Common.DataColumnMapping("Ȩ��ID", "Ȩ��ID")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT ID, Ȩ��ģ����, ���, �˵�����, �˵���ĿID, ���ӵ�ַ, ��ע FROM Ȩ��ģ��";
			this.sqlSelectCommand2.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = "INSERT INTO Ȩ��ģ��(Ȩ��ģ����, ���, �˵�����, �˵���ĿID, ���ӵ�ַ, ��ע) VALUES (@Ȩ��ģ����, @���, @�˵�����, @" +
				"�˵���ĿID, @���ӵ�ַ, @��ע); SELECT ID, Ȩ��ģ����, ���, �˵�����, �˵���ĿID, ���ӵ�ַ, ��ע FROM Ȩ��ģ�� WHER" +
				"E (ID = @@IDENTITY)";
			this.sqlInsertCommand2.Connection = this.sqlConnection1;
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ȩ��ģ����", System.Data.SqlDbType.NVarChar, 50, "Ȩ��ģ����"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Int, 4, "���"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�˵�����", System.Data.SqlDbType.Int, 4, "�˵�����"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�˵���ĿID", System.Data.SqlDbType.Int, 4, "�˵���ĿID"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ӵ�ַ", System.Data.SqlDbType.NVarChar, 1000, "���ӵ�ַ"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.NVarChar, 1073741823, "��ע"));
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = @"UPDATE Ȩ��ģ�� SET Ȩ��ģ���� = @Ȩ��ģ����, ��� = @���, �˵����� = @�˵�����, �˵���ĿID = @�˵���ĿID, ���ӵ�ַ = @���ӵ�ַ, ��ע = @��ע WHERE (ID = @Original_ID) AND (Ȩ��ģ���� = @Original_Ȩ��ģ����) AND (��� = @Original_���) AND (�˵����� = @Original_�˵����� OR @Original_�˵����� IS NULL AND �˵����� IS NULL) AND (�˵���ĿID = @Original_�˵���ĿID OR @Original_�˵���ĿID IS NULL AND �˵���ĿID IS NULL) AND (���ӵ�ַ = @Original_���ӵ�ַ OR @Original_���ӵ�ַ IS NULL AND ���ӵ�ַ IS NULL); SELECT ID, Ȩ��ģ����, ���, �˵�����, �˵���ĿID, ���ӵ�ַ, ��ע FROM Ȩ��ģ�� WHERE (ID = @ID)";
			this.sqlUpdateCommand2.Connection = this.sqlConnection1;
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ȩ��ģ����", System.Data.SqlDbType.NVarChar, 50, "Ȩ��ģ����"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Int, 4, "���"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�˵�����", System.Data.SqlDbType.Int, 4, "�˵�����"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�˵���ĿID", System.Data.SqlDbType.Int, 4, "�˵���ĿID"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ӵ�ַ", System.Data.SqlDbType.NVarChar, 1000, "���ӵ�ַ"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.NVarChar, 1073741823, "��ע"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ȩ��ģ����", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ȩ��ģ����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�˵�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�˵�����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�˵���ĿID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�˵���ĿID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ӵ�ַ", System.Data.SqlDbType.NVarChar, 1000, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���ӵ�ַ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = @"DELETE FROM Ȩ��ģ�� WHERE (ID = @Original_ID) AND (Ȩ��ģ���� = @Original_Ȩ��ģ����) AND (��� = @Original_���) AND (�˵����� = @Original_�˵����� OR @Original_�˵����� IS NULL AND �˵����� IS NULL) AND (�˵���ĿID = @Original_�˵���ĿID OR @Original_�˵���ĿID IS NULL AND �˵���ĿID IS NULL) AND (���ӵ�ַ = @Original_���ӵ�ַ OR @Original_���ӵ�ַ IS NULL AND ���ӵ�ַ IS NULL)";
			this.sqlDeleteCommand2.Connection = this.sqlConnection1;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ȩ��ģ����", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ȩ��ģ����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�˵�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�˵�����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�˵���ĿID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�˵���ĿID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ӵ�ַ", System.Data.SqlDbType.NVarChar, 1000, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���ӵ�ַ", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter2
			// 
			this.sqlDataAdapter2.DeleteCommand = this.sqlDeleteCommand2;
			this.sqlDataAdapter2.InsertCommand = this.sqlInsertCommand2;
			this.sqlDataAdapter2.SelectCommand = this.sqlSelectCommand2;
			this.sqlDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "Ȩ��ģ��", new System.Data.Common.DataColumnMapping[] {
																																																			  new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																			  new System.Data.Common.DataColumnMapping("Ȩ��ģ����", "Ȩ��ģ����"),
																																																			  new System.Data.Common.DataColumnMapping("���", "���"),
																																																			  new System.Data.Common.DataColumnMapping("�˵�����", "�˵�����"),
																																																			  new System.Data.Common.DataColumnMapping("�˵���ĿID", "�˵���ĿID"),
																																																			  new System.Data.Common.DataColumnMapping("���ӵ�ַ", "���ӵ�ַ"),
																																																			  new System.Data.Common.DataColumnMapping("��ע", "��ע")})});
			this.sqlDataAdapter2.UpdateCommand = this.sqlUpdateCommand2;
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

		private void RadioButtonList1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Response.Write(RadioButtonList1.SelectedValue);
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{

			int aa=Convert.ToInt32(ViewState["a"]);
			aa++;
			ViewState["a"]=aa;
			Response.Write(ViewState["a"]);
			
		}
	}
}
