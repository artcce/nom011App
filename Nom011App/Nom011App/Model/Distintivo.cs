
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nom011.ModelDatabase
{
    public  class Distintivo
    {
        [PrimaryKey, AutoIncrement]
        public int? IdDistintivo { get; set; }
        public string Clave { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int Numero { get; set; }
        public int IdStatus { get; set; }
        public DateTime FechaUso { get; set; }
        public int IdVerificacion { get; set; }

    }
}
