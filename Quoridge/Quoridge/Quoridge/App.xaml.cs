using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quoridge
{
    public partial class App : Application
    {
        public static Page Page { get; internal set; }

        //public static List<Ingredient> ingredients = new List<Ingredient>();
        public App()
        {
            //Data.UniversalFood();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjAyMzk3QDMxMzcyZTM0MmUzMEc2Nk93c0JWZ1BJcU5Hb2NDRkh6MnVrMFEyZ21pdDV1RUtPRkYveXJTeTA9");

            InitializeComponent();

            MainPage = new AppShell();

            //theme.Source
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
