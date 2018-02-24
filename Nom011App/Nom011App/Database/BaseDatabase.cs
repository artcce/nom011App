using Nom011.ModelDatabase;
using Nom011App.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nom011App.Database
{
    public class BaseDatabase
    {
        #region Constant Fields
        #endregion

        #region Fields
        static bool _isInitialized;
        #endregion

        #region Properties
        #endregion

        #region Methods
        public static string GetDatabaseConnection()
        {
            if (!_isInitialized)
                Initialize();

            return "ok";
        }

        static void Initialize()
        {
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            string path = Path.Combine(documentsPath, "Nom011dev.db");
            using (var conn = new SQLiteConnection(path))
            {
                conn.CreateTable<Basculas>(SQLite.CreateFlags.ImplicitPK | SQLite.CreateFlags.AutoIncPK);
                conn.CreateTable<Ciudad>((SQLite.CreateFlags.ImplicitPK | SQLite.CreateFlags.AutoIncPK));
                conn.CreateTable<Cliente>((SQLite.CreateFlags.ImplicitPK | SQLite.CreateFlags.AutoIncPK));
                conn.CreateTable<Colonia>((SQLite.CreateFlags.ImplicitPK | SQLite.CreateFlags.AutoIncPK));
                conn.CreateTable<Distintivo>((SQLite.CreateFlags.ImplicitPK | SQLite.CreateFlags.AutoIncPK));
                conn.CreateTable<Equipo>((SQLite.CreateFlags.ImplicitPK | SQLite.CreateFlags.AutoIncPK));
                conn.CreateTable<Estado>((SQLite.CreateFlags.ImplicitPK | SQLite.CreateFlags.AutoIncPK));
                conn.CreateTable<Giros>((SQLite.CreateFlags.ImplicitPK | SQLite.CreateFlags.AutoIncPK));
                conn.CreateTable<Holograma>((SQLite.CreateFlags.ImplicitPK | SQLite.CreateFlags.AutoIncPK));
                conn.CreateTable<Status>((SQLite.CreateFlags.ImplicitPK | SQLite.CreateFlags.AutoIncPK));
                conn.CreateTable<TipoBasculas>(SQLite.CreateFlags.ImplicitPK | SQLite.CreateFlags.AutoIncPK);
                conn.CreateTable<TipoVerificacion>(SQLite.CreateFlags.ImplicitPK | SQLite.CreateFlags.AutoIncPK);
                conn.CreateTable<Verificacion>(SQLite.CreateFlags.ImplicitPK | SQLite.CreateFlags.AutoIncPK);
                conn.CreateTable<Verificador>(SQLite.CreateFlags.ImplicitPK | SQLite.CreateFlags.AutoIncPK);
            }

            _isInitialized = true;
        }

        static void InsertStates()
        {
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            string path = Path.Combine(documentsPath, "Nom011dev.db");
            using (var conn = new SQLiteConnection(path))
            {
                conn.DropTable<Cliente>();
                conn.CreateTable<Cliente>((SQLite.CreateFlags.ImplicitPK | SQLite.CreateFlags.AutoIncPK));

                if (conn.Table<Estado>().Count() == 0)
                {
                    conn.Insert(new Estado() { IdEstado = 1, Clave = "AGUASCALIENTES", Descripcion = "AGUASCALIENTES" });
                    conn.Insert(new Estado() { IdEstado = 2, Clave = "BAJA CALIFORNIA", Descripcion = "BAJA CALIFORNIA" });
                    conn.Insert(new Estado() { IdEstado = 3, Clave = "BAJA CALIFORNIA SUR", Descripcion = "BAJA CALIFORNIA SUR" });
                    conn.Insert(new Estado() { IdEstado = 4, Clave = "CAMPECHE", Descripcion = "CAMPECHE" });
                    conn.Insert(new Estado() { IdEstado = 5, Clave = "CHIAPAS", Descripcion = "CHIAPAS" });
                    conn.Insert(new Estado() { IdEstado = 6, Clave = "CHIHUAHUA", Descripcion = "CHIHUAHUA" });
                    conn.Insert(new Estado() { IdEstado = 7, Clave = "COAHUILA", Descripcion = "COAHUILA" });
                    conn.Insert(new Estado() { IdEstado = 8, Clave = "COLIMA", Descripcion = "COLIMA" });
                    conn.Insert(new Estado() { IdEstado = 9, Clave = "CIUDAD DE MEXICO", Descripcion = "CIUDAD DE MEXICO" });
                    conn.Insert(new Estado() { IdEstado = 10, Clave = "DURANGO", Descripcion = "DURANGO" });
                    conn.Insert(new Estado() { IdEstado = 11, Clave = "ESTADO DE MEXICO", Descripcion = "ESTADO DE MEXICO" });
                    conn.Insert(new Estado() { IdEstado = 12, Clave = "GUANAJUATO", Descripcion = "GUANAJUATO" });
                    conn.Insert(new Estado() { IdEstado = 13, Clave = "GUERRERO", Descripcion = "GUERRERO" });
                    conn.Insert(new Estado() { IdEstado = 14, Clave = "HIDALGO", Descripcion = "HIDALGO" });
                    conn.Insert(new Estado() { IdEstado = 15, Clave = "JALISCO", Descripcion = "JALISCO" });
                    conn.Insert(new Estado() { IdEstado = 16, Clave = "MICHOACAN", Descripcion = "MICHOACAN" });
                    conn.Insert(new Estado() { IdEstado = 17, Clave = "MORELOS", Descripcion = "MORELOS" });
                    conn.Insert(new Estado() { IdEstado = 18, Clave = "NAYARIT", Descripcion = "NAYARIT" });
                    conn.Insert(new Estado() { IdEstado = 19, Clave = "NUEVO LEON", Descripcion = "NUEVO LEON" });
                    conn.Insert(new Estado() { IdEstado = 20, Clave = "OAXACA", Descripcion = "OAXACA" });
                    conn.Insert(new Estado() { IdEstado = 21, Clave = "PUEBLA", Descripcion = "PUEBLA" });
                    conn.Insert(new Estado() { IdEstado = 22, Clave = "QUERETARO", Descripcion = "QUERETARO" });
                    conn.Insert(new Estado() { IdEstado = 23, Clave = "QUINTANA ROO", Descripcion = "QUINTANA ROO" });
                    conn.Insert(new Estado() { IdEstado = 24, Clave = "SAN LUIS POTOSI", Descripcion = "SAN LUIS POTOSI" });
                    conn.Insert(new Estado() { IdEstado = 25, Clave = "SINALOA", Descripcion = "SINALOA" });
                    conn.Insert(new Estado() { IdEstado = 26, Clave = "SONORA", Descripcion = "SONORA" });
                    conn.Insert(new Estado() { IdEstado = 27, Clave = "TABASCO", Descripcion = "TABASCO" });
                    conn.Insert(new Estado() { IdEstado = 28, Clave = "TAMAULIPAS", Descripcion = "TAMAULIPAS" });
                    conn.Insert(new Estado() { IdEstado = 29, Clave = "TLAXCALA", Descripcion = "TLAXCALA" });
                    conn.Insert(new Estado() { IdEstado = 30, Clave = "VERACRUZ", Descripcion = "VERACRUZ" });
                    conn.Insert(new Estado() { IdEstado = 31, Clave = "YUCATAN", Descripcion = "YUCATAN" });
                    conn.Insert(new Estado() { IdEstado = 32, Clave = "ZACATECAS", Descripcion = "ZACATECAS" });

                }

            }
        }

        #endregion
    }
}
