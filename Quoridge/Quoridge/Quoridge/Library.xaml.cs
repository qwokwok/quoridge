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
            ingredientListView.ItemTapped += IngredientListView_ItemTapped;
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

            var libraryPage = new Storage();
            Shell.SetTabBarIsVisible(libraryPage, false);
            Shell.Current.Navigation.PushAsync(libraryPage, true);

        }

        private void IngredientListView_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            Storage.storage.Add(new Ingredient()
            {
                IngredientID = 3,
                Name = "Brown Egg",
                Category = Categories.Dairy,
                Where = Where.Refrigerator
            });

            var libraryPage = new Storage();
            Shell.SetTabBarIsVisible(libraryPage, false);
            Shell.Current.Navigation.PushAsync(libraryPage, true);
        }
    }
}