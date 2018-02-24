using Nom011.ModelDatabase;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nom011App.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListGiros : ContentPage
	{

        static readonly string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
        static readonly string path = Path.Combine(documentsPath, "Nom011dev.db");
        public ListGiros ()
		{
			InitializeComponent ();
            getGiros();

            btnAddGiros.Clicked += BtnAddGiros_Clicked;
            lstGiros.ItemTapped += (sender, e) =>
              {
                  var giro = (Giros)((ListView)sender).SelectedItem;
                  Navigation.PopAsync();
                  Navigation.PushAsync(new AddNewGiro(giro.IdGiro));
              };
		}

        private void BtnAddGiros_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            Navigation.PushAsync(new AddNewGiro());
        }

        private void getGiros()
        {
            var conn = new SQLiteConnection(path);


            var list = conn.Table<Giros>().ToList();

            lstGiros.ItemsSource = list;
        }
    }
}