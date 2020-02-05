using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quoridge
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            hue.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                "Dignissim suspendisse in est ante in nibh mauris cursus. Aliquam vestibulum morbi blandit cursus. Turpis egestas pretium aenean pharetra magna ac " +
                "placerat vestibulum lectus. Sit amet consectetur adipiscing elit. Dignissim diam quis enim lobortis scelerisque fermentum dui. Ac tincidunt vitae semper " +
                "quis lectus nulla at volutpat diam. Urna et pharetra pharetra massa massa ultricies. Iaculis at erat pellentesque adipiscing commodo elit. Pretium vulputate sapien nec sagittis aliquam.";
        }
    }
}