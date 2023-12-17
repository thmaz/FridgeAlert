using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FridgeAlert.Models;

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
