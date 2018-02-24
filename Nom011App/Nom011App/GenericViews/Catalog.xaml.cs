using Nom011.ModelDatabase;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nom011App.GenericViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Catalog : MasterDetailPage
    {
        
        public Catalog()
        {
            InitializeComponent();

           
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as CatalogMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page) { };
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}