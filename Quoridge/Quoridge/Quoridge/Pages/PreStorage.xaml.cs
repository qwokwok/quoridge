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
    public partial class PreStorage : ContentPage
    {
        public PreStorage()
        {
            InitializeComponent();
            storageButton.Clicked += StorageButton_Clicked;
            countLabel.Text = "Number of storages: " + AppShell.storage.Count.ToString();
        }

        private async void StorageButton_Clicked(object sender, EventArgs e)
        {
            IsEnabled = false;
            await Navigation.PushAsync(AppShell.storagePage, true);
            IsEnabled = true;
        }
    }
}