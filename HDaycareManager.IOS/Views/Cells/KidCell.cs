using Foundation;
using System;
using System.CodeDom.Compiler;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using HDaycareManager.Core.Model;
using UIKit;



namespace HDaycareManager.IOS
{
	public class KidCell : MvxTableViewCell
	{
		internal static readonly NSString Identifier = 
			new NSString("KidCell");

		public KidCell(IntPtr handle) : base(handle)
		{

		}

		private void CreateBindings()
		{
			var set = this.CreateBindingSet<KidCell, Kid>();

			//set.Bind(fromCityLabel)
			//	.To(vm => vm.FromCity.CityName);

			//set.Bind(toCityLabel)
			//	.To(vm => vm.ToCity.CityName);

			//set.Bind(departureDateLabel)
			//	.To(vm => vm.JourneyDate)
			//	.WithConversion(new DateTimeToDayConverter());

			//set.Bind(departureTimeLabel)
			//	.To(vm => vm.DepartureTime)
			//	.WithConversion(new DateTimeToTimeConverter());

			set.Apply();
		}

		public override void LayoutSubviews()
		{
			base.LayoutSubviews();
			CreateBindings();
		}
	}
}
