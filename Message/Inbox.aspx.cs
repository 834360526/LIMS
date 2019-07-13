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
	/// Inbox 的摘要说明。
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
			//个人信息、公告、科室信息
			daInbox.SelectCommand.CommandText+=" where (信息类型=2 and 收件人ID="+user.ID+") or (信息类型=4) or (信息类型=3 and 收件人ID="+user.OfficeID+") ORDER BY 发送时间 desc";
			daInbox.Fill(dsMessage1.收件箱);
			
//			//如果收件箱中没有新的信息，则调整Grid的高度
//			if (dsMessage1.收件箱.Rows.Count<1)
//				Message.Height=45;
			Message.DataBind();
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
																							  new System.Data.Common.DataTableMapping("Table", "收件箱", new System.Data.Common.DataColumnMapping[] {
																																																	 new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																	 new System.Data.Common.DataColumnMapping("标题", "标题"),
																																																	 new System.Data.Common.DataColumnMapping("日期", "日期"),
																																																	 new System.Data.Common.DataColumnMapping("发件人", "发件人"),
																																																	 new System.Data.Common.DataColumnMapping("已阅", "已阅"),
																																																	 new System.Data.Common.DataColumnMapping("收件人ID", "收件人ID")})});
			// 
			// dsMessage1
			// 
			this.dsMessage1.DataSetName = "dsMessage";
			this.dsMessage1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ID, 标题, 发送时间 AS 日期, 发件人, 已阅, 收件人ID FROM 收件箱";
			this.sqlSelectCommand1.Connection = this.cn;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO 收件箱(标题, 发送时间, 发件人, 已阅, 收件人ID) VALUES (@标题, @发送时间, @发件人, @已阅, @收件人ID);" +
				" SELECT ID, 标题, 发送时间 AS 日期, 发件人, 已阅, 收件人ID FROM 收件箱";
			this.sqlInsertCommand1.Connection = this.cn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@标题", System.Data.SqlDbType.NVarChar, 1073741823, "标题"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@发送时间", System.Data.SqlDbType.DateTime, 8, "日期"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@发件人", System.Data.SqlDbType.NVarChar, 10, "发件人"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@已阅", System.Data.SqlDbType.Bit, 1, "已阅"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@收件人ID", System.Data.SqlDbType.Int, 4, "收件人ID"));
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
