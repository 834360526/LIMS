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
using LIMS.Base;

namespace LIMS.Message
{
	/// <summary>
	/// Outbox ��ժҪ˵����
	/// </summary>
	public class Outbox : BaseForm
	{
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected Infragistics.WebUI.UltraWebTab.UltraWebTab Addressee;
		protected System.Web.UI.WebControls.TextBox Content;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Send;
		protected System.Web.UI.WebControls.Label Err;
		protected System.Web.UI.HtmlControls.HtmlInputFile File1;
		protected System.Web.UI.WebControls.RadioButtonList MessageType;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit Title;
		protected Dallas.Core.Message msg;
		private void Page_Load(object sender, System.EventArgs e)
		{
			msg=new Dallas.Core.Message();
			if (!IsPostBack)
			{
				//Ĭ������Ϊ���ˣ����Կ���tab���ɼ�
				Addressee.Tabs[1].Visible=false;

				//���û�з��������Ȩ�������Ϣ������ɾȥ����ѡ��
				if (!user.HasPermission("��������"))
					MessageType.Items.RemoveAt(2);
			}
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
			this.MessageType.SelectedIndexChanged += new System.EventHandler(this.MessageType_SelectedIndexChanged);
			this.Send.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.Send_Click);
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ID, ��Ϣ����, ���� FROM ��Ϣ����";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=QDMT;packet size=4096;user id=sa;integrated security=SSPI;data sou" +
				"rce=\".\";persist security info=False;initial catalog=lims";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO ��Ϣ����(��Ϣ����, ����) VALUES (@��Ϣ����, @����); SELECT ID, ��Ϣ����, ���� FROM ��Ϣ���� WHE" +
				"RE (ID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��Ϣ����", System.Data.SqlDbType.NVarChar, 50, "��Ϣ����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 1073741823, "����"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE ��Ϣ���� SET ��Ϣ���� = @��Ϣ����, ���� = @���� WHERE (ID = @Original_ID) AND (��Ϣ���� = @Ori" +
				"ginal_��Ϣ���� OR @Original_��Ϣ���� IS NULL AND ��Ϣ���� IS NULL); SELECT ID, ��Ϣ����, ���� FROM" +
				" ��Ϣ���� WHERE (ID = @ID)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��Ϣ����", System.Data.SqlDbType.NVarChar, 50, "��Ϣ����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 1073741823, "����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��Ϣ����", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��Ϣ����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM ��Ϣ���� WHERE (ID = @Original_ID) AND (��Ϣ���� = @Original_��Ϣ���� OR @Origina" +
				"l_��Ϣ���� IS NULL AND ��Ϣ���� IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��Ϣ����", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��Ϣ����", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "��Ϣ����", new System.Data.Common.DataColumnMapping[] {
																																																			  new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																			  new System.Data.Common.DataColumnMapping("��Ϣ����", "��Ϣ����"),
																																																			  new System.Data.Common.DataColumnMapping("����", "����")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Send_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			//����·��
			string path=null;
			ArrayList Tree;
//			foreach (System.Web.UI.Control c in Addressee.Controls)
//			{
//				Response.Write(c.UniqueID+"<br>");
//			}
//			Response.Write(((LIMS.Control.OfficTree)Addressee.Controls[0]).ID);
//			Response.Write(Server.MapPath(""));


			//����и������ϴ�
			if (!(File1.Value==null || File1.Value==""))
			{
				path=msg.BuildUploadFilename(File1.PostedFile.FileName,@"\LIMS\Message\Upload\",user);

				//UpLoadFile�����ĵڶ���������Ҫ��·��ת��Ϊ��������·��
				Tool.UpLoadFile(File1,Server.MapPath("").ToLower().Replace(@"\lims\message","")+path);
			}
			else
				//���pathΪnull��������sql��Ӽ�¼ʱ�������������
				//����Ҫ��ֵ""
				path="";


			switch (MessageType.SelectedIndex)
			{
				//������Ϣ
				case 0:
					Tree=((LIMS.Control.IndividualTree)Addressee.Controls[0].Controls[0]).SelectedNodes;
					if (Tree.Count==0)
					{
						NotSelected();
						return;
					}
					msg.Send(Title.Text,Content.Text,user.ID,int.Parse(MessageType.SelectedItem.Value),path,Tree);
					
//					send
					break;
				//������Ϣ
				case 1:
					Tree=((LIMS.Control.OfficeTree)Addressee.Controls[1].Controls[0]).SelectedNodes;
					if (Tree.Count==0)
					{
						NotSelected();
						return;
					}
					//ע�⣺�ڸ����ҷ�����Ϣʱ���ռ���ID�ֶδ�ŵ�ʵ���ǿ���ID
					msg.Send(Title.Text,Content.Text,user.ID,int.Parse(MessageType.SelectedItem.Value),path,Tree);
//					send
					break;
				//����
				case 2:
					msg.Send(Title.Text,Content.Text,user.ID,path);
//					send
					break;
			}
			
//			
			Response.Write("<script>alert('���ͳɹ�!')</script>"); 

//			Response.Write(Addressee.Controls[1].Controls[0]);
//			Response.Write(((LIMS.Control.IndividualTree)Addressee.Controls[0].Controls[1]).SelectedNodes.Count);


		}

		/// <summary>
		/// û��ѡ���ռ���
		/// </summary>
		private void NotSelected()
		{
			Err.Text="û��ѡ���ռ���";
		}

		private void MessageType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Addressee.Enabled=true;
			switch (MessageType.SelectedIndex)
			{
				case 0:
					Addressee.Tabs[1].Visible=false;
					Addressee.Tabs[0].Visible=true;
					break;
				case 1:
//					Addressee.Controls[0].Visible=false;
					Addressee.Tabs[0].Visible=false;
					Addressee.Tabs[1].Visible=true;
					break;
				case 2:
					Addressee.Enabled=false;
					break;
			}
		}
	}
}
