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

namespace LIMS.StandardImplement
{
	/// <summary>
	/// AddStandardImplement 的摘要说明。
	/// </summary>
	public class AddStandardImplement : BaseForm
	{
		protected System.Data.SqlClient.SqlConnection cn;
		protected Infragistics.WebUI.WebDataInput.WebDateTimeEdit LastTestDate;
		protected System.Web.UI.WebControls.TextBox Remark;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Submit;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit StandardImplementName;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit Manufactory;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit Model;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit SN;
		protected Infragistics.WebUI.WebDataInput.WebCurrencyEdit Price;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit AccuracyLevel;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit MeasureRange;
		protected Infragistics.WebUI.WebDataInput.WebDateTimeEdit PurchaseDate;
		protected System.Data.SqlClient.SqlDataAdapter daStandardImplementType;
		protected Infragistics.WebUI.WebCombo.WebCombo Type;
		protected LIMS.StandardImplement.StandardImplement standardImplement1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator2;
		protected Infragistics.WebUI.WebDataInput.WebNumericEdit TestCyc;
		protected Dallas.Core.StandardImplement si;

		private void Page_Load(object sender, System.EventArgs e)
		{
			si=new Dallas.Core.StandardImplement();
			BindGrid();
		}

		private void BindGrid()
		{
			daStandardImplementType.Fill(standardImplement1.标准器类型);
			Type.DataBind();
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
			this.daStandardImplementType = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.standardImplement1 = new LIMS.StandardImplement.StandardImplement();
			((System.ComponentModel.ISupportInitialize)(this.standardImplement1)).BeginInit();
			this.Submit.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.Submit_Click);
			// 
			// cn
			// 
			this.cn.ConnectionString = "workstation id=QDMT;packet size=4096;user id=sa;integrated security=SSPI;data sou" +
				"rce=\".\";persist security info=False;initial catalog=lims";
			// 
			// daStandardImplementType
			// 
			this.daStandardImplementType.DeleteCommand = this.sqlDeleteCommand1;
			this.daStandardImplementType.InsertCommand = this.sqlInsertCommand1;
			this.daStandardImplementType.SelectCommand = this.sqlSelectCommand1;
			this.daStandardImplementType.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																											  new System.Data.Common.DataTableMapping("Table", "标准器类型", new System.Data.Common.DataColumnMapping[] {
																																																					   new System.Data.Common.DataColumnMapping("Type", "Type"),
																																																					   new System.Data.Common.DataColumnMapping("ID", "ID")})});
			this.daStandardImplementType.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM 标准器类型 WHERE (ID = @Original_ID) AND (类型 = @Original_Type OR @Original" +
				"_Type IS NULL AND 类型 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.cn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO 标准器类型(类型) VALUES (@类型); SELECT 类型 AS Type, ID FROM 标准器类型 WHERE (ID = " +
				"@@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.cn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@类型", System.Data.SqlDbType.NVarChar, 50, "Type"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 类型 AS Type, ID FROM 标准器类型";
			this.sqlSelectCommand1.Connection = this.cn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE 标准器类型 SET 类型 = @类型 WHERE (ID = @Original_ID) AND (类型 = @Original_Type OR @" +
				"Original_Type IS NULL AND 类型 IS NULL); SELECT 类型 AS Type, ID FROM 标准器类型 WHERE (I" +
				"D = @ID)";
			this.sqlUpdateCommand1.Connection = this.cn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@类型", System.Data.SqlDbType.NVarChar, 50, "Type"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			// 
			// standardImplement1
			// 
			this.standardImplement1.DataSetName = "StandardImplement";
			this.standardImplement1.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.standardImplement1)).EndInit();

		}
		#endregion

		private void Submit_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			Hashtable StandardImplement=new Hashtable();
			StandardImplement.Add("名称",StandardImplementName.Text);
			StandardImplement.Add("制造厂商",Manufactory.Text);
			StandardImplement.Add("型号规格",Model.Text);
			StandardImplement.Add("出场编号",SN.Text);
			StandardImplement.Add("类型",Type.DataValue);
			StandardImplement.Add("价格",Price.Text);
			StandardImplement.Add("准确度等级",AccuracyLevel.Text);
			StandardImplement.Add("测量范围",MeasureRange.Text);
			StandardImplement.Add("购买日期",PurchaseDate.Text);
			StandardImplement.Add("检定周期",TestCyc.Text);
			StandardImplement.Add("上次检定日期",LastTestDate.Text);
			StandardImplement.Add("备注",Remark.Text);
			
			StandardImplement.Add("保管人ID",user.ID);

			si.AddStandardImplement(StandardImplement);
		}
	}
}
