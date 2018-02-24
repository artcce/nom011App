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
	public partial class AddNewHolograma : ContentPage
	{

        Holograma hologramaContext = new Holograma();
        static readonly string sqliteFilename = "Nom011dev.db";
        static readonly string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
        static readonly string path = Path.Combine(documentsPath, sqliteFilename);

        public AddNewHolograma ()
		{
			InitializeComponent ();

            BindingContext = hologramaContext;
            btnGuardar.Clicked += BtnGuardar_Clicked;
        }

        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            insertUpdateData(hologramaContext);
            Navigation.PopAsync();
            Navigation.PushAsync(new ListHologramas());
        }

        public AddNewHolograma(int? IdHolograma)
        {
            InitializeComponent();
            BindingContext = hologramaContext;

            btnGuardar.Clicked += BtnGuardar_Clicked;

            var conn = new SQLiteConnection(path);

            hologramaContext = conn.Find<Holograma>(IdHolograma);
        }

        public static string insertUpdateData(Holograma data)
        {
            try
            {
                var conn = new SQLiteConnection(path);
                if (data.IdHolograma > 0)
                {
                    conn.Update(data);
                }
                else
                    conn.Insert(data);
                return "Single data file inserted or updated";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }


}