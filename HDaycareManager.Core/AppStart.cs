using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using HDaycareManager.Core.ViewModel;
                     
namespace HDaycareManager.Core
{
	public class AppStart: MvxNavigatingObject, IMvxAppStart
	{
		
		public void Start(object hint = null)
		{
			//hardcoded login for this demo
			//var userService = Mvx.Resolve<IUserDataService>();
			//await userService.Login("gillcleeren", "123456");

			ShowViewModel<MainViewModel>();
		}
	}
}
