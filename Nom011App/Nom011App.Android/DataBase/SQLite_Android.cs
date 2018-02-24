using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Nom011App.Services;
using SQLite;
using System.IO;
using Xamarin.Forms;
using Nom011App.Droid.DataBase;

[assembly: Dependency(typeof(SQLite_Android))]
namespace Nom011App.Droid.DataBase
{

    class SQLite_Android : ISQLite
    {
        #region ISQLite implementation
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "Nom011dev.db";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);


            var conn = new SQLiteConnection(path);

            // Return the database connection 
            return conn;
        }

     

        #endregion
    }
}

