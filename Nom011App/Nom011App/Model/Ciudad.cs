using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nom011.ModelDatabase
{
   
    public class Ciudad
    {
        [PrimaryKey, AutoIncrement]
        public int IdCiudad { get; set; }
        public string Clave { get; set; }
        public string Descripcion{ get; set; }
        public int IdEstado { get; set; }

    }
}
