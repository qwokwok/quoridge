using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Quoridge
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class Storage : ContentPage
    {
        public Storage()
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
            AppShell.fromDrawer = false;
            IsEnabled = false;
            var libraryPage = new LibraryPage();
            Shell.SetTabBarIsVisible(libraryPage, true);
            await Shell.Current.Navigation.PushAsync(libraryPage, true);
            IsEnabled = true;
        }
    }
}
