using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidCodeBehind
{
	[Activity(Label = "AndroidCodeBehind", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		private TextView _clicksCountTxt;
		private Button _helloWorldBtn;
		private int _clicksCount;

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
				_clicksCount++;
				_clicksCountTxt.Text = _clicksCount.ToString();
			};
		}
	}
}

