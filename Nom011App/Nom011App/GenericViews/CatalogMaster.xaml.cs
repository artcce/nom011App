using Nom011App.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nom011App.GenericViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CatalogMaster : ContentPage
    {
        public ListView ListView;

        public CatalogMaster()
        {
            InitializeComponent() ;
            Content.BackgroundColor = Color.FromHex("#2e4874");

            BindingContext = new CatalogMasterViewModel();
            ListView = MenuItemsListView;
        }

        class CatalogMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<CatalogMenuItem> MenuItems { get; set; }
            
            public CatalogMasterViewModel()
            {
                MenuItems = new ObservableCollection<CatalogMenuItem>(new[]
                {
                    new CatalogMenuItem { Id = 0, Title = "Nueva Verificacion", TargetType=typeof(NewVerificacion) },
                    new CatalogMenuItem { Id = 1, Title = "Verificador", TargetType=typeof(ListVerificadores) },
                    new CatalogMenuItem { Id = 2, Title = "Equipos", TargetType=typeof(ListEquipo) },
                    new CatalogMenuItem { Id = 3, Title = "Distintivo", TargetType=typeof(ListDistintivo) },
                    new CatalogMenuItem { Id = 4, Title = "Holograma", TargetType=typeof(ListHologramas) },
                    new CatalogMenuItem { Id = 5, Title = "Giros" , TargetType=typeof(ListGiros)},
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
             
            #endregion
        }
    }
}