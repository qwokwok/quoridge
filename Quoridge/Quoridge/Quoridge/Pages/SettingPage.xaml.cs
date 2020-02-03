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
    }
}