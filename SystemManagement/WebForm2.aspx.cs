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
using System.Data.SqlClient;
using Dallas.Core;

namespace LIMS.SystemManagement
{
	/// <summary>
	/// WebForm2 ��ժҪ˵����
	/// </summary>
	public class WebForm2 : System.Web.UI.Page
	{
		protected System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		protected System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		protected System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		protected System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		protected System.Data.OleDb.OleDbDataAdapter odda;
		protected System.Data.DataSet dataSet1;
		protected System.Web.UI.WebControls.DataGrid dg;
		protected System.Data.SqlClient.SqlConnection cn;
		protected System.Data.SqlClient.SqlCommand cmd;
		protected System.Web.UI.WebControls.Button Start;
		protected System.Web.UI.WebControls.Button AddHandler;
		protected System.Data.OleDb.OleDbConnection oleDbConnection1;
		protected System.Data.OleDb.OleDbConnection odcn;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			
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
			this.odcn = new System.Data.OleDb.OleDbConnection();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.odda = new System.Data.OleDb.OleDbDataAdapter();
			this.dataSet1 = new System.Data.DataSet();
			this.cn = new System.Data.SqlClient.SqlConnection();
			this.cmd = new System.Data.SqlClient.SqlCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			this.Start.Click += new System.EventHandler(this.Start_Click);
			// 
			// odda
			// 
			this.odda.DeleteCommand = this.oleDbDeleteCommand1;
			this.odda.InsertCommand = this.oleDbInsertCommand1;
			this.odda.SelectCommand = this.oleDbSelectCommand1;
			this.odda.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			this.dataSet1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// cn
			// 
			this.cn.ConnectionString = "workstation id=\"QDMT-GKBDQ462XO\";packet size=4096;integrated security=SSPI;data s" +
				"ource=\"QDMT-GKBDQ462XO\";persist security info=False;initial catalog=LIMS_Bak";
			// 
			// cmd
			// 
			this.cmd.Connection = this.cn;
			this.AddHandler.Click += new System.EventHandler(this.AddHandler_Click);
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();

		}
		#endregion

		private void Start_Click(object sender, System.EventArgs e)
		{
			odcn.ConnectionString=@"Provider=Microsoft.Jet.Oledb.4.0;Data Source=D:\Documents and Settings\Administrator\My Documents\����.xls;Extended Properties=Excel 8.0";  
			odda=new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet3$]",odcn);
			odda.Fill(dataSet1);
			dg.DataBind();

			Dallas.Core.User user=new Dallas.Core.User();
			SqlDataReader sdr;

			Hashtable newUser,newUserInfo;

			cn.Open();
			foreach (DataRow dr in dataSet1.Tables[0].Rows)
			{
				newUser=new Hashtable();
				newUserInfo=new Hashtable();

				newUser.Add("�û���",dr[1]);
				newUser.Add("����","111111");

				cmd.CommandText="select ID from ���� where ��������='"+dr[3]+"'";
				
				sdr=cmd.ExecuteReader();
				if (sdr.Read())
					newUser.Add("����ID",sdr[0]);
				//				else
				//					throw new Exception(sdr[0]+":"+dr[0]);

				sdr.Close();
				

				//				newUser.Add("��������",PasswordQuestion.Text);
				//				newUser.Add("�����",PasswordAnswer.Text);
				//����״̬Ϊ����
				newUser.Add("״̬ID",1);
				//��������Ϊ��ͨ�û�
				newUser.Add("����ID",1);

				newUserInfo.Add("����",dr[0]);
				//				newUserInfo.Add("�Ա�",Sex.SelectedValue);
				//				newUserInfo.Add("��������",BirthDate.Text);
			
			
				user.Register(newUser,newUserInfo);
			}

			cn.Close();
		}

		private void AddHandler_Click(object sender, System.EventArgs e)
		{
			odcn.ConnectionString=@"Provider=Microsoft.Jet.Oledb.4.0;Data Source=D:\Documents and Settings\Administrator\My Documents\office\db7.mdb";  
			odda=new System.Data.OleDb.OleDbDataAdapter("select distinct �춨��Ա from shoufatable",odcn);
			odda.Fill(dataSet1);
			dg.DataBind();
		}
	}
}
