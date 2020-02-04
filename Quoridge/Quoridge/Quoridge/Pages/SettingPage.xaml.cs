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
    public partial class SettingPage : ContentPage
    {
        ICollection<ResourceDictionary> mergedDictionaries;
        public SettingPage()
        {
            InitializeComponent();

            flyoutList.ItemsSource = FlyoutData.flyoutList;

            mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        }

        private void PurpleButton_Clicked(object sender, EventArgs e)
        {
            mergedDictionaries.Add(new Purple());
        }

        private void LimeButton_Clicked(object sender, EventArgs e)
        {
            mergedDictionaries.Add(new Lime());
        }

        private void PastelButton_Clicked(object sender, EventArgs e)
        {
            mergedDictionaries.Add(new Pastel());
        }

        private void SkyButton_Clicked(object sender, EventArgs e)
        {
            mergedDictionaries.Add(new Sky());
        }

        private void DolButton_Clicked(object sender, EventArgs e)
        {
            mergedDictionaries.Add(new Dol());
        }





        private void DarkButton_Clicked(object sender, EventArgs e)
        {
        }

        private void LightButton_Clicked(object sender, EventArgs e)
        {
        }

        private void FlyoutList_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            IsEnabled = false;
            Flyout item = (Flyout)e.ItemData;
            AppShell.picture = item.Picture;

            IsEnabled = true;
        }
    }
}