
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
	[Activity (Label = "SpeedUp")]			
	public class SpeedUp : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.SpeedUp);
			// Create your application here

			TextView tv1 = FindViewById<TextView> (Resource.Id.editText1);
			TextView tv2 = FindViewById<TextView> (Resource.Id.editText2);
			TextView tv3 = FindViewById<TextView> (Resource.Id.editText3);
			TextView tv4 = FindViewById<TextView> (Resource.Id.editText4);


			// Create your application here

			decimal[] AREA = new decimal[9];
			AREA [0] = 100000000000;
			AREA [1] = 7716049;
			AREA [2] = 91440000000	;
			AREA [3] = 2540000000	;



			tv1.TextChanged += delegate 
			{
				if(tv1.IsFocused)
				{
					if(tv1.Text!="")
					{
						tv2.Text=CS.F((System.Convert.ToDecimal (tv1.Text) / AREA[1]*AREA[0]).ToString ());
						tv3.Text=CS.F((System.Convert.ToDecimal (tv1.Text) / AREA[2]*AREA[0]).ToString ());
						tv4.Text=CS.F((System.Convert.ToDecimal (tv1.Text) / AREA[3]*AREA[0]).ToString ());

					}
					else  tv2.Text = tv3.Text = tv4.Text  = "";
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

					}
					else  tv1.Text = tv3.Text = tv4.Text  ="";
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

					}
					else  tv2.Text = tv1.Text = tv4.Text  ="";
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

					}
					else  tv2.Text = tv3.Text = tv1.Text  ="";
				}
			};

		}

	}
}
