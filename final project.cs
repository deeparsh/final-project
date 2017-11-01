using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            Button btnCall = FindViewById<Button>(Resource.Id.call);

            btnCall.Click += delegate
            {
                //open dialer

                var uri1 = Android.Net.Uri.Parse("tel:2892423237");
                var intent = new Intent(Intent.ActionDial, uri1);
                StartActivity(intent);


            };

        }
    }
};


