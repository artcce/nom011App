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
	public partial class ListEquipo : ContentPage
	{
        static readonly string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
        static readonly string path = Path.Combine(documentsPath, "Nom011dev.db");

        public ListEquipo ()
		{
			InitializeComponent ();

            getEquipos();
            btnAddEquipo.Clicked += BtnAddEquipo_Clicked;

            lstEquipos.ItemTapped += (sender, e) =>
              {
                  var ver = (Equipo)((ListView)sender).SelectedItem; // de-select the row
                  Navigation.PopAsync();
                  Navigation.PushAsync(new AddNewEquipo(ver.IdEquipo));
              };
		}

        private void BtnAddEquipo_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            Navigation.PushAsync(new AddNewEquipo());
        }

        private void getEquipos()
        {
            var conn = new SQLiteConnection(path);


            var list = conn.Table<Equipo>().ToList();

            lstEquipos.ItemsSource = list;
        }
    }
}