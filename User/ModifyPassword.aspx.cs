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

namespace LIMS.User
{
	/// <summary>
	/// ModifyPassword ��ժҪ˵����
	/// </summary>
	public class ModifyPassword : BaseForm
	{
		protected System.Web.UI.WebControls.CompareValidator CompareValidator1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator3;
		protected System.Web.UI.WebControls.RegularExpressionValidator RegularExpressionValidator2;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit OldPassword;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit NewPassword;
		protected Infragistics.WebUI.WebDataInput.WebTextEdit ConfirmPassword;
		protected Infragistics.WebUI.WebDataInput.WebImageButton Confirm;
		protected System.Web.UI.WebControls.Label Notice;
		protected System.Web.UI.WebControls.RegularExpressionValidator RegularExpressionValidator1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator2;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
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
			this.Confirm.Click += new Infragistics.WebUI.WebDataInput.ClickHandler(this.Confirm_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Confirm_Click(object sender, Infragistics.WebUI.WebDataInput.ButtonEventArgs e)
		{
			if (user.ModifyPassword(OldPassword.Text,NewPassword.Text))
				Notice.Text="�����޸ĳɹ�";
			else
				Notice.Text="�����벻��ȷ";
		}
	}
}
