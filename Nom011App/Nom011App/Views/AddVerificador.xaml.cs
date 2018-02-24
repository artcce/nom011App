using Nom011.ModelDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nom011App.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddVerificador : ContentPage
	{

       
        public AddVerificador ()
		{
           //  InitializeComponent();

            Verificador verifContext = new Verificador();

            BindingContext = verifContext;
        }
 
    }
}