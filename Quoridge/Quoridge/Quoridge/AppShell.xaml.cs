using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quoridge
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public static List<Ingredient> ingredients = new List<Ingredient>();

        public AppShell()
        {
            var i = new Ingredient()
            {
                IngredientID = 1,
                Name = "Salmon",
                Category = Categories.Fish
            };

            ingredients.Add(i);

            InitializeComponent();

            var assembly = typeof(AppShell).GetType().Assembly;
            Stream s = assembly.GetManifestResourceStream("Quoridge.Food.json");

            using (new StreamReader(s))
            {

                List<Ingredient> foodList = new List<Ingredient>(JsonConvert.DeserializeObject<List<Ingredient>>(File.ReadAllText("Food.json")));



            }
        }
    }
}