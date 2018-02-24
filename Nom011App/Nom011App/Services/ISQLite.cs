using SQLite;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nom011App.Services
{
    public interface ISQLite
    {
        SQLite.SQLiteConnection GetConnection();
    }
}
