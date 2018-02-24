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

namespace Nom011App.VerificacionViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Customer : ContentPage
	{

        static readonly string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
        static readonly string path = Path.Combine(documentsPath, "Nom011dev.db");

        Dictionary<string, string> dcCiudades = new Dictionary<string, string>();

        public Customer ()
		{

            InitializeComponent ();
            var conn = new SQLiteConnection(path);

            var list = conn.Table<Cliente>().ToList();

        }
    }
}