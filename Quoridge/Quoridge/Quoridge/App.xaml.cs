using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quoridge
{
    public partial class App : Application
    {
        //public static List<Ingredient> ingredients = new List<Ingredient>();
        public App()
        {
            //Data.UniversalFood();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjA1MDA2QDMxMzcyZTM0MmUzMEc2Nk93c0JWZ1BJcU5Hb2NDRkh6MnVrMFEyZ21pdDV1RUtPRkYveXJTeTA9");

            InitializeComponent();

            MainPage = new AppShell();
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
