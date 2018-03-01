using Nom011.ModelDatabase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nom011App.VerificacionViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BasculasView : ContentPage
	{
		public BasculasView ()
		{
			InitializeComponent ();
            var listBasculas = new ObservableCollection<Basculas>();
            
            listBasculasLS.ItemsSource = listBasculas;
            btnAddBascula.Clicked += (sender, args) => {

                var newBascula = new Basculas(){ };
                listBasculas.Add(newBascula);
                Navigation.PushModalAsync(new AddBascula(newBascula));
                listBasculasLS.ItemsSource = null;
                listBasculasLS.ItemsSource = listBasculas;

            };

            listBasculas.CollectionChanged += (sender, args) => {
                listBasculasLS.ItemsSource = null;
                listBasculasLS.ItemsSource = listBasculas;
            };
          
		}
	}
}