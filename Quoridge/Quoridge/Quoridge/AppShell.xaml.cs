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
        public AppShell()
        {       
            InitializeComponent();


            //Application.Current.Properties["ID"] = "started";

            //var assembly = typeof(MainPage).GetType().Assembly;
            //Stream s = assembly.GetManifestResourceStream("Quoridge.Food.json");

            //using (var r = new StreamReader(path))
            //{
            //    var json = r.ReadToEnd();
            //    List<Ingredient> foodList = new List<Ingredient>(JsonConvert.DeserializeObject<List<Ingredient>>(json));



            //}
        }
    }
}