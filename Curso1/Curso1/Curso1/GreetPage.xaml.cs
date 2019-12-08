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
	public partial class GreetPage : ContentPage
	{
		public GreetPage ()
		{
			InitializeComponent ();
            sldValue.Value = 0.5;
		}

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblValor2.Text = String.Format("Valor : {0:F2}", e.NewValue);
        }
    }
}