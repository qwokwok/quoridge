using Syncfusion.XForms.PopupLayout;
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
    public partial class LibraryPage : ContentPage
    {
        public SfPopupLayout popupLayout = new SfPopupLayout();
        public Ingredient swiped;
        public LibraryPage()
        {
            InitializeComponent();

            ingredientListView.ItemsSource = Data.ingredients;

            //ingredientListView.SelectionChanged += IngredientListView_SelectionChanged;

            searchBar.TextChanged += SearchBar_TextChanged;

            //ingredientListView.ItemTapped += IngredientListView_ItemTapped;

            ingredientListView.Swiping += IngredientListView_Swiping;

            popupLayout.Closed += PopupLayout_Closed;
        }

        private void IngredientListView_Swiping(object sender, Syncfusion.ListView.XForms.SwipingEventArgs e)
        {
            swiped = (Ingredient)e.ItemData;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                ingredientListView.ItemsSource = Data.ingredients;
            }
            else
            {
                ingredientListView.ItemsSource = (Data.ingredients.Where(x => x.Name.ToLower().Contains(e.NewTextValue.ToLower())
                || x.Category.ToString().ToLower().Contains(e.NewTextValue.ToLower())));
            }
        }

        //private void IngredientListView_SelectionChanged(object sender, Syncfusion.ListView.XForms.ItemSelectionChangedEventArgs e)
        //{

        //}

        private void IngredientListView_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            //Ingredient ingredient = (Ingredient)e.ItemData;

            //AppShell.storage.Add(ingredient);

            //Navigation.RemovePage(AppShell.storagePage);
            //AppShell.storagePage = new Storage();
            //Navigation.InsertPageBefore(AppShell.storagePage, this);



            //var popupLayout = new SfPopupLayout();
            //popupLayout.PopupView.AnimationMode = AnimationMode.Zoom;
            //popupLayout.Show();
        }
        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            IsEnabled = false;

            Ingredient ingredient = swiped;

            //AppShell.storage.Add(ingredient);

            await Navigation.PushAsync(new PopUp());
            popupLayout.PopupView.AnimationMode = AnimationMode.Zoom;
            popupLayout.Show();

            if (popupLayout.IsOpen == true)
            {
                await Task.Delay(1000);
                IsEnabled = true;
            }
        }

        private void PopupLayout_Closed(object sender, EventArgs e)
        {
            ingredientListView.ResetSwipe(true);
        }
    }
}