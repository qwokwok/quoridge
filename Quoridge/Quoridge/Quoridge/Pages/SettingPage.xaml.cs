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

            selectDog.BackgroundColor = Color.FromHex("#BBFAD6");

            mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        }

        //Theme choice
        private void PurpleButton_Clicked(object sender, EventArgs e)
        {
            mergedDictionaries.Add(new Purple());
            AppShell.p = new Purple();
        }

        private void LimeButton_Clicked(object sender, EventArgs e)
        {
            mergedDictionaries.Add(new Lime());
            AppShell.p = new Lime();
        }

        private void PastelButton_Clicked(object sender, EventArgs e)
        {
            mergedDictionaries.Add(new Pastel());
            AppShell.p = new Pastel();
        }

        private void SkyButton_Clicked(object sender, EventArgs e)
        {
            mergedDictionaries.Add(new Sky());
            AppShell.p = new Sky();
        }

        private void DolButton_Clicked(object sender, EventArgs e)
        {
            mergedDictionaries.Add(new Dol());
            AppShell.p = new Dol();
        }

        private void PeachButton_Clicked(object sender, EventArgs e)
        {
            mergedDictionaries.Add(new Peach());
            AppShell.p = new Peach();
        }


        //Night Mode choice
        private void DarkButton_Clicked(object sender, EventArgs e)
        {
            mergedDictionaries.Add(new Dark());
        }

        private void LightButton_Clicked(object sender, EventArgs e)
        {
            if(mergedDictionaries != null)
                mergedDictionaries.Add(AppShell.p);
        }


        //Flyout Header choice
        private void FlyoutList_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            IsEnabled = false;
            Flyout item = (Flyout)e.ItemData;
            App.Current.Resources["Header"] = item.Picture;
            IsEnabled = true;
        }

        //Personal choice
        private void Dog_Clicked(object sender, EventArgs e)
        {
            Select(selectDog, selectPrincess, selectScientist, selectQuoc, selectPaint, selectVampire,
                selectAngel, selectBrave, selectDoll, selectDoom, "Quoridge.Images.Personal.dog.png");
        }

        private void Princess_Clicked(object sender, EventArgs e)
        {
            Select(selectPrincess, selectDog, selectScientist, selectQuoc, selectPaint, selectVampire,
                selectAngel, selectBrave, selectDoll, selectDoom, "Quoridge.Images.Personal.green.png");
        }

        private void Scientist_Clicked(object sender, EventArgs e)
        {
            Select(selectScientist, selectDog, selectPrincess, selectQuoc, selectPaint, selectVampire, 
                selectAngel, selectBrave, selectDoll, selectDoom, "Quoridge.Images.Personal.scientist.png");
        }

        private void Quoc_Clicked(object sender, EventArgs e)
        {
            Select(selectQuoc, selectDog, selectPrincess, selectScientist, selectPaint, selectVampire, 
                selectAngel, selectBrave, selectDoll, selectDoom, "Quoridge.Images.Personal.quoc.png");
        }

        private void Doll_Clicked(object sender, EventArgs e)
        {
            Select(selectDoll, selectDog, selectPrincess, selectScientist, selectPaint, selectVampire,
                selectAngel, selectBrave, selectQuoc, selectDoom, "Quoridge.Images.Personal.dollGirl.png");
        }

        private void Brave_Clicked(object sender, EventArgs e)
        {
            Select(selectBrave, selectDog, selectPrincess, selectScientist, selectPaint, selectVampire,
                selectAngel, selectQuoc, selectDoll, selectDoom, "Quoridge.Images.Personal.braveGirl.png");
        }

        private void Vampire_Clicked(object sender, EventArgs e)
        {
            Select(selectVampire, selectDog, selectPrincess, selectScientist, selectPaint, selectBrave,
                selectAngel, selectQuoc, selectDoll, selectDoom, "Quoridge.Images.Personal.vampireGirl.png");
        }

        private void Paint_Clicked(object sender, EventArgs e)
        {
            Select(selectPaint, selectDog, selectPrincess, selectScientist, selectBrave, selectVampire,
                selectAngel, selectQuoc, selectDoll, selectDoom, "Quoridge.Images.Personal.paintGirl.png");
        }

        private void Angel_Clicked(object sender, EventArgs e)
        {
            Select(selectAngel, selectDog, selectPrincess, selectScientist, selectPaint, selectVampire,
                selectBrave, selectQuoc, selectDoll, selectDoom, "Quoridge.Images.Personal.angelGirl.png");
        }

        private void Doom_Clicked(object sender, EventArgs e)
        {
            Select(selectDoom, selectDog, selectPrincess, selectScientist, selectPaint, selectVampire,
                selectBrave, selectQuoc, selectDoll, selectAngel, "Quoridge.Images.Personal.doomGirl.png");
        }

        private void Select(Button select, Button unselectOne,
                Button unselectTwo, Button unselectThird, Button unselectFour,
                Button unselectFive, Button unselectSix, Button unselectSeven,
                Button unselectEight, Button unselectNine, string name)
        {
            select.BackgroundColor = Color.FromHex("#BBFAD6");
            App.Current.Resources["Personal"] = ImageSource.FromResource(name, typeof(SettingPage));
            unselectOne.BackgroundColor = Color.Transparent; unselectTwo.BackgroundColor = Color.Transparent;
            unselectThird.BackgroundColor = Color.Transparent; unselectFour.BackgroundColor = Color.Transparent;
            unselectFive.BackgroundColor = Color.Transparent; unselectSix.BackgroundColor = Color.Transparent;
            unselectSeven.BackgroundColor = Color.Transparent; unselectEight.BackgroundColor = Color.Transparent;
            unselectNine.BackgroundColor = Color.Transparent;
        }
    }
}