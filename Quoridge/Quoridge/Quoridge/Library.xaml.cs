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
    
    public partial class Library : ContentPage
    {
        public Library()
        {
            InitializeComponent();

            ingredientListView.ItemsSource = App.ingredients;

            //ingredientListView.SelectionChanged += IngredientListView_SelectionChanged;

            searchBar.TextChanged += SearchBar_TextChanged;

            ingredientListView.ItemTapped += IngredientListView_ItemTapped;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(e.NewTextValue))
            {
                ingredientListView.ItemsSource = App.ingredients;
            }
            else
            {
                ingredientListView.ItemsSource = (App.ingredients.Where(x => x.Name.ToLower().Contains(e.NewTextValue.ToLower()) 
                || x.Category.ToString().ToLower().Contains(e.NewTextValue.ToLower())));
            }
        }

        private void IngredientListView_SelectionChanged(object sender, Syncfusion.ListView.XForms.ItemSelectionChangedEventArgs e)
        {
            //var item = ingredientListView.SelectedItem;
            //App.storage.Add(item as Ingredient);
            Storage.storage.Add(new Ingredient()
            {
                IngredientID = 3,
                Name = "Brown Egg",
                Category = Categories.Dairy,
                Where = Where.Refrigerator
            });

        }

        private void IngredientListView_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            //var item = ingredientListView.SelectedItem;
            //App.storage.Add(item as Ingredient);
            Storage.storage.Add(new Ingredient()
            {
                IngredientID = 3,
                Name = "Brown Egg",
                Category = Categories.Dairy,
                Where = Where.Refrigerator
            });

            Navigation.RemovePage(AppShell.storagePage);
            AppShell.storagePage = new Storage();
            Navigation.InsertPageBefore(AppShell.storagePage, this);

            var popupLayout = new SfPopupLayout();
            popupLayout.PopupView.AnimationMode = AnimationMode.Zoom;
            popupLayout.Show();
            
        }

        
        //async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        //{
        //    await Navigation.PopToRootAsync();
        //}
    }
}