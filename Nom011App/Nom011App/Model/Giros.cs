using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nom011.ModelDatabase
{

    public class Giros
    {
        [PrimaryKey, AutoIncrement]
        public int? IdGiro { get; set; }
        public string Clave{ get; set; }
        public string Descripcion { get; set; }
    }
}
