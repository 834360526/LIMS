namespace LIMS.Control
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using System.ComponentModel;
	/// <summary>
	///		AdvancedSQLBox ��ժҪ˵����
	/// </summary>
	public class AdvancedSQLBox : System.Web.UI.UserControl
	{
		protected char SingleWildcard;
		protected char MultiWildcard;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit ValueText;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		string Sql;
	

		/// <summary>
		/// �����ı�������ݻ��ȡ���ɵ�SQL���
		/// </summary>
		public string Value
		{
			get
			{
				Sql="'"+ValueText.Text+"'";
				//��������ֵ�в�����ͨ���
				if (Sql.IndexOf(SingleWildcard)==-1 && Sql.IndexOf(MultiWildcard)==-1)
				{
					//������Ϊ������
					Sql="="+Sql;
				}
				else
				{
					//����ͨ��������滻ͨ���Ϊ
					Sql=Sql.Replace(SingleWildcard,'_');
					Sql=Sql.Replace(MultiWildcard,'%');

					Sql=" like "+Sql;

				}
				
				return Sql;
			}
			set
			{
				//�����ı�������
				ValueText.Text=value;
			}
		}
		private void Page_Load(object sender, System.EventArgs e)
		{
			//����ͨ���
			SingleWildcard=System.Configuration.ConfigurationSettings.AppSettings["SingleWildcard"][0];
			MultiWildcard=System.Configuration.ConfigurationSettings.AppSettings["MultiWildcard"][0];
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
		///		�����֧������ķ��� - ��Ҫʹ�ô���༭��
		///		�޸Ĵ˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
