using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace AndroidMVVM.Core.ViewModels
{
	public class MainViewModel : MvxViewModel
	{
		public MainViewModel()
		{
			ClicksCount = 0;
		}

		private int? _clicksCount;

		public int? ClicksCount
		{
			get => _clicksCount;
			set => SetProperty(ref _clicksCount, value);
		}

		private ICommand _increaseCount;

		public ICommand IncreaseCount => _increaseCount ?? (_increaseCount = new MvxCommand(Increase));

		private void Increase()
		{
			ClicksCount++;
		}
	}
}
