using System;
using Android.App;
using Android.OS;
using Android.Widget;
using AndroidMVP.Presentation.Presenters;
using AndroidMVP.Presentation.Views;

namespace AndroidMVP
{
	[Activity(Label = "AndroidMVP", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity, IMainActivityView
	{
		private TextView _clicksCountTxt;
		private Button _helloWorldBtn;
		private MainActivityPresenter _presenter;
		public event EventHandler ButtonClicked;

		public int ClicksCount
		{
			get => int.Parse(_clicksCountTxt.Text);
			set => _clicksCountTxt.Text = value.ToString();
		}

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Main);
			SetView();
		}

		private void SetView()
		{
			_clicksCountTxt = FindViewById<TextView>(Resource.Id.clicksCountTxt);

			_helloWorldBtn = FindViewById<Button>(Resource.Id.helloWorldBtn);
			_helloWorldBtn.Click += (s, e) =>
			{
				ButtonClicked?.Invoke(this, EventArgs.Empty);
			};

			_presenter = new MainActivityPresenter(this);
		}
	}
}

