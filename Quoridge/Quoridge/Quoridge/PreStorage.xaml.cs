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
            Navigation.PushAsync(AppShell.storagePage, true);
        }
    }
}