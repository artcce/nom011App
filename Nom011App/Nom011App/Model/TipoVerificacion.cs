using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nom011.ModelDatabase
{
    public class TipoVerificacion
    {
        [PrimaryKey, AutoIncrement]
        public int IdTipoVerificacion { get; set; }
        public string Descripcion { get; set; }
    }
}
