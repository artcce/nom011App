using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nom011.ModelDatabase
{

    public  class Verificacion
    {
        [PrimaryKey, AutoIncrement]
        public int IdVerificacion { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string HoraInicial { get; set; }
        public string HoraFinal { get; set; }
        public string Apoyo { get; set; }
        public string Apoyo2 { get; set; }
        public int IdCliente { get; set; } //
        public string Latitud { get; set; } //
        public string Longitud { get; set; } //
        public string Este { get; set; } //
        public string Uso { get; set; } //
        public int IdEquipo { get; set; } //
        [Ignore]
        public List<Basculas> Basculas { get; set; }
    }
}
