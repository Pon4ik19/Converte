using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Converter
{
	[Activity (Label = "Power")]			
	public class Power : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Power);
			// Create your application here

			TextView tv1 = FindViewById<TextView> (Resource.Id.editText1);
			TextView tv2 = FindViewById<TextView> (Resource.Id.editText2);
			TextView tv3 = FindViewById<TextView> (Resource.Id.editText3);
			TextView tv4 = FindViewById<TextView> (Resource.Id.editText4);
			TextView tv5 = FindViewById<TextView> (Resource.Id.editText5);

			// Create your application here

			decimal[] AREA = new decimal[9];
			AREA [0] = 100000000;
			AREA [1] = 980665;
			AREA [2] = 980665000;
			AREA [3] = 980665000000;
			AREA [4] = 100000000000;


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

					}
					else  tv2.Text = tv3.Text = tv4.Text = tv5.Text = "";
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

					}
					else  tv1.Text = tv3.Text = tv4.Text = tv5.Text ="";
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

					}
					else  tv2.Text = tv1.Text = tv4.Text = tv5.Text  ="";
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

					}
					else  tv2.Text = tv3.Text = tv1.Text = tv5.Text ="";
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

					}
					else  tv2.Text = tv3.Text = tv4.Text = tv1.Text ="";
				}
			};

		}

	}
}
