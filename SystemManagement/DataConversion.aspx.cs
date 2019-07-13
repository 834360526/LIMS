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

namespace LIMS.SystemManagement
{
	/// <summary>
	/// DataConversion 的摘要说明。
	/// </summary>
	public class DataConversion : System.Web.UI.Page
	{
		protected System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		protected System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		protected System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		protected System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		protected System.Data.OleDb.OleDbConnection odcn;
		protected System.Web.UI.WebControls.DataGrid dg;
		protected System.Data.Odbc.OdbcCommand odcm;
		protected System.Data.OleDb.OleDbDataAdapter odda;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			DataSet ds=new DataSet();
			odda.SelectCommand.CommandText="select distinct 检定人员 from shoufatable";
			odda.Fill(ds);

			dg.DataSource=ds;
			dg.DataBind();

			ArrayList al=new ArrayList();
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				if (dr[0]==null || dr[0].ToString()=="")
					continue;
				string[] n=dr[0].ToString().Split(' ');

				foreach (string s in n)
				{
					string ns=s.Replace(".",null);
					ns=ns.Replace("*",null);
					if (al.Contains(ns))
						continue;
					else
					{
						al.Add(ns);
						Response.Write(ns+"<br>");
					}
				}
			}
//			odcm.CommandText=

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
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.odcn = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.odda = new System.Data.OleDb.OleDbDataAdapter();
			this.odcm = new System.Data.Odbc.OdbcCommand();
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT 备注, 部件费, 传真号, 单位地址, 电话, 附件, 检定费, 检定人员, 检校类别, 交费日期, 交通费, 科别, 流水号, 器号, 器具名称," +
				" 实交费用, 数量, 送检单位, 送检日期, 完成日期, 委托人, 校准费, 协作费, 型号, 修理费, 应交费用, 邮政编码 FROM shoufatable" +
				"";
			this.oleDbSelectCommand1.Connection = this.odcn;
			// 
			// odcn
			// 
			this.odcn.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Data Source=""D:\Documents and Settings\Administrator\My Documents\office\db7.mdb"";Jet OLEDB:Engine Type=5;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO shoufatable(备注, 部件费, 传真号, 单位地址, 电话, 附件, 检定费, 检定人员, 检校类别, 交费日期, 交通费, 科" +
				"别, 器号, 器具名称, 实交费用, 数量, 送检单位, 送检日期, 完成日期, 委托人, 校准费, 协作费, 型号, 修理费, 应交费用, 邮政编码) VAL" +
				"UES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, " +
				"?)";
			this.oleDbInsertCommand1.Connection = this.odcn;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("备注", System.Data.OleDb.OleDbType.VarWChar, 0, "备注"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("部件费", System.Data.OleDb.OleDbType.Currency, 0, "部件费"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("传真号", System.Data.OleDb.OleDbType.VarWChar, 15, "传真号"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("单位地址", System.Data.OleDb.OleDbType.VarWChar, 42, "单位地址"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("电话", System.Data.OleDb.OleDbType.VarWChar, 14, "电话"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("附件", System.Data.OleDb.OleDbType.VarWChar, 40, "附件"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("检定费", System.Data.OleDb.OleDbType.Currency, 0, "检定费"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("检定人员", System.Data.OleDb.OleDbType.VarWChar, 68, "检定人员"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("检校类别", System.Data.OleDb.OleDbType.VarWChar, 20, "检校类别"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("交费日期", System.Data.OleDb.OleDbType.DBDate, 0, "交费日期"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("交通费", System.Data.OleDb.OleDbType.Currency, 0, "交通费"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("科别", System.Data.OleDb.OleDbType.VarWChar, 13, "科别"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("器号", System.Data.OleDb.OleDbType.VarWChar, 20, "器号"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("器具名称", System.Data.OleDb.OleDbType.VarWChar, 50, "器具名称"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("实交费用", System.Data.OleDb.OleDbType.Currency, 0, "实交费用"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("数量", System.Data.OleDb.OleDbType.Integer, 0, "数量"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("送检单位", System.Data.OleDb.OleDbType.VarWChar, 38, "送检单位"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("送检日期", System.Data.OleDb.OleDbType.DBDate, 0, "送检日期"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("完成日期", System.Data.OleDb.OleDbType.DBDate, 0, "完成日期"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("委托人", System.Data.OleDb.OleDbType.VarWChar, 10, "委托人"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("校准费", System.Data.OleDb.OleDbType.Currency, 0, "校准费"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("协作费", System.Data.OleDb.OleDbType.Currency, 0, "协作费"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("型号", System.Data.OleDb.OleDbType.VarWChar, 16, "型号"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("修理费", System.Data.OleDb.OleDbType.Currency, 0, "修理费"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("应交费用", System.Data.OleDb.OleDbType.Currency, 0, "应交费用"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("邮政编码", System.Data.OleDb.OleDbType.VarWChar, 12, "邮政编码"));
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE shoufatable SET 备注 = ?, 部件费 = ?, 传真号 = ?, 单位地址 = ?, 电话 = ?, 附件 = ?, 检定费 = ?, 检定人员 = ?, 检校类别 = ?, 交费日期 = ?, 交通费 = ?, 科别 = ?, 器号 = ?, 器具名称 = ?, 实交费用 = ?, 数量 = ?, 送检单位 = ?, 送检日期 = ?, 完成日期 = ?, 委托人 = ?, 校准费 = ?, 协作费 = ?, 型号 = ?, 修理费 = ?, 应交费用 = ?, 邮政编码 = ? WHERE (流水号 = ?) AND (交费日期 = ? OR ? IS NULL AND 交费日期 IS NULL) AND (交通费 = ? OR ? IS NULL AND 交通费 IS NULL) AND (传真号 = ? OR ? IS NULL AND 传真号 IS NULL) AND (修理费 = ? OR ? IS NULL AND 修理费 IS NULL) AND (协作费 = ? OR ? IS NULL AND 协作费 IS NULL) AND (单位地址 = ? OR ? IS NULL AND 单位地址 IS NULL) AND (器具名称 = ? OR ? IS NULL AND 器具名称 IS NULL) AND (器号 = ? OR ? IS NULL AND 器号 IS NULL) AND (型号 = ? OR ? IS NULL AND 型号 IS NULL) AND (委托人 = ? OR ? IS NULL AND 委托人 IS NULL) AND (完成日期 = ? OR ? IS NULL AND 完成日期 IS NULL) AND (实交费用 = ? OR ? IS NULL AND 实交费用 IS NULL) AND (应交费用 = ? OR ? IS NULL AND 应交费用 IS NULL) AND (数量 = ? OR ? IS NULL AND 数量 IS NULL) AND (校准费 = ? OR ? IS NULL AND 校准费 IS NULL) AND (检定人员 = ? OR ? IS NULL AND 检定人员 IS NULL) AND (检定费 = ? OR ? IS NULL AND 检定费 IS NULL) AND (检校类别 = ? OR ? IS NULL AND 检校类别 IS NULL) AND (电话 = ? OR ? IS NULL AND 电话 IS NULL) AND (科别 = ? OR ? IS NULL AND 科别 IS NULL) AND (送检单位 = ? OR ? IS NULL AND 送检单位 IS NULL) AND (送检日期 = ? OR ? IS NULL AND 送检日期 IS NULL) AND (邮政编码 = ? OR ? IS NULL AND 邮政编码 IS NULL) AND (部件费 = ? OR ? IS NULL AND 部件费 IS NULL) AND (附件 = ? OR ? IS NULL AND 附件 IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.odcn;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("备注", System.Data.OleDb.OleDbType.VarWChar, 0, "备注"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("部件费", System.Data.OleDb.OleDbType.Currency, 0, "部件费"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("传真号", System.Data.OleDb.OleDbType.VarWChar, 15, "传真号"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("单位地址", System.Data.OleDb.OleDbType.VarWChar, 42, "单位地址"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("电话", System.Data.OleDb.OleDbType.VarWChar, 14, "电话"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("附件", System.Data.OleDb.OleDbType.VarWChar, 40, "附件"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("检定费", System.Data.OleDb.OleDbType.Currency, 0, "检定费"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("检定人员", System.Data.OleDb.OleDbType.VarWChar, 68, "检定人员"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("检校类别", System.Data.OleDb.OleDbType.VarWChar, 20, "检校类别"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("交费日期", System.Data.OleDb.OleDbType.DBDate, 0, "交费日期"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("交通费", System.Data.OleDb.OleDbType.Currency, 0, "交通费"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("科别", System.Data.OleDb.OleDbType.VarWChar, 13, "科别"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("器号", System.Data.OleDb.OleDbType.VarWChar, 20, "器号"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("器具名称", System.Data.OleDb.OleDbType.VarWChar, 50, "器具名称"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("实交费用", System.Data.OleDb.OleDbType.Currency, 0, "实交费用"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("数量", System.Data.OleDb.OleDbType.Integer, 0, "数量"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("送检单位", System.Data.OleDb.OleDbType.VarWChar, 38, "送检单位"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("送检日期", System.Data.OleDb.OleDbType.DBDate, 0, "送检日期"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("完成日期", System.Data.OleDb.OleDbType.DBDate, 0, "完成日期"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("委托人", System.Data.OleDb.OleDbType.VarWChar, 10, "委托人"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("校准费", System.Data.OleDb.OleDbType.Currency, 0, "校准费"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("协作费", System.Data.OleDb.OleDbType.Currency, 0, "协作费"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("型号", System.Data.OleDb.OleDbType.VarWChar, 16, "型号"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("修理费", System.Data.OleDb.OleDbType.Currency, 0, "修理费"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("应交费用", System.Data.OleDb.OleDbType.Currency, 0, "应交费用"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("邮政编码", System.Data.OleDb.OleDbType.VarWChar, 12, "邮政编码"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_流水号", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "流水号", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_交费日期", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "交费日期", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_交费日期1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "交费日期", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_交通费", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "交通费", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_交通费1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "交通费", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_传真号", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "传真号", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_传真号1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "传真号", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_修理费", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "修理费", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_修理费1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "修理费", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_协作费", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "协作费", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_协作费1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "协作费", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_单位地址", System.Data.OleDb.OleDbType.VarWChar, 42, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "单位地址", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_单位地址1", System.Data.OleDb.OleDbType.VarWChar, 42, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "单位地址", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_器具名称", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "器具名称", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_器具名称1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "器具名称", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_器号", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "器号", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_器号1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "器号", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_型号", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "型号", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_型号1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "型号", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_委托人", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "委托人", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_委托人1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "委托人", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_完成日期", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "完成日期", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_完成日期1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "完成日期", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_实交费用", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "实交费用", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_实交费用1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "实交费用", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_应交费用", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "应交费用", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_应交费用1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "应交费用", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_数量", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "数量", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_数量1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "数量", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_校准费", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "校准费", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_校准费1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "校准费", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_检定人员", System.Data.OleDb.OleDbType.VarWChar, 68, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "检定人员", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_检定人员1", System.Data.OleDb.OleDbType.VarWChar, 68, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "检定人员", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_检定费", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "检定费", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_检定费1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "检定费", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_检校类别", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "检校类别", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_检校类别1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "检校类别", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_电话", System.Data.OleDb.OleDbType.VarWChar, 14, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电话", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_电话1", System.Data.OleDb.OleDbType.VarWChar, 14, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电话", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_科别", System.Data.OleDb.OleDbType.VarWChar, 13, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "科别", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_科别1", System.Data.OleDb.OleDbType.VarWChar, 13, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "科别", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_送检单位", System.Data.OleDb.OleDbType.VarWChar, 38, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "送检单位", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_送检单位1", System.Data.OleDb.OleDbType.VarWChar, 38, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "送检单位", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_送检日期", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "送检日期", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_送检日期1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "送检日期", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_邮政编码", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "邮政编码", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_邮政编码1", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "邮政编码", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_部件费", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "部件费", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_部件费1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "部件费", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_附件", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "附件", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_附件1", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "附件", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM shoufatable WHERE (流水号 = ?) AND (交费日期 = ? OR ? IS NULL AND 交费日期 IS NULL) AND (交通费 = ? OR ? IS NULL AND 交通费 IS NULL) AND (传真号 = ? OR ? IS NULL AND 传真号 IS NULL) AND (修理费 = ? OR ? IS NULL AND 修理费 IS NULL) AND (协作费 = ? OR ? IS NULL AND 协作费 IS NULL) AND (单位地址 = ? OR ? IS NULL AND 单位地址 IS NULL) AND (器具名称 = ? OR ? IS NULL AND 器具名称 IS NULL) AND (器号 = ? OR ? IS NULL AND 器号 IS NULL) AND (型号 = ? OR ? IS NULL AND 型号 IS NULL) AND (委托人 = ? OR ? IS NULL AND 委托人 IS NULL) AND (完成日期 = ? OR ? IS NULL AND 完成日期 IS NULL) AND (实交费用 = ? OR ? IS NULL AND 实交费用 IS NULL) AND (应交费用 = ? OR ? IS NULL AND 应交费用 IS NULL) AND (数量 = ? OR ? IS NULL AND 数量 IS NULL) AND (校准费 = ? OR ? IS NULL AND 校准费 IS NULL) AND (检定人员 = ? OR ? IS NULL AND 检定人员 IS NULL) AND (检定费 = ? OR ? IS NULL AND 检定费 IS NULL) AND (检校类别 = ? OR ? IS NULL AND 检校类别 IS NULL) AND (电话 = ? OR ? IS NULL AND 电话 IS NULL) AND (科别 = ? OR ? IS NULL AND 科别 IS NULL) AND (送检单位 = ? OR ? IS NULL AND 送检单位 IS NULL) AND (送检日期 = ? OR ? IS NULL AND 送检日期 IS NULL) AND (邮政编码 = ? OR ? IS NULL AND 邮政编码 IS NULL) AND (部件费 = ? OR ? IS NULL AND 部件费 IS NULL) AND (附件 = ? OR ? IS NULL AND 附件 IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.odcn;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_流水号", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "流水号", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_交费日期", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "交费日期", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_交费日期1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "交费日期", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_交通费", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "交通费", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_交通费1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "交通费", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_传真号", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "传真号", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_传真号1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "传真号", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_修理费", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "修理费", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_修理费1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "修理费", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_协作费", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "协作费", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_协作费1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "协作费", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_单位地址", System.Data.OleDb.OleDbType.VarWChar, 42, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "单位地址", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_单位地址1", System.Data.OleDb.OleDbType.VarWChar, 42, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "单位地址", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_器具名称", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "器具名称", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_器具名称1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "器具名称", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_器号", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "器号", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_器号1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "器号", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_型号", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "型号", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_型号1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "型号", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_委托人", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "委托人", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_委托人1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "委托人", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_完成日期", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "完成日期", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_完成日期1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "完成日期", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_实交费用", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "实交费用", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_实交费用1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "实交费用", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_应交费用", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "应交费用", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_应交费用1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "应交费用", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_数量", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "数量", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_数量1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "数量", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_校准费", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "校准费", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_校准费1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "校准费", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_检定人员", System.Data.OleDb.OleDbType.VarWChar, 68, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "检定人员", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_检定人员1", System.Data.OleDb.OleDbType.VarWChar, 68, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "检定人员", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_检定费", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "检定费", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_检定费1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "检定费", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_检校类别", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "检校类别", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_检校类别1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "检校类别", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_电话", System.Data.OleDb.OleDbType.VarWChar, 14, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电话", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_电话1", System.Data.OleDb.OleDbType.VarWChar, 14, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电话", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_科别", System.Data.OleDb.OleDbType.VarWChar, 13, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "科别", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_科别1", System.Data.OleDb.OleDbType.VarWChar, 13, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "科别", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_送检单位", System.Data.OleDb.OleDbType.VarWChar, 38, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "送检单位", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_送检单位1", System.Data.OleDb.OleDbType.VarWChar, 38, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "送检单位", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_送检日期", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "送检日期", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_送检日期1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "送检日期", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_邮政编码", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "邮政编码", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_邮政编码1", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "邮政编码", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_部件费", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "部件费", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_部件费1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "部件费", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_附件", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "附件", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_附件1", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "附件", System.Data.DataRowVersion.Original, null));
			// 
			// odda
			// 
			this.odda.DeleteCommand = this.oleDbDeleteCommand1;
			this.odda.InsertCommand = this.oleDbInsertCommand1;
			this.odda.SelectCommand = this.oleDbSelectCommand1;
			this.odda.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						   new System.Data.Common.DataTableMapping("Table", "shoufatable", new System.Data.Common.DataColumnMapping[] {
																																																		  new System.Data.Common.DataColumnMapping("备注", "备注"),
																																																		  new System.Data.Common.DataColumnMapping("部件费", "部件费"),
																																																		  new System.Data.Common.DataColumnMapping("传真号", "传真号"),
																																																		  new System.Data.Common.DataColumnMapping("单位地址", "单位地址"),
																																																		  new System.Data.Common.DataColumnMapping("电话", "电话"),
																																																		  new System.Data.Common.DataColumnMapping("附件", "附件"),
																																																		  new System.Data.Common.DataColumnMapping("检定费", "检定费"),
																																																		  new System.Data.Common.DataColumnMapping("检定人员", "检定人员"),
																																																		  new System.Data.Common.DataColumnMapping("检校类别", "检校类别"),
																																																		  new System.Data.Common.DataColumnMapping("交费日期", "交费日期"),
																																																		  new System.Data.Common.DataColumnMapping("交通费", "交通费"),
																																																		  new System.Data.Common.DataColumnMapping("科别", "科别"),
																																																		  new System.Data.Common.DataColumnMapping("流水号", "流水号"),
																																																		  new System.Data.Common.DataColumnMapping("器号", "器号"),
																																																		  new System.Data.Common.DataColumnMapping("器具名称", "器具名称"),
																																																		  new System.Data.Common.DataColumnMapping("实交费用", "实交费用"),
																																																		  new System.Data.Common.DataColumnMapping("数量", "数量"),
																																																		  new System.Data.Common.DataColumnMapping("送检单位", "送检单位"),
																																																		  new System.Data.Common.DataColumnMapping("送检日期", "送检日期"),
																																																		  new System.Data.Common.DataColumnMapping("完成日期", "完成日期"),
																																																		  new System.Data.Common.DataColumnMapping("委托人", "委托人"),
																																																		  new System.Data.Common.DataColumnMapping("校准费", "校准费"),
																																																		  new System.Data.Common.DataColumnMapping("协作费", "协作费"),
																																																		  new System.Data.Common.DataColumnMapping("型号", "型号"),
																																																		  new System.Data.Common.DataColumnMapping("修理费", "修理费"),
																																																		  new System.Data.Common.DataColumnMapping("应交费用", "应交费用"),
																																																		  new System.Data.Common.DataColumnMapping("邮政编码", "邮政编码")})});
			this.odda.UpdateCommand = this.oleDbUpdateCommand1;
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
