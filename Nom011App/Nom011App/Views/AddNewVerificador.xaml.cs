
using Nom011;
using Nom011.ModelDatabase;
using Nom011App.Database;
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
	public partial class AddNewVerificador : ContentPage
    {
        Verificador verifContext = new Verificador();
        static readonly string sqliteFilename = "Nom011dev.db";
        static readonly string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
        static readonly string path = Path.Combine(documentsPath, sqliteFilename);


        public AddNewVerificador ()
		{
			InitializeComponent ();
            BindingContext = verifContext;
            btnGuardar.Clicked += BtnGuardar_Clicked; 
        }

        public AddNewVerificador(int? IdVerificador)
        {
            InitializeComponent();

            BindingContext = verifContext;
            btnGuardar.Clicked += BtnGuardar_Clicked;
            var conn = new SQLiteConnection(path);
            verifContext = conn.Find<Verificador>(IdVerificador);
            Nombre.SetBinding(Entry.TextProperty, verifContext.Nombre);
            NoId.SetBinding(Entry.TextProperty, verifContext.NoId);
            IdVerificadorEntry.SetBinding(Entry.TextProperty, verifContext.IdVerificador.ToString());

        }

        

        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            var verif = new Verificador()
            {
                NoId = NoId.Text,
                Nombre = Nombre.Text                
            };
            if (IdVerificadorEntry.Text != "")
            {
                verif.IdVerificador = Convert.ToInt32(IdVerificadorEntry.Text);
            }
            //IRepository<Verificador> stockRepo = new Repository<Verificador>();
            //stockRepo.Insert(verif);
             insertUpdateData(verif);
            Navigation.PopAsync();
            Navigation.PushAsync(new ListVerificadores());
            
        }


        public static string insertUpdateData(Verificador data)
        {
            try
            {
                var conn = new SQLiteConnection( path);
                if (data.IdVerificador > 0)
                {
                    conn.Update(data);
                }else
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