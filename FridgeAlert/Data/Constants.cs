using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using sqlite;
using SQLite;
using System.Security.Cryptography.X509Certificates;

namespace FridgeAlert.Data
{
    public static class Constants
    {
        private const string DBFileName = "TopSecret.db3";
        public const SQLiteOpenFlags flags =
            SQLiteOpenFlags.ReadWrite |
            SQLiteOpenFlags.Create |
            SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get {
                return Path.Combine(FileSystem.AppDataDirectory, DBFileName);
            }
        }
    }
}
