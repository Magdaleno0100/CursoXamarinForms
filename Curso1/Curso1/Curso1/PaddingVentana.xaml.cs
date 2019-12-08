using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Curso1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaddingVentana : ContentPage
    {
        public PaddingVentana()
        {
            InitializeComponent();
            sldValue2.Value = 0.5;

            //Se comenta para agregar esto mismo con XAML
            /*
            if (Device.RuntimePlatform == Device.iOS)
                Padding = new Thickness(0, 20, 0, 0);
            else if (Device.RuntimePlatform == Device.Android)
                Padding = new Thickness(0, 20, 0, 0);
            else if (Device.RuntimePlatform == Device.WPF)
                Padding = new Thickness(0, 20, 0, 0);
                */

            /*
             * Se comenta otra forma de agregar padding
             var x = new OnPlatform<Thickness>
            {
                Android = new Thickness(0),
                iOS = new Thickness(0,20,0,0)
            };

            Padding = x;
            */




        }
    }
}