using Syncfusion.XForms.PopupLayout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quoridge
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LibraryPage : ContentPage
    {
        DataTemplate templateView;
        public Ingredient swiped;
        string imagePopup;
        Image image;
        public LibraryPage()
        {
            InitializeComponent();
            
            templateView = new DataTemplate(() =>
            {
                image = new Image();
                image.Source = ImageSource.FromResource(imagePopup, typeof(LibraryPage));
                return image;
            });

            ingredientListView.ItemsSource = Data.ingredients;

            //ingredientListView.SelectionChanged += IngredientListView_SelectionChanged;

            searchBar.TextChanged += SearchBar_TextChanged;

            //ingredientListView.ItemTapped += IngredientListView_ItemTapped;

            ingredientListView.Swiping += IngredientListView_Swiping;
            
            //popupLayout.Closed += PopupLayout_Closed;
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
            ingredientListView.ResetSwipe(true);
        }

        private async void RightTap_Tapped(object sender, EventArgs e)
        {
            IsEnabled = false;

            Ingredient ingredient = swiped;

            //AppShell.storage.Add(ingredient);

            CustomizingPopUpLayout("Quoridge.Images.popup.png", 268, 375, AnimationMode.SlideOnRight);
            //imagePopup = "Quoridge.Images.popup.png";
            //popupLayout.PopupView.HeightRequest = 268;
            //popupLayout.PopupView.WidthRequest = 375;
            //popupLayout.PopupView.AnimationMode = AnimationMode.SlideOnRight;
            //popupLayout.Show();

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

        
        private void LeftTap_Tapped(object sender, EventArgs e)
        {
            CustomizingPopUpLayout("Quoridge.Images.shoppingPopup.png", 300, 300, AnimationMode.SlideOnLeft);
            //imagePopup = "Quoridge.Images.shoppingPopup.png";
            //popupLayout.PopupView.HeightRequest = 49;
            //popupLayout.PopupView.WidthRequest = 49;
            //popupLayout.PopupView.AnimationMode = AnimationMode.SlideOnLeft;
            //popupLayout.Show();
        }

        private void CustomizingPopUpLayout(string imagePath, int height, int width, AnimationMode animation)
        {
            imagePopup = imagePath;
            popupLayout.PopupView.ShowHeader = false;
            popupLayout.PopupView.ShowFooter = false;
            popupLayout.PopupView.HeightRequest = height;
            popupLayout.PopupView.WidthRequest = width;
            popupLayout.PopupView.AnimationMode = animation;
            popupLayout.PopupView.ContentTemplate = templateView;
            popupLayout.Show();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ingredientListView.ResetSwipe(true);
        }
    }
}