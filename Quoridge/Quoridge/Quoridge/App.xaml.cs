using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quoridge
{
    public partial class App : Application
    {
        public static List<Ingredient> ingredients = new List<Ingredient>();
        public App()
        {
            Data.UniversalFood();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTg4NTQ1QDMxMzcyZTM0MmUzMGhrd3JWRGFaNUQ1ZXFUMExZRTlBZmNGM0xCcXQ2NCsya09rd1psU1VZbnM9");

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
