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

namespace LIMS.Message
{
	/// <summary>
	/// Inbox ��ժҪ˵����
	/// </summary>
	public class Inbox : BaseForm
	{
		protected System.Data.SqlClient.SqlConnection cn;
		protected System.Data.SqlClient.SqlDataAdapter daInbox;
		protected Infragistics.WebUI.UltraWebGrid.UltraWebGrid Message;
		protected LIMS.Message.dsMessage dsMessage1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Del;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			if (!IsPostBack)
				BindGrid();
		}

		private void BindGrid()
		{
			//������Ϣ�����桢������Ϣ
			daInbox.SelectCommand.CommandText+=" where (��Ϣ����=2 and �ռ���ID="+user.ID+") or (��Ϣ����=4) or (��Ϣ����=3 and �ռ���ID="+user.OfficeID+") ORDER BY ����ʱ�� desc";
			daInbox.Fill(dsMessage1.�ռ���);
			
//			//����ռ�����û���µ���Ϣ�������Grid�ĸ߶�
//			if (dsMessage1.�ռ���.Rows.Count<1)
//				Message.Height=45;
			Message.DataBind();
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
			this.daInbox = new System.Data.SqlClient.SqlDataAdapter();
			this.dsMessage1 = new LIMS.Message.dsMessage();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.dsMessage1)).BeginInit();
			this.Message.InitializeRow += new Infragistics.WebUI.UltraWebGrid.InitializeRowEventHandler(this.Message_InitializeRow);
			this.Del.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.Del_Click);
			// 
			// cn
			// 
			this.cn.ConnectionString = "workstation id=QDMT;packet size=4096;user id=sa;integrated security=SSPI;data sou" +
				"rce=\".\";persist security info=False;initial catalog=lims";
			// 
			// daInbox
			// 
			this.daInbox.InsertCommand = this.sqlInsertCommand1;
			this.daInbox.SelectCommand = this.sqlSelectCommand1;
			this.daInbox.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							  new System.Data.Common.DataTableMapping("Table", "�ռ���", new System.Data.Common.DataColumnMapping[] {
																																																	 new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																	 new System.Data.Common.DataColumnMapping("����", "����"),
																																																	 new System.Data.Common.DataColumnMapping("����", "����"),
																																																	 new System.Data.Common.DataColumnMapping("������", "������"),
																																																	 new System.Data.Common.DataColumnMapping("����", "����"),
																																																	 new System.Data.Common.DataColumnMapping("�ռ���ID", "�ռ���ID")})});
			// 
			// dsMessage1
			// 
			this.dsMessage1.DataSetName = "dsMessage";
			this.dsMessage1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ID, ����, ����ʱ�� AS ����, ������, ����, �ռ���ID FROM �ռ���";
			this.sqlSelectCommand1.Connection = this.cn;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO �ռ���(����, ����ʱ��, ������, ����, �ռ���ID) VALUES (@����, @����ʱ��, @������, @����, @�ռ���ID);" +
				" SELECT ID, ����, ����ʱ�� AS ����, ������, ����, �ռ���ID FROM �ռ���";
			this.sqlInsertCommand1.Connection = this.cn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 1073741823, "����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 8, "����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������", System.Data.SqlDbType.NVarChar, 10, "������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Bit, 1, "����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ռ���ID", System.Data.SqlDbType.Int, 4, "�ռ���ID"));
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsMessage1)).EndInit();

		}
		#endregion

		private void Message_InitializeRow(object sender, Infragistics.WebUI.UltraWebGrid.RowEventArgs e)
		{
			if (!Convert.ToBoolean(e.Row.Cells[6].Value.ToString()))
			{

				e.Row.Cells[2].Text=@"<a href=""ShowMessage.aspx?ID="+e.Row.Cells[1].Text+@"""><font color=""red"">"+e.Row.Cells[2].Text+"</font></a>";
				//				e.Row.Cells[2].TargetURL=e.Row.Cells[2].Text;
			}
			else
			{
				e.Row.Cells[2].Text=@"<a href=""ShowMessage.aspx?ID="+e.Row.Cells[1].Text+@""">"+e.Row.Cells[2].Text+"</a>";
			}
		}

		private void Del_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			Dallas.Core.Tool tool=new Dallas.Core.Tool();
			Dallas.Core.Message msg=new Dallas.Core.Message();
			msg.DelMessage(tool.GetSelected(Message,0,1));
			BindGrid();
		}
	}
}
