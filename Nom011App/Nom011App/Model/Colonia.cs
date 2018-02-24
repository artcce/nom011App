using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nom011.ModelDatabase
{

    public class Colonia
    {
        [PrimaryKey, AutoIncrement]
        public int IdColonia { get; set; }
        public string Descripcion { get; set; }
        public string CodigoPostal { get; set; }
        public int IdCiudad { get; set; }

    }
}
