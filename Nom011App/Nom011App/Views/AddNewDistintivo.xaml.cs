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
	public partial class AddNewDistintivo : ContentPage
	{

        Distintivo distintivoContext = new Distintivo();
        static readonly string sqliteFilename = "Nom011dev.db";
        static readonly string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
        static readonly string path = Path.Combine(documentsPath, sqliteFilename);



        public AddNewDistintivo ()
		{
			InitializeComponent ();

            BindingContext = distintivoContext;
            btnGuardar.Clicked += BtnGuardar_Clicked;
        }

        public AddNewDistintivo(int? idDistintivo)
        {
            InitializeComponent();

            btnGuardar.Clicked += BtnGuardar_Clicked; ;
            var conn = new SQLiteConnection(path);

            distintivoContext = conn.Find<Distintivo>(idDistintivo);
            BindingContext = distintivoContext;

        }

        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            
            insertUpdateData(distintivoContext);
            Navigation.PopAsync();
            Navigation.PushAsync(new ListDistintivo());
        }

        public static string insertUpdateData(Distintivo data)
        {
            try
            {
                var conn = new SQLiteConnection(path);
                if (data.IdDistintivo > 0)
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