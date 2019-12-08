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
	public partial class Ejercicio1 : ContentPage
	{
        private int _inicio = 0;
        private string[] _citas = new string[]
        {
            "Text0",
            "Text1111",
            "Text22222222"
        };
		public Ejercicio1 ()
		{
			InitializeComponent ();
            citas.Text = _citas[_inicio];
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            _inicio++;
            if (_inicio >= _citas.Length)
                _inicio = 0;

            citas.Text = _citas[_inicio];
                

        }
    }
}