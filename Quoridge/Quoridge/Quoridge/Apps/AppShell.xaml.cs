using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quoridge
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public static ObservableCollection<Ingredient> storage = new ObservableCollection<Ingredient>();
        public static StoragePage storagePage;
        public static ImageSource picture;
        public AppShell()
        {
            InitializeComponent();

            storagePage = new StoragePage();
            
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        protected async override void OnNavigating(Xamarin.Forms.ShellNavigatingEventArgs args)
        {
            if (Device.RuntimePlatform == Device.Android)
                await Task.Delay(200);
        }


    }
}