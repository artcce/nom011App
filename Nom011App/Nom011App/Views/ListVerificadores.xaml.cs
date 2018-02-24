using Nom011;
using Nom011.ModelDatabase;
using Nom011App.Database;
using Nom011App.GenericViews;
using SQLite;
using System;
using System.Collections;
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
	public partial class ListVerificadores : ContentPage
	{
        static readonly string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
        static readonly string path = Path.Combine(documentsPath, "Nom011dev.db");

        public ListVerificadores ()
		{
			InitializeComponent ();

            getVerificadores();

            btnAddVerificador.Clicked += BtnAddVerificador_Clicked;
            // Using ItemTapped
            lstVerificador.ItemTapped += (sender, e) => {
               Verificador ver = (Verificador)((ListView)sender).SelectedItem; // de-select the row
                Navigation.PopAsync();
                Navigation.PushAsync(new AddNewVerificador(ver.IdVerificador)); 
            };
        }

        private void BtnAddVerificador_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            Navigation.PushAsync(new AddNewVerificador());
            // Catalog().Detail.Navigation.PushAsync(new AddNewVerificador());

        }

        public void getVerificadores()
        {
            var conn = new SQLiteConnection(path);


            var list =  conn.Table<Verificador>().ToList();

            lstVerificador.ItemsSource = list;
        }


       
    }
}