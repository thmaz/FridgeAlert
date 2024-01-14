
/* Unmerged change from project 'FridgeAlert (net7.0-windows10.0.19041.0)'
Before:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using sqlite;
using SQLite;
using System.Security.Cryptography.X509Certificates;
After:
using sqlite;
using SQLite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
*/

/* Unmerged change from project 'FridgeAlert (net7.0-ios)'
Before:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using sqlite;
using SQLite;
using System.Security.Cryptography.X509Certificates;
After:
using sqlite;
using SQLite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
*/

/* Unmerged change from project 'FridgeAlert (net7.0-maccatalyst)'
Before:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using sqlite;
using SQLite;
using System.Security.Cryptography.X509Certificates;
After:
using sqlite;
using SQLite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
*/
using SQLite;

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
            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, DBFileName);
            }
        }
    }
}
