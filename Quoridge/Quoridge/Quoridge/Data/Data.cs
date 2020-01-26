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
            list.Add(new Ingredient() { IngredientID = 1, Name = "Salmon", Category = Categories.Fish, Where = Where.Frozen, Image = "NotDone.png", Description = "" });
            list.Add(new Ingredient() {
                IngredientID = 2,
                Name = "White Egg",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "whiteEgg.png",
                Description = "consists primarily of about 90% water into which about 10% proteins (including albumins, mucoproteins, and globulins) are dissolved. Unlike the yolk, which is high in lipids (fats), egg white contains almost no fat, and carbohydrate content is less than 1%.",
                LibraryImage = ImageSource.FromResource("Quoridge.Images.Dairy.whiteEgg.png", typeof(LibraryPage))
        });

            list.Add(new Ingredient() { IngredientID = 3, Name = "Brown Egg", Category = Categories.Dairy, Where = Where.Refrigerator, Image = "brownEgg.png", Description = "" });
            list.Add(new Ingredient() { IngredientID = 4, Name = "Butter", Category = Categories.Dairy, Where = Where.Refrigerator,Image = "butter.png", Description = "" });

            list.Add(new Ingredient()
            {
                IngredientID = 5,
                Name = "Milk",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "milk.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 6,
                Name = "Parmesan",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "parmesan.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 7,
                Name = "Cheddar",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "cheddar.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 8,
                Name = "American Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "americanCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 9,
                Name = "Sour Cream",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "sourCream.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 10,
                Name = "Cream Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "creamCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 11,
                Name = "Mozzarella",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "mozzarella.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 12,
                Name = "Yogurt",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "yogurt.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 13,
                Name = "Evaporated Milk",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "evaporatedMilk.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 14,
                Name = "Whipped Cream",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "whippedCream.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 15,
                Name = "Half And Half",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "halfAndHalf.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 16,
                Name = "Feta",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "feta.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 17,
                Name = "Monterey Jack Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "montereyJackCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 18,
                Name = "Condensed Milk",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "condensedMilk.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 19,
                Name = "Cottage Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "cottageCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 20,
                Name = "Ice Cream",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "iceCream.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 21,
                Name = "Swiss Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "swissCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 22,
                Name = "Velveeta",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "velveeta.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 23,
                Name = "Frosting",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "frosting.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 24,
                Name = "Buttermilk",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "buttermilk.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 25,
                Name = "Ricotta",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "ricotta.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 26,
                Name = "Goat Milk",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "goatMilk.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 27,
                Name = "Provolone",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "provolone.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 28,
                Name = "Blue Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "blueCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 29,
                Name = "Powdered Milk",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "powderedMilk.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 30,
                Name = "Colby Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "colbyCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 31,
                Name = "Pepper Jack Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "pepperJackCheese.png",
                Description = ""
            });
            list.Add(new Ingredient()
            {
                IngredientID = 32,
                Name = "Italian Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "italianCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 33,
                Name = "Soft Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "softCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 34,
                Name = "Gouda",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "gouda.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 35,
                Name = "Romano",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "romano.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 35,
                Name = "Brie",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "brie.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 36,
                Name = "Pizza Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "pizzaCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 37,
                Name = "Ghee",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "ghee.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 38,
                Name = "Creme Fraiche",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "cremeFraiche.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 39,
                Name = "Cheese Soup",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "cheeseSoup.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 40,
                Name = "Gruyere",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "gruyere.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 41,
                Name = "Pecorino Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "pecorinoCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 42,
                Name = "Custard",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "custard.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 43,
                Name = "Muenster",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "muenster.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 44,
                Name = "Queso Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "quesoCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 45,
                Name = "Hard Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "hardCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 46,
                Name = "Havarti Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "havartiCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 47,
                Name = "Asiago",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "asiago.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 48,
                Name = "Mascarpone",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "mascarpone.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 49,
                Name = "Neufchatel",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "neufchatel.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 50,
                Name = "Halloumi",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "halloumi.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 51,
                Name = "Paneer",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "paneer.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 52,
                Name = "Brick Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "brickCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 53,
                Name = "Camembert Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "camembertCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 54,
                Name = "Garlic Herb Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "garlicHerbCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 55,
                Name = "Edam Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "edamCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 56,
                Name = "Manchego",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "manchego.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 57,
                Name = "Fontina",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "fontina.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 58,
                Name = "Stilton Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "stiltonCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 59,
                Name = "Emmental Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "emmentalCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 60,
                Name = "Red Leicester Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "redLeicesterCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 61,
                Name = "Jarlsberg Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "jarlsbergCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 62,
                Name = "Bocconcini Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "bocconciniCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 63,
                Name = "Farmer Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "farmerCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 64,
                Name = "Creme De Cassis",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "cremeDeCassis.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 65,
                Name = "Wensleydale Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "wensleydaleCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 66,
                Name = "Longhorn Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "longhornCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 67,
                Name = "Double Gloucester",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "doubleGloucester.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 68,
                Name = "Raclette Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "racletteCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 69,
                Name = "Lancashire Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "lancashireCheese.png",
                Description = ""
            });

            list.Add(new Ingredient()
            {
                IngredientID = 70,
                Name = "Cheshire Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "cheshireCheese.png",
                Description = ""
            });
        }
    }
}
