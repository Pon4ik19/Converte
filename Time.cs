
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Converter
{
	[Activity (Label = "Time")]			
	public class Time : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Time);
			// Create your application here

			TextView tv1 = FindViewById<TextView> (Resource.Id.editText1);
			TextView tv2 = FindViewById<TextView> (Resource.Id.editText2);
			TextView tv3 = FindViewById<TextView> (Resource.Id.editText3);
			TextView tv4 = FindViewById<TextView> (Resource.Id.editText4);
			TextView tv5 = FindViewById<TextView> (Resource.Id.editText5);
			TextView tv6 = FindViewById<TextView> (Resource.Id.editText6);
			tv1.TextChanged += delegate {
				if(tv1.IsFocused)
				{
				if(tv1.Text!="")
				{
					tv2.Text = CS.F((System.Convert.ToDecimal (tv1.Text) / 60).ToString ());
					tv3.Text = CS.F((System.Convert.ToDecimal (tv1.Text) / 3600).ToString ());
					tv4.Text = CS.F((System.Convert.ToDecimal (tv1.Text) / 86400).ToString ());
					tv5.Text = CS.F((System.Convert.ToDecimal (tv1.Text) / 604800).ToString ());
					tv6.Text = CS.F((System.Convert.ToDecimal (tv1.Text) / 31556926).ToString ());
				}
				else 
				{
					tv2.Text = tv3.Text = tv4.Text = tv5.Text = tv6.Text = ""; 
				}
				}
			};
			tv2.TextChanged += delegate {
				if(tv2.IsFocused)
				{
				if(tv2.Text!="")
				{
					tv1.Text = CS.F((System.Convert.ToDecimal (tv2.Text) * 60).ToString ());
					tv3.Text = CS.F((System.Convert.ToDecimal (tv2.Text) / 60).ToString ());
					tv4.Text = CS.F((System.Convert.ToDecimal (tv2.Text) / 1440).ToString ());
					tv5.Text = CS.F((System.Convert.ToDecimal (tv2.Text) / 10080).ToString ());
					tv6.Text = CS.F((System.Convert.ToDecimal (tv2.Text) / 31556926 * 60).ToString ());
				}
				else 
				{
					tv1.Text = tv3.Text = tv4.Text = tv5.Text = tv6.Text = ""; 
				}
				}
			};

			tv3.TextChanged += delegate {
				if(tv3.IsFocused)
				{
				if(tv3.Text!="" )
				{
					tv1.Text = CS.F((System.Convert.ToDecimal (tv3.Text) * 3600).ToString ());
					tv2.Text = CS.F((System.Convert.ToDecimal (tv3.Text) * 60).ToString ());
					tv4.Text = CS.F((System.Convert.ToDecimal (tv3.Text) / 86400 * 3600).ToString ());
					tv5.Text = CS.F((System.Convert.ToDecimal (tv3.Text) / 604800 * 3600).ToString ());
					tv6.Text = CS.F((System.Convert.ToDecimal (tv3.Text) / 31556926 * 3600).ToString ());
				}
				else 
				{
					tv2.Text = tv1.Text = tv4.Text = tv5.Text = tv6.Text = ""; 
				}
				}
			};
			tv4.TextChanged += delegate {
				if(tv4.IsFocused)
				{
				if(tv4.Text!="")
				{
					tv1.Text = CS.F((System.Convert.ToDecimal (tv4.Text) * 86400).ToString ());
					tv2.Text = CS.F((System.Convert.ToDecimal (tv4.Text) * 1440).ToString ());
					tv3.Text = CS.F((System.Convert.ToDecimal (tv4.Text) * 24).ToString ());
					tv5.Text = CS.F((System.Convert.ToDecimal (tv4.Text) / 604800 * 86400).ToString ());
					tv6.Text = CS.F((System.Convert.ToDecimal (tv4.Text) / 31556926 * 86400).ToString ());
				}
				else 
				{
					tv2.Text = tv3.Text = tv1.Text = tv5.Text = tv6.Text = ""; 
				}
				}
			};
			tv5.TextChanged += delegate {
				if(tv5.IsFocused)
				{
				if(tv5.Text!="")
				{
					tv1.Text = CS.F((System.Convert.ToDecimal (tv5.Text) * 604800).ToString ());
					tv2.Text = CS.F((System.Convert.ToDecimal (tv5.Text) * 10080).ToString ());
					tv3.Text = CS.F((System.Convert.ToDecimal (tv5.Text) * 168).ToString ());
					tv4.Text = CS.F((System.Convert.ToDecimal (tv5.Text) * 7).ToString ());
					tv6.Text = CS.F((System.Convert.ToDecimal (tv5.Text) / 31556926 * 604800).ToString ());
				}
				else 
				{
					tv2.Text = tv3.Text = tv4.Text = tv1.Text = tv6.Text = ""; 
				}
				}
			};
			tv6.TextChanged += delegate {
				if(tv6.IsFocused)
				{
				if(tv6.Text!="")
				{
					tv1.Text = CS.F((System.Convert.ToDecimal (tv6.Text) * 31556926).ToString ());
					tv2.Text = CS.F((System.Convert.ToDecimal (tv6.Text) / 60 * 31556926).ToString ());
					tv3.Text = CS.F((System.Convert.ToDecimal (tv6.Text) / 3600 * 31556926).ToString ());
					tv4.Text = CS.F((System.Convert.ToDecimal (tv6.Text) / 86400 * 31556926).ToString ());
					tv5.Text = CS.F((System.Convert.ToDecimal (tv6.Text) / 604800 * 31556926).ToString ());

				}
				else 
				{
					tv2.Text = tv3.Text = tv4.Text = tv5.Text = tv1.Text = ""; 
				}
				}
			};
		}
	}
}

