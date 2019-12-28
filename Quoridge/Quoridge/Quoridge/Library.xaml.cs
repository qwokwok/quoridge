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

            ingredientListView.SelectionChanged += IngredientListView_SelectionChanged;
            //ingredientListView.ItemTapped += IngredientListView_ItemTapped;
        }

        private void IngredientListView_SelectionChanged(object sender, Syncfusion.ListView.XForms.ItemSelectionChangedEventArgs e)
        {
            var items = e.AddedItems;
            var index = ingredientListView.DataSource.DisplayItems.IndexOf(items[0]);
            App.storage.Add(App.ingredients[index]);
        }

        //private void IngredientListView_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        //{
            
        //    var selectedIngredient = App.ingredients[position].
        //}
    }
}