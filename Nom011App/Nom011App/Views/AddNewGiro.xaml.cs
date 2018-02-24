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
	public partial class AddNewGiro : ContentPage
	{

        Giros giroContext = new Giros();
        static readonly string sqliteFilename = "Nom011dev.db";
        static readonly string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
        static readonly string path = Path.Combine(documentsPath, sqliteFilename);

        public AddNewGiro ()
		{
			InitializeComponent ();

            BindingContext = giroContext;
            btnGuardar.Clicked += BtnGuardar_Clicked;

        
        }

        public AddNewGiro(int? idGiro)
        {
            InitializeComponent();

            BindingContext = giroContext;
            btnGuardar.Clicked += BtnGuardar_Clicked;

            var conn = new SQLiteConnection(path);

            giroContext = conn.Find<Giros>(idGiro);
            BindingContext = giroContext;
        }

        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            insertUpdateData(giroContext);
            Navigation.PopAsync();
            Navigation.PushAsync(new ListGiros());
        }

        public static string insertUpdateData(Giros data)
        {
            try
            {
                var conn = new SQLiteConnection(path);
                if (data.IdGiro > 0)
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