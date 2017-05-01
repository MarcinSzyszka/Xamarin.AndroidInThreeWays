using System;

namespace AndroidMVP.Presentation.Views
{
	public interface IMainActivityView
	{
		event EventHandler ButtonClicked;
		int ClicksCount { get; set; }
	}
}
