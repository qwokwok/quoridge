using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quoridge
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StoragePage : ContentPage
    {
        public StoragePage()
        {
            InitializeComponent();

            storageListView.ItemsSource = AppShell.storage;

            storageListView.ItemTapped += StorageListView_ItemTapped;
        }
        private void StorageListView_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            Shell.Current.FlyoutIsPresented = true;
        }

        private async void AddButton_Clicked(object sender, EventArgs e)
        {
            IsEnabled = false;
            var libraryPage = new LibraryPage();
            Shell.SetTabBarIsVisible(libraryPage, true);
            await Shell.Current.Navigation.PushAsync(libraryPage, true);
            IsEnabled = true;
        }
    }
}