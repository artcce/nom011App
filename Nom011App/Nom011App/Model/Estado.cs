using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nom011.ModelDatabase
{
   public class Estado
    {
        [PrimaryKey, AutoIncrement]
        public int IdEstado { get; set; }

        public string Clave { get; set; }

        public string Descripcion { get; set; }

        public override string ToString()
        {
            return string.Format("[Estado: Id={0}, Descripcion={1}]", IdEstado, Descripcion);
        }
    }
}
