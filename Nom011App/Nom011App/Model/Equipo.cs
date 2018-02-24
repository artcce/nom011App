using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nom011.ModelDatabase
{
     public  class Equipo
    {
        [PrimaryKey, AutoIncrement]
        public int? IdEquipo { get; set; }
        public string JP { get; set; }
        public string PP5 { get; set; }
        public string PP10 { get; set; }
        public string PP20 { get; set; }
        public int IdVerificador { get; set; }

    }
}
