using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nom011App.GenericViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CatalogDetail : ContentPage
    {
        public CatalogDetail()
        {
            InitializeComponent();
            Content.BackgroundColor = Color.FromHex("#343635"); 
          
        }
    }
}