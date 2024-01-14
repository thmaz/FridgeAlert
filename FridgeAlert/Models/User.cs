
/* Unmerged change from project 'FridgeAlert (net7.0-windows10.0.19041.0)'
Before:
using System;
After:
using SQLite;
using System;
*/

/* Unmerged change from project 'FridgeAlert (net7.0-ios)'
Before:
using System;
After:
using SQLite;
using System;
*/

/* Unmerged change from project 'FridgeAlert (net7.0-maccatalyst)'
Before:
using System;
After:
using SQLite;
using System;
*/
using SQLite;
using System.ComponentModel.DataAnnotations;

/* Unmerged change from project 'FridgeAlert (net7.0-windows10.0.19041.0)'
Before:
using SQLite;
namespace FridgeAlert.Models;
After:
namespace FridgeAlert.Models;
*/

/* Unmerged change from project 'FridgeAlert (net7.0-ios)'
Before:
using SQLite;
namespace FridgeAlert.Models;
After:
namespace FridgeAlert.Models;
*/

/* Unmerged change from project 'FridgeAlert (net7.0-maccatalyst)'
Before:
using SQLite;
namespace FridgeAlert.Models;
After:
namespace FridgeAlert.Models;
*/
namespace FridgeAlert.Models;

[Table("UserData")]
public class User
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    [SQLite.MaxLength(32), Unique]
    public string UserName { get; set; }
    [MinLength(12)]
    public string Password { get; set; }
    public bool? SaveLogin { get; set; }
}
