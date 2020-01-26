using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Quoridge
{
    public enum Categories
    {
        Alcohol,
        Baking,
        Beverage,
        Dairy,
        Fish,
        Fruit,
        Grain,
        Legume,
        Meat,
        Nut,
        Oil,
        Sauce,
        Seafood,
        Seasoning,
        Spice,
        Soup,
        Sweetener,
        Vegatable,
    }
    public enum Where
    {
        Frozen,
        Refrigerator,
        RoomTempature
    }

    public class Ingredient
    {
        public int IngredientID { get; set; }
        public string Name { get; set; }
        public string [] Tag { get; set; }
        public Categories Category { get; set; }
        public string MeasureUnit { get; set; }
        public double Quantity { get; set; }
        public DateTime ExpireDate { get; set; }
        public int LastBeforeExpire { get; set; }
        public Where Where { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public ImageSource LibraryImage { get; set; }
    }
}
