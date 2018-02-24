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
	public partial class ListHologramas : ContentPage
	{
        static readonly string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
        static readonly string path = Path.Combine(documentsPath, "Nom011dev.db");

        public ListHologramas ()
		{
			InitializeComponent ();

            getHologramas();

            btnAddHolograma.Clicked += BtnAddHolograma_Clicked;
            // Using ItemTapped
            lstHologramas.ItemTapped += (sender, e) => {
                var ver = (Holograma)((ListView)sender).SelectedItem; // de-select the row
                Navigation.PopAsync();
                Navigation.PushAsync(new AddNewHolograma(ver.IdHolograma));
            };
        }

        private void BtnAddHolograma_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            Navigation.PushAsync(new AddNewHolograma());
        }

        private void getHologramas()
        {
            var conn = new SQLiteConnection(path);


            var list = conn.Table<Holograma>().ToList();

            lstHologramas.ItemsSource = list;
        }
    }
}