using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_2890433
{
    public static class Constants
    {
        public const string DatabaseFilename = "TodoSQLite.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            //Abre la base de datos en modo lectura/escritura
            SQLite.SQLiteOpenFlags.ReadWrite |
            //Crea la base de datos si esta no existe
            SQLite.SQLiteOpenFlags.Create |
            //Habilita el acceso a la base de datos de subprocesos múltiples
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);
    }
}
