using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Converter
{
	[Activity (Label = "Converter", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button1 = FindViewById<Button> (Resource.Id.Button1);
			Button button2 = FindViewById<Button> (Resource.Id.button2);
			Button button3 = FindViewById<Button> (Resource.Id.button3);
			Button button4 = FindViewById<Button> (Resource.Id.button4);
			Button button5 = FindViewById<Button> (Resource.Id.button5);
			button1.Click += delegate {
				var	mIntent = new Intent(this,typeof(Convert));
				StartActivity(mIntent);
			};
			button2.Click += delegate {
				var	mIntent = new Intent(this,typeof(SorryMaybeLater));
				StartActivity(mIntent);
			};
			button3.Click += delegate {
				var	mIntent = new Intent(this,typeof(SorryMaybeLater));
				StartActivity(mIntent);
			};
			button4.Click += delegate {
				var	mIntent = new Intent(this,typeof(SorryMaybeLater));
				StartActivity(mIntent);
			};
			button5.Click += delegate {
				Android.OS.Process.KillProcess (Android.OS.Process.MyPid ()); 

			};

		}
	}
}


