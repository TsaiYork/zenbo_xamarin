using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace Zenbo_BookingService
{
    [Activity(Label = "Zenbo_BookingService", MainLauncher = true)]
    public class MainActivity : Activity
    {
        int count = 1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button1 = FindViewById<Button>(Resource.Id.button1);

            button1.Click += delegate { button1.Text = string.Format("{0} clicks!", count++); };
        }

  
    }
}

