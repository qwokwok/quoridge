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
            BackgroundColor = Color.FromRgb(151, 117, 170);
            storageListView.ItemsSource = App.storage;
            storageListView.ItemTapped += JView_ItemTapped;

            //jView.ItemSelected += (sender, e) =>
            //{
            //    ((ListView)sender).SelectedItem = null;
            //};     
        }

        private void JView_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void AddButton_Clicked(object sender, EventArgs e)
        {
            var libraryPage = new Library();
            Shell.SetTabBarIsVisible(libraryPage, false);
            await Shell.Current.Navigation.PushAsync(libraryPage, true);
        }
    }
}
