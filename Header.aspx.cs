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

namespace LIMS
{
	/// <summary>
	/// Header ��ժҪ˵����
	/// </summary>
	public class Header : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Name;
		protected Dallas.Core.User user;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
//			if (Session["User"]==null)
//				return;
//			user=(Dallas.Core.User)Session["User"];
			Name.Text=DateTime.Now.ToLongDateString();
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
