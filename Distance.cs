
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
	[Activity (Label = "Distance")]			
	public class Distance : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Distance);
			// Create your application here

			TextView tv1 = FindViewById<TextView> (Resource.Id.editText1);
			TextView tv2 = FindViewById<TextView> (Resource.Id.editText2);
			TextView tv3 = FindViewById<TextView> (Resource.Id.editText3);
			TextView tv4 = FindViewById<TextView> (Resource.Id.editText4);
			TextView tv5 = FindViewById<TextView> (Resource.Id.editText5);
			TextView tv6 = FindViewById<TextView> (Resource.Id.editText6);
			TextView tv7 = FindViewById<TextView> (Resource.Id.editText7);
			TextView tv8 = FindViewById<TextView> (Resource.Id.editText8);
			TextView tv9 = FindViewById<TextView> (Resource.Id.editText9);
			TextView tv10 = FindViewById<TextView> (Resource.Id.editText10);

			tv1.TextChanged += delegate {
				if(tv1.IsFocused)
				{
					if(tv1.Text!="")
					{
						tv2.Text=CS.F((System.Convert.ToDecimal (tv1.Text) / 1000).ToString ());
						tv3.Text=CS.F((System.Convert.ToDecimal (tv1.Text) / 10000).ToString ());
						tv4.Text=CS.F((System.Convert.ToDecimal (tv1.Text) / 100000).ToString ());
						tv5.Text=CS.F((System.Convert.ToDecimal (tv1.Text) / 1000000).ToString ());
						tv6.Text=CS.F((System.Convert.ToDecimal (tv1.Text) / 1000000000).ToString ());
						tv7.Text=CS.F((System.Convert.ToDecimal (tv1.Text) / 25400).ToString ());
						tv8.Text=CS.F((System.Convert.ToDecimal (tv1.Text) / 304800).ToString ());
						tv9.Text=CS.F((System.Convert.ToDecimal (tv1.Text) / 914400).ToString ());
						tv10.Text=CS.F((System.Convert.ToDecimal (tv1.Text) / 1609344000).ToString ());
					}
					else  tv2.Text = tv3.Text = tv4.Text = tv5.Text = tv6.Text = tv7.Text = tv8.Text =tv9.Text =tv10.Text ="";
				}
			};
			tv2.TextChanged += delegate {
				if(tv2.IsFocused)
				{
					if(tv2.Text!="")
					{
						tv1.Text=CS.F((System.Convert.ToDecimal (tv2.Text) * 1000).ToString ());
						tv3.Text=CS.F((System.Convert.ToDecimal (tv2.Text) / 10).ToString ());
						tv4.Text=CS.F((System.Convert.ToDecimal (tv2.Text) / 100).ToString ());
						tv5.Text=CS.F((System.Convert.ToDecimal (tv2.Text) / 1000).ToString ());
						tv6.Text=CS.F((System.Convert.ToDecimal (tv2.Text) / 1000000).ToString ());
						tv7.Text=CS.F((System.Convert.ToDecimal (tv2.Text) / 254*10).ToString ());
						tv8.Text=CS.F((System.Convert.ToDecimal (tv2.Text) / 3048*10).ToString ());
						tv9.Text=CS.F((System.Convert.ToDecimal (tv2.Text) / 9144*10).ToString ());
						tv10.Text=CS.F((System.Convert.ToDecimal (tv2.Text) / 1609344).ToString ());
					}
					else tv1.Text =  tv3.Text = tv4.Text = tv5.Text = tv6.Text = tv7.Text = tv8.Text =tv9.Text =tv10.Text ="";
				}
			};
			tv3.TextChanged += delegate {
				if(tv3.IsFocused)
				{
					if(tv3.Text!="")
					{
						tv2.Text=CS.F((System.Convert.ToDecimal (tv3.Text) * 10).ToString ());
						tv1.Text=CS.F((System.Convert.ToDecimal (tv3.Text) * 10000).ToString ());
						tv4.Text=CS.F((System.Convert.ToDecimal (tv3.Text) / 10).ToString ());
						tv5.Text=CS.F((System.Convert.ToDecimal (tv3.Text) / 100).ToString ());
						tv6.Text=CS.F((System.Convert.ToDecimal (tv3.Text) / 100000).ToString ());
						tv7.Text=CS.F((System.Convert.ToDecimal (tv3.Text) / 254*100).ToString ());
						tv8.Text=CS.F((System.Convert.ToDecimal (tv3.Text) / 3048*100).ToString ());
						tv9.Text=CS.F((System.Convert.ToDecimal (tv3.Text) / 9144*100).ToString ());
						tv10.Text=CS.F((System.Convert.ToDecimal (tv3.Text) / 1609344*10).ToString ());
					}
					else tv1.Text = tv2.Text = tv4.Text = tv5.Text = tv6.Text = tv7.Text = tv8.Text =tv9.Text =tv10.Text ="";
				}
			};
			tv4.TextChanged += delegate {
				if(tv4.IsFocused)
				{
					if(tv4.Text!="")
					{
						tv2.Text=CS.F((System.Convert.ToDecimal (tv4.Text) * 100).ToString ());
						tv3.Text=CS.F((System.Convert.ToDecimal (tv4.Text) * 10).ToString ());
						tv1.Text=CS.F((System.Convert.ToDecimal (tv4.Text) * 100000).ToString ());
						tv5.Text=CS.F((System.Convert.ToDecimal (tv4.Text) / 10).ToString ());
						tv6.Text=CS.F((System.Convert.ToDecimal (tv4.Text) / 10000).ToString ());
						tv7.Text=CS.F((System.Convert.ToDecimal (tv4.Text) / 254*1000).ToString ());
						tv8.Text=CS.F((System.Convert.ToDecimal (tv4.Text) / 3048*1000).ToString ());
						tv9.Text=CS.F((System.Convert.ToDecimal (tv4.Text) / 9144*1000).ToString ());
						tv10.Text=CS.F((System.Convert.ToDecimal (tv4.Text) / 1609344*100).ToString ());
					}
					else tv1.Text = tv2.Text = tv3.Text = tv5.Text = tv6.Text = tv7.Text = tv8.Text =tv9.Text =tv10.Text ="";
				}
			};
			tv5.TextChanged += delegate {
				if(tv5.IsFocused)
				{
					if(tv5.Text!="")
					{
						tv2.Text=CS.F((System.Convert.ToDecimal (tv5.Text) * 1000).ToString ());
						tv3.Text=CS.F((System.Convert.ToDecimal (tv5.Text) * 100).ToString ());
						tv4.Text=CS.F((System.Convert.ToDecimal (tv5.Text) * 10).ToString ());
						tv1.Text=CS.F((System.Convert.ToDecimal (tv5.Text) * 1000000).ToString ());
						tv6.Text=CS.F((System.Convert.ToDecimal (tv5.Text) / 1000).ToString ());
						tv7.Text=CS.F((System.Convert.ToDecimal (tv5.Text) / 254*10000).ToString ());
						tv8.Text=CS.F((System.Convert.ToDecimal (tv5.Text) / 3048*10000).ToString ());
						tv9.Text=CS.F((System.Convert.ToDecimal (tv5.Text) / 9144*10000).ToString ());
						tv10.Text=CS.F((System.Convert.ToDecimal (tv5.Text) / 1609344*1000).ToString ());
					}
					else tv1.Text = tv2.Text = tv3.Text = tv4.Text = tv6.Text = tv7.Text = tv8.Text =tv9.Text =tv10.Text ="";
				}
			};
			tv6.TextChanged += delegate {
				if(tv6.IsFocused)
				{
					if(tv6.Text!="")
					{
						tv2.Text=CS.F((System.Convert.ToDecimal (tv6.Text) * 1000000).ToString ());
						tv3.Text=CS.F((System.Convert.ToDecimal (tv6.Text) * 100000).ToString ());
						tv4.Text=CS.F((System.Convert.ToDecimal (tv6.Text) * 10000).ToString ());
						tv5.Text=CS.F((System.Convert.ToDecimal (tv6.Text) * 1000).ToString ());
						tv1.Text=CS.F((System.Convert.ToDecimal (tv6.Text) * 1000000000).ToString ());
						tv7.Text=CS.F((System.Convert.ToDecimal (tv6.Text) / 25400*1000000000).ToString ());
						tv8.Text=CS.F((System.Convert.ToDecimal (tv6.Text) / 304800*1000000000).ToString ());
						tv9.Text=CS.F((System.Convert.ToDecimal (tv6.Text) / 914400*1000000000).ToString ());
						tv10.Text=CS.F((System.Convert.ToDecimal (tv6.Text) / 1609344000*1000000000).ToString ());
					}
					else tv1.Text = tv2.Text = tv3.Text = tv4.Text = tv5.Text = tv7.Text = tv8.Text =tv9.Text =tv10.Text ="";
				}
			};
			tv7.TextChanged += delegate {
				if(tv7.IsFocused)
				{
					if(tv7.Text!="")
					{
						tv2.Text=CS.F((System.Convert.ToDecimal (tv7.Text) * 254/10).ToString ());
						tv3.Text=CS.F((System.Convert.ToDecimal (tv7.Text) * 254/100).ToString ());
						tv4.Text=CS.F((System.Convert.ToDecimal (tv7.Text) * 254/1000).ToString ());
						tv5.Text=CS.F((System.Convert.ToDecimal (tv7.Text) * 254/10000).ToString ());
						tv6.Text=CS.F((System.Convert.ToDecimal (tv7.Text) * 254/1000000000).ToString ());
						tv1.Text=CS.F((System.Convert.ToDecimal (tv7.Text) * 25400).ToString ());
						tv8.Text=CS.F((System.Convert.ToDecimal (tv7.Text) / 12).ToString ());
						tv9.Text=CS.F((System.Convert.ToDecimal (tv7.Text) / 36).ToString ());
						tv10.Text=CS.F((System.Convert.ToDecimal (tv7.Text) / 63360).ToString ());
					}
					else tv1.Text = tv2.Text = tv3.Text = tv4.Text = tv5.Text = tv6.Text = tv8.Text =tv9.Text =tv10.Text ="";
				}
			};
			tv8.TextChanged += delegate {
				if(tv8.IsFocused)
				{
					if(tv8.Text!="")
					{
						tv2.Text=CS.F((System.Convert.ToDecimal (tv8.Text) * 3048/10).ToString ());
						tv3.Text=CS.F((System.Convert.ToDecimal (tv8.Text) * 3048/100).ToString ());
						tv4.Text=CS.F((System.Convert.ToDecimal (tv8.Text) * 3048/1000).ToString ());
						tv5.Text=CS.F((System.Convert.ToDecimal (tv8.Text) * 3048/10000).ToString ());
						tv6.Text=CS.F((System.Convert.ToDecimal (tv8.Text) * 3048/10000000).ToString ());
						tv7.Text=CS.F((System.Convert.ToDecimal (tv8.Text) * 12).ToString ());
						tv1.Text=CS.F((System.Convert.ToDecimal (tv8.Text) * 304800).ToString ());
						tv9.Text=CS.F((System.Convert.ToDecimal (tv8.Text) / 3).ToString ());
						tv10.Text=CS.F((System.Convert.ToDecimal (tv8.Text) / 5280).ToString ());
					}
					else tv1.Text = tv2.Text = tv3.Text = tv4.Text = tv5.Text = tv6.Text = tv7.Text =tv9.Text =tv10.Text ="";
				}
			};
			tv9.TextChanged += delegate {
				if(tv9.IsFocused)
				{
					if(tv9.Text!="")
					{
						tv2.Text=CS.F((System.Convert.ToDecimal (tv9.Text) * 3048*30).ToString ());
						tv3.Text=CS.F((System.Convert.ToDecimal (tv9.Text) * 3048*300).ToString ());
						tv4.Text=CS.F((System.Convert.ToDecimal (tv9.Text) * 3048*3000).ToString ());
						tv5.Text=CS.F((System.Convert.ToDecimal (tv9.Text) * 3048*30000).ToString ());
						tv6.Text=CS.F((System.Convert.ToDecimal (tv9.Text) * 3048*3000000).ToString ());
						tv7.Text=CS.F((System.Convert.ToDecimal (tv9.Text) * 12*3).ToString ());
						tv8.Text=CS.F((System.Convert.ToDecimal (tv9.Text) * 3).ToString ());
						tv1.Text=CS.F((System.Convert.ToDecimal (tv9.Text) * 914400 ).ToString ());
						tv10.Text=CS.F((System.Convert.ToDecimal (tv9.Text) / 1760).ToString ());
					}
					else tv1.Text = tv2.Text = tv3.Text = tv4.Text = tv5.Text = tv6.Text = tv7.Text = tv8.Text =tv10.Text ="";
				}
			};
			tv10.TextChanged += delegate {
				if(tv10.IsFocused)
				{
					if(tv10.Text!="")
					{
						tv1.Text=CS.F((System.Convert.ToDecimal (tv10.Text) * 1609344000).ToString ());
						tv2.Text=CS.F((System.Convert.ToDecimal (tv10.Text) * 1609344).ToString ());
						tv3.Text=CS.F((System.Convert.ToDecimal (tv10.Text) * 1609344/10).ToString ());
						tv4.Text=CS.F((System.Convert.ToDecimal (tv10.Text) * 1609344/100).ToString ());
						tv5.Text=CS.F((System.Convert.ToDecimal (tv10.Text) * 1609344/1000).ToString ());
						tv6.Text=CS.F((System.Convert.ToDecimal (tv10.Text) * 1609344/1000000).ToString ());
						tv7.Text=CS.F((System.Convert.ToDecimal (tv10.Text) * 63360).ToString ());
						tv8.Text=CS.F((System.Convert.ToDecimal (tv10.Text) * 5280).ToString ());
						tv9.Text=CS.F((System.Convert.ToDecimal (tv10.Text) * 1760 ).ToString ());

					}
					else tv1.Text = tv2.Text = tv3.Text = tv4.Text = tv5.Text = tv6.Text = tv7.Text = tv8.Text =tv9.Text ="";
				}
			};
		}
	}
}

