using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nom011.ModelDatabase
{
   
    public class Basculas
    {
        [PrimaryKey, AutoIncrement]
        public int IdBascula { get; set; }
        public int IdVerificacion { get; set; }
        public int IdTipoBascula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public int AlcMax1 { get; set; }
        public int AlcMax2 { get; set; }
        public int Div1 { get; set; }
        public int Div2 { get; set; }
        public int IdTipoVerificacion { get; set; }
        public int IdHolograma { get; set; }
        public int IdDistintivo { get; set; }

        public Basculas()
        {
            IdBascula = 0;
            IdVerificacion = 0;
            IdTipoBascula = 0;
            Marca = "";
            Modelo = "";
            Serie = "";
            AlcMax1 = 0;
            AlcMax2 = 0;
            Div1 = 0;
            Div2 = 0;
            IdTipoVerificacion = 0;
            IdHolograma = 0;
            IdDistintivo = 0;
        
        }

    }
}
