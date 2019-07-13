namespace LIMS.Control
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using System.Collections;

	/// <summary>
	///		IndividualTree ��ժҪ˵����
	/// </summary>
	public class IndividualTree : System.Web.UI.UserControl
	{
		protected Infragistics.WebUI.UltraWebNavigator.UltraWebTree IndividualWebTree;
		protected System.Web.UI.WebControls.Button Button1;
		protected Dallas.Core.Message msg;

		/// <summary>
		/// ѡ��������˵�ID
		/// </summary>
		public ArrayList SelectedNodes
		{
			get
			{
				return msg.GetSelectedNodes(IndividualWebTree,2);
			}
		}

		private void Page_Load(object sender, System.EventArgs e)
		{
			msg=new Dallas.Core.Message();
			if (!IsPostBack)
			{
				msg.AddIndividualtree(ref IndividualWebTree);
				IndividualWebTree.Nodes[0].Expand(false);
//					.ExpandAll();
			}
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

//		private void Button1_Click(object sender, System.EventArgs e)
//		{
//			ArrayList SelectedNodes=msg.GetSelectedNodes(IndividualWebTree,2);
//			foreach(string[] s in SelectedNodes)
//				Response.Write(s[0]+"---"+s[1]+"<br>");
//		}
	}
}
