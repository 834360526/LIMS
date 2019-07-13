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
	///	页面左边的菜单
	/// </summary>
	public class LeftMenu : System.Web.UI.UserControl
	{
		protected Infragistics.WebUI.UltraWebListbar.UltraWebListbar Menu;
		private User user;
		private void Page_Load(object sender, System.EventArgs e)
		{
			//测试用
			user=(Dallas.Core.User)Session["User"];
			GenerateMenu();
		}

		/// <summary>
		/// 生成菜单
		/// </summary>
		protected void GenerateMenu()
		{
			string ParentMenuName;
			Menu m=new Menu();

			//向菜单控间添加父项目

			//获取父项目
			ArrayList rootMenu=m.GetRootMenu();
			IEnumerator rootie = rootMenu.GetEnumerator();
			while ( rootie.MoveNext() )
			{
				ParentMenuName=rootie.Current.ToString();
			
				//为每个父选项添加其子项目
				ArrayList subMenu=m.GetSubMenu(ParentMenuName,user.ID);

				//只有包含子项目的才添加其父项目
				if (subMenu.Count>0)	
				{
					Menu.Groups.Add(ParentMenuName);
					//
					
					IEnumerator subie =subMenu.GetEnumerator();

					//向父项目中添加子项目
					while(subie.MoveNext())
					{
						ArrayList submenuPara=(ArrayList)subie.Current;
						
						
						Menu.Groups[ Menu.Groups.Count-1 ].Items.Add(submenuPara[0].ToString(),submenuPara[0].ToString());
						//添加链接地址
						Menu.Groups[Menu.Groups.Count-1].Items.FromKey(submenuPara[0].ToString()).TargetUrl=submenuPara[1].ToString();
						//添加目标框架
						Menu.Groups[Menu.Groups.Count-1].Items.FromKey(submenuPara[0].ToString()).TargetFrame="main";
					}
					
				}
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
		///		设计器支持所需的方法 - 不要使用代码编辑器
		///		修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
