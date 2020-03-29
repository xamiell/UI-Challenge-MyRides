using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyRidesChallenge.Utils
{
    [ContentProperty(nameof(Source))] // This property is used as a parameter in XAML.
    public class EmbeddedResourceExtention : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }

            // Search for the image resource and return and object that
            // represents the image path.
            var imageSource = ImageSource.FromResource(Source,
                            typeof(EmbeddedResourceExtention).GetTypeInfo().Assembly);
            return imageSource;
        }
    }
}
