using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quoridge
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public static ObservableCollection<Ingredient> storage = new ObservableCollection<Ingredient>();
        public static StoragePage storagePage;
        public static bool fromDrawer = false;
        public AppShell()
        {       
            InitializeComponent();

            storagePage = new StoragePage();

            ingredientTemplate.Appearing += IngredientTemplate_Appearing;
            //Application.Current.Properties["ID"] = "started";

            //var assembly = typeof(MainPage).GetType().Assembly;
            //Stream s = assembly.GetManifestResourceStream("Quoridge.Food.json");

            //using (var r = new StreamReader(path))
            //{
            //    var json = r.ReadToEnd();
            //    List<Ingredient> foodList = new List<Ingredient>(JsonConvert.DeserializeObject<List<Ingredient>>(json));
            //}
        }

        private void IngredientTemplate_Appearing(object sender, EventArgs e)
        {
            fromDrawer = true;
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}