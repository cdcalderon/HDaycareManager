using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using HDaycareManager.Core.ViewModel;
using HDaycareManager.Core.Contracts.ViewModels;
using HDaycareManager.Core.Model;
using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.Messenger;
using HDaycareManager.Core.Contracts.Services;
using HDaycareManager.Core.Extensions;

namespace HDaycareManager.Core
{
	public class KidListViewModel : BaseViewModel, IKidListViewModel
	{
		private readonly IKidDataService _kidDataService;
		private ObservableCollection<Kid> _kids;

		public KidListViewModel(IMvxMessenger messenger, IKidDataService kidDataService) : base(messenger)
        {
			_kidDataService = kidDataService;

			//InitializeMessenger();
		}


		//private void InitializeMessenger()
		//{
		//	Messenger.Subscribe<CurrencyChangedMessage>(async message => await ReloadDataAsync());
		//}
		public ObservableCollection<Kid> Kids
		{
			get
			{
				return _kids;
			}
			set
			{
				_kids = value;
				RaisePropertyChanged(() => Kids);
			}
		}

		public override async void Start()
		{
			base.Start();
			await ReloadDataAsync();
		}

		protected override async Task InitializeAsync()
		{
			//var user = _userDataService.GetActiveUser();
			Kids = (await _kidDataService.GetKids()).ToObservableCollection();
		}
	}
}
