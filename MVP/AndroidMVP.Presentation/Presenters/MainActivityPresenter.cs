using System;
using AndroidMVP.Presentation.Views;

namespace AndroidMVP.Presentation.Presenters
{
	public class MainActivityPresenter
	{
		private readonly IMainActivityView _view;

		public MainActivityPresenter(IMainActivityView view)
		{
			_view = view;
			_view.ButtonClicked += _view_ButtonClicked;
		}

		private void _view_ButtonClicked(object sender, EventArgs e)
		{
			_view.ClicksCount++;
		}
	}
}
