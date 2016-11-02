using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using HDaycareManager.Core.Contracts.ViewModel;

namespace HDaycareManager.Core.ViewModel
{
	public class MainViewModel : MvxViewModel, IMainViewModel
	{
		private readonly Lazy<KidListViewModel> _kidListViewModel;
		public KidListViewModel KidListViewModel => _kidListViewModel.Value;

		public MainViewModel()
		{
			_kidListViewModel = new Lazy<KidListViewModel>(Mvx.IocConstruct<KidListViewModel>);
		}

		public void ShowKidList()
		{
			ShowViewModel<KidListViewModel>();
		}
	}
}
