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
	public partial class ListDistintivo : ContentPage
	{

        static readonly string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
        static readonly string path = Path.Combine(documentsPath, "Nom011dev.db");

        public ListDistintivo()
        {
            InitializeComponent();

            getDistintivos();

            btnAddDistintivo.Clicked += BtnAddDistintivo_Clicked;

            lstDistintivos.ItemTapped += (sender, e) =>
            {
                var ver = (Distintivo)((ListView)sender).SelectedItem; // de-select the row
                Navigation.PopAsync();
                Navigation.PushAsync(new AddNewDistintivo(ver.IdDistintivo));
            };
		}
         
        private void BtnAddDistintivo_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            Navigation.PushAsync(new AddNewDistintivo());
        }

        private void getDistintivos()
        {
            var conn = new SQLiteConnection(path);


            var list = conn.Table<Distintivo>().ToList();

            lstDistintivos.ItemsSource = list;
        }
    }
}