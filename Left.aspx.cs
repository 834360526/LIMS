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
namespace LIMS
{
	/// <summary>
	/// Left ��ժҪ˵����
	/// </summary>
	public class Left : BaseForm
	{
		protected Infragistics.WebUI.Misc.WebPanel Info;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
//			Name.Text=user.Name;
//			Offic.Text=user.Office;
			((Label)Info.FindControl("Name")).Text=user.Name;
			((Label)Info.FindControl("Office")).Text=user.Office;
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion


	}
}
