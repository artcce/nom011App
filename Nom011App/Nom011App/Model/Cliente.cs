using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nom011.ModelDatabase
{ 
    public class Cliente
    {
        [PrimaryKey,AutoIncrement]
        public int IdCliente { get; set; }
        public string Clave { get; set; }
        public string RFC { get; set; }
        public string RazonSocial { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string Ciudad { get; set; }
        public int IdEstado { get; set; }
        public string Telefono { get; set; }
        public string Solicitante { get; set; }

    }
}
