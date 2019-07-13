namespace LIMS.Control
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	/// <summary>
	///		Login ��ժҪ˵����
	/// </summary>
	public class Login : System.Web.UI.UserControl
	{
		protected Infragistics.WebUI.WebDataInput.WebTextEdit Password;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit UserName;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Confirm;
		protected System.Web.UI.WebControls.Label Err;
		protected Dallas.Core.User user;
		private void Page_Load(object sender, System.EventArgs e)
		{
			user=new Dallas.Core.User();
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
			this.Confirm.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.Confirm_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Confirm_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			if (UserName.Text=="" || UserName.Text==null)
				return;
			int ID=user.Login(UserName.Text,Password.Text);
			if (ID==0)
				Err.Text="�û������������";
			else
			{
				Session["User"]=new Dallas.Core.User(ID);

				//�������������
				Response.Write(@"<script   language=javascript>window.parent.main.location.href='../main.aspx'</script>");

				//������߿������
				Response.Write(@"<script   language=javascript>window.parent.contents.location.href='../Left.aspx'</script>");
//				Response.Redirect(@"\LIMS\Left.aspx",false);
				
			}
		}
	}
}
