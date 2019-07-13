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
	/// Outbox 的摘要说明。
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
				//默认设置为个人，所以科室tab不可见
				Addressee.Tabs[1].Visible=false;

				//如果没有发布公告的权力则从信息类型中删去公告选项
				if (!user.HasPermission("发布公告"))
					MessageType.Items.RemoveAt(2);
			}
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
			this.MessageType.SelectedIndexChanged += new System.EventHandler(this.MessageType_SelectedIndexChanged);
			this.Send.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.Send_Click);
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ID, 信息类型, 描述 FROM 信息类型";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=QDMT;packet size=4096;user id=sa;integrated security=SSPI;data sou" +
				"rce=\".\";persist security info=False;initial catalog=lims";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO 信息类型(信息类型, 描述) VALUES (@信息类型, @描述); SELECT ID, 信息类型, 描述 FROM 信息类型 WHE" +
				"RE (ID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@信息类型", System.Data.SqlDbType.NVarChar, 50, "信息类型"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@描述", System.Data.SqlDbType.NVarChar, 1073741823, "描述"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE 信息类型 SET 信息类型 = @信息类型, 描述 = @描述 WHERE (ID = @Original_ID) AND (信息类型 = @Ori" +
				"ginal_信息类型 OR @Original_信息类型 IS NULL AND 信息类型 IS NULL); SELECT ID, 信息类型, 描述 FROM" +
				" 信息类型 WHERE (ID = @ID)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@信息类型", System.Data.SqlDbType.NVarChar, 50, "信息类型"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@描述", System.Data.SqlDbType.NVarChar, 1073741823, "描述"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_信息类型", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "信息类型", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM 信息类型 WHERE (ID = @Original_ID) AND (信息类型 = @Original_信息类型 OR @Origina" +
				"l_信息类型 IS NULL AND 信息类型 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_信息类型", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "信息类型", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "信息类型", new System.Data.Common.DataColumnMapping[] {
																																																			  new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																			  new System.Data.Common.DataColumnMapping("信息类型", "信息类型"),
																																																			  new System.Data.Common.DataColumnMapping("描述", "描述")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Send_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			//附件路径
			string path=null;
			ArrayList Tree;
//			foreach (System.Web.UI.Control c in Addressee.Controls)
//			{
//				Response.Write(c.UniqueID+"<br>");
//			}
//			Response.Write(((LIMS.Control.OfficTree)Addressee.Controls[0]).ID);
//			Response.Write(Server.MapPath(""));


			//如果有附件则上传
			if (!(File1.Value==null || File1.Value==""))
			{
				path=msg.BuildUploadFilename(File1.PostedFile.FileName,@"\LIMS\Message\Upload\",user);

				//UpLoadFile函数的第二个参数需要把路径转换为本地完整路径
				Tool.UpLoadFile(File1,Server.MapPath("").ToLower().Replace(@"\lims\message","")+path);
			}
			else
				//如果path为null，则在向sql添加记录时会产生参数错误。
				//所以要赋值""
				path="";


			switch (MessageType.SelectedIndex)
			{
				//个人信息
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
				//科室信息
				case 1:
					Tree=((LIMS.Control.OfficeTree)Addressee.Controls[1].Controls[0]).SelectedNodes;
					if (Tree.Count==0)
					{
						NotSelected();
						return;
					}
					//注意：在给科室发送信息时，收件人ID字段存放的实际是科室ID
					msg.Send(Title.Text,Content.Text,user.ID,int.Parse(MessageType.SelectedItem.Value),path,Tree);
//					send
					break;
				//公告
				case 2:
					msg.Send(Title.Text,Content.Text,user.ID,path);
//					send
					break;
			}
			
//			
			Response.Write("<script>alert('发送成功!')</script>"); 

//			Response.Write(Addressee.Controls[1].Controls[0]);
//			Response.Write(((LIMS.Control.IndividualTree)Addressee.Controls[0].Controls[1]).SelectedNodes.Count);


		}

		/// <summary>
		/// 没有选择收件人
		/// </summary>
		private void NotSelected()
		{
			Err.Text="没有选择收件人";
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
