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
	/// Register 的摘要说明。
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
			daOffic.Fill(user1.科室);
			Offic.DataBind();
		}
		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
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
																							  new System.Data.Common.DataTableMapping("Table", "科室", new System.Data.Common.DataColumnMapping[] {
																																																	new System.Data.Common.DataColumnMapping("Offic", "Offic"),
																																																	new System.Data.Common.DataColumnMapping("ID", "ID")})});
			this.daOffic.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = "DELETE FROM 科室 WHERE (ID = @Original_ID) AND (科室名称 = @Original_Offic OR @Original" +
				"_Offic IS NULL AND 科室名称 IS NULL)";
			this.sqlDeleteCommand2.Connection = this.cn;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Offic", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Offic", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO 科室(科室名称) VALUES (@科室名称); SELECT 科室名称 AS Offic, ID FROM 科室 WHERE (ID =" +
				" @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.cn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@科室名称", System.Data.SqlDbType.NVarChar, 50, "Offic"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 科室名称 AS Offic, ID FROM 科室";
			this.sqlSelectCommand1.Connection = this.cn;
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = "UPDATE 科室 SET 科室名称 = @科室名称 WHERE (ID = @Original_ID) AND (科室名称 = @Original_Offic " +
				"OR @Original_Offic IS NULL AND 科室名称 IS NULL); SELECT 科室名称 AS Offic, ID FROM 科室 W" +
				"HERE (ID = @ID)";
			this.sqlUpdateCommand2.Connection = this.cn;
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@科室名称", System.Data.SqlDbType.NVarChar, 50, "Offic"));
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

			//存储用户表信息
			Hashtable newUser=new Hashtable();
			//存储员工档案表信息
			Hashtable newUserInfo=new Hashtable();

			newUser.Add("用户名",UserName.Text);
			newUser.Add("密码",Password.Text);
			newUser.Add("科室ID",Offic.DataValue);
			newUser.Add("密码问题",PasswordQuestion.Text);
			newUser.Add("密码答案",PasswordAnswer.Text);
			//设置状态为启用
			newUser.Add("状态ID",1);
			//设置类型为普通用户
			newUser.Add("类型ID",1);

			newUserInfo.Add("姓名",Name.Text);
			newUserInfo.Add("性别",Sex.SelectedValue);
			newUserInfo.Add("出生日期",BirthDate.Text);
			
			
			user.Register(newUser,newUserInfo);
//			Response.Write(Offic.DataValue);
			Response.Write("<script>alert('注册成功!')</script>"); 
		}

		private bool IsNull(string param)
		{
			if (param==null && param=="")
				return false;
			return true;
		}
	}
}
