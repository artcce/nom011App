using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nom011.ModelDatabase;
using SQLite.Net;

namespace Nom011
{
   public static class DataBaseConections
    {
        public static string createDatabase(string path)
        {
            try
            {
                var connection = new SQLiteConnection(path);
                connection.CreateTableAsync<Basculas>();
                connection.CreateTableAsync<Ciudad>();
                connection.CreateTableAsync<Cliente>();
                connection.CreateTableAsync<Colonia>();
                connection.CreateTableAsync<Distintivo>();
                connection.CreateTableAsync<Equipo>();
                connection.CreateTableAsync<Estado>();
                connection.CreateTableAsync<Giros>();
                connection.CreateTableAsync<Holograma>();
                connection.CreateTableAsync<Status>();
                connection.CreateTableAsync<TipoBasculas>();
                connection.CreateTableAsync<TipoVerificacion>();
                connection.CreateTableAsync<Verificacion>();
                connection.CreateTableAsync<Verificador>();
                return "Database created";
            }
            catch (SQLiteException ex)
            {
                return ex.Message;
            }
        }

      
    }
}
