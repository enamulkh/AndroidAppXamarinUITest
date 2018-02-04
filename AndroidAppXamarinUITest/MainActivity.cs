using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Distribute;
using Microsoft.AppCenter.Push;

namespace AndroidAppXamarinUITest
{
    [Activity(Label = "AndroidAppXamarinUITest", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            AppCenter.Start("2a70aa9d-ed34-4e01-8def-9ac5852e4c5d",
                       typeof(Analytics), typeof(Crashes));

            Button button = FindViewById<Button>(Resource.Id.button1);

            button.Click += Button_Click;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            EditText textEntry = FindViewById<EditText>(Resource.Id.textView1);
            textEntry.Text = "Button Click is working";
        }
    }
}

