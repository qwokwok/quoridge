using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Quoridge
{
    public static class Data
    {
        public static ObservableCollection<Ingredient> ingredients;
        static Data()
        {
            var list = new List<Ingredient>();
            var newList = new ObservableCollection<Ingredient>();
            UniversalFood(list);
            var preIngredients = list.OrderBy(i => i.Name).ToList();

            for (int i = 0; i < preIngredients.Count; i++)
                newList.Add(preIngredients[i]);
            ingredients = newList;
        }
        public static void UniversalFood(List<Ingredient> list)
        {
            list.Add(new Ingredient() { IngredientID = 1, Name = "Salmon", Category = Categories.Fish, Where = Where.Frozen, Image = "NotDone.png",
                Description = "",
                //LibraryImage = ImageSource.FromResource("Quoridge.Images.Fish.salmon.png", typeof(LibraryPage))
            });
            list.Add(new Ingredient() { IngredientID = 2, Name = "White Egg", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "whiteEgg.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.whiteEgg.png", typeof(LibraryPage)),
                Description = "consists primarily of about 90% water into which about 10% proteins (including albumins, mucoproteins, and globulins) are dissolved. " +
                "Unlike the yolk, which is high in lipids (fats), egg white contains almost no fat, and carbohydrate content is less than 1%." });
            list.Add(new Ingredient() { IngredientID = 3, Name = "Brown Egg", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "brownEgg.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.brownEgg.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 4, Name = "Butter", Category = Categories.Dairy, Where = Where.Refrigerator,Image = "butter.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.butter.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 5, Name = "Milk", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "milk.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.milk.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 6, Name = "Parmesan", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "parmesan.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.parmesan.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 7, Name = "Cheddar", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "cheddar.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.cheddar.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 8, Name = "American Cheese", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "americanCheese.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.americanCheese.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 9, Name = "Sour Cream", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "sourCream.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.sourCream.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 10, Name = "Cream Cheese", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "creamCheese.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.creamCheese.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 11, Name = "Mozzarella", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "mozzarella.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.mozzarella.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 12, Name = "Yogurt", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "yogurt.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.yogurt.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 13, Name = "Evaporated Milk", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "evaporatedMilk.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.evaporatedMilk.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 14, Name = "Whipped Cream", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "whippedCream.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.whippedCream.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 15, Name = "Half And Half", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "halfAndHalf.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.halfAndHalf.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 16, Name = "Feta", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "feta.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.feta.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 17, Name = "Monterey Jack Cheese", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "montereyJackCheese.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.montereyJackCheese.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 18, Name = "Condensed Milk", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "condensedMilk.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.condensedMilk.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 19, Name = "Cottage Cheese", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "cottageCheese.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.cottageCheese.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 20, Name = "Ice Cream", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "iceCream.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.iceCream.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 21, Name = "Swiss Cheese", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "swissCheese.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.swissCheese.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 22, Name = "Velveeta", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "velveeta.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.velveeta.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 23, Name = "Frosting", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "frosting.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.frosting.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 24, Name = "Buttermilk", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "buttermilk.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.buttermilk.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 25, Name = "Ricotta", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "ricotta.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.ricotta.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 26, Name = "Goat Milk", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "goatMilk.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.goatMilk.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 27, Name = "Provolone", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "provolone.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.provolone.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 28, Name = "Blue Cheese", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "blueCheese.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.blueCheese.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 29, Name = "Powdered Milk", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "powderedMilk.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.powderedMilk.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 30, Name = "Colby Cheese", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "colbyCheese.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.colbyCheese.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 31, Name = "Pepper Jack Cheese", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "pepperJackCheese.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.pepperJackCheese.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 32, Name = "Italian Cheese", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "italianCheese.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.italianCheese.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 33, Name = "Soft Cheese", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "softCheese.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.softCheese.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 34, Name = "Gouda", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "gouda.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.gouda.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 35, Name = "Romano", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "romano.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.romano.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 36, Name = "Brie", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "brie.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.brie.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 37, Name = "Pizza Cheese", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "pizzaCheese.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.pizzaCheese.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 38, Name = "Ghee", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "ghee.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.ghee.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 39, Name = "Creme Fraiche", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "cremeFraiche.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.cremeFraiche.png", typeof(LibraryPage)),
                Description = "" });
            list.Add(new Ingredient() { IngredientID = 40, Name = "Cheese Soup", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "cheeseSoup.png",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.cheeseSoup.png", typeof(LibraryPage)),
                Description = "" });


            list.Add(new Ingredient()
            {
                IngredientID = 41,
                Name = "Gruyere",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "gruyere.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 42,
                Name = "Pecorino Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "pecorinoCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 43,
                Name = "Custard",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "custard.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 44,
                Name = "Muenster",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "muenster.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 45,
                Name = "Queso Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "quesoCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 46,
                Name = "Hard Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "hardCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 47,
                Name = "Havarti Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "havartiCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 48,
                Name = "Asiago",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "asiago.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 49,
                Name = "Mascarpone",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "mascarpone.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 50,
                Name = "Neufchatel",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "neufchatel.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 51,
                Name = "Halloumi",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "halloumi.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 52,
                Name = "Paneer",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "paneer.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 53,
                Name = "Brick Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "brickCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 54,
                Name = "Camembert Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "camembertCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 55,
                Name = "Garlic Herb Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "garlicHerbCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 56,
                Name = "Edam Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "edamCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 57,
                Name = "Manchego",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "manchego.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 58,
                Name = "Fontina",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "fontina.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 59,
                Name = "Stilton Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "stiltonCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 60,
                Name = "Emmental Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "emmentalCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 61,
                Name = "Red Leicester Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "redLeicesterCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 62,
                Name = "Jarlsberg Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "jarlsbergCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 63,
                Name = "Bocconcini Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "bocconciniCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 64,
                Name = "Farmer Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "farmerCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 65,
                Name = "Creme De Cassis",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "cremeDeCassis.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 66,
                Name = "Wensleydale Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "wensleydaleCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 67,
                Name = "Longhorn Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "longhornCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 68,
                Name = "Double Gloucester",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "doubleGloucester.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 69,
                Name = "Raclette Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "racletteCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 70,
                Name = "Lancashire Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "lancashireCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 71,
                Name = "Cheshire Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "cheshireCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 72,
                Name = "Goat Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "goatCheese.png",
                Description = ""
            });
        }
    }
}
