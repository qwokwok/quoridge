using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Quoridge
{
    public class FlyoutData
    {
        public static List<Flyout> flyoutList;
        static FlyoutData()
        {
            var list = new List<Flyout>();

            list.Add(new Flyout() { Name = "kawaii", Picture = ImageSource.FromResource("Quoridge.Images.FlyoutHeader.kawaii.png", typeof(SettingPage)) });
            list.Add(new Flyout() { Name = "beach", Picture = ImageSource.FromResource("Quoridge.Images.FlyoutHeader.beach.png", typeof(SettingPage)) });
            list.Add(new Flyout() { Name = "dessert", Picture = ImageSource.FromResource("Quoridge.Images.FlyoutHeader.dessert.png", typeof(SettingPage)) });

            flyoutList = list;
        }
    }
}
