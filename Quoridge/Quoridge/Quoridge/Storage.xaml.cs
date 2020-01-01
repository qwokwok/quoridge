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
        public static List<Ingredient> storage = new List<Ingredient>();
        public Storage()
        {
            InitializeComponent();
            
            storageListView.ItemsSource = storage;
            //storageListView.ItemTapped += StorageListView_ItemTapped;
        }

        private void StorageListView_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void AddButton_Clicked(object sender, EventArgs e)
        {
            var libraryPage = new Library();
            Shell.SetTabBarIsVisible(libraryPage, true);
            await Shell.Current.Navigation.PushAsync(libraryPage, true);
        }
    }
}
