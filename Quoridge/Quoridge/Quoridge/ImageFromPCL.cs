using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quoridge
{
    [ContentProperty(nameof(Source))]
    public class ImageFromPCL : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }

            var imageSource = ImageSource.FromResource(Source, typeof(ImageFromPCL).GetTypeInfo().Assembly);

            return imageSource;
        }
    }
}
