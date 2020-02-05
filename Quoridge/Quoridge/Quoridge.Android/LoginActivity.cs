using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Quoridge.Droid
{
    [Activity(Label = "LoginActivity", Theme = "@style/LoginTheme", ScreenOrientation = ScreenOrientation.Portrait)]
    public class LoginActivity : Activity
    {
        public Button testButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Login);

            testButton = (Button)FindViewById(Resource.Id.testButton);
            testButton.Click += TestButton_Click;
        }

        private async void TestButton_Click(object sender, EventArgs e)
        {
            testButton.Clickable = false;
            StartActivity(typeof(MainActivity));
            Finish();
            await Task.Delay(500);
            testButton.Clickable = true;
        }
    }
}