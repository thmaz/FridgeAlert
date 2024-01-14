
/* Unmerged change from project 'FridgeAlert (net7.0-windows10.0.19041.0)'
Before:
using System;
After:
using FridgeAlert.Models;
using System;
*/

/* Unmerged change from project 'FridgeAlert (net7.0-ios)'
Before:
using System;
After:
using FridgeAlert.Models;
using System;
*/

/* Unmerged change from project 'FridgeAlert (net7.0-maccatalyst)'
Before:
using System;
After:
using FridgeAlert.Models;
using System;
*/
using
/* Unmerged change from project 'FridgeAlert (net7.0-windows10.0.19041.0)'
Before:
using System.Threading.Tasks;
using FridgeAlert.Models;
After:
using System.Threading.Tasks;
*/

/* Unmerged change from project 'FridgeAlert (net7.0-ios)'
Before:
using System.Threading.Tasks;
using FridgeAlert.Models;
After:
using System.Threading.Tasks;
*/

/* Unmerged change from project 'FridgeAlert (net7.0-maccatalyst)'
Before:
using System.Threading.Tasks;
using FridgeAlert.Models;
After:
using System.Threading.Tasks;
*/
FridgeAlert.Models;

namespace FridgeAlert.Api
{
    public class ApiLogic
    {
        public async static Task<List<Beers>> GenerateUrlRandom()
        {
            List<Beers> beers = new List<Beers>();

            var url = Beers.GenerateUrlRandom();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();
            }

            return beers;
        }
    }
}
