using Android.App;
using Android.OS;
using AndroidMVVM.Core.ViewModels;
using MvvmCross.Droid.Views;

namespace AndroidMVVM.Droid.Views
{
	[Activity(MainLauncher = true, Icon = "@drawable/icon")]
	public class MainView : MvxActivity<MainViewModel>
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.Main);
		}
	}
}