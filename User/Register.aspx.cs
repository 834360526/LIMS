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
//using LIMS.Base;
namespace LIMS.User
{
	/// <summary>
	/// Register ��ժҪ˵����
	/// </summary>
	public class Register : System.Web.UI.Page
	{
		protected System.Data.SqlClient.SqlConnection cn;
		protected System.Data.SqlClient.SqlDataAdapter daOffic;
		protected Infragistics.WebUI.WebCombo.WebCombo Offic;
		protected LIMS.User.User user1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit UserName;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit Password;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit ValidatePassword;
		protected System.Web.UI.WebControls.CompareValidator CompareValidator1;
		protected System.Web.UI.WebControls.RegularExpressionValidator RegularExpressionValidator1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator2;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator3;
		protected System.Web.UI.WebControls.RegularExpressionValidator RegularExpressionValidator2;
		protected System.Web.UI.WebControls.RadioButtonList Sex;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator4;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator5;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Confirm;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit PasswordQuestion;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit PasswordAnswer;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit Name;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		protected Infragistics.WebUI.WebDataInput.WebDateTimeEdit BirthDate;
		protected Dallas.Core.User user;
		private void Page_Load(object sender, System.EventArgs e)
		{
			user=new Dallas.Core.User();
			BindGrid();
		}

		private void BindGrid()
		{
			daOffic.Fill(user1.����);
			Offic.DataBind();
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
			this.daOffic = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.user1 = new LIMS.User.User();
			((System.ComponentModel.ISupportInitialize)(this.user1)).BeginInit();
			this.Confirm.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.Confirm_Click);
			// 
			// cn
			// 
			this.cn.ConnectionString = "workstation id=DALLAS;packet size=4096;integrated security=SSPI;data source=\".\";p" +
				"ersist security info=False;initial catalog=lims";
			// 
			// daOffic
			// 
			this.daOffic.DeleteCommand = this.sqlDeleteCommand2;
			this.daOffic.InsertCommand = this.sqlInsertCommand1;
			this.daOffic.SelectCommand = this.sqlSelectCommand1;
			this.daOffic.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							  new System.Data.Common.DataTableMapping("Table", "����", new System.Data.Common.DataColumnMapping[] {
																																																	new System.Data.Common.DataColumnMapping("Offic", "Offic"),
																																																	new System.Data.Common.DataColumnMapping("ID", "ID")})});
			this.daOffic.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = "DELETE FROM ���� WHERE (ID = @Original_ID) AND (�������� = @Original_Offic OR @Original" +
				"_Offic IS NULL AND �������� IS NULL)";
			this.sqlDeleteCommand2.Connection = this.cn;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Offic", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Offic", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO ����(��������) VALUES (@��������); SELECT �������� AS Offic, ID FROM ���� WHERE (ID =" +
				" @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.cn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.NVarChar, 50, "Offic"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT �������� AS Offic, ID FROM ����";
			this.sqlSelectCommand1.Connection = this.cn;
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = "UPDATE ���� SET �������� = @�������� WHERE (ID = @Original_ID) AND (�������� = @Original_Offic " +
				"OR @Original_Offic IS NULL AND �������� IS NULL); SELECT �������� AS Offic, ID FROM ���� W" +
				"HERE (ID = @ID)";
			this.sqlUpdateCommand2.Connection = this.cn;
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.NVarChar, 50, "Offic"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Offic", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Offic", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			// 
			// user1
			// 
			this.user1.DataSetName = "User";
			this.user1.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.user1)).EndInit();

		}
		#endregion

		private void Confirm_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			if (!(IsNull(UserName.Text)&&IsNull(Password.Text)&&IsNull(ValidatePassword.Text)&&IsNull(Name.Text)&&(Sex.SelectedIndex!=-1)&&(Offic.SelectedIndex!=-1)&&IsNull(BirthDate.Text)))
				return;

			//�洢�û�����Ϣ
			Hashtable newUser=new Hashtable();
			//�洢Ա����������Ϣ
			Hashtable newUserInfo=new Hashtable();

			newUser.Add("�û���",UserName.Text);
			newUser.Add("����",Password.Text);
			newUser.Add("����ID",Offic.DataValue);
			newUser.Add("��������",PasswordQuestion.Text);
			newUser.Add("�����",PasswordAnswer.Text);
			//����״̬Ϊ����
			newUser.Add("״̬ID",1);
			//��������Ϊ��ͨ�û�
			newUser.Add("����ID",1);

			newUserInfo.Add("����",Name.Text);
			newUserInfo.Add("�Ա�",Sex.SelectedValue);
			newUserInfo.Add("��������",BirthDate.Text);
			
			
			user.Register(newUser,newUserInfo);
//			Response.Write(Offic.DataValue);
			Response.Write("<script>alert('ע��ɹ�!')</script>"); 
		}

		private bool IsNull(string param)
		{
			if (param==null && param=="")
				return false;
			return true;
		}
	}
}
