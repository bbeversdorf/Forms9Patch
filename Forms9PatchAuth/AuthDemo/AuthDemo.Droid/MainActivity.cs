﻿using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AuthDemo.Droid
{
	[Activity(Label = "AuthDemo", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);
			Forms9Patch.Droid.Settings.LicenseKey = "L89Z-J4AV-D449-G3P6-TZ29-F45P-M9UN-XLWE-LAXM-LB8C-NTMA-4W2W-QA4D";

			LoadApplication(new AuthDemo.App());
		}
	}
}
