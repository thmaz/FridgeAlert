
/* Unmerged change from project 'FridgeAlert (net7.0-windows10.0.19041.0)'
Before:
using System;
After:
using FridgeAlert.Api;
using System;
*/

/* Unmerged change from project 'FridgeAlert (net7.0-ios)'
Before:
using System;
After:
using FridgeAlert.Api;
using System;
*/

/* Unmerged change from project 'FridgeAlert (net7.0-maccatalyst)'
Before:
using System;
After:
using FridgeAlert.Api;
using System;
*/
using
/* Unmerged change from project 'FridgeAlert (net7.0-windows10.0.19041.0)'
Before:
using System.Threading.Tasks;
using FridgeAlert.Api;
After:
using System.Threading.Tasks;
*/

/* Unmerged change from project 'FridgeAlert (net7.0-ios)'
Before:
using System.Threading.Tasks;
using FridgeAlert.Api;
After:
using System.Threading.Tasks;
*/

/* Unmerged change from project 'FridgeAlert (net7.0-maccatalyst)'
Before:
using System.Threading.Tasks;
using FridgeAlert.Api;
After:
using System.Threading.Tasks;
*/
FridgeAlert.Api;

namespace FridgeAlert.Models;

public class Beers
{
    public static string GenerateUrlRandom()
    {
        return ApiConstants.RANDOM_BEER;
    }
}
