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
	public partial class AddNewEquipo : ContentPage
	{
        Equipo equipoContext = new Equipo();
        static readonly string sqliteFilename = "Nom011dev.db";
        static readonly string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
        static readonly string path = Path.Combine(documentsPath, sqliteFilename);


        public AddNewEquipo ()
		{
			InitializeComponent ();
            BindingContext = equipoContext;
            btnGuardar.Clicked += BtnGuardar_Clicked;
        }

        public AddNewEquipo(int? idEquipo)
        {
            InitializeComponent();
            btnGuardar.Clicked += BtnGuardar_Clicked;

            var conn = new SQLiteConnection(path);

            equipoContext = conn.Find<Equipo>(idEquipo);
            BindingContext = equipoContext;

        }

        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            insertUpdateData(equipoContext);
            Navigation.PopAsync();
            Navigation.PushAsync(new ListEquipo());
        }

        public static string insertUpdateData(Equipo data)
        {
            try
            {
                var conn = new SQLiteConnection(path);
                if (data.IdEquipo > 0)
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