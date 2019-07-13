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
using Dallas.Core;

namespace LIMS.Work
{
	/// <summary>
	/// SelectKeepbookItem ��ժҪ˵����
	/// </summary>
	public class SelectKeepbookItem : BaseForm
	{
		protected System.Data.SqlClient.SqlConnection cn;
		protected System.Data.SqlClient.SqlDataAdapter daFresh;
		protected LIMS.Work.KeepBook keepBook1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Refresh;
		protected Infragistics.WebUI.WebCombo.WebCombo Com;
		protected System.Data.SqlClient.SqlDataAdapter daCom;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected LIMS.Work.Work work1;
		protected Infragistics.WebUI.WebDataInput.WebNumericEdit ProxySN;
		protected Infragistics.WebUI.WebDataInput.WebImageButton btQuery;
		protected System.Web.UI.WebControls.Label Err;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Submit;
		protected Infragistics.WebUI.UltraWebGrid.UltraWebGrid FreshData;
		protected Tool tool;

		private void Page_Load(object sender, System.EventArgs e)
		{
			cn.ConnectionString=cnStr;

			tool=new Tool();

			if (!IsPostBack)
			{
//				if (Session["KeepbookType"]==null)
//					Response.Redirect("OthersKeepBooks.aspx");

				daFresh.Fill(keepBook1.��У����);

				FreshData.DataBind();

				daCom.Fill(work1.�ͼ쵥λ);

				Com.DataBind();
			}
			
		}

