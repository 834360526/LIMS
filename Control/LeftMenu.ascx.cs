namespace LIMS.Control
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using Dallas.Core;
	using System.Collections;

	/// <summary>
	///	ҳ����ߵĲ˵�
	/// </summary>
	public class LeftMenu : System.Web.UI.UserControl
	{
		protected Infragistics.WebUI.UltraWebListbar.UltraWebListbar Menu;
		private User user;
		private void Page_Load(object sender, System.EventArgs e)
		{
			//������
			user=(Dallas.Core.User)Session["User"];
			GenerateMenu();
		}

		/// <summary>
		/// ���ɲ˵�
		/// </summary>
		protected void GenerateMenu()
		{
			string ParentMenuName;
			Menu m=new Menu();

			//��˵��ؼ���Ӹ���Ŀ

			//��ȡ����Ŀ
			ArrayList rootMenu=m.GetRootMenu();
			IEnumerator rootie = rootMenu.GetEnumerator();
			while ( rootie.MoveNext() )
			{
				ParentMenuName=rootie.Current.ToString();
			
				//Ϊÿ����ѡ�����������Ŀ
				ArrayList subMenu=m.GetSubMenu(ParentMenuName,user.ID);

				//ֻ�а�������Ŀ�Ĳ�����丸��Ŀ
				if (subMenu.Count>0)	
				{
					Menu.Groups.Add(ParentMenuName);
					//
					
					IEnumerator subie =subMenu.GetEnumerator();

					//����Ŀ���������Ŀ
					while(subie.MoveNext())
					{
						ArrayList submenuPara=(ArrayList)subie.Current;
						
						
						Menu.Groups[ Menu.Groups.Count-1 ].Items.Add(submenuPara[0].ToString(),submenuPara[0].ToString());
						//������ӵ�ַ
						Menu.Groups[Menu.Groups.Count-1].Items.FromKey(submenuPara[0].ToString()).TargetUrl=submenuPara[1].ToString();
						//���Ŀ����
						Menu.Groups[Menu.Groups.Count-1].Items.FromKey(submenuPara[0].ToString()).TargetFrame="main";
					}
					
				}
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
	}
}
