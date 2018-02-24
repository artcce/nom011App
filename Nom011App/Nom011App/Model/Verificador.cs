
using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nom011.ModelDatabase
{
    public class Verificador
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int? IdVerificador { get; set; }
        public string Nombre { get; set; }
        public string NoId { get; set; }
        
         
    }
    
}
