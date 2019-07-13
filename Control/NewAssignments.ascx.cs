namespace LIMS.Control
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	/// <summary>
	///		NewAssignments ��ժҪ˵����
	/// </summary>
	public class NewAssignments : System.Web.UI.UserControl
	{
		protected Infragistics.WebUI.UltraWebGrid.UltraWebGrid UndealGrid;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Accept;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Cancel;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlConnection cn;
		protected LIMS.Work.Work work1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlDataAdapter daAssignment;
		protected System.Web.UI.WebControls.Label UndealError;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
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
		///		�����֧������ķ��� - ��Ҫʹ�ô���༭��
		///		�޸Ĵ˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.cn = new System.Data.SqlClient.SqlConnection();
			this.work1 = new LIMS.Work.Work();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.daAssignment = new System.Data.SqlClient.SqlDataAdapter();
			((System.ComponentModel.ISupportInitialize)(this.work1)).BeginInit();
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = @"INSERT INTO ��У����(���, ��������, ��������, �ͺŹ��, �������, �ͼ쵥λ, �ͼ쵥λ��ַ, ��������, ί����, �绰, �����, ��У���, �ͼ�����, ��ע, ��У��ʽ, �춨����, У׼����, �������, �������, Ӧ������) VALUES (@���, @��������, @��������, @�ͺŹ��, @�������, @�ͼ쵥λ, @�ͼ쵥λ��ַ, @��������, @ί����, @�绰, @�����, @��У���, @�ͼ�����, @��ע, @��У��ʽ, @�춨����, @У׼����, @�������, @�������, @Ӧ������); SELECT ���, ��������, ��������, �ͺŹ��, �������, �ͼ쵥λ, �ͼ쵥λ��ַ, ��������, ί����, �绰, �����, ��У���, �ͼ�����, ��ע, ��У��ʽ, �춨����, У׼����, �������, �������, Ӧ������ FROM ��У����";
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.NVarChar, 50, "���"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.NVarChar, 255, "��������"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.Int, 4, "��������"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͺŹ��", System.Data.SqlDbType.NVarChar, 255, "�ͺŹ��"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�������", System.Data.SqlDbType.NVarChar, 255, "�������"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͼ쵥λ", System.Data.SqlDbType.NVarChar, 255, "�ͼ쵥λ"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͼ쵥λ��ַ", System.Data.SqlDbType.NVarChar, 255, "�ͼ쵥λ��ַ"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.NVarChar, 20, "��������"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ί����", System.Data.SqlDbType.NVarChar, 50, "ί����"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�绰", System.Data.SqlDbType.NVarChar, 30, "�绰"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�����", System.Data.SqlDbType.NVarChar, 30, "�����"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��У���", System.Data.SqlDbType.NVarChar, 50, "��У���"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͼ�����", System.Data.SqlDbType.DateTime, 8, "�ͼ�����"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.NVarChar, 1073741823, "��ע"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��У��ʽ", System.Data.SqlDbType.TinyInt, 1, "��У��ʽ"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�춨����", System.Data.SqlDbType.Money, 8, "�춨����"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@У׼����", System.Data.SqlDbType.Money, 8, "У׼����"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�������", System.Data.SqlDbType.Money, 8, "�������"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�������", System.Data.SqlDbType.Money, 8, "�������"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӧ������", System.Data.SqlDbType.Money, 8, "Ӧ������"));
			// 
			// cn
			// 
			this.cn.ConnectionString = "workstation id=QDMT;packet size=4096;user id=sa;integrated security=SSPI;data sou" +
				"rce=\".\";persist security info=False;initial catalog=lims";
			// 
			// work1
			// 
			this.work1.DataSetName = "Work";
			this.work1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT ���, ��������, ��������, �ͺŹ��, �������, �ͼ쵥λ, �ͼ쵥λ��ַ, ��������, ί����, �绰, �����, ��У���, �ͼ�����, " +
				"��ע, ��У��ʽ, �춨����, У׼����, �������, �������, Ӧ������ FROM ��У����";
			this.sqlSelectCommand2.Connection = this.cn;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO ��У����(���, ��������, ��������, �ͺŹ��, �������, �ͼ쵥λ, �ͼ쵥λ��ַ, ��������, ί����, �绰, �����, ��У���, �ͼ�����, ��ע, ��У��ʽ) VALUES (@���, @��������, @��������, @�ͺŹ��, @�������, @�ͼ쵥λ, @�ͼ쵥λ��ַ, @��������, @ί����, @�绰, @�����, @��У���, @�ͼ�����, @��ע, @��У��ʽ); SELECT ���, ��������, ��������, �ͺŹ��, �������, �ͼ쵥λ, �ͼ쵥λ��ַ, ��������, ί����, �绰, �����, ��У���, �ͼ�����, ��ע, ��У��ʽ FROM ��У����";
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.NVarChar, 50, "���"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.NVarChar, 255, "��������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.Int, 4, "��������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͺŹ��", System.Data.SqlDbType.NVarChar, 255, "�ͺŹ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�������", System.Data.SqlDbType.NVarChar, 255, "�������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͼ쵥λ", System.Data.SqlDbType.NVarChar, 255, "�ͼ쵥λ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͼ쵥λ��ַ", System.Data.SqlDbType.NVarChar, 255, "�ͼ쵥λ��ַ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.NVarChar, 20, "��������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ί����", System.Data.SqlDbType.NVarChar, 50, "ί����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�绰", System.Data.SqlDbType.NVarChar, 30, "�绰"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�����", System.Data.SqlDbType.NVarChar, 30, "�����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��У���", System.Data.SqlDbType.NVarChar, 50, "��У���"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͼ�����", System.Data.SqlDbType.DateTime, 8, "�ͼ�����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.NVarChar, 1073741823, "��ע"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��У��ʽ", System.Data.SqlDbType.TinyInt, 1, "��У��ʽ"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ���, ��������, ��������, �ͺŹ��, �������, �ͼ쵥λ, �ͼ쵥λ��ַ, ��������, ί����, �绰, �����, �ͼ�����, ��ע, ��У" +
				"��ʽ FROM ��У����";
			this.sqlSelectCommand1.Connection = this.cn;
			// 
			// daAssignment
			// 
			this.daAssignment.InsertCommand = this.sqlInsertCommand1;
			this.daAssignment.SelectCommand = this.sqlSelectCommand1;
			this.daAssignment.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								   new System.Data.Common.DataTableMapping("Table", "��У����", new System.Data.Common.DataColumnMapping[] {
																																																		   new System.Data.Common.DataColumnMapping("���", "���"),
																																																		   new System.Data.Common.DataColumnMapping("��������", "��������"),
																																																		   new System.Data.Common.DataColumnMapping("��������", "��������"),
																																																		   new System.Data.Common.DataColumnMapping("�ͺŹ��", "�ͺŹ��"),
																																																		   new System.Data.Common.DataColumnMapping("�������", "�������"),
																																																		   new System.Data.Common.DataColumnMapping("�ͼ쵥λ", "�ͼ쵥λ"),
																																																		   new System.Data.Common.DataColumnMapping("�ͼ쵥λ��ַ", "�ͼ쵥λ��ַ"),
																																																		   new System.Data.Common.DataColumnMapping("��������", "��������"),
																																																		   new System.Data.Common.DataColumnMapping("ί����", "ί����"),
																																																		   new System.Data.Common.DataColumnMapping("�绰", "�绰"),
																																																		   new System.Data.Common.DataColumnMapping("�����", "�����"),
																																																		   new System.Data.Common.DataColumnMapping("��У���", "��У���"),
																																																		   new System.Data.Common.DataColumnMapping("�ͼ�����", "�ͼ�����"),
																																																		   new System.Data.Common.DataColumnMapping("��ע", "��ע"),
																																																		   new System.Data.Common.DataColumnMapping("��У��ʽ", "��У��ʽ")})});
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.work1)).EndInit();

		}
		#endregion
	}
}
