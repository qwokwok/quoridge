using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridge
{
    public static class Data
    {
        public static void UniversalFood()
        {
            App.ingredients.Add(new Ingredient()
            {
                IngredientID = 1,
                Name = "Salmon",
                Category = Categories.Fish,
                Where = Where.Frozen,
                Image = "NotDone.png",
                Description = ""
            });

            App.ingredients.Add(new Ingredient()
            {
                IngredientID = 2,
                Name = "White Egg",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "egg.png",
                Description = "consists primarily of about 90% water into which about 10% proteins (including albumins, mucoproteins, and globulins) are dissolved. Unlike the yolk, which is high in lipids (fats), egg white contains almost no fat, and carbohydrate content is less than 1%."
            });

            App.ingredients.Add(new Ingredient()
            {
                IngredientID = 3,
                Name = "Brown Egg",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "NotDone.png",
                Description = ""
            });

            App.ingredients.Add(new Ingredient()
            {
                IngredientID = 4,
                Name = "Butter",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "NotDone.png",
                Description = ""
            });

            App.ingredients.Add(new Ingredient()
            {
                IngredientID = 5,
                Name = "Milk",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "NotDone.png",
                Description = ""
            });

            App.ingredients.Add(new Ingredient()
            {
                IngredientID = 6,
                Name = "Parmesan",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "NotDone.png",
                Description = ""
            });

            App.ingredients.Add(new Ingredient()
            {
                IngredientID = 7,
                Name = "Cheddar",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "NotDone.png",
                Description = ""
            });

            App.ingredients.Add(new Ingredient()
            {
                IngredientID = 8,
                Name = "American Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "NotDone.png",
                Description = ""
            });

            App.ingredients.Add(new Ingredient()
            {
                IngredientID = 9,
                Name = "Sour Cream",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "NotDone.png",
                Description = ""
            });

            App.ingredients.Add(new Ingredient()
            {
                IngredientID = 10,
                Name = "Cream Cheese",
                Category = Categories.Dairy,
                Where = Where.Refrigerator,
                Image = "NotDone.png",
                Description = ""
            });
        }
    }
}