		public override void ClearSession()
		{
			base.ClearSession ();
			Session["KeepbookType"]=null;
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
			this.daFresh = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.keepBook1 = new LIMS.Work.KeepBook();
			this.daCom = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.work1 = new LIMS.Work.Work();
			((System.ComponentModel.ISupportInitialize)(this.keepBook1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.work1)).BeginInit();
			this.btQuery.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.btQuery_Click);
			this.Refresh.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.Refresh_Click);
			this.Submit.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.Submit_Click);
			// 
			// cn
			// 
			this.cn.ConnectionString = "workstation id=QDMT;packet size=4096;user id=sa;integrated security=SSPI;data sou" +
				"rce=\".\";persist security info=False;initial catalog=lims";
			// 
			// daFresh
			// 
			this.daFresh.InsertCommand = this.sqlInsertCommand1;
			this.daFresh.SelectCommand = this.sqlSelectCommand1;
			this.daFresh.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							  new System.Data.Common.DataTableMapping("Table", "��У����", new System.Data.Common.DataColumnMapping[] {
																																																	  new System.Data.Common.DataColumnMapping("���", "���"),
																																																	  new System.Data.Common.DataColumnMapping("��������", "��������"),
																																																	  new System.Data.Common.DataColumnMapping("��������", "��������"),
																																																	  new System.Data.Common.DataColumnMapping("�ͺŹ��", "�ͺŹ��"),
																																																	  new System.Data.Common.DataColumnMapping("�������", "�������"),
																																																	  new System.Data.Common.DataColumnMapping("�ͼ쵥λ", "�ͼ쵥λ"),
																																																	  new System.Data.Common.DataColumnMapping("�춨����", "�춨����"),
																																																	  new System.Data.Common.DataColumnMapping("��У���", "��У���"),
																																																	  new System.Data.Common.DataColumnMapping("�ͼ�����", "�ͼ�����"),
																																																	  new System.Data.Common.DataColumnMapping("�춨����", "�춨����"),
																																																	  new System.Data.Common.DataColumnMapping("У׼����", "У׼����"),
																																																	  new System.Data.Common.DataColumnMapping("�������", "�������"),
																																																	  new System.Data.Common.DataColumnMapping("�������", "�������"),
																																																	  new System.Data.Common.DataColumnMapping("Ӧ������", "Ӧ������"),
																																																	  new System.Data.Common.DataColumnMapping("ʵ������", "ʵ������"),
																																																	  new System.Data.Common.DataColumnMapping("��������", "��������"),
																																																	  new System.Data.Common.DataColumnMapping("�������", "�������"),
																																																	  new System.Data.Common.DataColumnMapping("��У��ʽ", "��У��ʽ"),
																																																	  new System.Data.Common.DataColumnMapping("��ע", "��ע"),
																																																	  new System.Data.Common.DataColumnMapping("�ͼ쵥λ��ַ", "�ͼ쵥λ��ַ"),
																																																	  new System.Data.Common.DataColumnMapping("��������", "��������"),
																																																	  new System.Data.Common.DataColumnMapping("ί����", "ί����"),
																																																	  new System.Data.Common.DataColumnMapping("�绰", "�绰"),
																																																	  new System.Data.Common.DataColumnMapping("�����", "�����")})});
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO ��У����(���, ��������, ��������, �ͺŹ��, �������, �ͼ쵥λ, �춨����, ��У���, �ͼ�����, �춨����, У׼����, �������, �������, Ӧ������, ʵ������, ��������, �������, ��У��ʽ, ��ע, �ͼ쵥λ��ַ, ��������, ί����, �绰, �����) VALUES (@���, @��������, @��������, @�ͺŹ��, @�������, @�ͼ쵥λ, @�춨����, @��У���, @�ͼ�����, @�춨����, @У׼����, @�������, @�������, @Ӧ������, @ʵ������, @��������, @�������, @��У��ʽ, @��ע, @�ͼ쵥λ��ַ, @��������, @ί����, @�绰, @�����); SELECT ���, ��������, ��������, �ͺŹ��, �������, �ͼ쵥λ, �춨����, ��У���, �ͼ�����, �춨����, У׼����, �������, �������, Ӧ������, ʵ������, ��������, �������, ��У��ʽ, ��ע, �ͼ쵥λ��ַ, ��������, ί����, �绰, ����� FROM ��У����";
			this.sqlInsertCommand1.Connection = this.cn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.NVarChar, 50, "���"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.NVarChar, 255, "��������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.Int, 4, "��������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͺŹ��", System.Data.SqlDbType.NVarChar, 255, "�ͺŹ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�������", System.Data.SqlDbType.NVarChar, 255, "�������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͼ쵥λ", System.Data.SqlDbType.NVarChar, 255, "�ͼ쵥λ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�춨����", System.Data.SqlDbType.NVarChar, 50, "�춨����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��У���", System.Data.SqlDbType.NVarChar, 50, "��У���"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͼ�����", System.Data.SqlDbType.DateTime, 8, "�ͼ�����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�춨����", System.Data.SqlDbType.Money, 8, "�춨����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@У׼����", System.Data.SqlDbType.Money, 8, "У׼����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�������", System.Data.SqlDbType.Money, 8, "�������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�������", System.Data.SqlDbType.Money, 8, "�������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӧ������", System.Data.SqlDbType.Money, 8, "Ӧ������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ʵ������", System.Data.SqlDbType.Money, 8, "ʵ������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.DateTime, 8, "��������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�������", System.Data.SqlDbType.DateTime, 8, "�������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��У��ʽ", System.Data.SqlDbType.NVarChar, 20, "��У��ʽ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.NVarChar, 1073741823, "��ע"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͼ쵥λ��ַ", System.Data.SqlDbType.NVarChar, 255, "�ͼ쵥λ��ַ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.NVarChar, 20, "��������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ί����", System.Data.SqlDbType.NVarChar, 50, "ί����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�绰", System.Data.SqlDbType.NVarChar, 30, "�绰"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�����", System.Data.SqlDbType.NVarChar, 30, "�����"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT top 20 ���, ��������, ��������, �ͺŹ��, �������, �ͼ쵥λ, �춨����, ��У���, �ͼ�����, �춨����, У׼����, �����" +
				"��, �������, Ӧ������, ʵ������, ��������, �������, ��У��ʽ, ��ע, �ͼ쵥λ��ַ, ��������, ί����, �绰, ����� FROM ��У���� " +
				"where ��� like \'QJ%\'order by ��� desc";
			this.sqlSelectCommand1.Connection = this.cn;
			// 
			// keepBook1
			// 
			this.keepBook1.DataSetName = "KeepBook";
			this.keepBook1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// daCom
			// 
			this.daCom.DeleteCommand = this.sqlDeleteCommand2;
			this.daCom.InsertCommand = this.sqlInsertCommand2;
			this.daCom.SelectCommand = this.sqlSelectCommand2;
			this.daCom.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							new System.Data.Common.DataTableMapping("Table", "�ͼ쵥λ", new System.Data.Common.DataColumnMapping[] {
																																																	new System.Data.Common.DataColumnMapping("��λ����", "��λ����"),
																																																	new System.Data.Common.DataColumnMapping("��ַ", "��ַ"),
																																																	new System.Data.Common.DataColumnMapping("�绰", "�绰"),
																																																	new System.Data.Common.DataColumnMapping("�ʱ�", "�ʱ�"),
																																																	new System.Data.Common.DataColumnMapping("�����", "�����"),
																																																	new System.Data.Common.DataColumnMapping("��ϵ��", "��ϵ��"),
																																																	new System.Data.Common.DataColumnMapping("ID", "ID")})});
			this.daCom.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = @"DELETE FROM �ͼ쵥λ WHERE (ID = @Original_ID) AND (����� = @Original_����� OR @Original_����� IS NULL AND ����� IS NULL) AND (��λ���� = @Original_��λ���� OR @Original_��λ���� IS NULL AND ��λ���� IS NULL) AND (��ַ = @Original_��ַ OR @Original_��ַ IS NULL AND ��ַ IS NULL) AND (�绰 = @Original_�绰 OR @Original_�绰 IS NULL AND �绰 IS NULL) AND (��ϵ�� = @Original_��ϵ�� OR @Original_��ϵ�� IS NULL AND ��ϵ�� IS NULL) AND (�ʱ� = @Original_�ʱ� OR @Original_�ʱ� IS NULL AND �ʱ� IS NULL)";
			this.sqlDeleteCommand2.Connection = this.cn;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�����", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��λ����", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��λ����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ַ", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ַ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�绰", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�绰", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ϵ��", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ϵ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ʱ�", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ʱ�", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = "INSERT INTO �ͼ쵥λ(��λ����, ��ַ, �绰, �ʱ�, �����, ��ϵ��) VALUES (@��λ����, @��ַ, @�绰, @�ʱ�, @�����, " +
				"@��ϵ��); SELECT ��λ����, ��ַ, �绰, �ʱ�, �����, ��ϵ��, ID FROM �ͼ쵥λ WHERE (ID = @@IDENTITY)";
			this.sqlInsertCommand2.Connection = this.cn;
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��λ����", System.Data.SqlDbType.NVarChar, 255, "��λ����"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ַ", System.Data.SqlDbType.NVarChar, 255, "��ַ"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�绰", System.Data.SqlDbType.NVarChar, 50, "�绰"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ʱ�", System.Data.SqlDbType.NVarChar, 20, "�ʱ�"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�����", System.Data.SqlDbType.NVarChar, 20, "�����"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ϵ��", System.Data.SqlDbType.NVarChar, 50, "��ϵ��"));
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT ��λ����, ��ַ, �绰, �ʱ�, �����, ��ϵ��, ID FROM �ͼ쵥λ";
			this.sqlSelectCommand2.Connection = this.cn;
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = @"UPDATE �ͼ쵥λ SET ��λ���� = @��λ����, ��ַ = @��ַ, �绰 = @�绰, �ʱ� = @�ʱ�, ����� = @�����, ��ϵ�� = @��ϵ�� WHERE (ID = @Original_ID) AND (����� = @Original_����� OR @Original_����� IS NULL AND ����� IS NULL) AND (��λ���� = @Original_��λ���� OR @Original_��λ���� IS NULL AND ��λ���� IS NULL) AND (��ַ = @Original_��ַ OR @Original_��ַ IS NULL AND ��ַ IS NULL) AND (�绰 = @Original_�绰 OR @Original_�绰 IS NULL AND �绰 IS NULL) AND (��ϵ�� = @Original_��ϵ�� OR @Original_��ϵ�� IS NULL AND ��ϵ�� IS NULL) AND (�ʱ� = @Original_�ʱ� OR @Original_�ʱ� IS NULL AND �ʱ� IS NULL); SELECT ��λ����, ��ַ, �绰, �ʱ�, �����, ��ϵ��, ID FROM �ͼ쵥λ WHERE (ID = @ID)";
			this.sqlUpdateCommand2.Connection = this.cn;
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��λ����", System.Data.SqlDbType.NVarChar, 255, "��λ����"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ַ", System.Data.SqlDbType.NVarChar, 255, "��ַ"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�绰", System.Data.SqlDbType.NVarChar, 50, "�绰"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ʱ�", System.Data.SqlDbType.NVarChar, 20, "�ʱ�"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�����", System.Data.SqlDbType.NVarChar, 20, "�����"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ϵ��", System.Data.SqlDbType.NVarChar, 50, "��ϵ��"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�����", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��λ����", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��λ����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ַ", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ַ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�绰", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�绰", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ϵ��", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ϵ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ʱ�", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ʱ�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			// 
			// work1
			// 
			this.work1.DataSetName = "Work";
			this.work1.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.keepBook1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.work1)).EndInit();

		}
		#endregion


		private void Refresh_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			daFresh.Fill(keepBook1.��У����);

			FreshData.DataBind();
		}

		private void btQuery_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			if (Tool.IsNull(Com.DataValue) && Tool.IsNull(ProxySN.Text))
			{
				Err.Text="��δѡ���ѯ����";
				return;
			}
			
			daFresh.SelectCommand.CommandText="SELECT ���, ��������, ��������, �ͺŹ��, �������, �ͼ쵥λ, �춨����, ��У���, �ͼ�����, �춨����, У׼����, �������, �������, Ӧ������, ʵ������, ��������, �������, ��У��ʽ, ��ע, �ͼ쵥λ��ַ, ��������, ί����, �绰, ����� FROM ��У���� where ";

			if (!Tool.IsNull(Com.DataValue))
				daFresh.SelectCommand.CommandText+="�ͼ쵥λ='"+Com.DataValue+"' and ";
			
			if (!Tool.IsNull(ProxySN.Text))
				daFresh.SelectCommand.CommandText+="ί�е���="+ProxySN.Text;

			//����п��ܶ��һ��and
			if (daFresh.SelectCommand.CommandText.Substring(daFresh.SelectCommand.CommandText.Length-4-1,4).Trim()=="and")
				daFresh.SelectCommand.CommandText=daFresh.SelectCommand.CommandText.TrimEnd().Remove(daFresh.SelectCommand.CommandText.Length-3-1,3);

			daFresh.Fill(keepBook1.��У����);
			FreshData.DataBind();

		}

		private void Submit_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			ArrayList selected=tool.GetSelected(FreshData,0,1);
			foreach (String s in selected)
				Response.Write(s+"<br>");
		}

	}
}
