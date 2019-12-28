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
                Where = Where.Frozen
            });

            App.ingredients.Add(new Ingredient()
            {
                IngredientID = 2,
                Name = "White Egg",
                Category = Categories.Dairy,
                Where = Where.Refrigerator
            });

            App.ingredients.Add(new Ingredient()
            {
                IngredientID = 3,
                Name = "Brown Egg",
                Category = Categories.Dairy,
                Where = Where.Refrigerator
            });
        }
    }
}
