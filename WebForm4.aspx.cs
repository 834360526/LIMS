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
	/// WebForm4 的摘要说明。
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
//			string s=@"http://localhost/LIMS/Work/Certificate/电磁科/[钢卷尺][QJ2006-000000022]校?准?证?书内(1).doc";
//			Response.Write(Server.u);
//			ArrayList al=new ArrayList();
//			al.Add(3);
//			al.Add(4);
//			Response.Write(al[0]);

//			sqlDataAdapter2.Fill(ds1.权限模块);
//			sqlDataAdapter1.Fill(ds1.角色权限);
//			
//			UltraWebGrid1.DataBind();
//			string pp="d:\\2.doc";
//			Editor1.LoadRTF(pp);
			if (!IsPostBack)
				ViewState["a"]=1;
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
			this.sqlSelectCommand1.CommandText = "SELECT ID, 角色ID, 权限ID FROM 角色权限";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=QDMT;packet size=4096;user id=sa;integrated security=SSPI;data sou" +
				"rce=\".\";persist security info=False;initial catalog=lims";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO 角色权限(角色ID, 权限ID) VALUES (@角色ID, @权限ID); SELECT ID, 角色ID, 权限ID FROM 角色" +
				"权限 WHERE (ID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@角色ID", System.Data.SqlDbType.Int, 4, "角色ID"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@权限ID", System.Data.SqlDbType.Int, 4, "权限ID"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE 角色权限 SET 角色ID = @角色ID, 权限ID = @权限ID WHERE (ID = @Original_ID) AND (权限ID = " +
				"@Original_权限ID) AND (角色ID = @Original_角色ID); SELECT ID, 角色ID, 权限ID FROM 角色权限 WHE" +
				"RE (ID = @ID)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@角色ID", System.Data.SqlDbType.Int, 4, "角色ID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@权限ID", System.Data.SqlDbType.Int, 4, "权限ID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_权限ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "权限ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_角色ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "角色ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM 角色权限 WHERE (ID = @Original_ID) AND (权限ID = @Original_权限ID) AND (角色ID " +
				"= @Original_角色ID)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_权限ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "权限ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_角色ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "角色ID", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "角色权限", new System.Data.Common.DataColumnMapping[] {
																																																			  new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																			  new System.Data.Common.DataColumnMapping("角色ID", "角色ID"),
																																																			  new System.Data.Common.DataColumnMapping("权限ID", "权限ID")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT ID, 权限模块名, 类别, 菜单级别, 菜单项目ID, 链接地址, 备注 FROM 权限模块";
			this.sqlSelectCommand2.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = "INSERT INTO 权限模块(权限模块名, 类别, 菜单级别, 菜单项目ID, 链接地址, 备注) VALUES (@权限模块名, @类别, @菜单级别, @" +
				"菜单项目ID, @链接地址, @备注); SELECT ID, 权限模块名, 类别, 菜单级别, 菜单项目ID, 链接地址, 备注 FROM 权限模块 WHER" +
				"E (ID = @@IDENTITY)";
			this.sqlInsertCommand2.Connection = this.sqlConnection1;
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@权限模块名", System.Data.SqlDbType.NVarChar, 50, "权限模块名"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@类别", System.Data.SqlDbType.Int, 4, "类别"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@菜单级别", System.Data.SqlDbType.Int, 4, "菜单级别"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@菜单项目ID", System.Data.SqlDbType.Int, 4, "菜单项目ID"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@链接地址", System.Data.SqlDbType.NVarChar, 1000, "链接地址"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.NVarChar, 1073741823, "备注"));
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = @"UPDATE 权限模块 SET 权限模块名 = @权限模块名, 类别 = @类别, 菜单级别 = @菜单级别, 菜单项目ID = @菜单项目ID, 链接地址 = @链接地址, 备注 = @备注 WHERE (ID = @Original_ID) AND (权限模块名 = @Original_权限模块名) AND (类别 = @Original_类别) AND (菜单级别 = @Original_菜单级别 OR @Original_菜单级别 IS NULL AND 菜单级别 IS NULL) AND (菜单项目ID = @Original_菜单项目ID OR @Original_菜单项目ID IS NULL AND 菜单项目ID IS NULL) AND (链接地址 = @Original_链接地址 OR @Original_链接地址 IS NULL AND 链接地址 IS NULL); SELECT ID, 权限模块名, 类别, 菜单级别, 菜单项目ID, 链接地址, 备注 FROM 权限模块 WHERE (ID = @ID)";
			this.sqlUpdateCommand2.Connection = this.sqlConnection1;
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@权限模块名", System.Data.SqlDbType.NVarChar, 50, "权限模块名"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@类别", System.Data.SqlDbType.Int, 4, "类别"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@菜单级别", System.Data.SqlDbType.Int, 4, "菜单级别"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@菜单项目ID", System.Data.SqlDbType.Int, 4, "菜单项目ID"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@链接地址", System.Data.SqlDbType.NVarChar, 1000, "链接地址"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.NVarChar, 1073741823, "备注"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_权限模块名", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "权限模块名", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_类别", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "类别", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_菜单级别", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "菜单级别", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_菜单项目ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "菜单项目ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_链接地址", System.Data.SqlDbType.NVarChar, 1000, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "链接地址", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = @"DELETE FROM 权限模块 WHERE (ID = @Original_ID) AND (权限模块名 = @Original_权限模块名) AND (类别 = @Original_类别) AND (菜单级别 = @Original_菜单级别 OR @Original_菜单级别 IS NULL AND 菜单级别 IS NULL) AND (菜单项目ID = @Original_菜单项目ID OR @Original_菜单项目ID IS NULL AND 菜单项目ID IS NULL) AND (链接地址 = @Original_链接地址 OR @Original_链接地址 IS NULL AND 链接地址 IS NULL)";
			this.sqlDeleteCommand2.Connection = this.sqlConnection1;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_权限模块名", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "权限模块名", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_类别", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "类别", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_菜单级别", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "菜单级别", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_菜单项目ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "菜单项目ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_链接地址", System.Data.SqlDbType.NVarChar, 1000, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "链接地址", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter2
			// 
			this.sqlDataAdapter2.DeleteCommand = this.sqlDeleteCommand2;
			this.sqlDataAdapter2.InsertCommand = this.sqlInsertCommand2;
			this.sqlDataAdapter2.SelectCommand = this.sqlSelectCommand2;
			this.sqlDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "权限模块", new System.Data.Common.DataColumnMapping[] {
																																																			  new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																			  new System.Data.Common.DataColumnMapping("权限模块名", "权限模块名"),
																																																			  new System.Data.Common.DataColumnMapping("类别", "类别"),
																																																			  new System.Data.Common.DataColumnMapping("菜单级别", "菜单级别"),
																																																			  new System.Data.Common.DataColumnMapping("菜单项目ID", "菜单项目ID"),
																																																			  new System.Data.Common.DataColumnMapping("链接地址", "链接地址"),
																																																			  new System.Data.Common.DataColumnMapping("备注", "备注")})});
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
