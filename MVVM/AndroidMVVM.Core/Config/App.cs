using AndroidMVVM.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace AndroidMVVM.Core.Config
{
	public class App : MvxApplication
	{
		public override void Initialize()
		{
			RegisterAppStart<MainViewModel>();
		}
	}
}
