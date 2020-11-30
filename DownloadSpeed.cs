
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
	[Activity (Label = "Download speed")]			
	public class DownloadSpeed : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.DownloadSpeed);
			// Create your application here

			TextView tv1 = FindViewById<TextView> (Resource.Id.editText1);
			TextView tv2 = FindViewById<TextView> (Resource.Id.editText2);
			TextView tv3 = FindViewById<TextView> (Resource.Id.editText3);
			TextView tv4 = FindViewById<TextView> (Resource.Id.editText4);
			TextView tv5 = FindViewById<TextView> (Resource.Id.editText5);
			TextView tv6 = FindViewById<TextView> (Resource.Id.editText6);
			// Create your application here

			decimal[] AREA = new decimal[9];
			AREA [0] = 1;
			AREA [1] = 1024;
			AREA [2] = 1048576;
			AREA [3] = 1073741824;
			AREA [4] = 1099511627776;
			AREA [5] = 1125899906842624;

			tv1.TextChanged += delegate 
			{
				if(tv1.IsFocused)
				{
					if(tv1.Text!="")
					{
						tv2.Text=CS.F((System.Convert.ToDecimal (tv1.Text) / AREA[1]*AREA[0]).ToString ());
						tv3.Text=CS.F((System.Convert.ToDecimal (tv1.Text) / AREA[2]*AREA[0]).ToString ());
						tv4.Text=CS.F((System.Convert.ToDecimal (tv1.Text) / AREA[3]*AREA[0]).ToString ());
						tv5.Text=CS.F((System.Convert.ToDecimal (tv1.Text) / AREA[4]*AREA[0]).ToString ());
						tv6.Text=CS.F((System.Convert.ToDecimal (tv1.Text) / AREA[5]*AREA[0]).ToString ());

					}
					else  tv2.Text = tv3.Text = tv4.Text = tv5.Text = tv6.Text  ="";
				}
			};
			tv2.TextChanged += delegate 
			{
				if(tv2.IsFocused)
				{
					if(tv2.Text!="")
					{
						tv1.Text=CS.F((System.Convert.ToDecimal (tv2.Text) / AREA[0]*AREA[1]).ToString ());
						tv3.Text=CS.F((System.Convert.ToDecimal (tv2.Text) / AREA[2]*AREA[1]).ToString ());
						tv4.Text=CS.F((System.Convert.ToDecimal (tv2.Text) / AREA[3]*AREA[1]).ToString ());
						tv5.Text=CS.F((System.Convert.ToDecimal (tv2.Text) / AREA[4]*AREA[1]).ToString ());
						tv6.Text=CS.F((System.Convert.ToDecimal (tv2.Text) / AREA[5]*AREA[1]).ToString ());

					}
					else  tv1.Text = tv3.Text = tv4.Text = tv5.Text = tv6.Text  ="";
				}
			};
			tv3.TextChanged += delegate 
			{
				if(tv3.IsFocused)
				{
					if(tv3.Text!="")
					{
						tv2.Text=CS.F((System.Convert.ToDecimal (tv3.Text) / AREA[1]*AREA[2]).ToString ());
						tv1.Text=CS.F((System.Convert.ToDecimal (tv3.Text) / AREA[0]*AREA[2]).ToString ());
						tv4.Text=CS.F((System.Convert.ToDecimal (tv3.Text) / AREA[3]*AREA[2]).ToString ());
						tv5.Text=CS.F((System.Convert.ToDecimal (tv3.Text) / AREA[4]*AREA[2]).ToString ());
						tv6.Text=CS.F((System.Convert.ToDecimal (tv3.Text) / AREA[5]*AREA[2]).ToString ());

					}
					else  tv2.Text = tv1.Text = tv4.Text = tv5.Text = tv6.Text  ="";
				}
			};
			tv4.TextChanged += delegate 
			{
				if(tv4.IsFocused)
				{
					if(tv4.Text!="")
					{
						tv2.Text=CS.F((System.Convert.ToDecimal (tv4.Text) / AREA[1]*AREA[3]).ToString ());
						tv3.Text=CS.F((System.Convert.ToDecimal (tv4.Text) / AREA[2]*AREA[3]).ToString ());
						tv1.Text=CS.F((System.Convert.ToDecimal (tv4.Text) / AREA[0]*AREA[3]).ToString ());
						tv5.Text=CS.F((System.Convert.ToDecimal (tv4.Text) / AREA[4]*AREA[3]).ToString ());
						tv6.Text=CS.F((System.Convert.ToDecimal (tv4.Text) / AREA[5]*AREA[3]).ToString ());

					}
					else  tv2.Text = tv3.Text = tv1.Text = tv5.Text = tv6.Text  ="";
				}
			};
			tv5.TextChanged += delegate 
			{
				if(tv5.IsFocused)
				{
					if(tv5.Text!="")
					{
						tv2.Text=CS.F((System.Convert.ToDecimal (tv5.Text) / AREA[1]*AREA[4]).ToString ());
						tv3.Text=CS.F((System.Convert.ToDecimal (tv5.Text) / AREA[2]*AREA[4]).ToString ());
						tv4.Text=CS.F((System.Convert.ToDecimal (tv5.Text) / AREA[3]*AREA[4]).ToString ());
						tv1.Text=CS.F((System.Convert.ToDecimal (tv5.Text) / AREA[0]*AREA[4]).ToString ());
						tv6.Text=CS.F((System.Convert.ToDecimal (tv5.Text) / AREA[5]*AREA[4]).ToString ());

					}
					else  tv2.Text = tv3.Text = tv4.Text = tv1.Text = tv6.Text  ="";
				}
			};
			tv6.TextChanged += delegate 
			{
				if(tv6.IsFocused)
				{
					if(tv6.Text!="")
					{
						tv2.Text=CS.F((System.Convert.ToDecimal (tv6.Text) / AREA[1]*AREA[5]).ToString ());
						tv3.Text=CS.F((System.Convert.ToDecimal (tv6.Text) / AREA[2]*AREA[5]).ToString ());
						tv4.Text=CS.F((System.Convert.ToDecimal (tv6.Text) / AREA[3]*AREA[5]).ToString ());
						tv5.Text=CS.F((System.Convert.ToDecimal (tv6.Text) / AREA[4]*AREA[5]).ToString ());
						tv1.Text=CS.F((System.Convert.ToDecimal (tv6.Text) / AREA[0]*AREA[5]).ToString ());

					}
					else  tv2.Text = tv3.Text = tv4.Text = tv5.Text = tv1.Text ="";
				}
			};

		}

	}
}