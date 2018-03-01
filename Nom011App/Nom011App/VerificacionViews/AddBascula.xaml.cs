using Nom011.ModelDatabase;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nom011App.VerificacionViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddBascula : ContentPage
	{
        static readonly string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
        static readonly string path = Path.Combine(documentsPath, "Nom011dev.db");
        Dictionary<string, string> dcTiposBasculas = new Dictionary<string, string>();
        Dictionary<string, string> dcTipoVerificacion= new Dictionary<string, string>();
        Dictionary<string, string> dcHolograma= new Dictionary<string, string>();
        Dictionary<string, string> dcDistintivo= new Dictionary<string, string>();

        public AddBascula()
        {
            InitializeComponent();
        }

        public AddBascula (Nom011.ModelDatabase.Basculas newBascula)
		{
			InitializeComponent ();

            var conn = new SQLiteConnection(path);

            var listBasculas = new ObservableCollection<Basculas>();
            var listTipoBascula = conn.Table<TipoBasculas>().ToList();
            var listTipoVerificacion = conn.Table<TipoVerificacion>().ToList();
            var listHolograma = conn.Table<Holograma>().ToList();
            var listDistintivo = conn.Table<Distintivo>().ToList();

            listTipoBascula.ForEach(item => dcTiposBasculas.Add(item.Descripcion, item.IdTipo.ToString()));
            listTipoVerificacion.ForEach(item => dcTipoVerificacion.Add(item.Descripcion, item.IdTipoVerificacion.ToString()));
            listHolograma.ForEach(item => dcHolograma.Add(item.Numero.ToString(), item.IdHolograma.ToString()));
            listDistintivo.ForEach(item => dcDistintivo.Add(item.Numero.ToString(), item.IdDistintivo.ToString()));

            listTipoBascula.ForEach(c => TipoBasculaPicker.Items.Add(c.Descripcion));
            listTipoVerificacion.ForEach(c => TipoVerificacionPicker.Items.Add(c.Descripcion));
            listHolograma.ForEach(c => HologranaPicker.Items.Add(c.Numero.ToString()));
            listDistintivo.ForEach(c => DistintivoPicker.Items.Add(c.Numero.ToString()));

            TipoBasculaPicker.SelectedIndexChanged += (sender, args) =>
            {
                //IdEquipoEntry.Text = dcEquipos[EquipoEntry.Items[EquipoEntry.SelectedIndex]];
            };

            TipoVerificacionPicker.SelectedIndexChanged += (sender, args) =>
            {
                //IdEquipoEntry.Text = dcEquipos[EquipoEntry.Items[EquipoEntry.SelectedIndex]];
            };

            HologranaPicker.SelectedIndexChanged += (sender, args) =>
            {
                //IdEquipoEntry.Text = dcEquipos[EquipoEntry.Items[EquipoEntry.SelectedIndex]];
            };

            DistintivoPicker.SelectedIndexChanged += (sender, args) =>
            {
                //IdEquipoEntry.Text = dcEquipos[EquipoEntry.Items[EquipoEntry.SelectedIndex]];
            };
            
            btnAddBascula.Clicked += (sender, args)=>{
                newBascula.Marca= MarcaEntry.Text;
                newBascula.Modelo = ModeloEntry.Text;
                newBascula.Serie = SerieEntry.Text;
                Navigation.PopModalAsync();
            };
        }
	}
}