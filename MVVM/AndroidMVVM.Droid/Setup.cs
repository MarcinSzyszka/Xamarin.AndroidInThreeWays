using Android.Content;
using AndroidMVVM.Core.Config;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace AndroidMVVM.Droid
{
	public class Setup : MvxAppCompatSetup
	{
		public Setup(Context applicationContext) : base(applicationContext)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new App();
		}
	}
}